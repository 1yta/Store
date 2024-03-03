using Application.ViewModel.Category;

namespace Application.Services.Interface
{
    public interface ICategoryService
    {
        List<CategoryViewModel> GetAll();
        UpsertCategoryViewModel GetById(int id);
        void Create(UpsertCategoryViewModel model);
        void Update(UpsertCategoryViewModel model);
        void Delete(int id);
    }
}
