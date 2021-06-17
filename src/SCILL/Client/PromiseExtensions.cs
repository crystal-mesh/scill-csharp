using RSG;

namespace SCILL.Client
{
    public static class PromiseExtensions
    {
        public static IPromise<T> ExtractResponseData<T>(this IPromise<ApiResponse<T>> PromiseWithHttpInfo)
        {
            var promise = new Promise<T>((resolve, reject) =>
            {
                PromiseWithHttpInfo.Then(apiResponse => resolve(apiResponse.Data))
                    .Catch(reject);
            });
            return promise;
        }
    }
}