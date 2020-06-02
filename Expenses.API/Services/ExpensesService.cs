using SqlWrapper;
using SqlWrapper.Models;
using System;
using System.Collections.Generic;

namespace Expenses.API.Services
{
    public class ExpensesService : IExpensesService
    {
        private readonly ISqlWrapper _sqlWrapper;

        public ExpensesService(ISqlWrapper sqlWrapper)
        {
            _sqlWrapper = sqlWrapper;
        }

        public void Add(Expense expense)
        {
            throw new NotImplementedException();
        }

        public Expense Get(int id)
        {
            return _sqlWrapper.Read(id);
        }

        public IEnumerable<Expense> Get()
        {
            return _sqlWrapper.Read();
        }
    }
}
