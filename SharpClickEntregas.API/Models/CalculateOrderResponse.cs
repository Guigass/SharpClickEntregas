using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class CalculateOrderResponse
    {
        [JsonProperty("is_successful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }

        [JsonProperty("warnings")]
        public List<string> Warnings { get; set; }

        [JsonProperty("parameter_warnings")]
        public ParameterWarnings ParameterWarnings { get; set; }
    }
}
