using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public int Code { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public bool IsPublished { get; set; }
        public string Description { get; set; }
    }
}
