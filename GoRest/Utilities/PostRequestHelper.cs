using GoRest.Main;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoRest.Utilities
{
    public class PostRequestHelper : Base
    {
        public IRestResponse PerformPostRequest(string endpoint, Dictionary<string, string> headers, object body)
        {
            String jsonBody = Serializer.SerializeResponse(body);
            IRestRequest restRequest = GetRestRequest(endpoint, headers, Method.POST, jsonBody);
            IRestResponse restResponse = SendRequest(restRequest);
            return restResponse;
        }

        public IRestResponse PerformPostRequest<T>(string endpoint, Dictionary<string, string> headers, object body) where T : new()
        {
            String jsonBody = Serializer.SerializeResponse(body);
            IRestRequest restRequest = GetRestRequest(endpoint, headers, Method.POST, jsonBody);
            IRestResponse restResponse = SendRequest<T>(restRequest);
            return restResponse;
        }
    }
}
