using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GoRest.Hooks
{
    [Binding]
    public sealed class SenarioHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public static void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            // Write teardown method to release the objects here
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
