using GoRest.Main;
using GoRest.Models;
using GoRest.Settings;
using GoRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace GoRest.Steps
{
    [Binding]
    public sealed class GetUserSteps
    {

        private GetRequestHelper getRequestHelper = new GetRequestHelper();
        private GetSpecificUserModel userResponse;

        #region When   

        [When(@"I set User ID as '(.*)'")]
        public void WhenISetUserIDAs(int userId)
        {
            ObjectRepository.endpoint = ObjectRepository.endpoint + "/" + userId;
        }

        [When(@"I send GET Http request")]
        public void WhenISendGETHttpRequest()
        {
            ObjectRepository.restResponse = getRequestHelper.PerformGetRequest(ObjectRepository.endpoint, ObjectRepository.headers);
        }

        #endregion

        #region Then


        [Then(@"I receive the response with user details")]
        public void ThenIReceiveTheResponseWithUserDetails()
        {
           userResponse =  Deserializer.DeserializeResponse<GetSpecificUserModel>(ObjectRepository.restResponse);
        }

        [Then(@"I receive valid http status code '(.*)'")]
        public void ThenIReceiveValidHttpResponseCode(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)ObjectRepository.restResponse.StatusCode);
        }

        [Then(@"Response body is not null")]
        public void ThenResponseBodyIsNotNull()
        {
            Assert.IsNotNull(ObjectRepository.restResponse);
        }

        [Then(@"I receive user with name '(.*)'")]
        public void ThenIReceiveUserWithName(string userName)
        {
            Assert.AreEqual(userName, userResponse.data.name);
        }

        #endregion
    }
}
