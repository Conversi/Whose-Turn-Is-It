
using Whose_Turn_Is_It.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Whose_Turn_Is_It.Data
{
    public class WhoseContext : DbContext
    {
        public WhoseContext() : base("WhoseContext")
        {
        }

        public DbSet<CreateJob> createJobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
