using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24Week12CodeFirstApproach
{
    // context class
    // it must inherit from built-in class DbContext
    public class SchoolContext : DbContext
    {
        // entity sets - (required)
        // define properties of type DbSet<> for all entities
        public DbSet<Student>? Students { get; set; }
        public DbSet<Standard>? Standards { get; set; }


        // define the database connection - (required)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=SchoolCF; Trusted_Connection=True;MultipleActiveResultSets=true;");
        }


        // data seeding - (optional)

    }
}
