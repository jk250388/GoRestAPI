using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoRest.Settings
{
    public class ObjectRepository
    {
        public static string endpoint { get; set; }
        public static Dictionary<string, string> headers { get; set; }

        public static IRestResponse restResponse;
    }
}
