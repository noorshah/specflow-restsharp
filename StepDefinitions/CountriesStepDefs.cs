using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using specflow_restsharp.Helpers;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Extensions;
using Newtonsoft.Json;

namespace specflow_restsharp.StepDefinitions
{
    [Binding]
    public sealed class CountriesStepDefs
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

       
        IRestResponse response;
        CountriesHelper helper = new CountriesHelper();
        List<string> names=new List<string>() { };


        [Given(@"I get information for all countries of the world")]
        public void GivenIGetInformationForAllCountriesOfTheWorld()
        {
            response = helper.restCountries(); 
        }

        [Then(@"the status code should be (.*)")]
        public void ThenTheStatusCodeShouldBe(int code)
        {
            Assert.AreEqual(helper.restCountriesStatusCode(response), code);
        }

        [Then(@"(.*) exists in the list of countries")]
        public void ThenUnitedKingdomExistsInTheListOfCountries(string UK)
        {   
            var countryInfo = new JsonDeserializer().Deserialize<List<CountryInfo>>(response);
            
            foreach(var country in countryInfo)
            {
                if (country.Name==UK)
                {
                    break;
                }
            }

            

        }


    }
}
