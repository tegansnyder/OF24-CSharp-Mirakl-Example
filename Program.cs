using RestSharp;
using System;
using mirakl.OF24;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace mirakl
{
    using RestSharp;

    public class Program
    {
        
        static void Main(string[] args)
        {

            List<Offer> offersData = new List<Offer>();

            Offer o = new Offer();
            o.Description = "test";
            o.LeadTimeToShip = "1";
            o.LogisticClass = "ship-engine";
            o.Price = "33";
            o.PriceAdditionalInfo = "Free shipping over $70";
            o.ProductId = "9400016774345";
            o.ProductIdType = "UPC";
            o.Quantity = "1";
            o.ShopSku = "ABCDEF-EACH";
            o.StateCode = "1";
            o.UpdateDelete = "update";

            List<OfferAdditionalField> additionalFields = new List<OfferAdditionalField>{
                new OfferAdditionalField {
                    Code = "distributor-sku",
                    Value = "ABCDEF"
                },
                new OfferAdditionalField {
                    Code = "selling-unit",
                    Value = "EACH"
                }
            };
     
            o.OfferAdditionalFields = additionalFields;

            offersData.Add(o);

            string OF24Body = JsonConvert.SerializeObject(new {
                offers = offersData
            });

            Console.WriteLine(OF24Body);

            var client = new RestClient("https://3m-qa.mirakl.net/api/offers");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "API_KEY_GOES_HERE");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", OF24Body, ParameterType.RequestBody);


            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

        }
    }
}
