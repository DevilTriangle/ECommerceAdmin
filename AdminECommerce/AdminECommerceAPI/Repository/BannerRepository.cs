using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public class BannerRepository : BaseRepository<Banner>
    {
        public BannerRepository(MStoreContext dataContext) : base(dataContext)
        {
        }
    }
}