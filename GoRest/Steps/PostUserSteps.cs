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
    public sealed class PostUserSteps
    { 
        private PostRequestHelper postRequestHelper = new PostRequestHelper();
        PostUserModel postUserModel = new PostUserModel();
        private GetSpecificUserModel userResponse;

        #region Given 

        [Given(@"I set user '(.*)', '(.*)', '(.*)' and '(.*)'")]
        public void GivenISetUserAnd(string name, string gender, string email, string status)
        {
            postUserModel.name = name;
            postUserModel.gender = gender;
            postUserModel.email = email;
            postUserModel.status = status;
        }

        #endregion

        #region When
        [When(@"I send POST Http request")]
        public void WhenISendPOSTHttpRequest()
        {
            ObjectRepository.restResponse = postRequestHelper.PerformPostRequest(ObjectRepository.endpoint, ObjectRepository.headers, postUserModel);
        }

        #endregion

        #region Then

        [Then(@"I verify user details in response as '(.*)', '(.*)', '(.*)' and '(.*)'")]
        public void ThenIVerifyUserDetailsInResponseAsAnd(string name, string gender, string email, string status)
        {
            userResponse = Deserializer.DeserializeResponse<GetSpecificUserModel>(ObjectRepository.restResponse);
            Assert.AreEqual(name, userResponse.data.name);
            Assert.AreEqual(gender, userResponse.data.gender);
            Assert.AreEqual(email, userResponse.data.email);
            Assert.AreEqual(status, userResponse.data.status);
        }


        #endregion
    }
}
