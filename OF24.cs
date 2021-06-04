using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mirakl.OF24
{
    public class Offer
    {
        [JsonProperty("leadtime_to_ship")]
        public string LeadTimeToShip { get; set; }

        [JsonProperty("logistic_class")]
        public string LogisticClass { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("offer_additional_fields")]
        public List<OfferAdditionalField> OfferAdditionalFields { get; set; }
        
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_additional_info")]
        public string PriceAdditionalInfo { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("product_id_type")]
        public string ProductIdType { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("shop_sku")]
        public string ShopSku { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("update_delete")]
        public string UpdateDelete { get; set; }

    }
    public class OfferAdditionalField
    {

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

}
