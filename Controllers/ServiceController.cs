using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AromasEstoque.Controllers
{
    class ServiceController
    {
        IServiceController _view;
        public ServiceController(IServiceController view)
        {
            _view = view;
            UpdateDataSource();
        }

        public void UpdateDataSource()
        {
            if (_view.FilterByDate)
            {
                _view.ServiceDataSource = GetServiceList(_view.FromDate, _view.ToDate);
                DisplayIncome(_view.FromDate, _view.ToDate);
            }
            else
            {
                _view.ServiceDataSource = GetServiceList();
                DisplayMonthIncome();
            }
        }

        private void DisplayMonthIncome()
        {
            var database = new AromasDatabaseEntities();
            var monthlyIncome = database.Job
                .Where(job => job.EventDate.Year == DateTime.Now.Year && job.EventDate.Month == DateTime.Now.Month)
                .Sum(job => (decimal?)job.TotalPrice);
            _view.MonthlyIncome = monthlyIncome ?? 0;
        }
        private void DisplayIncome(DateTime from, DateTime to)
        {
            var database = new AromasDatabaseEntities();
            var monthlyIncome = database.Job
                .Where(job => job.EventDate >= DbFunctions.TruncateTime(from) && job.EventDate <= DbFunctions.TruncateTime(to))
                .Sum(job => (decimal?)job.TotalPrice);
            _view.MonthlyIncome = monthlyIncome ?? 0;
        }
        private object GetServiceList()
        {
            var database = new AromasDatabaseEntities();
            return database.Job.Select(job => new {
                job.JobId,
                job.EventDate,
                Service = job.Specification,
                job.ServiceProvider.FullName,
                CustomerName = job.Customer.FullName,
                job.TotalPrice,
            }).OrderByDescending(job => job.JobId).ToList();
        }
        private object GetServiceList(DateTime from, DateTime to)
        {
            var database = new AromasDatabaseEntities();
            return database.Job.Select(job => new {
                job.JobId,
                job.EventDate,
                Service = job.Specification,
                job.ServiceProvider.FullName,
                CustomerName = job.Customer.FullName,
                job.TotalPrice,
            }).OrderByDescending(job => job.JobId)
            .Where(job => job.EventDate >= DbFunctions.TruncateTime(from) && job.EventDate <= DbFunctions.TruncateTime(to))
            .ToList();
        }
        private DialogResult ShowDeleteConfirmation(Job job)
        {
            var confirmation = MessageBox.Show($@"Você está excluindo o serviço {job.JobId}. Todos os pagamentos associados a ele serão excluídos. Deseja continuar?",
                @"Excluir serviço",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            return confirmation;
        }
        public void DeleteJob()
        {
            if (!MainDashboard.IsActionAllowed) return;

            using (var database = new AromasDatabaseEntities())
            {
                var job = database.Job.Find(_view.SelectedJobId);
                if (ShowDeleteConfirmation(job) != DialogResult.Yes || !MainDashboard.IsActionAllowed) return;
                database.Transactions.RemoveRange(job.Transactions);
                database.Job.Remove(job);
                database.SaveChanges();
            }
            _view.ServiceDataSource = GetServiceList();
        }
    }
}
