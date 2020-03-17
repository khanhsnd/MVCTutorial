using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repositories.Interface
{
  public  interface IProductsRepository
  {
      List<Product> Products_Search();
  }
}
