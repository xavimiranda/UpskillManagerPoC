using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UpskillManager.Data.Models
{
    public class Pessoa 
    {
        //ASP Identity User
        public IdentityUser User { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }


    }
}
