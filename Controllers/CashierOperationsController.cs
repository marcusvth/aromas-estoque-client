using System;

namespace AromasEstoque.Controllers
{
    public class CashierOperationsController
    {
        private ICasherOperations _view;
        public CashierOperationsController(ICasherOperations view)
        {
            _view = view;
        }
        private void Transact()
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.Transactions.Add(new Transactions
                {
                    EventDate = DateTime.Now,
                    Amount = _view.Amount,
                    Category = _view.IsDeposit? "D" : "W",
                    Comment = _view.Comment,
                    EmployeeId = MainDashboard.CurrentEmployee.EmployeeId,
                    Currency = "M"
                });

                database.SaveChanges();
            }
        }

        private void Readjust()
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.VaultBalance.Add(new VaultBalance
                {
                    ReferenceDate = DateTime.Now,
                    AdjustmentType = "M",
                    Balance = _view.Amount,
                    EmployeeId = MainDashboard.CurrentEmployee.EmployeeId
                });
                database.SaveChanges();
            }
        }

        public void CompleteOperation()
        {
            if (_view.IsReadjustment)
                Readjust();
            else Transact();
        }
    }
}
