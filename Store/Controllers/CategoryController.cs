
using Application.Services.Interface;
using Application.ViewModel.Category;
using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class CategoryController : Controller
    {
        #region Peroperties
        private ICategoryService _categoryService { get; set; }

        #endregion

        #region Ctor
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        #endregion

        #region Actions

        #region Get
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            return View(result);

        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UpsertCategoryViewModel model)
        {
            _categoryService.Create(model);

            return Ok();

        }
        #endregion

        #region Update
        public IActionResult Update(int id)
        {
            var category = _categoryService.GetById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Update(UpsertCategoryViewModel model)
        {
            _categoryService.Update(model);
            return Ok();
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok();
        }

        #endregion 
        #endregion

    }
}
