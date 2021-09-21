using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AromasEstoque
{
    public partial class Comission : MetroForm
    {
        public Comission()
        {
            InitializeComponent();
        }

        private void Date_CloseUp(object sender, EventArgs e)
        {
            var database = new AromasDatabaseEntities();

            var salesFromPeriod = database.Sale.Where(sale => DbFunctions.TruncateTime(sale.EventDate) >= fromDatePicker.Value.Date && DbFunctions.TruncateTime(sale.EventDate) <= toDatePicker.Value.Date).ToList();

            var comission = salesFromPeriod
                .GroupBy(sale => sale.Employee.FullName)
                .Select(ec => new
                {
                    Funcionário = ec.Key,
                    Comissão = (ec
                        .Sum(sale => sale.SaleDetail.Sum(detail => detail.SalePrice * detail.Amount) - sale.Discount) * 0.02m).ToString("C")
                });

            comissionGrid.DataSource = comission.ToList();
        }
    }
}
