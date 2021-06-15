using System.Collections.Generic;

namespace SCILL.Client
{
    public interface IRestResponse
    {
        int StatusCode { get; set; }
        string Content { get; }
        string ErrorMessage { get; set; }
        byte[] RawBytes { get; set; }
        
        IDictionary<string, string> Headers { get; }
    }
}