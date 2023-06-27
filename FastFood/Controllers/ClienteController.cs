using FastFood.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FastFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ClienteRepository _repo;

        public ClienteController(ClienteRepository repo)
        {
            _repo = repo;
        }
    }
}
