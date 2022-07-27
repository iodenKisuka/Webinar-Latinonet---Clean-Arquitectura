using Entitys.Clases_POCOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorry.DataContext
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> opcions): base(opcions) { }
        public DbSet<Product> Products { get; set; }
    }
}
