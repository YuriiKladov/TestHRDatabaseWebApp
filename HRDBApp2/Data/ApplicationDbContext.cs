using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HRDBApp2.Models;

namespace HRDBApp2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HRDBApp2.Models.Position> Position { get; set; }
        public DbSet<HRDBApp2.Models.Employee> Employee { get; set; }
    }
}