using System;
using System.Collections.Generic;

namespace AromasEstoque.Controllers
{
    public class PaymentGatewayController : ISubject
    {
        private readonly IPaymentController _view;
        private readonly List<IObserver> _observers = new List<IObserver>();

        public PaymentGatewayController(IPaymentController view)
        {
            _view = view;
            Attach(TransactionsDashboard.Instance.Controller);
            Attach(PendingPayments.Instance.Controller);
        }

        private decimal CalculateReturnAmount()
        {
            var paidAmount = (_view.MoneyAmount + _view.DebitCardAmount + _view.CreditCardAmount);
            var returnAmount = paidAmount < _view.AmountToPay
                ? 0
                : paidAmount - _view.AmountToPay;
            return returnAmount;
        }
        public void UpdateDisplay()
        {
            _view.ReturnAmount = CalculateReturnAmount();
        }

        private void Pay(Sale sale, string method, decimal amount)
        {
            sale.Transactions.Add(new Transactions
            {
                Amount = amount,
                Currency = method,
                Category = "S",
                EventDate = DateTime.Now,
                Parcel = "C".Equals(method) ? _view.Parcel : (byte) 0,
                EmployeeId = MainDashboard.CurrentEmployee.EmployeeId,
                Comment = $"Pagamento de venda nº {sale.SaleId}",
            });

        }

        private void Pay(Job job, string method, decimal amount)
        {
            job.Transactions.Add(new Transactions
            {
                Amount = amount,
                Currency = method,
                Category = "J",
                EventDate = DateTime.Now,
                Parcel = "C".Equals(method) ? _view.Parcel : (byte) 0,
                EmployeeId = MainDashboard.CurrentEmployee.EmployeeId,
                Comment = $"Pagamento de serviço nº {job.JobId}",
            });
        }

        public void Transact(Sale refSale)
        {
            using (var database = new AromasDatabaseEntities())
            {
                var sale = database.Sale.Find(refSale.SaleId);


                if (_view.CreditCardEnabled && _view.CreditCardAmount > 0)
                    Pay(sale, "C", _view.CreditCardAmount);
                if (_view.DebitCardEnabled && _view.DebitCardAmount > 0)
                    Pay(sale, "D", _view.DebitCardAmount);
                if (_view.MoneyEnabled && _view.MoneyAmount > 0)
                    Pay(sale, "M", _view.MoneyAmount);
                if (CalculateReturnAmount() > 0)
                    TransactReturn(sale);

                database.SaveChanges();
            }
            Notify();
        }

        public void Transact(Job refJob)
        {
            using (var database = new AromasDatabaseEntities())
            {
                var job = database.Job.Find(refJob.JobId);


                if (_view.CreditCardEnabled && _view.CreditCardAmount > 0)
                    Pay(job, "C", _view.CreditCardAmount);
                if (_view.DebitCardEnabled && _view.DebitCardAmount > 0)
                    Pay(job, "D", _view.DebitCardAmount);
                if (_view.MoneyEnabled && _view.MoneyAmount > 0)
                    Pay(job, "M", _view.MoneyAmount);
                if (CalculateReturnAmount() > 0)
                    TransactReturn(job: job);

                database.SaveChanges();
            }

            Notify();
        }

        private void TransactReturn(Sale sale = null, Job job = null)
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.Transactions.Add(new Transactions
                {
                    Amount = CalculateReturnAmount(),
                    Currency = "M",
                    Category = "W",
                    EventDate = DateTime.Now,
                    Parcel = 0,
                    EmployeeId = MainDashboard.CurrentEmployee.EmployeeId,
                    Comment = "Troco",
                    SaleId = sale?.SaleId,
                    JobId = job?.JobId
                });

                database.SaveChanges();
            }
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
    }
}
