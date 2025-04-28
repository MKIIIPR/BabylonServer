using Microsoft.Extensions.DependencyInjection;
using Services.AccountServices;
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
    public static class BackEndServicesConfiguration
    {
        public static void ADDBackEndServices(this IServiceCollection services)
        {
            services.AddSingleton<IAPIHelper, APIHelper>();
            services.AddSingleton<ILoggedInUserModel, LoggedInUserModel>();
            services.AddSingleton<InGameItemApiClient>();
            services.AddSingleton<IMarketService, MarketService>();
            services.AddSingleton(typeof(InGameItemContext<>));

            services.ADDBabylonFactory();

        }
    }

}
