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
        public interface IEventsApi : IApiAccessor
    {
     
        #region Asynchronous Operations
        /// <summary>
        /// Get all available events and required and optional properties
        /// </summary>
        /// <remarks>
        /// Get all available events and required and optional properties
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;EventDescription&gt;</returns>
        IPromise<List<EventDescription>> GetAvailableEventsAsync ();

        /// <summary>
        /// Get all available events and required and optional properties
        /// </summary>
        /// <remarks>
        /// Get all available events and required and optional properties
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;EventDescription&gt;)</returns>
        IPromise<ApiResponse<List<EventDescription>>> GetAvailableEventsAsyncWithHttpInfo ();
        /// <summary>
        /// Post an event
        /// </summary>
        /// <remarks>
        /// Post an event to the SCILL backend
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Event payload or team event payload</param>
        /// <returns>Task of ActionResponse</returns>
        IPromise<ActionResponse> SendEventAsync (EventPayload body);

        /// <summary>
        /// Post an event
        /// </summary>
        /// <remarks>
        /// Post an event to the SCILL backend
        /// </remarks>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Event payload or team event payload</param>
        /// <returns>Task of ApiResponse (ActionResponse)</returns>
        IPromise<ApiResponse<ActionResponse>> SendEventAsyncWithHttpInfo (EventPayload body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class EventsApi : IEventsApi
    {
        private SCILL.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi(String basePath)
        {
            this.Configuration = new SCILL.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SCILL.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// </summary>
        /// <returns></returns>
        public EventsApi()
        {
            this.Configuration = SCILL.Client.Configuration.Default;

            ExceptionFactory = SCILL.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventsApi(SCILL.Client.Configuration configuration = null)
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SCILL.Client.Configuration Configuration {get; set;}

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
        /// Get all available events and required and optional properties Get all available events and required and optional properties
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;EventDescription&gt;</returns>
        public IPromise<List<EventDescription>> GetAvailableEventsAsync ()
        {
             return GetAvailableEventsAsyncWithHttpInfo().ExtractResponseData();

        }

        /// <summary>
        /// Get all available events and required and optional properties Get all available events and required and optional properties
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;EventDescription&gt;)</returns>
        public IPromise<ApiResponse<List<EventDescription>>> GetAvailableEventsAsyncWithHttpInfo ()
        {

            // var localVarPath = "/api/v1/public/documentation";
            // var localVarPathParams = new Dictionary<String, String>();
            // var localVarQueryParams = new List<KeyValuePair<String, String>>();
            // var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            // var localVarFormParams = new Dictionary<String, String>();
            // var localVarFileParams = new Dictionary<String, FileParameter>();
            // Object localVarPostBody = null;
            //
            // // to determine the Content-Type header
            // String[] localVarHttpContentTypes = new String[] {
            // };
            // String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
            //
            // // to determine the Accept header
            // String[] localVarHttpHeaderAccepts = new String[] {
            //     "application/json"
            // };
            // String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            // if (localVarHttpHeaderAccept != null)
            //     localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            //
            //
            // // make the HTTP request
            // IScillApiResponse localVarResponse = (IScillApiResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            //     Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            //     localVarPathParams, localVarHttpContentType);
            //
            // int localVarStatusCode = (int) localVarResponse.StatusCode;
            //
            // if (ExceptionFactory != null)
            // {
            //     Exception exception = ExceptionFactory("GetAvailableEvents", localVarResponse);
            //     if (exception != null) throw exception;
            // }
            //
            // return new ApiResponse<List<EventDescription>>(localVarStatusCode,
            //     localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            //     (List<EventDescription>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EventDescription>)));

            return new Promise<ApiResponse<List<EventDescription>>>();
        }

        /// <summary>
        /// Post an event Post an event to the SCILL backend
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Event payload or team event payload</param>
        /// <returns>Task of ActionResponse</returns>
        public IPromise<ActionResponse> SendEventAsync (EventPayload body)
        {
             return SendEventAsyncWithHttpInfo(body).ExtractResponseData();

        }

        /// <summary>
        /// Post an event Post an event to the SCILL backend
        /// </summary>
        /// <exception cref="SCILL.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Event payload or team event payload</param>
        /// <returns>Task of ApiResponse (ActionResponse)</returns>
        public IPromise<ApiResponse<ActionResponse>> SendEventAsyncWithHttpInfo (EventPayload body)
        {
            // // verify the required parameter 'body' is set
            // if (body == null)
            //     throw new ApiException(400, "Missing required parameter 'body' when calling EventsApi->SendEvent");
            //
            // var localVarPath = "/api/v1/events";
            // var localVarPathParams = new Dictionary<String, String>();
            // var localVarQueryParams = new List<KeyValuePair<String, String>>();
            // var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            // var localVarFormParams = new Dictionary<String, String>();
            // var localVarFileParams = new Dictionary<String, FileParameter>();
            // Object localVarPostBody = null;
            //
            // // to determine the Content-Type header
            // String[] localVarHttpContentTypes = new String[] {
            //     "application/json"
            // };
            // String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
            //
            // // to determine the Accept header
            // String[] localVarHttpHeaderAccepts = new String[] {
            //     "application/json"
            // };
            // String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            // if (localVarHttpHeaderAccept != null)
            //     localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            //
            // if (body != null && body.GetType() != typeof(byte[]))
            // {
            //     localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            // }
            // else
            // {
            //     localVarPostBody = body; // byte array
            // }
            // // authentication (ApiKeyType) required
            // if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            // {
            //     localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            // }
            // // authentication (BearerAuth) required
            // // bearer required
            // if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            // {
            //     localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            // }
            // // authentication (oAuthNoScopes) required
            // // oauth required
            // if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            // {
            //     localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            // }
            //
            // // make the HTTP request
            // IScillApiResponse localVarResponse = (IScillApiResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            //     Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            //     localVarPathParams, localVarHttpContentType);
            //
            // int localVarStatusCode = (int) localVarResponse.StatusCode;
            //
            // if (ExceptionFactory != null)
            // {
            //     Exception exception = ExceptionFactory("SendEvent", localVarResponse);
            //     if (exception != null) throw exception;
            // }
            //
            // return new ApiResponse<ActionResponse>(localVarStatusCode,
            //     localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            //     (ActionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActionResponse)));

            return new Promise<ApiResponse<ActionResponse>>();
        }

    }
}
