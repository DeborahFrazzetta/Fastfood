using FastFood.DTO;
using FastFood.Model;
using FastFood.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FastFood.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ClienteRepository _repo;

        public ClienteController(ClienteRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Cliente> list = _repo.GetAll();
            List<ClienteDTO> result = list.Select(x => entityToDto(x)).ToList();
            return this.Ok(result);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            Cliente c = _repo.GetById(id);
            if (c == null) return this.NotFound();


            ClienteDTO result = entityToDto(c);
            return this.Ok(result); 
        }

        [HttpPost]
        public IActionResult Save([FromBody] ClienteDTO dto)
        {
            Cliente saving = dtoToEntity(dto); 
            var result = _repo.Save(saving);
            return this.Ok(result);

        }

        private ClienteDTO entityToDto(Cliente c)
        {
            ClienteDTO dto = new ClienteDTO();
           dto.id = c.id;
           dto.nome = c.nome;
            dto.is_vegetariano = c.is_vegetariano;
            dto.eta = c.eta;
            return dto;
        }

        private Cliente dtoToEntity(ClienteDTO dto)
        {
            Cliente c = new Cliente();
            c.id = dto.id;
            c.nome = dto.nome;
            c.is_vegetariano = dto.is_vegetariano;
            c.eta = dto.eta;

            return c;
        }

        
            

            //var result = new List<ClienteDTO>();
            //var entities = _repo.GetAll();
            //foreach (var entity in entities)
            //{
            //    result.Add(ClienteDTO.CreateDTO(entity));
            //}
            //return this.Ok(result);
        }


        
    }

