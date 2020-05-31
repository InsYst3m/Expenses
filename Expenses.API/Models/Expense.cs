using System;
using System.Collections.Generic;

namespace Expenses.API.Models
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public IList<string> Tags { get; set; }
    }
}
