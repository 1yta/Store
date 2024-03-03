using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Delete(int id);
        void Insert(Category model);
        void Update(Category model);
    }
}
