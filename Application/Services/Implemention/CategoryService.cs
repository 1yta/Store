using Application.Services.Interface;
using Application.ViewModel.Category;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services.Implemention
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository { get; set; }
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<CategoryViewModel> GetAll()
        {
            return _categoryRepository.GetAll().Select(c => new CategoryViewModel
            {
                Title = c.Title,
                Id = c.Id,

            }).ToList();

        }

        public UpsertCategoryViewModel GetById(int id)
        {
            var category = _categoryRepository.GetById(id);

            return new UpsertCategoryViewModel
            {
                Title = category.Title,
                Id = category.Id
            };
        }

        public void Create(UpsertCategoryViewModel model)
        {
            Category category = new Category();
            category.Title = model.Title;

            _categoryRepository.Insert(category);
        }

        public void Update(UpsertCategoryViewModel model)
        {

            var category = _categoryRepository.GetById(model.Id);
            category.Title = model.Title;

            _categoryRepository.Update(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }
    }
}
