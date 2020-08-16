using System.Collections.Generic;
using System.Linq;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrate.EfCore
{
    public class EfCorePrductRepository : EfCoreGenericRepository<Product,ShopContext>,IProductRepository
    {
        private ShopContext db=new ShopContext();

        public List<Product> GetPopularProducts()
        {
           using(var context=new ShopContext())
            {
              return context.Products.ToList();
            }
        }
        // public void Create(Product entity)
        // {
        //     db.Products.Add(entity);
        //     db.SaveChanges();
        // }

        // public void Delete(int entity)
        // {
        //     throw new System.NotImplementedException();
        // }

        // public List<Product> GetAll()
        // {
        //     throw new System.NotImplementedException();
        // }

        // public Product GetById(int id)
        // {
        //     throw new System.NotImplementedException();
        // }

        // public List<Product> GetPopularProducts()
        // {
        //     throw new System.NotImplementedException();
        // }

        // public void Update(Product product)
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}