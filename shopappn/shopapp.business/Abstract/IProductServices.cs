using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IProductServices
    {
         Product GetById(int id);
         List<Product> GetAll();
         void Create(Product entity);
         void Update(Product entity);
         void Delete(Product entity);
    }
}