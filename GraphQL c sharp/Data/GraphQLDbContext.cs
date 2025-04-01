using GraphQL_c_sharp.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_c_sharp.Data
{
    public class GraphQLDbContext : DbContext
    {
        public GraphQLDbContext(DbContextOptions<GraphQLDbContext> options) : base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Menu>().HasData(
                new Menu(){ Id =1, Name = "aa", Description = "aaa", Price = 1},
                new Menu(){ Id =2, Name = "bb", Description = "bbb", Price = 2},
                new Menu(){ Id =3, Name = "cc", Description = "ccc", Price = 3},
                new Menu(){ Id =4, Name = "dd", Description = "ddd", Price = 4}
            );
        }
    }
}