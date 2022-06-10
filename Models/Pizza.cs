using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nuova_pizza_ef_mvc.Models
{
    [Table("Pizza")]
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public string? ImgPath { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }

        public Pizza()
        {

        }
    }
}
