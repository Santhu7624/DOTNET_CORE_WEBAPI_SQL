using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using EComm.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace EComm.DataAccess.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products {get; set;}

        public DbSet<ProductBrand> ProductBraands {get;set;}

        public DbSet<ProductType> ProductTypes {get; set;}

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}