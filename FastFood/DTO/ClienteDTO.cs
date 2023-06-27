using FastFood.Model;

namespace FastFood.DTO
{

    public class ClienteDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public bool is_vegetariano { get; set; }
        public  int eta { get; set; }            
        public ClienteDTO() { }

        public static ClienteDTO CreateDTO (ClienteDTO entity)
        {
            ClienteDTO dto = new ClienteDTO
            {
                id = entity.id,
                nome = entity.nome,
                is_vegetariano = entity.is_vegetariano,
                eta = entity.eta,
            };
            return dto;

        }

        public static Cliente GetEntity(ClienteDTO dto)
        {
            return new Cliente
            {
                id = dto.id,
                nome = dto.nome,
                is_vegetariano = dto.is_vegetariano,
                eta = dto.eta,
            };
        }

    }
}
