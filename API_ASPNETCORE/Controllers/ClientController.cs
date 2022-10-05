using API_ASPNETCORE.Domain.Services;
using API_ASPNETCORE.Domain.Services.IServices;
using API_ASPNETCORE.Domain.ViewModel;
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
                return new JsonResult(BadRequest(error: "Não foi possivel retornar uma lista de clientes. Favor inserir quantidade válida."));
            
            return new JsonResult(result);
        }

        [HttpPost(Name = "PostClientes")]
        public async Task<ActionResult> Post([FromBody] List<ClientViewModel> listClients)
        {
            await _service.PostClients(listClients);
            return Ok(listClients);
        }

        [HttpPut(Name = "PutCliente")]
        public async Task<ActionResult> Put(int id, string nome)
        {
            var result = await _service.PutClient(id, nome);
            if(result == null)
                return BadRequest("Erro ao atualizar");

            return Ok(result);
        }

        [HttpDelete(Name = "DeleteCliente")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteClient(id);
            if(result)
                return Ok();
            return BadRequest("Falha ao excluir este cliente.");
        }
    }
}
