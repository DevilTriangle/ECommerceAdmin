using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public class PromotionRepository : BaseRepository<Promotion>
    {
        public PromotionRepository(MStoreContext dataContext) : base(dataContext)
        {
        }
    }
}