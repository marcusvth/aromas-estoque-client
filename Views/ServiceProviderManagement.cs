using MetroFramework.Forms;
using System.Windows.Forms;

namespace AromasEstoque
{
    public partial class ServiceProviderManagement : MetroForm, IServiceProviderManagement
    {
        public ServiceProviderController Controller;
        private static ServiceProviderManagement _instance;
        private bool _isDeleting;
        private bool _isEditing;
        public bool IsDeleting 
        { 
            get => _isDeleting;
            private set 
            {
                _isDeleting = value;
                if (value)
                    Controller.DeleteProvider();
            } 
        }
        public bool IsEditing 
        {
            get => _isEditing;
            private set 
            {

                _isEditing = value;
                if (value)
                    Controller.EditProvider();
            } 
        }
        public ServiceProviderManagement()
        {
            InitializeComponent();
            Controller =  new ServiceProviderController(this);
        }
        public static ServiceProviderManagement Instance
        {
            get
            {
                var isNullOrDisposed = _instance?.IsDisposed ?? true;
                return isNullOrDisposed ? _instance = new ServiceProviderManagement() : _instance;
            }
        }
        public void SetController(ServiceProviderController controller)
        {
            Controller = controller;
        }
        public object ProviderDataSource { set => providerGrid.DataSource = value; }
        public int SelectedProviderId { get; set; }
        private void ProviderGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var isDeleting = providerGrid.Columns[e.ColumnIndex].Name == "Delete";
            var isEditing = providerGrid.Columns[e.ColumnIndex].Name == "Edit";
            if (!isDeleting && !isEditing || e.RowIndex < 0) return;
            SelectedProviderId = int.Parse(providerGrid.Rows[e.RowIndex].Cells["ProviderId"].Value.ToString());
            IsDeleting = isDeleting;
            IsEditing = isEditing;
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            Controller.AddProvider();
        }
    }
}
