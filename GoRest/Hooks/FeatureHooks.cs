using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GoRest.Hooks
{
    [Binding]
    public sealed class FeatureHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeFeature]
            
        public static void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterFeature]
        public static void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
