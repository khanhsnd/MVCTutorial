using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repositories.Interface;

namespace Repositories
{
   public class ProductsRepository :IProductsRepository
    {
        private DataContext _dataContext = null;
        public  ProductsRepository()
        {
            _dataContext = new DataContext();
        }

        public List<Product> Products_Search()
        {
            var query = _dataContext.Database.SqlQuery<Product>("Products_Search").ToList();
            return query;
        }
    }
}
