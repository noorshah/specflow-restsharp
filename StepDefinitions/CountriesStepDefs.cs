using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using specflow_restsharp;
using System.Net.Http.Headers;
using specflow_restsharp.Helpers;
using NUnit.Framework;

namespace specflow_restsharp.StepDefinitions
{
    [Binding]
    public sealed class CountriesStepDefs
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        int statusCode;

        [Given(@"I get information for all countries of the world")]
        public void GivenIGetInformationForAllCountriesOfTheWorld()
        {
            statusCode = new CountriesHelper().restCountriesStatusCode();
        }

        [Then(@"the status code should be (.*)")]
        public void ThenTheStatusCodeShouldBe(int code)
        {
            Assert.AreEqual(statusCode, code);
        }

    }
}
