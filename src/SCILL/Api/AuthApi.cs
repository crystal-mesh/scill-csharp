/* 
 * SCILL API
 *
 * SCILL gives you the tools to activate, retain and grow your user base in your app or game by bringing you features well known in the gaming industry: Gamification. We take care of the services and technology involved so you can focus on your game and content.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@scillgame.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using RSG;
using SCILL.Client;
using SCILL.Model;

namespace SCILL.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthApi : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// Get an access token for any user identifier signed with the API-Key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Foreign user identifier.</param>
        /// <returns>Task of AccessToken</returns>
        IPromise<AccessToken> GenerateAccessTokenAsync(ForeignUserIdentifier body);

        /// <summary>
        /// Get an access token for any user identifier signed with the API-Key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Foreign user identifier.</param>
        /// <returns>Task of ApiResponse (AccessToken)</returns>
        IPromise<ApiResponse<AccessToken>> GenerateAccessTokenAsyncWithHttpInfo(
            ForeignUserIdentifier body);

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever a battle pass or challenges and levels within the battle pass change
        /// </summary>
        /// <remarks>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever a battle pass changes.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="battlePassId">The battle pass you want to get notified</param>
        /// <returns>Task of NotificationTopic</returns>
        IPromise<NotificationTopic> GetUserBattlePassNotificationTopicAsync(string battlePassId);

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever a battle pass or challenges and levels within the battle pass change
        /// </summary>
        /// <remarks>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever a battle pass changes.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="battlePassId">The battle pass you want to get notified</param>
        /// <returns>Task of ApiResponse (NotificationTopic)</returns>
        IPromise<ApiResponse<NotificationTopic>> GetUserBattlePassNotificationTopicAsyncWithHttpInfo(
            string battlePassId);

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever the specified challenge changes.
        /// </summary>
        /// <remarks>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever the challenge changes.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="challengeId">The challenge id you want to get notified</param>
        /// <returns>Task of NotificationTopic</returns>
        IPromise<NotificationTopic> GetUserChallengeNotificationTopicAsync(string challengeId);

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever the specified challenge changes.
        /// </summary>
        /// <remarks>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever the challenge changes.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="challengeId">The challenge id you want to get notified</param>
        /// <returns>Task of ApiResponse (NotificationTopic)</returns>
        IPromise<ApiResponse<NotificationTopic>> GetUserChallengeNotificationTopicAsyncWithHttpInfo(
            string challengeId);

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever challenges for the user provided by the access token changes.
        /// </summary>
        /// <remarks>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever challenges for the user provided by the access token change.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of NotificationTopic</returns>
        IPromise<NotificationTopic> GetUserChallengesNotificationTopicAsync();

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever challenges for the user provided by the access token changes.
        /// </summary>
        /// <remarks>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever challenges for the user provided by the access token change.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (NotificationTopic)</returns>
        IPromise<ApiResponse<NotificationTopic>>
            GetUserChallengesNotificationTopicAsyncWithHttpInfo();

        /// <summary>
        /// Get additional info stored per user
        /// </summary>
        /// <remarks>
        /// Returns additional info object with usernames and avatar image for a user which is used in the leaderboard system
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserInfo</returns>
        IPromise<UserInfo> GetUserInfoAsync();

        /// <summary>
        /// Get additional info stored per user
        /// </summary>
        /// <remarks>
        /// Returns additional info object with usernames and avatar image for a user which is used in the leaderboard system
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserInfo)</returns>
        IPromise<ApiResponse<UserInfo>> GetUserInfoAsyncWithHttpInfo();

        /// <summary>
        /// Set additional info stored per user
        /// </summary>
        /// <remarks>
        /// Sets user info like username and avatar image which is returned as part of the user rankings in leaderboards.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UserInfo object stored in the SCILL database for the user</param>
        /// <returns>Task of UserInfo</returns>
        IPromise<UserInfo> SetUserInfoAsync(UserInfo body);

        /// <summary>
        /// Set additional info stored per user
        /// </summary>
        /// <remarks>
        /// Sets user info like username and avatar image which is returned as part of the user rankings in leaderboards.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UserInfo object stored in the SCILL database for the user</param>
        /// <returns>Task of ApiResponse (UserInfo)</returns>
        IPromise<ApiResponse<UserInfo>> SetUserInfoAsyncWithHttpInfo(UserInfo body);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthApi : IAuthApi
    {
        private SCILL.Client.ExceptionFactory _exceptionFactory = (name, response) => null;


        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// </summary>
        /// <returns></returns>
        public AuthApi() : this(SCILL.Client.Configuration.Default)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi(String basePath) : this(new SCILL.Client.Configuration {BasePath = basePath})
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthApi(SCILL.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = SCILL.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = SCILL.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the Configuration.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete(
            "SetBasePath is deprecated, please do 'Configuration.BasePath = \"http://new-path\" instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SCILL.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SCILL.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }

                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get an access token for any user identifier signed with the API-Key 
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Foreign user identifier.</param>
        /// <returns>Task of AccessToken</returns>
        public IPromise<AccessToken> GenerateAccessTokenAsync(ForeignUserIdentifier body)
        {
            return GenerateAccessTokenAsyncWithHttpInfo(body).ExtractResponseData();
        }

        /// <summary>
        /// Get an access token for any user identifier signed with the API-Key 
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Foreign user identifier.</param>
        /// <returns>Task of ApiResponse (AccessToken)</returns>
        public IPromise<ApiResponse<AccessToken>> GenerateAccessTokenAsyncWithHttpInfo(
            ForeignUserIdentifier body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400,
                    "Missing required parameter 'body' when calling AuthApi->GenerateAccessToken");

            string path = "/api/v1/auth/access-token";

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, path, HttpMethod.Post);

            var responsePromise = Configuration.ApiClient.CallApi<AccessToken>(request);
            return responsePromise;
        }


        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever a battle pass or challenges and levels within the battle pass change Get a topic to be used with an MQTT client to receive real time updates whenever a battle pass changes.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="battlePassId">The battle pass you want to get notified</param>
        /// <returns></returns>
        public IPromise<NotificationTopic> GetUserBattlePassNotificationTopicAsync(
            string battlePassId)
        {
            return GetUserBattlePassNotificationTopicAsyncWithHttpInfo(battlePassId).ExtractResponseData();
        }

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever a battle pass or challenges and levels within the battle pass change Get a topic to be used with an MQTT client to receive real time updates whenever a battle pass changes.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="battlePassId">The battle pass you want to get notified</param>
        /// <returns>Task of ApiResponse (NotificationTopic)</returns>
        public IPromise<ApiResponse<NotificationTopic>>
            GetUserBattlePassNotificationTopicAsyncWithHttpInfo(string battlePassId)
        {
            // verify the required parameter 'battlePassId' is set
            if (battlePassId == null)
                throw new ApiException(400,
                    "Missing required parameter 'battlePassId' when calling AuthApi->GetUserBattlePassNotificationTopic");

            var localVarPath = "/api/v1/auth/user-battle-pass-topic-link";
            HttpMethod method = HttpMethod.Get;
            object body = null;

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, localVarPath, method);
            
            request.QueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "battle_pass_id", battlePassId));

            var responsePromise = Configuration.ApiClient.CallApi<NotificationTopic>(request);
            return responsePromise;
        }

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever the specified challenge changes. Get a topic to be used with an MQTT client to receive real time updates whenever the challenge changes.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="challengeId">The challenge id you want to get notified</param>
        /// <returns>Task of NotificationTopic</returns>
        public IPromise<NotificationTopic> GetUserChallengeNotificationTopicAsync(
            string challengeId)
        {
            return GetUserChallengeNotificationTopicAsyncWithHttpInfo(challengeId).ExtractResponseData();
        }

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever the specified challenge changes. Get a topic to be used with an MQTT client to receive real time updates whenever the challenge changes.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="challengeId">The challenge id you want to get notified</param>
        /// <returns>Task of ApiResponse (NotificationTopic)</returns>
        public IPromise<ApiResponse<NotificationTopic>>
            GetUserChallengeNotificationTopicAsyncWithHttpInfo(string challengeId)
        {
            // verify the required parameter 'challengeId' is set
            if (challengeId == null)
                throw new ApiException(400,
                    "Missing required parameter 'challengeId' when calling AuthApi->GetUserChallengeNotificationTopic");

            var localVarPath = "/api/v1/auth/user-challenge-topic-link";

            HttpMethod method = HttpMethod.Get;
            object body = null;

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, localVarPath, method);


            request.QueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "challenge_id", challengeId));

            var responsePromise = Configuration.ApiClient.CallApi<NotificationTopic>(request);
            return responsePromise;
        }

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever challenges for the user provided by the access token changes. Get a topic to be used with an MQTT client to receive real time updates whenever challenges for the user provided by the access token change.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of NotificationTopic</returns>
        public IPromise<NotificationTopic> GetUserChallengesNotificationTopicAsync()
        {
            return GetUserChallengesNotificationTopicAsyncWithHttpInfo().ExtractResponseData();
        }

        /// <summary>
        /// Get a topic to be used with an MQTT client to receive real time updates whenever challenges for the user provided by the access token changes. Get a topic to be used with an MQTT client to receive real time updates whenever challenges for the user provided by the access token change.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (NotificationTopic)</returns>
        public IPromise<ApiResponse<NotificationTopic>>
            GetUserChallengesNotificationTopicAsyncWithHttpInfo()
        {
            var localVarPath = "/api/v1/auth/user-challenges-topic-link";

            HttpMethod method = HttpMethod.Get;
            object body = null;

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, localVarPath, method);


            var responsePromise = Configuration.ApiClient.CallApi<NotificationTopic>(request);
            return responsePromise;
        }

        /// <summary>
        /// Get additional info stored per user Returns additional info object with usernames and avatar image for a user which is used in the leaderboard system
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserInfo</returns>
        public IPromise<UserInfo> GetUserInfoAsync()
        {
            return GetUserInfoAsyncWithHttpInfo().ExtractResponseData();
        }

        /// <summary>
        /// Get additional info stored per user Returns additional info object with usernames and avatar image for a user which is used in the leaderboard system
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserInfo)</returns>
        public IPromise<ApiResponse<UserInfo>> GetUserInfoAsyncWithHttpInfo()
        {
            var localVarPath = "/api/v1/user-additional-info";

            HttpMethod method = HttpMethod.Get;
            object body = null;

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, localVarPath, method);

            var responsePromise = Configuration.ApiClient.CallApi<UserInfo>(request);
            return responsePromise;
        }

        /// <summary>
        /// Set additional info stored per user Sets user info like username and avatar image which is returned as part of the user rankings in leaderboards.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UserInfo object stored in the SCILL database for the user</param>
        /// <returns>Task of UserInfo</returns>
        public IPromise<UserInfo> SetUserInfoAsync(UserInfo body)
        {
            return SetUserInfoAsyncWithHttpInfo(body).ExtractResponseData();
        }

        /// <summary>
        /// Set additional info stored per user Sets user info like username and avatar image which is returned as part of the user rankings in leaderboards.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">UserInfo object stored in the SCILL database for the user</param>
        /// <returns>Task of ApiResponse (UserInfo)</returns>
        public IPromise<ApiResponse<UserInfo>> SetUserInfoAsyncWithHttpInfo(UserInfo body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AuthApi->SetUserInfo");

            var localVarPath = "/api/v1/user-additional-info";
            HttpMethod method = HttpMethod.Put;

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, localVarPath, method);

            var responsePromise = Configuration.ApiClient.CallApi<UserInfo>(request);
            return responsePromise;
        }
    }
}