using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class OrderPoint
    {
        [JsonProperty("point_type")]
        public string PointType { get; set; }

        [JsonProperty("point_id")]
        public object PointId { get; set; }

        [JsonProperty("delivery_id")]
        public object DeliveryId { get; set; }

        [JsonProperty("client_order_id")]
        public object ClientOrderId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("required_start_datetime")]
        public DateTimeOffset RequiredStartDatetime { get; set; }

        [JsonProperty("required_finish_datetime")]
        public DateTimeOffset RequiredFinishDatetime { get; set; }

        [JsonProperty("arrival_start_datetime")]
        public object ArrivalStartDatetime { get; set; }

        [JsonProperty("arrival_finish_datetime")]
        public object ArrivalFinishDatetime { get; set; }

        [JsonProperty("estimated_arrival_datetime")]
        public object EstimatedArrivalDatetime { get; set; }

        [JsonProperty("courier_visit_datetime")]
        public object CourierVisitDatetime { get; set; }

        [JsonProperty("contact_person")]
        public PurpleContactPerson ContactPerson { get; set; }

        [JsonProperty("taking_amount")]
        public string TakingAmount { get; set; }

        [JsonProperty("buyout_amount")]
        public string BuyoutAmount { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("packages")]
        public List<object> Packages { get; set; }

        [JsonProperty("is_cod_cash_voucher_required")]
        public bool IsCodCashVoucherRequired { get; set; }

        [JsonProperty("place_photo_url")]
        public object PlacePhotoUrl { get; set; }

        [JsonProperty("sign_photo_url")]
        public object SignPhotoUrl { get; set; }

        [JsonProperty("tracking_url")]
        public object TrackingUrl { get; set; }

        [JsonProperty("checkin")]
        public object Checkin { get; set; }

        [JsonProperty("is_order_payment_here")]
        public bool IsOrderPaymentHere { get; set; }

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
