using System.Linq;
using System.Windows.Forms;

namespace AromasEstoque
{
    public class ServiceProviderController
    {
        private readonly IServiceProviderManagement _view;
        public ServiceProviderController(IServiceProviderManagement view)
        {
            _view = view;
            _view.SetController(this);
            _view.ProviderDataSource = GetProviderList();
        }
        public ServiceProviderController()
        {

        }
        public void AddProvider(string providerName)
        {
            using (var database = new AromasDatabaseEntities())
            {
                database.ServiceProvider.Add(new ServiceProvider
                {
                    FullName = providerName
                });

                database.SaveChanges();
            }
        }
        public void AddProvider()
        {
            using (var addDialog = new AddUpdateServiceProvider())
            {
                if (addDialog.ShowDialog() != DialogResult.OK) return;
            }
            _view.ProviderDataSource = GetProviderList();
        }

        public void UpdateProvider(int providerId, string newName)
        {
            using (var database = new AromasDatabaseEntities())
            {
                var provider = database.ServiceProvider.Find(providerId);
                provider.FullName = newName;
                database.SaveChanges();
            }
        }

        public void EditProvider()
        {
            using (var editDialog = new AddUpdateServiceProvider(_view.SelectedProviderId))
            {
                if (editDialog.ShowDialog() != DialogResult.OK) return;
            }
            _view.ProviderDataSource = GetProviderList();
        }

        private DialogResult ShowDeleteConfirmation(ServiceProvider provider)
        {
            var confirmation = MessageBox.Show($"Tem certeza que deseja excluir o prestador de serviços {provider.FullName}?",
                "Excluir prestador de serviços",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            return confirmation;
        }
        public void DeleteProvider()
        {
            using (var database = new AromasDatabaseEntities())
            {
                var provider = database.ServiceProvider.Find(_view.SelectedProviderId);
                if (ShowDeleteConfirmation(provider) != DialogResult.Yes) return;
                database.ServiceProvider.Remove(provider);
                database.SaveChanges();
            }
            _view.ProviderDataSource = GetProviderList();
        }
        public ServiceProvider GetSingleProvider (int providerId)
        {
            using (var database = new AromasDatabaseEntities())
            {
                return  database.ServiceProvider.Find(providerId);
            }
        }
        public object GetProviderList()
        {
            var database = new AromasDatabaseEntities();
            return database.ServiceProvider
                .Select(provider => new {
                    provider.ProviderId,
                    provider.FullName
                }).ToList();
        }
    }
}
