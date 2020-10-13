using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class GetOrdersResponse
    {
        [JsonProperty("is_successful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }

        [JsonProperty("orders_count")]
        public long OrdersCount { get; set; }
    }
}
