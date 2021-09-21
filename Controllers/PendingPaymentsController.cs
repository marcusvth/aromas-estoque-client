using Humanizer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AromasEstoque
{
    public class PendingPaymentsController : IObserver
    {
        private IPendingPayments _view;
        private static decimal GetTotalPrice(Sale sale) => sale.SaleDetail.Sum(d => d.SalePrice * d.Amount) - sale.Discount;
        private static decimal GetReturnAmount(Sale sale) =>
            (decimal?)sale.Transactions.Where(t => "R".Equals(t.Category)).Sum(t => t.Amount) ?? 0;
        private static decimal GetReturnAmount(Job job) =>
            (decimal?)job.Transactions.Where(t => "R".Equals(t.Category)).Sum(t => t.Amount) ?? 0;
        private static decimal GetPaidAmount(Sale sale) => ((decimal?)sale.Transactions.Where(t => "S".Equals(t.Category)).Sum(t => t.Amount) ?? 0) - GetReturnAmount(sale);
        private static decimal GetPaidAmount(Job job) => ((decimal?)job.Transactions.Where(t => "J".Equals(t.Category)).Sum(t => t.Amount) ?? 0) - GetReturnAmount(job);
        private static bool IsSaleUnpaid(Sale sale) => GetTotalPrice(sale) > GetPaidAmount(sale);
        private static bool IsJobUnpaid(Job job) => job.TotalPrice > GetPaidAmount(job);

        public PendingPaymentsController(IPendingPayments view)
        {
            _view = view;
            UpdateDisplay();
        }
        public List<Sale> GetUnpaidSales()
        {
            var database = new AromasDatabaseEntities();
            return _view.FilterByCustomer
                ? (database.Sale.AsEnumerable() ?? Array.Empty<Sale>()).Where(sale => sale.CustomerId == _view.SelectedCustomerId && IsSaleUnpaid(sale)).ToList()
                : (database.Sale.AsEnumerable() ?? Array.Empty<Sale>()).Where(sale => sale.Customer != null && IsSaleUnpaid(sale)).ToList();
        }

        public List<Job> GetUnpaidJobs()
        {
            var database = new AromasDatabaseEntities();
            return _view.FilterByCustomer
                ? (database.Job.AsEnumerable() ?? Array.Empty<Job>()).Where(job => job.CustomerId == _view.SelectedCustomerId && IsJobUnpaid(job)).ToList()
                : (database.Job.AsEnumerable() ?? Array.Empty<Job>()).Where(job => job.Customer != null && IsJobUnpaid(job)).ToList();
        }

        private Job GetJobToPay()
        {
            var database = new AromasDatabaseEntities();
            return database.Job.Find(_view.SelectedPayableId);
        }

        private Sale GetSaleToPay()
        {
            var database = new AromasDatabaseEntities();
            return database.Sale.Find(_view.SelectedPayableId);
        }

        public string GetSaleItems(int saleId)
        {
            var builder = new StringBuilder();
            var database = new AromasDatabaseEntities();
            var sale = database.Sale.Find(saleId);
            foreach (var detail in sale.SaleDetail)
            {
                builder.AppendLine($"● {detail.ProductName.ToLower().Titleize()} ({detail.Amount} un.)  —  {detail.SalePrice * detail.Amount:C}");
            }
            return builder.ToString();
        }
        public string GetJobItems(int jobId)
        {
            var database = new AromasDatabaseEntities();
            var job = database.Job.Find(jobId);
            return $"● {job.Specification.ToLower().Titleize()}  —  {job.TotalPrice:C}";
        }

        public void PayDebt()
        {
            DebtPayment debtPayment;

            if (_view.IsJobSelected)
            {
                var job = GetJobToPay();
                var amountToPay = job.TotalPrice - GetPaidAmount(job);
                debtPayment = new DebtPayment(job, amountToPay);
            }
            else
            {
                var sale = GetSaleToPay();
                var amountToPay = GetTotalPrice(sale) - GetPaidAmount(sale);
                debtPayment = new DebtPayment(sale, amountToPay);
            }

            debtPayment.ShowDialog();
        }

        private object GetUnpaidPurchasings()
        {
            var unpaidSales = GetUnpaidSales()?.Select(s => new
            {
                Category = "Venda",
                RefId = s.SaleId,
                Customer = s.Customer?.FullName,
                s.EventDate,
                Total = GetTotalPrice(s),
                PaidAmount = GetPaidAmount(s)
            });

            var unpaidJobs = GetUnpaidJobs()?.Select(j => new
            {
                Category = "Serviço",
                RefId = j.JobId,
                Customer = j.Customer?.FullName,
                j.EventDate,
                Total = j.TotalPrice,
                PaidAmount = GetPaidAmount(j)
            });

            if (unpaidSales != null && unpaidJobs != null)
                return unpaidSales.Union(unpaidJobs).ToList();
            return unpaidJobs?.ToList() ?? unpaidSales?.ToList();
        }
        public void UpdateDisplay()
        {
            _view.DataSource = GetUnpaidPurchasings();
            if (!_view.FilterByCustomer) return;
            decimal jobDebtAmount = GetUnpaidJobs()?.Sum(j => j.TotalPrice - GetPaidAmount(j)) ?? 0;
            decimal saleDebtAmount = GetUnpaidSales()?.Sum(s => GetTotalPrice(s) - GetPaidAmount(s)) ?? 0;
            _view.TotalCustomerDebtAmount = jobDebtAmount + saleDebtAmount;
        }

        public void Update(ISubject subject)
        {
            UpdateDisplay();
        }
    }
}
