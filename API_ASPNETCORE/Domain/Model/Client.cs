using API_ASPNETCORE.Domain.Base;
using API_ASPNETCORE.Domain.Enum;

namespace API_ASPNETCORE.Domain.Model
{
    public sealed class Client : ModelBase
    {
        public int ClientCode { get; set; }
        public string ClientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public EnumTypeClient TypeClient { get; set; }
    }
}
