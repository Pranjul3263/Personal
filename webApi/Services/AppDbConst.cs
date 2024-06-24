using Microsoft.EntityFrameworkCore;
using System.Net;
using webApi.Model.Entity;

namespace webApi.Data
{
    public class AppDbConst : DbContext
    {
        public AppDbConst(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }



        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.Entity<Employee>().HasNoKey();

        }
    }
}
