
using Microsoft.EntityFrameworkCore;

namespace InsuranceQuote.Models
{
    public class InsuranceContext : DbContext
    {
        public DbSet<Insuree> Insurees { get; set; }

        public InsuranceContext(DbContextOptions<InsuranceContext> options) : base(options)
        {
        }
    }
}
