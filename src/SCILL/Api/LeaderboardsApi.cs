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
    public interface ILeaderboardsApi : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// Retrieve Leaderboard
        /// </summary>
        /// <remarks>
        /// Provides the current leaderboard rankings for a specific leaderboard.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leaderboardId">The id of the leaderboard</param>
        /// <param name="currentPage">The page index starting at 1. The number of pageSize elements are returned for each page. Default value is 1 (optional)</param>
        /// <param name="pageSize">The number of elements per page. Default is 25. (optional)</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of Leaderboard</returns>
        IPromise<Leaderboard> GetLeaderboardAsync(string leaderboardId, int? currentPage = null, int? pageSize = null,
            string language = null);

        /// <summary>
        /// Retrieve Leaderboard
        /// </summary>
        /// <remarks>
        /// Provides the current leaderboard rankings for a specific leaderboard.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leaderboardId">The id of the leaderboard</param>
        /// <param name="currentPage">The page index starting at 1. The number of pageSize elements are returned for each page. Default value is 1 (optional)</param>
        /// <param name="pageSize">The number of elements per page. Default is 25. (optional)</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of ApiResponse (Leaderboard)</returns>
        IPromise<ApiResponse<Leaderboard>> GetLeaderboardAsyncWithHttpInfo(string leaderboardId,
            int? currentPage = null, int? pageSize = null, string language = null);

        /// <summary>
        /// Retrieve User Ranking
        /// </summary>
        /// <remarks>
        /// Returns a LeaderboardMemberRanking item for the specified leaderboard. Use this route to get the position of a user of team in a specified leaderboard.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberType">The member type, can be user or team (right now) and sets which leaderboards should be selected.</param>
        /// <param name="memberId">Either the user_id or team_id you used when sending the events. The memberType flag identifies which one is used.</param>
        /// <param name="leaderboardId">The id of the leaderboard</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of LeaderboardMemberRanking</returns>
        IPromise<LeaderboardMemberRanking> GetLeaderboardRankingAsync(string memberType, string memberId,
            string leaderboardId, string language = null);

        /// <summary>
        /// Retrieve User Ranking
        /// </summary>
        /// <remarks>
        /// Returns a LeaderboardMemberRanking item for the specified leaderboard. Use this route to get the position of a user of team in a specified leaderboard.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberType">The member type, can be user or team (right now) and sets which leaderboards should be selected.</param>
        /// <param name="memberId">Either the user_id or team_id you used when sending the events. The memberType flag identifies which one is used.</param>
        /// <param name="leaderboardId">The id of the leaderboard</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of ApiResponse (LeaderboardMemberRanking)</returns>
        IPromise<ApiResponse<LeaderboardMemberRanking>> GetLeaderboardRankingAsyncWithHttpInfo(string memberType,
            string memberId, string leaderboardId, string language = null);

        /// <summary>
        /// Retrieve User Rankings
        /// </summary>
        /// <remarks>
        /// Returns an array of LeaderboardRanking items defined for all leaderboards in the application specified for the user.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberType">The member type, can be user or team (right now) and sets which leaderboards should be selected.</param>
        /// <param name="memberId">Either the user_id or team_id you used when sending the events. The memberType flag identifies which one is used.</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of List&lt;LeaderboardMemberRanking&gt;</returns>
        IPromise<List<LeaderboardMemberRanking>> GetLeaderboardRankingsAsync(string memberType, string memberId,
            string language = null);

        /// <summary>
        /// Retrieve User Rankings
        /// </summary>
        /// <remarks>
        /// Returns an array of LeaderboardRanking items defined for all leaderboards in the application specified for the user.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberType">The member type, can be user or team (right now) and sets which leaderboards should be selected.</param>
        /// <param name="memberId">Either the user_id or team_id you used when sending the events. The memberType flag identifies which one is used.</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of ApiResponse (List&lt;LeaderboardMemberRanking&gt;)</returns>
        IPromise<ApiResponse<List<LeaderboardMemberRanking>>> GetLeaderboardRankingsAsyncWithHttpInfo(string memberType,
            string memberId, string language = null);

        /// <summary>
        /// Retrieve Leaderboards
        /// </summary>
        /// <remarks>
        /// Returns an array of Leaderboard items defined for the application.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentPage">The page index starting at 1. The number of pageSize elements are returned for each page. Default value is 1 (optional)</param>
        /// <param name="pageSize">The number of elements per page. Default is 25. (optional)</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of List&lt;Leaderboard&gt;</returns>
        IPromise<List<Leaderboard>> GetLeaderboardsAsync(int? currentPage = null, int? pageSize = null,
            string language = null);

        /// <summary>
        /// Retrieve Leaderboards
        /// </summary>
        /// <remarks>
        /// Returns an array of Leaderboard items defined for the application.
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentPage">The page index starting at 1. The number of pageSize elements are returned for each page. Default value is 1 (optional)</param>
        /// <param name="pageSize">The number of elements per page. Default is 25. (optional)</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of ApiResponse (List&lt;Leaderboard&gt;)</returns>
        IPromise<ApiResponse<List<Leaderboard>>> GetLeaderboardsAsyncWithHttpInfo(int? currentPage = null,
            int? pageSize = null, string language = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LeaderboardsApi : ILeaderboardsApi
    {
        private SCILL.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LeaderboardsApi(String basePath)
        {
            this.Configuration = new SCILL.Client.Configuration {BasePath = basePath};

            ExceptionFactory = SCILL.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardsApi"/> class
        /// </summary>
        /// <returns></returns>
        public LeaderboardsApi()
        {
            this.Configuration = SCILL.Client.Configuration.Default;

            ExceptionFactory = SCILL.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeaderboardsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LeaderboardsApi(SCILL.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = SCILL.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = SCILL.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
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
            "SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Retrieve Leaderboard Provides the current leaderboard rankings for a specific leaderboard.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leaderboardId">The id of the leaderboard</param>
        /// <param name="currentPage">The page index starting at 1. The number of pageSize elements are returned for each page. Default value is 1 (optional)</param>
        /// <param name="pageSize">The number of elements per page. Default is 25. (optional)</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of Leaderboard</returns>
        public IPromise<Leaderboard> GetLeaderboardAsync(string leaderboardId, int? currentPage = null,
            int? pageSize = null, string language = null)
        {
            return GetLeaderboardAsyncWithHttpInfo(leaderboardId, currentPage, pageSize, language)
                .ExtractResponseData();
        }

        /// <summary>
        /// Retrieve Leaderboard Provides the current leaderboard rankings for a specific leaderboard.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="leaderboardId">The id of the leaderboard</param>
        /// <param name="currentPage">The page index starting at 1. The number of pageSize elements are returned for each page. Default value is 1 (optional)</param>
        /// <param name="pageSize">The number of elements per page. Default is 25. (optional)</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of ApiResponse (Leaderboard)</returns>
        public IPromise<ApiResponse<Leaderboard>> GetLeaderboardAsyncWithHttpInfo(string leaderboardId,
            int? currentPage = null, int? pageSize = null, string language = null)
        {
            // verify the required parameter 'leaderboardId' is set
            if (leaderboardId == null)
                throw new ApiException(400,
                    "Missing required parameter 'leaderboardId' when calling LeaderboardsApi->GetLeaderboard");

            var localVarPath = $"/api/v1/leaderboards/{leaderboardId}";
            HttpMethod method = HttpMethod.Get;
            object body = null;

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, localVarPath, method);

            if (currentPage != null)
                request.QueryParams.AddRange(
                    this.Configuration.ApiClient.ParameterToKeyValuePairs("", "currentPage",
                        currentPage)); // query parameter
            if (pageSize != null)
                request.QueryParams.AddRange(
                    this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize)); // query parameter


            var responsePromise = Configuration.ApiClient.CallApi<Leaderboard>(request);
            return responsePromise;
        }

        /// <summary>
        /// Retrieve User Ranking Returns a LeaderboardMemberRanking item for the specified leaderboard. Use this route to get the position of a user of team in a specified leaderboard.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberType">The member type, can be user or team (right now) and sets which leaderboards should be selected.</param>
        /// <param name="memberId">Either the user_id or team_id you used when sending the events. The memberType flag identifies which one is used.</param>
        /// <param name="leaderboardId">The id of the leaderboard</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of LeaderboardMemberRanking</returns>
        public IPromise<LeaderboardMemberRanking> GetLeaderboardRankingAsync(string memberType, string memberId,
            string leaderboardId, string language = null)
        {
            return GetLeaderboardRankingAsyncWithHttpInfo(memberType, memberId, leaderboardId, language)
                .ExtractResponseData();
        }

        /// <summary>
        /// Retrieve User Ranking Returns a LeaderboardMemberRanking item for the specified leaderboard. Use this route to get the position of a user of team in a specified leaderboard.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberType">The member type, can be user or team (right now) and sets which leaderboards should be selected.</param>
        /// <param name="memberId">Either the user_id or team_id you used when sending the events. The memberType flag identifies which one is used.</param>
        /// <param name="leaderboardId">The id of the leaderboard</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of ApiResponse (LeaderboardMemberRanking)</returns>
        public IPromise<ApiResponse<LeaderboardMemberRanking>> GetLeaderboardRankingAsyncWithHttpInfo(string memberType,
            string memberId, string leaderboardId, string language = null)
        {
            // verify the required parameter 'memberType' is set
            if (memberType == null)
                throw new ApiException(400,
                    "Missing required parameter 'memberType' when calling LeaderboardsApi->GetLeaderboardRanking");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400,
                    "Missing required parameter 'memberId' when calling LeaderboardsApi->GetLeaderboardRanking");
            // verify the required parameter 'leaderboardId' is set
            if (leaderboardId == null)
                throw new ApiException(400,
                    "Missing required parameter 'leaderboardId' when calling LeaderboardsApi->GetLeaderboardRanking");

            var localVarPath = $"/api/v1/leaderboards-members/{memberType}/{memberId}/{leaderboardId}";

            HttpMethod method = HttpMethod.Get;
            object body = null;

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, localVarPath, method);
            var responsePromise = Configuration.ApiClient.CallApi<LeaderboardMemberRanking>(request);
            return responsePromise;
        }


        /// <summary>
        /// Retrieve User Rankings Returns an array of LeaderboardRanking items defined for all leaderboards in the application specified for the user.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberType">The member type, can be user or team (right now) and sets which leaderboards should be selected.</param>
        /// <param name="memberId">Either the user_id or team_id you used when sending the events. The memberType flag identifies which one is used.</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of List&lt;LeaderboardMemberRanking&gt;</returns>
        public IPromise<List<LeaderboardMemberRanking>> GetLeaderboardRankingsAsync(string memberType, string memberId,
            string language = null)
        {
            return GetLeaderboardRankingsAsyncWithHttpInfo(memberType, memberId, language).ExtractResponseData();
        }

        /// <summary>
        /// Retrieve User Rankings Returns an array of LeaderboardRanking items defined for all leaderboards in the application specified for the user.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberType">The member type, can be user or team (right now) and sets which leaderboards should be selected.</param>
        /// <param name="memberId">Either the user_id or team_id you used when sending the events. The memberType flag identifies which one is used.</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of ApiResponse (List&lt;LeaderboardMemberRanking&gt;)</returns>
        public IPromise<ApiResponse<List<LeaderboardMemberRanking>>> GetLeaderboardRankingsAsyncWithHttpInfo(
            string memberType, string memberId, string language = null)
        {
            // verify the required parameter 'memberType' is set
            if (memberType == null)
                throw new ApiException(400,
                    "Missing required parameter 'memberType' when calling LeaderboardsApi->GetLeaderboardRankings");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400,
                    "Missing required parameter 'memberId' when calling LeaderboardsApi->GetLeaderboardRankings");

            var localVarPath = $"/api/v1/leaderboards-members/{memberType}/{memberId}";
            HttpMethod method = HttpMethod.Get;
            object body = null;

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, localVarPath, method);
            var responsePromise = Configuration.ApiClient.CallApi<List<LeaderboardMemberRanking>>(request);
            return responsePromise;
        }


        /// <summary>
        /// Retrieve Leaderboards Returns an array of Leaderboard items defined for the application.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentPage">The page index starting at 1. The number of pageSize elements are returned for each page. Default value is 1 (optional)</param>
        /// <param name="pageSize">The number of elements per page. Default is 25. (optional)</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of List&lt;Leaderboard&gt;</returns>
        public IPromise<List<Leaderboard>> GetLeaderboardsAsync(int? currentPage = null, int? pageSize = null,
            string language = null)
        {
            return GetLeaderboardsAsyncWithHttpInfo(currentPage, pageSize, language).ExtractResponseData();
        }

        /// <summary>
        /// Retrieve Leaderboards Returns an array of Leaderboard items defined for the application.
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="currentPage">The page index starting at 1. The number of pageSize elements are returned for each page. Default value is 1 (optional)</param>
        /// <param name="pageSize">The number of elements per page. Default is 25. (optional)</param>
        /// <param name="language">Set the language. Content can be translated in the Admin Panel. Values can be international language codes like de, en, fr, it, ... (optional)</param>
        /// <returns>Promise of ApiResponse (List&lt;Leaderboard&gt;)</returns>
        public IPromise<ApiResponse<List<Leaderboard>>> GetLeaderboardsAsyncWithHttpInfo(int? currentPage = null,
            int? pageSize = null, string language = null)
        {
            var localVarPath = "/api/v1/leaderboards";

            HttpMethod method = HttpMethod.Get;
            object body = null;

            ApiRequest request =
                Configuration.ApiClient.CreateBaseApiRequest(body, localVarPath, method);

            if (currentPage != null)
                request.QueryParams.AddRange(
                    this.Configuration.ApiClient.ParameterToKeyValuePairs("", "currentPage",
                        currentPage)); // query parameter
            if (pageSize != null)
                request.QueryParams.AddRange(
                    this.Configuration.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize)); // query parameter

            var responsePromise = Configuration.ApiClient.CallApi<List<Leaderboard>>(request);
            return responsePromise;
        }
    }
}