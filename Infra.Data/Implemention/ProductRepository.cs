using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Implemention
{
    public class ProductRepository : IProductRepository
    {
        public StoreContext _context { get; set; }
        public ProductRepository()
        {

        }
        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public void Insert(Product model)
        {
            _context.Add(model);
            _context.SaveChanges();
        }

        public void Update(Product model)
        {
            _context.Update(model);
            _context.SaveChanges();
        }
    }
}
