using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillManager.Data.Models
{
    public class Curso
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Pessoa Coordenador { get; set; }

        public List<Modulo> Modulos { get; set; } = new List<Modulo>();
    }
}
