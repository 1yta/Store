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
    public class CategoryRepository : ICategoryRepository
    {
        private StoreContext _context { get; set; }
        public CategoryRepository(StoreContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Insert(Category model)
        {
            _context.Add(model);
            _context.SaveChanges();

        }

        public void Update(Category model)
        {
            _context.Update(model);
            _context.SaveChanges();
        }
    }
}
