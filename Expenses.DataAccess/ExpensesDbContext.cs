using Expenses.DataAccess.EntityConfigurations;
using Expenses.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Expenses.DataAccess
{
    public class ExpensesDbContext : DbContext
    {
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6KQ96MP\MSSQLSERVER2017;Initial Catalog=ExpensesGod;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
            modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
        }
    }
}
