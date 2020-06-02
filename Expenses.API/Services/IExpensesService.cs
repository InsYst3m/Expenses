using SqlWrapper.Models;
using System.Collections.Generic;

namespace Expenses.API.Services
{
    public interface IExpensesService
    {
        void Add(Expense expense);
        Expense Get(int id);
        IEnumerable<Expense> Get();
    }
}
