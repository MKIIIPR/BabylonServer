using AshesMapBib.Models;
using Blazored.LocalStorage;
using FrontUI.AppStates;
using FrontUI.AuthenticationServices;
using FrontUI.FtpService;
using FrontUI.Helper.MapHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using Newtonsoft.Json;
using PWAPortal.Authentication;
using Services;
using Services.AccountServices;
using Services.AccountServices.ClientServices.Api;
using Services.AccountServices.ClientServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FrontUI
{
    public static class ServicesConfiguration
    {
        public static void ADDFrontUIServices(this IServiceCollection services)
        {
            // Umgebung bestimmen (hier auch anpassbar)

            // Weitere Services
            services.ADDBabylonServices();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            services.AddAuthorizationCore();

            services.AddSingleton<IAPIHelper, APIHelper>();
            services.AddSingleton<ILoggedInAccount, LoggedInAccount>();
            services.AddSingleton<ILoggedInUserModel, LoggedInUserModel>();
            services.AddTransient<IUserEndpoint, UserEndpoint>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IProfileEndpoint, ProfileEndpoint>();
            services.AddSingleton<CascadingAppStateProvider>();
            services.AddBlazoredLocalStorage();
            services.AddMudServices();
            services.AddScoped<MapHandler>();
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://your-api-url.com") });
            services.AddScoped<FTPConnection>();

            // API Clients
            services.AddScoped<ResourceApiClient<Node>>(sp =>
                new ResourceApiClient<Node>(
                    sp.GetRequiredService<HttpClient>(),
                    sp.GetRequiredService<ILogger<ResourceApiClient<Node>>>()
                )
            );

            services.AddScoped<ResourceApiClient<NodePosition>>(sp =>
                new ResourceApiClient<NodePosition>(
                    sp.GetRequiredService<HttpClient>(),
                    sp.GetRequiredService<ILogger<ResourceApiClient<NodePosition>>>()
                )
            );
        }
    }


}
