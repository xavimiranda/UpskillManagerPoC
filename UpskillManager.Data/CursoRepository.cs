using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpskillManager.Data.Models;

namespace UpskillManager.Data
{
    public class CursoRepositorySqlSever : ICursoRepository
    {

        public string ConnString { get; set; }

        public CursoRepository(string conn)
        {
            ConnString = conn;
        }
        public List<Curso> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                List<Curso> cursos = conn.Query<Curso>("SELECT * FROM Cursos");
                return cursos;
            }
        }

        public Curso GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
