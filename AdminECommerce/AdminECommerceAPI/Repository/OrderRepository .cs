using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(MStoreContext dataContext) : base(dataContext)
        {
        }
    }
}