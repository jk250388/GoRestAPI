using Newtonsoft.Json;
using RestSharp;

namespace GoRest.Main
{
    public static class Deserializer
    {
        public static T DeserializeResponse<T>(IRestResponse restResponse) where T : new()
        {
            var deserializedResponse = JsonConvert.DeserializeObject<T>(restResponse.Content);
            return deserializedResponse;
        }
    }
}
