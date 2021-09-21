using AromasEstoque.Controllers;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace AromasEstoque
{
    public partial class ServiceManagement : MetroForm, IServiceController
    {
        private ServiceController _controller;
        public int SelectedJobId { get; set; }
        private FromToDatetime _fromToDateTime {get; set;}

        private bool _isDeleting;
        public bool IsDeleting
        {
            get => _isDeleting;
            private set
            {
                if (value)
                    _controller.DeleteJob();
            }
        }
        public ServiceManagement()
        {
            InitializeComponent();
            serviceGrid.AutoGenerateColumns = false;
            _fromToDateTime = new FromToDatetime();
            dateTimePanel.Controls.Add(_fromToDateTime);
            _controller = new ServiceController(this);
            _fromToDateTime.ToDatePicker.CloseUp += DatePicker_CloseUp;
            _fromToDateTime.FromDatePicker.CloseUp += DatePicker_CloseUp;
        }

        public decimal MonthlyIncome
        {
            set => monthlyTotalDisplay.Text = $@"Total recebido: {value:C}";
        }

        private static ServiceManagement _instance;

        public static ServiceManagement Instance
        {
            get
            {
                var isNullOrDisposed = _instance?.IsDisposed ?? true;
                return isNullOrDisposed ? _instance = new ServiceManagement() : _instance;
            }
        }
        public object ServiceDataSource { set => serviceGrid.DataSource = value; }

        public bool FilterByDate => filterByDateSelector.Checked;

        public DateTime FromDate => _fromToDateTime.From;

        public DateTime ToDate => _fromToDateTime.To;

        private void ServiceGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var isDeleting = serviceGrid.Columns[e.ColumnIndex].Name == "Delete";
            if (!isDeleting || e.RowIndex < 0) return;
            SelectedJobId = int.Parse(serviceGrid.Rows[e.RowIndex].Cells["JobId"].Value.ToString());
            IsDeleting = true;
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            var addService = new AddService();
            if (addService.ShowDialog() != DialogResult.OK) return;
            _controller.UpdateDataSource();
        }

        private void ProviderManagementButton_Click(object sender, System.EventArgs e)
        {
            var providerManagement = new ServiceProviderManagement();
            providerManagement.ShowDialog();
        }

        private void FilterByDateSelector_CheckedChanged(object sender, System.EventArgs e)
        {
            dateTimePanel.Visible = filterByDateSelector.Checked;
            _controller.UpdateDataSource();
        }

        private void DatePicker_CloseUp(object sender, EventArgs e)
        {
            _controller.UpdateDataSource();
        }

        private void ServiceGrid_DatabindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            serviceGrid.Enabled = serviceGrid.Rows.Count > 0;
        }
    }
}
