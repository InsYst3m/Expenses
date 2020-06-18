using Expenses.DataAccess.EntityConfigurations;
using Expenses.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expenses.DataAccess
{
    public class ExpensesDbContext : DbContext
    {
        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options) 
            : base(options) { }

        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
        }
    }
}
