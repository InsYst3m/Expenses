using Expenses.Domain.IRepositories;
using System;

namespace Expenses.Domain.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IExpensesRepository Expenses { get; }
        int Complete();
    }
}
