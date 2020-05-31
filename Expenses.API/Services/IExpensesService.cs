using Expenses.API.Models;
using System;
using System.Collections.Generic;

namespace Expenses.API.Services
{
    public interface IExpensesService
    {
        void Add(Expense expense);
        Expense Get(Guid id);
        IEnumerable<Expense> Get();
    }
}
