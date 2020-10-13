using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class OrderChangedNotification
    {
        [JsonProperty("event_datetime")]
        public DateTimeOffset EventDatetime { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}
