using Expenses.Domain.IRepositories;
using Expenses.Domain.UnitOfWorks;

namespace Expenses.DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExpensesDbContext _context;

        public IExpensesRepository Expenses { get; private set; }

        public UnitOfWork(ExpensesDbContext context, IExpensesRepository expensesRepository)
        {
            _context = context;
            Expenses = expensesRepository;
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
