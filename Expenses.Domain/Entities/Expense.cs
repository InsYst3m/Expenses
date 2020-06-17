using System.Collections.Generic;

namespace Expenses.Domain.Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
