using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bulky.Models;

namespace Bulky.DataAccess.Respositary.IRepositary
{
    public interface IProductRepositary : IRepositary<Product>
    {
        void Update(Product obj);
    }
}
