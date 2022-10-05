using API_ASPNETCORE.Domain.Base;
using API_ASPNETCORE.Domain.Enum;

namespace API_ASPNETCORE.Domain.ViewModel
{
    public sealed class ClientViewModel : ViewModelBase
    {
        public int CodigoCliente { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string NomeCliente { get; set; }
        public string? Email { get; set; }
        public string? Endereco { get; set; }
        public EnumTypeClient TipoCliente { get; set; }
    }
}
