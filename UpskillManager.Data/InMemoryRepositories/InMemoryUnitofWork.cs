using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillManager.Data
{
    public class InMemoryUnitOfWork : IUnitOfWork
    {
        public IAlunosRepository Alunos { get; private set;  }
        
        public InMemoryUnitOfWork(IAlunosRepository alunos)
        {
            this.Alunos = alunos;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
