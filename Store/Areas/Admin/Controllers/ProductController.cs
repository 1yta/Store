using Application.Services.Interface;
using Application.ViewModel.Product;
using Microsoft.AspNetCore.Mvc;

namespace Store.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        #region Properties
        public IProductService _productService { get; set; } 
        #endregion

        #region Ctor
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion

        #region Actions

        #region Get
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            return View();
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductViewModel model)
        {
            _productService.Create(model);
            return Ok();
        }
        #endregion

        #region Update
        public IActionResult Update(int id)
        {
            var product = _productService.GetById(id);
            return View(product);
        }

        public IActionResult Update(UpdateProductViewModel model)
        {
            _productService.Update(model);
            return Ok();
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return Ok();
        }

        #endregion 

        #endregion
    }
}
