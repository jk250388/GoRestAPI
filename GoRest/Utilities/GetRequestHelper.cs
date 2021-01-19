using GoRest.Main;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoRest.Utilities
{
    public class GetRequestHelper : Base
    {
        public IRestResponse PerformGetRequest(string endpoint, Dictionary<string,string> headers)
        {
            IRestRequest restRequest = GetRestRequest(endpoint, headers, Method.GET, null);
            IRestResponse restResponse = SendRequest(restRequest);
            return restResponse;
        }

        public IRestResponse PerformGetRequest<T>(string endpoint, Dictionary<string, string> headers) where T : new()
        {
            IRestRequest restRequest = GetRestRequest(endpoint, headers, Method.GET, null);
            IRestResponse restResponse = SendRequest<T>(restRequest);
            return restResponse;
        }
    }
}
