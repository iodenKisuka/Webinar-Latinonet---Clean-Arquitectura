using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataContext
{
    //crear migraciones esto es una fabrica de contexto
    public class ContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContext CreateDbContext(string[] args)
        {
            var opcionsBuilder = new DbContextOptionsBuilder<ProductContext>();
            opcionsBuilder.UseSqlServer("Server=(localdb)//mssqllocaldb;database=LatinoNet");
            return new ProductContext(opcionsBuilder.Options);
        }
    }
}
