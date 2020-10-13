using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class ParameterErrors
    {
        [JsonProperty("points")]
        public List<PointRequest> Points { get; set; }
    }

}
