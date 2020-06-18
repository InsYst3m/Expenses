using Expenses.DataAccess.Repositories;
using Expenses.DataAccess.UnitOfWorks;
using Expenses.Domain.IRepositories;
using Expenses.Domain.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Expenses.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
        {
            services.AddDbContext<ExpensesDbContext>(options =>
                options.UseSqlServer(@"Data Source=DESKTOP-6KQ96MP\MSSQLSERVER2017;Initial Catalog=ExpensesGod;Integrated Security=True"));

            services.AddTransient<IExpensesRepository, ExpensesRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
