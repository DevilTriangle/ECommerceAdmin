using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public class ContactRepository : BaseRepository<Contact>
    {
        public ContactRepository(MStoreContext dataContext) : base(dataContext)
        {
        }
    }
}