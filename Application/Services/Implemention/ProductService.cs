using Application.Services.Interface;
using Application.ViewModel.Product;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implemention
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository { get; set; }
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(CreateProductViewModel model)
        {
            Product product = new Product();
            product.Title = model.Title;
            product.Description = model.Description;
            product.IsPublished = model.IsPublished;
            product.Code = model.Code;
            product.Count = model.Count;
            product.CategoryId = model.CategoryId;

            _productRepository.Insert(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepository.GetAll().Select(p => new ProductViewModel
            {
                Title = p.Title,
                Description = p.Description,
                IsPublished = p.IsPublished,
                CategoryId = p.CategoryId,
                Count = p.Count,
                Code = p.Code,
                ImageName = p.ImageName,
                Price = p.Price,
            }).ToList();
        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetById(id);

            return new ProductViewModel
            {
                Title = product.Title,
                Description = product.Description,
                IsPublished = product.IsPublished,
                CategoryId = product.CategoryId,
                Count = product.Count,
                Code = product.Code,
                ImageName = product.ImageName,
                Price = product.Price,

            };
        }

        public void Update(UpdateProductViewModel model)
        {
            var product = _productRepository.GetById(model.Id);
            product.Title = model.Title;
            product.Description = model.Description;
            product.IsPublished = model.IsPublished;
            product.Code = model.Code;
            product.Count = model.Count;
            product.CategoryId = model.CategoryId;

            _productRepository.Update(product);
        }
    }
}
