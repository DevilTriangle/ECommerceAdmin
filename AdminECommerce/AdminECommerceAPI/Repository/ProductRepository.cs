using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(MStoreContext dataContext) : base(dataContext)
        {
        }
    }
}