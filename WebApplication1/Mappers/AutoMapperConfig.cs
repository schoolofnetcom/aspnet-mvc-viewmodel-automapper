using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ModelToViewModelProfile>();
                x.AddProfile<ViewModelToModelProfile>();
            });
        }
    }
}