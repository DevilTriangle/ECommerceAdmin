using AdminECommerceWeb.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceWeb
{
    public class AutoMapperConfig
    {
        public static void Config()
        {
            Mapper.Initialize(cf =>
            {
                cf.AddProfile<EntityToViewModelProfile>();
                cf.AddProfile<ViewModelToEntityProfile>();
            });
                
        }
    }
}