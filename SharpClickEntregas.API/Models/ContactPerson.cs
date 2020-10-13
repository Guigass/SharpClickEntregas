using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class ContactPerson
    {
        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
