using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UpskillManager.Shared.Validation;

namespace UpskillManager.UI.Models
{
    public class AlunoViewModel
    {
        [Required(ErrorMessage = "O aluno precisa de um nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Qual a data de nascimento do aluno")]
        [DateAttribute(ErrorMessage = "Data de Nascimento tem que ser entre {1} e {2}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Introduza o CC do aluno")]
        public string CC { get; set; }
   }

}
