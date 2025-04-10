using ADataAcces.Mapping;
using HashidsNet;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServicesConfiguration
    {
        public static void ADDBabylonFactory(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DataMap));
            services.AddSingleton<IHashids>(_ => new Hashids("ArschKeksGesicht", 6));


        }
    }

}
