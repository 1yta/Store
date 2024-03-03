using Domain.Models;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Delete(int id);
        void Insert(Product model);
        void Update(Product model);
    }
}
