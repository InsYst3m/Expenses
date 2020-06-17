using Expenses.Domain.Entities;
using Expenses.Domain.IRepositories;

namespace Expenses.DataAccess.Repositories
{
    public class ExpensesRepository : Repository<Expense>, IExpensesRepository
    {
        public ExpensesRepository(ExpensesDbContext context)
            : base(context) { }

    }
}
