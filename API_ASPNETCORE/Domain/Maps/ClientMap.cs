using API_ASPNETCORE.Domain.Model;
using API_ASPNETCORE.Domain.ViewModel;
using Mapster;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace API_ASPNETCORE.Domain.Maps
{
    public class ClientMap : IRegister
    {
        /// <summary>
        /// Exemplo de Mapeamento entre Model e ViewModel. Mesmo não sendo necessario para este caso.
        /// </summary>
        public void Register(TypeAdapterConfig config)
        {
            TypeAdapterConfig<Client, ClientViewModel>.NewConfig()
                .Map(trg => trg.CodigoCliente, src => src.ClientCode)
                .Map(trg => trg.NomeCliente, src => src.ClientName)
                .Map(trg => trg.DataNascimento, src => src.BirthDate)
                .Map(trg => trg.Email, src => src.Email)
                .Map(trg => trg.Endereco, src => src.Address)
                .Map(trg => trg.TipoCliente, src => src.TypeClient);

            TypeAdapterConfig<ClientViewModel, Client>.NewConfig()
                .Map(trg => trg.ClientCode, src => src.CodigoCliente)
                .Map(trg => trg.ClientName, src => src.NomeCliente)
                .Map(trg => trg.BirthDate, src => src.DataNascimento)
                .Map(trg => trg.Email, src => src.Email)
                .Map(trg => trg.Address, src => src.Endereco)
                .Map(trg => trg.TypeClient, src => src.TipoCliente);
        }
    }
}
