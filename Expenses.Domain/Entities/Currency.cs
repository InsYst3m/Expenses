using System.Collections.Generic;

namespace Expenses.Domain.Entities
{
    public class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }

        public List<Expense> Expenses { get; set; }
    }
}
