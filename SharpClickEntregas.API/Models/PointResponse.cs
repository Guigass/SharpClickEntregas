using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class PointResponse
    {
        [JsonProperty("point_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PointType { get; set; }

        [JsonProperty("point_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? PointId { get; set; }

        [JsonProperty("delivery_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeliveryId { get; set; }

        [JsonProperty("client_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ClientOrderId { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }

        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }

        [JsonProperty("required_start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RequiredStartDatetime { get; set; }

        [JsonProperty("required_finish_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RequiredFinishDatetime { get; set; }

        [JsonProperty("arrival_start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset ArrivalStartDatetime { get; set; }

        [JsonProperty("arrival_finish_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset ArrivalFinishDatetime { get; set; }

        [JsonProperty("estimated_arrival_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset EstimatedArrivalDatetime { get; set; }

        [JsonProperty("courier_visit_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset CourierVisitDatetime { get; set; }

        [JsonProperty("contact_person", NullValueHandling = NullValueHandling.Ignore)]
        public ContactPerson ContactPerson { get; set; }

        [JsonProperty("taking_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TakingAmount { get; set; }

        [JsonProperty("buyout_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyoutAmount { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("packages", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Packages { get; set; }

        [JsonProperty("is_cod_cash_voucher_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCodCashVoucherRequired { get; set; }

        [JsonProperty("place_photo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PlacePhotoUrl { get; set; }

        [JsonProperty("sign_photo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SignPhotoUrl { get; set; }

        [JsonProperty("tracking_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackingUrl { get; set; }

        [JsonProperty("checkin", NullValueHandling = NullValueHandling.Ignore)]
        public object Checkin { get; set; }

        [JsonProperty("is_order_payment_here", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOrderPaymentHere { get; set; }

        [JsonProperty("building_number")]
        public object BuildingNumber { get; set; }

        [JsonProperty("entrance_number")]
        public object EntranceNumber { get; set; }

        [JsonProperty("intercom_code")]
        public object IntercomCode { get; set; }

        [JsonProperty("floor_number")]
        public object FloorNumber { get; set; }

        [JsonProperty("apartment_number")]
        public object ApartmentNumber { get; set; }

        [JsonProperty("invisible_mile_navigation_instructions")]
        public object InvisibleMileNavigationInstructions { get; set; }
    }
}
