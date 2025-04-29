using Microsoft.Extensions.DependencyInjection;
using Services.AccountServices.ClientServices.Api;
using Services.GameDataServices;
using Services.MarketPlaceServcies;
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

            services.AddSingleton(typeof(MarketContext<>));
            services.AddSingleton<IAPIHelper, APIHelper>();
            services.AddSingleton<InGameItemApiClient>();
            services.AddSingleton<IMarketService, MarketService>();
            services.AddSingleton(typeof(InGameItemContext<>));

            services.ADDBabylonFactory();

        }
    }

}
