using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Respositary.IRepositary
{
    public interface IUnitOfWork
    {
        ICategoryRepositary Category { get; }
        IProductRepositary Product { get; }


        void Save();
    }
}
