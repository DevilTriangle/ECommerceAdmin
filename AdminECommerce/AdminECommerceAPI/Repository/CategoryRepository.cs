using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(MStoreContext dataContext) : base(dataContext)
        {
        }
    }
}