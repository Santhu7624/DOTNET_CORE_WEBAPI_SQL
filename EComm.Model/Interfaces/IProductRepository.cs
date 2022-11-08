using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EComm.Model.Entities;

namespace EComm.Model.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<IReadOnlyList<Product>> GetProductsListAsync();

        Task<IReadOnlyList<ProductBrand>> GetProductBrandsListAsync();

        Task<IReadOnlyList<ProductType>> GetProductTypesListAsync();

    }
}