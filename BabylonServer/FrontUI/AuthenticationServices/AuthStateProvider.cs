using Blazored.LocalStorage;
using FrontUI.AppStates;
using FrontUI.AuthenticationServices;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using Services.AccountServices.ClientServices.Api;
using Services.AccountServices.ClientServices.Models;
using System.Security.Claims;
using System.Threading.Tasks;


namespace PWAPortal.Authentication
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private readonly IAPIHelper _apiHelper;
        private readonly ILocalStorageService _localStorage;
        private readonly IConfiguration _config;
        private readonly CascadingAppStateProvider _appState;
        private readonly ILoggedInAccount _userClient;
        private readonly AuthenticationState _anonymous;
        private readonly IClientService _clientService;

        public AuthStateProvider(    HttpClient httpClient,
                                     IAPIHelper IhttpClient,
                                     IClientService clientService,
                                     ILocalStorageService localStorage,
                                     IConfiguration config,
                                     CascadingAppStateProvider appState,
                                     ILoggedInAccount userClient)
        {
            _clientService = clientService;
            _httpClient = httpClient;
            _apiHelper = IhttpClient;
            _localStorage = localStorage;
            _config = config;
            _appState = appState;
            _userClient = userClient;
            _anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string authTokenStorageKey = _config["authTokenStorageKey"];
            var token = await _localStorage.GetItemAsync<string>(authTokenStorageKey);

            if (string.IsNullOrWhiteSpace(token))
            {
                return _anonymous;
            }

           // _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            _apiHelper.GetLoggedInUserInfo(token);
           // var x = await _clientService.ClientCall();
           //_userClient.SetClient(x);
            //var savedMainProfile = x.Profiles.Where(e => e.IsMainProfile == true).FirstOrDefault();
            
            //    State.UserState.SetActiveProfile(this, savedMainProfile);
            //State.UserState.GetClientProfile(this, x);
            return new AuthenticationState(
                new ClaimsPrincipal(
                    new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token),
                    "jwtAuthType")));
        }

        public void NotifyUserAuthentication(string token)
        {
            var authenticatedUser = new ClaimsPrincipal(
                    new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token),
                    "jwtAuthType"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public void NotifyUserLogout()
        {
            var authState = Task.FromResult(_anonymous);
            NotifyAuthenticationStateChanged(authState);
        }
    }
}
