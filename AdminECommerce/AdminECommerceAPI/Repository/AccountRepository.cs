using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public class AccountRepository : BaseRepository<Account>
    {
        public AccountRepository(MStoreContext dataContext) : base(dataContext)
        {
        }
    }
}