using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class Delivery
    {
        [JsonProperty("delivery_id")]
        public long DeliveryId { get; set; }

        [JsonProperty("delivery_type")]
        public string DeliveryType { get; set; }

        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("client_id")]
        public long ClientId { get; set; }

        [JsonProperty("client_order_id")]
        public object ClientOrderId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_datetime")]
        public DateTimeOffset StatusDatetime { get; set; }

        [JsonProperty("created_datetime")]
        public DateTimeOffset CreatedDatetime { get; set; }

        [JsonProperty("order_name")]
        public long OrderName { get; set; }

        [JsonProperty("order_payment_amount")]
        public string OrderPaymentAmount { get; set; }

        [JsonProperty("delivery_price_amount")]
        public string DeliveryPriceAmount { get; set; }

        [JsonProperty("point_id")]
        public long PointId { get; set; }

        [JsonProperty("contact_person")]
        public ContactPerson ContactPerson { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("building_number")]
        public object BuildingNumber { get; set; }

        [JsonProperty("apartment_number")]
        public object ApartmentNumber { get; set; }

        [JsonProperty("entrance_number")]
        public object EntranceNumber { get; set; }

        [JsonProperty("intercom_code")]
        public object IntercomCode { get; set; }

        [JsonProperty("floor_number")]
        public object FloorNumber { get; set; }

        [JsonProperty("invisible_mile_navigation_instructions")]
        public object InvisibleMileNavigationInstructions { get; set; }

        [JsonProperty("required_start_datetime")]
        public DateTimeOffset RequiredStartDatetime { get; set; }

        [JsonProperty("required_finish_datetime")]
        public DateTimeOffset RequiredFinishDatetime { get; set; }

        [JsonProperty("taking_amount")]
        public string TakingAmount { get; set; }

        [JsonProperty("buyout_amount")]
        public string BuyoutAmount { get; set; }

        [JsonProperty("is_cod_cash_voucher_required")]
        public bool IsCodCashVoucherRequired { get; set; }

        [JsonProperty("is_motobox_required")]
        public bool IsMotoboxRequired { get; set; }

        [JsonProperty("is_door_to_door")]
        public bool IsDoorToDoor { get; set; }

        [JsonProperty("is_return_to_first_point_required")]
        public bool IsReturnToFirstPointRequired { get; set; }

        [JsonProperty("matter")]
        public object Matter { get; set; }

        [JsonProperty("insurance_amount")]
        public string InsuranceAmount { get; set; }

        [JsonProperty("weight_kg")]
        public long WeightKg { get; set; }

        [JsonProperty("packages")]
        public List<object> Packages { get; set; }

        [JsonProperty("checkin_issue_name")]
        public object CheckinIssueName { get; set; }
    }
}
