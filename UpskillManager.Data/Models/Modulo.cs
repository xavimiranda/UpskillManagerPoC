using System.ComponentModel.DataAnnotations;

namespace UpskillManager.Data.Models
{
    public class Modulo
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public Pessoa Formador { get; set; }
    }
}