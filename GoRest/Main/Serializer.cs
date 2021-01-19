using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoRest.Main
{
    public static class Serializer
    {
        public static string SerializeResponse(object body)
        {
            string jsonBody = JsonConvert.SerializeObject(body);
            return jsonBody;
        }
    }
}
