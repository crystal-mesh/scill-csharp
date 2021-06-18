using System;
using RSG;
using SCILL.Api;
using SCILL.Client;
using SCILL.Model;


namespace SCILL
{
    public class SCILLBackend
    {
        public string ApiKey => _config.ApiKey[this.ToString()];

        public AuthApi AuthApi { get; }

        public EventsApi EventsApi { get; }

        private static Configuration _config;

        public SCILLBackend(string apiKey, Environment environment = Environment.Production)
        {
            string hostSuffix = "";
            if (environment == Environment.Staging)
            {
                hostSuffix = "-staging";
            }
            else if (environment == Environment.Development)
            {
                hostSuffix = "-dev";
            }

            _config = Configuration.Default.Clone(string.Empty, Configuration.Default.BasePath);
            _config.AddApiKey("auth", "api_key");


            // EventsApi = GetApi<EventsApi>(apiKey, "https://ep" + hostSuffix + ".scillgame.com");
            // AuthApi = GetApi<AuthApi>(apiKey, "https://us" + hostSuffix + ".scillgame.com");
            string authBasePath = "https://us" + hostSuffix + ".scillgame.com";
            AuthApi = new AuthApi(_config.Clone(apiKey, authBasePath));

            string eventsBasePath = "https://ep" + hostSuffix + ".scillgame.com";
            EventsApi = new EventsApi(_config.Clone(apiKey, eventsBasePath));

            // On backend side, the event parser is set to use the api key to authenticate the request
        }


        private T GetApi<T>(string token, string basePath) where T : IApiAccessor
        {
            return (T) Activator.CreateInstance(typeof(T), new object[] {_config.Clone(token, basePath)});
        }

        public void GetAccessTokenAsync(string userId, Action<string> callback)
        {
            GetAccessTokenAsync(userId).Then(callback);
        }

        public IPromise<string> GetAccessTokenAsync(string userId)
        {
            return GetAccessTokenAsync(new ForeignUserIdentifier(userId));
        }

        private IPromise<string> GetAccessTokenAsync(ForeignUserIdentifier foreignUser)
        {
            if (string.IsNullOrEmpty(_config.AccessToken) == false)
                return Promise<string>.Resolved(_config.AccessToken);

            var tokenPromise = AuthApi.GenerateAccessTokenAsync(foreignUser);

            Promise<string> stringTokenPromise = new Promise<string>((resolve, reject) =>
            {
                tokenPromise.Then(accesToken => resolve(accesToken.token))
                    .Catch(reject);
            });


            return stringTokenPromise;
        }
    }
}