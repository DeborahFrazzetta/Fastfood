using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastFood.Model
{
    [Table("cliente")]
   public class Cliente
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(45)]
        public string nome { get; set; }
        [Required]
        public bool is_vegetariano { get; set; }
        [Required]
        public int eta { get; set; }    



    }
}
