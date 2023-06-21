using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastFood.Model
{
    [Table("piatto")]
    public class Piatto
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(45)]
        public string descrizione { get; set; }
        [Required]
        public bool is_vegetariano { get; set; }
        [Required]
        public int prezzo { get; set; }



    }
}
