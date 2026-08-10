using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Respositary.IRepositary;
using Bulky.Models;

namespace Bulky.DataAccess.Respositary
{
    public class CategoryRepositary : Repositary<Category>, ICategoryRepositary
    {
        private ApplicationDbContext _db;
        public CategoryRepositary(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
