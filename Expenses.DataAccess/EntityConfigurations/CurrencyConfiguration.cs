using Expenses.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expenses.DataAccess.EntityConfigurations
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.Property(currency => currency.Id)
                .IsRequired()
                .UseIdentityColumn();

            builder.Property(currency => currency.Symbol)
                .HasMaxLength(1);

            builder.Property(currency => currency.Code)
                .IsRequired()
                .HasMaxLength(5);

            builder.HasMany(currency => currency.Expenses)
                .WithOne(expense => expense.Currency)
                .IsRequired();
        }
    }
}
