using AdminECommerceAPI.ViewModel;
using AdminECommerceModel.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI.Repository
{
    public interface ICategoryRepository
    {
    }

    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MStoreContext dataContext) : base(dataContext)
        {
        }

       
    }
}