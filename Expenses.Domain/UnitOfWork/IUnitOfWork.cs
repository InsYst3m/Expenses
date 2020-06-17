using Expenses.Domain.IRepositories;
using System;

namespace Expenses.Domain.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IExpensesRepository Expenses { get; }
        int Complete();
    }
}
