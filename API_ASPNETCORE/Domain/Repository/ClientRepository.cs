using API_ASPNETCORE.Domain.Bases;
using API_ASPNETCORE.Domain.Enum;
using API_ASPNETCORE.Domain.Model;

namespace API_ASPNETCORE.Domain.Repository
{
    /// <summary>
    /// Este repository foi criado apenas para simular rapidamente a API. Não fazendo de forma real o CRUD.
    /// </summary>
    public class ClientRepository : RepositoryBase<Client>
    {

        public IList<Client> GetListClients(int quantidade)
        {
            var listaClient = new List<Client>();

            for(int i = 1; i <= quantidade; i++)
            {
                listaClient.Add(RandonClient(i));
            }

            if(listaClient.Count > 0)
                return listaClient;
            else
                return new List<Client>();
        }

        public Client UpdateClient(int id, string name)
        {
            Client client = RandonClient(id);
            client.ClientName = name;
            return client;
        }

        public bool DeleteClient(int id)
        {
            if (id > 0)
                return true;
            return false;
        }

        private static Client RandonClient(int id)
        {
            DateTime date = DateTime.Now.AddYears(-id).Date;
            Random gerador = new();
            Client client = new()
            {
                ClientCode = gerador.Next(),
                ClientName = "Cliente - " + id,
                BirthDate = date,
                Email = "cliente@email.com." + id,
                Address = $"endereço cliente({id})",
                TypeClient = GetType(id),
                DtSyncApi = DateTime.Now
            };
            

            return client;
        }

        private static EnumTypeClient GetType(int id)
        {
            if ((id % 2) == 1)
                return EnumTypeClient.JURIDICA;
            else
                return EnumTypeClient.FISICA;
        }

        


    }
}

