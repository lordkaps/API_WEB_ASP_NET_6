using API_ASPNETCORE.Domain.Bases;
using API_ASPNETCORE.Domain.Model;
using API_ASPNETCORE.Domain.Repository;
using API_ASPNETCORE.Domain.Services.IServices;
using API_ASPNETCORE.Domain.ViewModel;

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
            throw new NotImplementedException();
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
