using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EComm.Model.Entities;
using EComm.Model.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EComm.DataAccess.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }        

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products
            .Include(p => p.ProductType)
            .Include(p => p.ProductType)
            .FirstOrDefaultAsync(p => p.ID == id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsListAsync()
        {
            return await _context.Products
            .Include(p => p.ProductType)
            .Include(p => p.ProductType)
            .ToListAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesListAsync()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsListAsync()
        {
            return await _context.ProductBraands.ToListAsync();
        }
    }
}