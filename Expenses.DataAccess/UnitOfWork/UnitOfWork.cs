using Expenses.DataAccess.Repositories;
using Expenses.Domain.IRepositories;
using Expenses.Domain.UnitOfWork;

namespace Expenses.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExpensesDbContext _context;

        public IExpensesRepository Expenses { get; private set; }

        public UnitOfWork(ExpensesDbContext context)
        {
            _context = context;
            Expenses = new ExpensesRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
