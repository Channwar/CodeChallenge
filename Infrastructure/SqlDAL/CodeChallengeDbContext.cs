using Infrastructure.SqlDAL.Model;

using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

namespace Infrastructure.SqlDAL
{
    public class CodeChallengeDbContext : DbContext
    {
        private readonly string connectionString;

        public CodeChallengeDbContext(string connectionString)
        : base() => this.connectionString = connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySQL(connectionString);

        public DbSet<InfrastructureEmployee> EmployeeDbSet => 
            Set<InfrastructureEmployee>();

        public DbSet<InfrastructureProject> ProjectDbSet =>
            Set<InfrastructureProject>();
        public DbSet<InfrastructureDepartment> DepartementDbSet =>
            Set<InfrastructureDepartment>();
    }
}