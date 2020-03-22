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
    public class AccountRepository : IAccountRepository
    {
        private DataContext _dataContext = null;

        public AccountRepository ()
        {
            _dataContext = new DataContext();
        }
        public bool Login(string username, string password)
        {
            
            var param = new[] {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password)
            };
            var res = _dataContext.Database.SqlQuery<bool>("Accounts_Login @username, @password", param).SingleOrDefault();
            return res;
        }
    }
}
