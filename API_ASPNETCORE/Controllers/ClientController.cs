using API_ASPNETCORE.Domain.Services;
using API_ASPNETCORE.Domain.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace API_ASPNETCORE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private IClientService _service;

        public ClientController()
        {
            _service = new ClientService();
        }

        [HttpGet(Name = "ListaClientes")]
        public async Task<JsonResult> Get([FromHeader] int quantidadeCliente)
        {
            var result = await _service.GetClients(quantidadeCliente);
            if (result == null || result.Count == 0)
            {
                return new JsonResult(BadRequest(error: "Não foi possivel retornar uma lista de clientes. Favor inserir quantidade válida."));
            }
            return new JsonResult(result);
        }
    }
}
