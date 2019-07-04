using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {

            Mapper.Initialize(x =>
            {
                x.CreateMap<InSimularAcordo, WebApplication3.IndadosAcordo>();
            });
        }
    }
}