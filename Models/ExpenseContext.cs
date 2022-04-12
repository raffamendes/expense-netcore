using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ExpenseApi.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base (options)
        {}

        public DbSet<Expense> ExpensesEntries { get; set; } = null!;
    }
}