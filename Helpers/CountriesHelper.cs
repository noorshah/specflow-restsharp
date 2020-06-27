using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Serialization;

namespace specflow_restsharp.Helpers
{
    class CountriesHelper
    {

        RestClient restClient = new RestClient("https://restcountries.eu/rest/v2");
        RestRequest restRequest;
       IRestResponse restResponse;

        public int restCountries()


        {
            restRequest = new RestRequest("/all", Method.GET);

            restResponse = restClient.Execute(restRequest);
            return (int)restResponse.StatusCode;
        }
        
    }
}
