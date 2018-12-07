using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminECommerceAPI
{
    public class AutoMapperConfig
    {
        public static void Config()
        {
            Mapper.Initialize(cf =>
            {
                
            });
        }
    }
}