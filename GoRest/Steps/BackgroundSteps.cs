using GoRest.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GoRest.Steps
{
    [Binding]
    public sealed class BackgroundSteps
    {
        #region Given

        [Given(@"I set GET users api endpoint as '(.*)'")]
        public void GivenISetGETUsersApiEndpointAs(string endpoint)
        {
            ObjectRepository.endpoint = endpoint;
        }

        [Given(@"I set headers '(.*)' and '(.*)' as '(.*)'")]
        public void GivenISetHeadersAndAs(string accept, string contentType, string value)
        {
            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add(accept, value);
            header.Add(contentType, value);
            ObjectRepository.headers = header;
        }

        #endregion
    }
}
