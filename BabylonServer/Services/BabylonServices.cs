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
        public static void ADDBabylonServices(this IServiceCollection services)
        {
            services.ADDBabylonFactory();

        }
    }

}
