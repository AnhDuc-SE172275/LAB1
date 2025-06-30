using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Collections.Generic;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductRepository;
        public ProductService()
        {
            iProductRepository = new ProductRepository();
        }
        public void DeleteProduct(Product p)
        {
            iProductRepository.DeleteProduct(p);
        }

        public void DeleteProduct(BusinessObjects.Product p)
        {
            throw new NotImplementedException();
        }

        public List<BusinessObjects.Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            return iProductRepository.GetProductById(id);
        }

        public BusinessObjects.Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return iProductRepository.GetProduct();
        }
        public void SaveProduct(Product p)
        {
            iProductRepository.SaveProduct(p);
        }

        public void SaveProduct(BusinessObjects.Product p)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product p)
        {
            iProductRepository.UpdateProduct(p);
        }

        public void UpdateProduct(BusinessObjects.Product p)
        {
            throw new NotImplementedException();
        }

        IEnumerable IProductService.GetProducts()
        {
            return GetProducts();
        }

        System.Collections.IEnumerable IProductService.GetProducts()
        {
            return GetProducts();
        }
    }
}
