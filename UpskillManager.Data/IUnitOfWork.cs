using System;

namespace UpskillManager.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IAlunosRepository Alunos { get; }
    }
}
