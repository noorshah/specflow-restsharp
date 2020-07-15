using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using Utf8Json;
using RestSharp.Serialization.Json;

namespace specflow_restsharp.Helpers
{
    class CountriesHelper
    {

        RestClient restClient = new RestClient("https://restcountries.eu/rest/v2");
        RestRequest restRequest;
        IRestResponse restResponse;
        


        public IRestResponse restCountries()
        {
            restRequest = new RestRequest("/all", Method.GET);
            restResponse = restClient.Execute<Dictionary<string, List<CountryInfo>>>(restRequest);
            return restResponse;
        }

        public int restCountriesStatusCode(IRestResponse response)
        {  
            return (int)response.StatusCode;
        }
        
        public string UKexistsInCountriesList(IRestResponse response)
        {
            
            Console.WriteLine(response.Content); 
            return response.Content;
        }
    }
}
