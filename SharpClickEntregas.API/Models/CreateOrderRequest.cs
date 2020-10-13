using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class CreateOrderRequest
    {
        [JsonProperty("matter")]
        public string Matter { get; set; }

        [JsonProperty("points")]
        public List<PointRequest> Points { get; set; }

        [JsonProperty("is_client_notification_enabled")]
        public bool IsClientNotificationEnabled { get; set; }

        [JsonProperty("is_contact_person_notification_enabled")]
        public bool IsContactPersonNotificationEnabled { get; set; }

        [JsonProperty("is_route_optimizer_enabled")]
        public bool IsRouteOptimizerEnabled { get; set; }

        [JsonProperty("insurance_amount")]
        public float InsuranceAmount { get; set; }
    }
}
