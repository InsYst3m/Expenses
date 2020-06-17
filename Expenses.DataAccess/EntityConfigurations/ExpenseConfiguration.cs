using Expenses.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expenses.DataAccess.EntityConfigurations
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Price)
                .IsRequired();

            builder.Property(x => x.Comment)
                .HasMaxLength(255);

            builder.HasMany(expense => expense.Tags)
                .WithOne(tag => tag.Expense)
                .IsRequired();
        }
    }
}
