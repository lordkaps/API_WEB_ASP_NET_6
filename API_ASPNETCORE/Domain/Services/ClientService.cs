using API_ASPNETCORE.Domain.Bases;
using API_ASPNETCORE.Domain.Model;
using API_ASPNETCORE.Domain.Repository;
using API_ASPNETCORE.Domain.Services.IServices;
using API_ASPNETCORE.Domain.ViewModel;
using System.Xml.Linq;

namespace API_ASPNETCORE.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly ClientRepository _clientRepository;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public async Task<IList<ClientViewModel>> GetClients(int amountClient)
        {
            return await Task.Run(() =>
            {
                IList<Client> listClients = _clientRepository.GetListClients(amountClient);
                IList<ClientViewModel> listClientsViewModel = new List<ClientViewModel>();

                foreach (Client client in listClients)
                {
                    listClientsViewModel.Add(Adapt(client));
                }
                return listClientsViewModel;
            });
        }

        public Task PostClients(List<ClientViewModel> listClients)
        {
            return Task.Run(() =>
            {
                return listClients;
            });
        }

        public Task<ClientViewModel> PutClient(int id, string name)
        {
            return Task.Run(() =>
            {
                Client cliente = _clientRepository.UpdateClient(id, name);
                    
                return Adapt(cliente);
            });
        }

        public Task<bool> DeleteClient(int id)
        {
            return Task.Run(() =>
            {
                var result = _clientRepository.DeleteClient(id);

                return result;
            });
        }

        public ClientViewModel Adapt(Client client)
        {
            if (client == null) return new ClientViewModel();

            ClientViewModel clientViewModel = new ClientViewModel
                (
                client.ClientCode,
                client.BirthDate,
                client.ClientName,
                client.Email,
                client.Address,
                client.TypeClient.ToString(),
                client.DtSyncApi
                );
            return clientViewModel;
        }

        
    }
}
