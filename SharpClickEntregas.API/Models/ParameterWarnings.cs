using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class ParameterWarnings
    {
        [JsonProperty("points")]
        public List<ParameterWarningsPoint> Points { get; set; }
    }
}
