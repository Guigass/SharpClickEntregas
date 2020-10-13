using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class FluffyContactPerson
    {
        [JsonProperty("phone")]
        public List<string> Phone { get; set; }
    }
}
