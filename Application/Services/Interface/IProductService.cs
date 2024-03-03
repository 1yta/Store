using Application.ViewModel.Product;

namespace Application.Services.Interface
{
    public interface IProductService
    {
        List<ProductViewModel> GetAll();
        ProductViewModel GetById(int id);
        void Create(CreateProductViewModel model);
        void Update(UpdateProductViewModel model);
        void Delete(int id);
    }
}
