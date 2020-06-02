using System.Collections.Generic;

namespace SqlWrapper.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public IList<string> Tags { get; set; }
    }
}
