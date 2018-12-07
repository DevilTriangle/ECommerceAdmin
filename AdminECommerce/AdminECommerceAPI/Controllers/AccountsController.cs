using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AdminECommerceAPI.Repository;
using AdminECommerceModel.Models;

namespace AdminECommerceAPI.Controllers
{
    public class AccountsController : ApiController
    {
        private MStoreContext db = new MStoreContext();

        private AccountRepository accountRepository;
        public AccountsController()
        {
            accountRepository = new AccountRepository(db);
        }

    }
}