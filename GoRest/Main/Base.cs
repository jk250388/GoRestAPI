using RestSharp;
using System.Collections.Generic;
using System.Configuration;

namespace GoRest.Main
{
    public class Base
    {
        protected IRestClient GetRestClient()
        {
            IRestClient restClient = new RestClient();
            return restClient;
        }

        protected IRestRequest GetRestRequest(string endpoint, Dictionary<string, string> headers, Method method, string jsonBody)
        {
            IRestRequest restRequest = new RestRequest()
            {
                Resource = ConfigurationManager.AppSettings["baseUrl"] + endpoint,
                Method = method
            };
            foreach(string key in headers.Keys)
            {
                restRequest.AddHeader(key, headers[key]);
            }
            if(method == Method.POST)
            {
                restRequest.AddHeader("Authorization", "Bearer " + ConfigurationManager.AppSettings["bearerToken"]);
                restRequest.AddJsonBody(jsonBody);
            }
            return restRequest;
        }

        protected IRestResponse SendRequest(IRestRequest restRequest)
        {
            IRestClient restClient = GetRestClient();
            IRestResponse restResponse = restClient.Execute(restRequest);
            return restResponse;
        }

        protected IRestResponse SendRequest<T>(IRestRequest restRequest) where T : new()
        {
            IRestClient restClient = GetRestClient();
            IRestResponse restResponse = restClient.Execute<T>(restRequest);
            return restResponse;
        }


    }
}
