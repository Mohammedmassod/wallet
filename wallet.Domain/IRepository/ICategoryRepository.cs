using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities.Category;

namespace wallet.Domain.IRepository
{
    public interface ICategoryRepository
    {
        Category GetById(int categoryId);
        IEnumerable<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
    }
}
