using Humanizer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AromasEstoque
{
    public class TransactionsController : IObserver, ISubject
    { 
        public enum ReportType
        {
            Day = 0,
            Week = 1,
            Month = 2,
            Custom = 3
        }

        private readonly ITransactionsDashboard _view;
        private List<Transactions> _transactions;
        private readonly List<IObserver> _observers = new List<IObserver>();
        private bool IsOutflowTransaction(Transactions transaction) => "R".Equals(transaction.Category) || "W".Equals(transaction.Category);
        private List<Transactions> Transactions
        {
            get => _transactions;
            set 
            { 
                _transactions = value;
                UpdateDisplay();
            }
        }
        public TransactionsController(ITransactionsDashboard view)
        {
            _view = view;
            Attach(PendingPayments.Instance.Controller);
            Attach(Sales.Instance);
        }
        public void SetCustomReport()
        {
            var database = new AromasDatabaseEntities();
            Transactions = database.Transactions.OrderByDescending(t => t.EventDate)
                .Where(t =>
                 DbFunctions.TruncateTime(t.EventDate) >= DbFunctions.TruncateTime(_view.FromReportDate)
                 && DbFunctions.TruncateTime(t.EventDate) <= DbFunctions.TruncateTime(_view.ToReportDate))
                .ToList();
        }

        public void SetReport()
        {
            switch ((ReportType)_view.SelectedReport)
            {
                case ReportType.Day:
                    SetDayReport();
                    break;
                case ReportType.Week:
                    SetWeekReport();
                    break;
                case ReportType.Month:
                    SetMonthReport();
                    break;
                case ReportType.Custom:
                    SetCustomReport();
                    break;
                default:
                    SetDayReport();
                    break;
            }
        }

        private void SetDayReport()
        {
            var database = new AromasDatabaseEntities();
            Transactions =  database.Transactions.OrderByDescending(t => t.EventDate)
                .Where(t =>
                DbFunctions.TruncateTime(DateTime.Now) == DbFunctions.TruncateTime(t.EventDate))
                .ToList();
        }

        private void SetWeekReport()
        {
            var firstDayOfWeek = GetFirstDayOfWeek(); // Cannot be inside of the LINQ query because is not suported

            var database = new AromasDatabaseEntities();
            Transactions = database.Transactions.OrderByDescending(t => t.EventDate)
                .Where(t =>
                 DbFunctions.TruncateTime(t.EventDate) >= DbFunctions.TruncateTime(firstDayOfWeek) 
                 && DbFunctions.TruncateTime(t.EventDate) <= DbFunctions.TruncateTime(DateTime.Now))
                .ToList();
        }

        private void SetMonthReport()
        {
            var currentYear = DateTime.Now.Year;
            var currentMonth = DateTime.Now.Month;

            var database = new AromasDatabaseEntities();
            Transactions = database.Transactions.OrderByDescending(t => t.EventDate)
                .Where(t =>
                t.EventDate.Year == currentYear && t.EventDate.Month == currentMonth)
                .ToList(); ;
        }

        public void UpdateDisplay()
        {
            SetTransactionsDatasource();
            _view.TotalMoney = GetTotalCurrencyIncome("M");
            _view.TotalCredit = GetTotalCurrencyIncome("C");
            _view.TotalDebit = GetTotalCurrencyIncome("D");
            _view.TotalIncome = _view.TotalCredit + _view.TotalDebit + _view.TotalMoney;
            _view.TotalOutflow = GetTotalOutflow();
            _view.Balance = _view.TotalIncome - _view.TotalOutflow;
            _view.VaultAmount = ComputeCurrentVaultBalance();
            _view.SelectLastSelectedRow();
        }
        public void DeleteTransaction()
        {
            if (!MainDashboard.IsActionAllowed) return;
            if (ConfirmTransactionDeletion() != DialogResult.Yes) return;
            using (var database = new AromasDatabaseEntities())
            {
                var transaction = database.Transactions.Find(_view.SelectedTransactionId);
                database.Transactions.Remove(transaction);
                database.SaveChanges();
            }
            Notify();
            SetReport();
        }

        private DateTime GetFirstDayOfWeek()
        {
            return DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
        }

        private DialogResult ConfirmTransactionDeletion()
        {
            var deleteConfirmation = MessageBox.Show($@"Excluindo o registro {_view.SelectedTransactionId}. Deseja continuar?",
               @"Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return deleteConfirmation;
        }
        private decimal GetTotalOutflow()
        {
            return Transactions
                .Where(t => t.Category == "W" || t.Category == "R")
                .Sum(t => t.Amount);
        }
        private decimal GetTotalCurrencyIncome(string currency)
        {
            return Transactions
                .Where(t => t.Currency.Equals(currency) && t.Category != "W" && t.Category != "R") //&& t.Category != "J")
                .Sum(t => t.Amount);
        }

        /*
         * Computes the current vault balance.
         * Formula: Vault Balance = (Last Balance + Current Income - Current Outflow)
         * Rules:
         * 1. Income = total money income (excluding Job income)
         * 2. Outflow = Total money withdraw + total return amount
         */
        public decimal ComputeCurrentVaultBalance()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var lastBalance = database.VaultBalance.OrderByDescending(b => b.ReferenceDate).First();
                var flowSinceBalance = database.Transactions
                    .Where(t => t.Currency.Equals("M") && t.EventDate > lastBalance.ReferenceDate); //&& t.Category != "J");

                var currentIncome = flowSinceBalance
                    .Where(t => t.Category != "W" && t.Category != "R")
                    .Sum(t => (decimal?)t.Amount);

                var currentOutflow = flowSinceBalance
                    .Where(t => t.Category.Equals("W") || t.Category.Equals("R"))
                    .Sum(t => (decimal?)t.Amount);
                return lastBalance.Balance + (currentIncome ?? 0) - (currentOutflow ?? 0);
            }
        }

        private void SetTransactionsDatasource()
        {
            var datasource = Transactions.Select(t => new
            {
                Flow = IsOutflowTransaction(t) ? "-" : "+",
                Id = t.TransactionId,
                Employee = t.Employee?.FullName ?? "Removido do sistema.",
                Information = $"R$ {t.Amount} — {t.Comment?.Transform(To.LowerCase, To.SentenceCase)}",
                Currency = "C".Equals(t.Currency)
                ? $"Cartão de crédito ({t.Parcel}x)"
                : "D".Equals(t.Currency)
                    ? "Débito"
                    : "Dinheiro",
                Date = t.EventDate
            });

            _view.DataSource = datasource.ToList();
        }

        public void Update(ISubject subject)
        {
            SetReport();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(this);
        }

        public void ShowCashierOperationsDialog()
        {
            var operation = new CashierOperations();
            if (operation.ShowDialog() != DialogResult.OK) return;
            SetReport();
        }

        public void ShowComissionDialog()
        {
            var comission = new Comission();
            comission.ShowDialog();
        }
    }
}