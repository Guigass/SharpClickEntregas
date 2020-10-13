using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class CalculateOrderRequest
    {
        [JsonProperty("matter")]
        public string Matter { get; set; }

        [JsonProperty("points")]
        public List<PointRequest> Points { get; set; }
    }
}
