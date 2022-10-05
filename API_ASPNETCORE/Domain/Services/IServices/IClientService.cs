using API_ASPNETCORE.Domain.ViewModel;

namespace API_ASPNETCORE.Domain.Services.IServices
{
    public interface IClientService
    {
        Task<IList<ClientViewModel>> GetClients(int amount);
        Task PostClients (List<ClientViewModel> listClients);
        Task<ClientViewModel> PutClient(int id, string name);
        Task<bool> DeleteClient(int id);
    }
}
