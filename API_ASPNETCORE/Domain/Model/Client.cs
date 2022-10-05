using API_ASPNETCORE.Domain.Bases;
using API_ASPNETCORE.Domain.Enum;

namespace API_ASPNETCORE.Domain.Model
{
    public sealed class Client : ModelBase
    {
        public int ClientCode { get; set; }
        public string ClientName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public EnumTypeClient? TypeClient { get; set; }

        public Client()
        {
        }

        public Client(int clientCode, string clientName, DateTime birthDate, string email, string address, EnumTypeClient? typeClient, DateTime dateTime) : base()
        {
            ClientCode = clientCode;
            ClientName = clientName;
            BirthDate = birthDate;
            Email = email;
            Address = address;
            TypeClient = typeClient;
            DtSyncApi = dateTime;
        }
    }
}
