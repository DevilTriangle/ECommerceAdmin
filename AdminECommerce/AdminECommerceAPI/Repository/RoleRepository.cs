using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(MStoreContext dataContext) : base(dataContext)
        {
        }
    }
}