using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Respositary.IRepositary;

namespace Bulky.DataAccess.Respositary
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepositary Category { get; set; }
        public IProductRepositary Product { get; set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category= new CategoryRepositary(_db);
            Product = new ProductRepositary(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
