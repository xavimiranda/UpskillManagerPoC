using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UpskillManager.Data.Models;

namespace UpskillManager.Data
{
    public class InMemoryAlunoRepository : IAlunosRepository
    {
        public List<Aluno> Alunos { get; set; }

        private int Id { get; set; }

        public InMemoryAlunoRepository()
        {
            Alunos = new List<Aluno>
            {
                new Aluno
                {
                    Id = 1,
                    Nome = "Xavier Llansol de Miranda",
                    DataNascimento = DateTime.ParseExact("1989/10/23", "yyyy/MM/dd", CultureInfo.InvariantCulture ),
                    CC = "123456789"
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "José Francisco Dias",
                    DataNascimento = DateTime.ParseExact("1995/02/02", "yyyy/MM/dd", CultureInfo.InvariantCulture ),
                    CC = "123456789"
                }
            };
            Id = 3;
        }
        public void Add(Aluno aluno)
        {
            aluno.Id = Id;
            Id++;
            Alunos.Add(aluno);
        }

        public IEnumerable<Aluno> Find(Expression<Func<Aluno, bool>> predicate) => Alunos.Where(predicate.Compile());

        public Aluno Get(int id) => Alunos.FirstOrDefault(a => a.Id == id);

        public IEnumerable<Aluno> GetAll() => Alunos;

        public void Remove(Aluno aluno)
        {
            int removeAt = Alunos.IndexOf(aluno);
            Alunos.RemoveAt(removeAt);
        }
    }
}
