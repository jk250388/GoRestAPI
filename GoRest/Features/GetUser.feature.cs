﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GoRest.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class GetUserFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetUser.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "GetUser", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "GetUser")))
            {
                global::GoRest.Features.GetUserFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
#line 4
 testRunner.Given("I set GET users api endpoint as \'/users\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
 testRunner.And("I set headers \'Accept\' and \'Content-Type\' as \'application/json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get data of all users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetUser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void GetDataOfAllUsers()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get data of all users", null, tagsOfScenario, argumentsOfScenario);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 9
 testRunner.When("I send GET Http request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then("I receive valid http status code \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("Response body is not null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void GetDataOfUsersWithSpecificUserID(string testCase, string userId, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("TestCase", testCase);
            argumentsOfScenario.Add("userId", userId);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get data of users with specific User ID", null, tagsOfScenario, argumentsOfScenario);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 14
 testRunner.When(string.Format("I set User ID as \'{0}\'", userId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.And("I send GET Http request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.Then("I receive the response with user details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.And("I receive valid http status code \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("Response body is not null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get data of users with specific User ID: 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetUser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TestCase", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:userId", "40")]
        public virtual void GetDataOfUsersWithSpecificUserID_1()
        {
#line 13
this.GetDataOfUsersWithSpecificUserID("1", "40", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get data of users with specific User ID: 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetUser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TestCase", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:userId", "41")]
        public virtual void GetDataOfUsersWithSpecificUserID_2()
        {
#line 13
this.GetDataOfUsersWithSpecificUserID("2", "41", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get data of users with specific User ID: 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetUser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:TestCase", "3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:userId", "42")]
        public virtual void GetDataOfUsersWithSpecificUserID_3()
        {
#line 13
this.GetDataOfUsersWithSpecificUserID("3", "42", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
