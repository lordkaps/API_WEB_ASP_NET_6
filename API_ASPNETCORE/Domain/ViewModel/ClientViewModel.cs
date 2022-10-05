using API_ASPNETCORE.Domain.Bases;
using API_ASPNETCORE.Domain.Enum;
using System.Text.Json.Serialization;

namespace API_ASPNETCORE.Domain.ViewModel
{
    public sealed class ClientViewModel : ViewModelBase
    {
        public int CodigoCliente { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string TipoCliente { get; set; }

        public ClientViewModel()
        {
        }

        public ClientViewModel(int codigoCliente, DateTime dataNascimento, string nomeCliente, string email, string endereco, string tipoCliente, DateTime? data) : base()
        {
            CodigoCliente = codigoCliente;
            DataNascimento = dataNascimento;
            NomeCliente = nomeCliente;
            Email = email;
            Endereco = endereco;
            TipoCliente = tipoCliente;
            DtSyncApi = data;
        }
    }
}
