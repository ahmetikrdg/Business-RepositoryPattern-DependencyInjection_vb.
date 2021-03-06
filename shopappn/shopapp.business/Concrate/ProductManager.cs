using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.data.Concrate.EfCore;
using shopapp.entity;

namespace shopapp.business.Concrate
{
    public class ProductManager : IProductServices
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository= productRepository;
        }
        public void Create(Product entity)
        {
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public System.Collections.Generic.List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}