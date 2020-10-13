using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class PointRequest
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("contact_person")]
        public ContactPerson ContactPerson { get; set; }
    }
}
