using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class ParameterWarningsPoint
    {
        [JsonProperty("contact_person")]
        public FluffyContactPerson ContactPerson { get; set; }
    }
}
