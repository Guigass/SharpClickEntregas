using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class CreateOrderResponse
    {
        [JsonProperty("is_successful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

        [JsonProperty("parameter_errors")]
        public ParameterErrors ParameterErrors { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}
