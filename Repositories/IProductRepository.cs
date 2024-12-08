using Orange_POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Repositories
{
    internal interface IProductRepository
    {
        void AddProduct(Products products);
        List<Products> GetAllProducts();
        void UpdateProduct(Products products);
        void DeleteProduct(int productId);
        Products GetProductById(int productId);
        List<Products> GetProductByMenuId(int menuId);
    }
}
