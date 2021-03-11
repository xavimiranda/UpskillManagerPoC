using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpskillManager.Data.Models;

namespace UpskillManager.Data
{
    public interface ICursoRepository
    {
        List<Curso> GetAll();

        Curso GetById(int id);
    }
}
