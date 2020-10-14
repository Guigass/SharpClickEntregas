using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class Order
    {
        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("order_name")]
        public string OrderName { get; set; }

        [JsonProperty("vehicle_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? VehicleTypeId { get; set; }

        [JsonProperty("created_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedDatetime { get; set; }

        [JsonProperty("finish_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FinishDatetime { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("status_description", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusDescription { get; set; }

        [JsonProperty("matter", NullValueHandling = NullValueHandling.Ignore)]
        public string Matter { get; set; }

        [JsonProperty("total_weight_kg", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalWeightKg { get; set; }

        [JsonProperty("is_client_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsClientNotificationEnabled { get; set; }

        [JsonProperty("is_contact_person_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsContactPersonNotificationEnabled { get; set; }

        [JsonProperty("loaders_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? LoadersCount { get; set; }

        [JsonProperty("backpayment_details", NullValueHandling = NullValueHandling.Ignore)]
        public string BackpaymentDetails { get; set; }

        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderPoint> Points { get; set; }

        [JsonProperty("payment_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentAmount { get; set; }

        [JsonProperty("delivery_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryFeeAmount { get; set; }

        [JsonProperty("intercity_delivery_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string IntercityDeliveryFeeAmount { get; set; }

        [JsonProperty("weight_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string WeightFeeAmount { get; set; }

        [JsonProperty("insurance_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string InsuranceAmount { get; set; }

        [JsonProperty("insurance_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string InsuranceFeeAmount { get; set; }

        [JsonProperty("loading_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadingFeeAmount { get; set; }

        [JsonProperty("money_transfer_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string MoneyTransferFeeAmount { get; set; }

        [JsonProperty("suburban_delivery_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string SuburbanDeliveryFeeAmount { get; set; }

        [JsonProperty("overnight_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OvernightFeeAmount { get; set; }

        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountAmount { get; set; }

        [JsonProperty("backpayment_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string BackpaymentAmount { get; set; }

        [JsonProperty("cod_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string CodFeeAmount { get; set; }

        [JsonProperty("backpayment_photo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BackpaymentPhotoUrl { get; set; }

        [JsonProperty("itinerary_document_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ItineraryDocumentUrl { get; set; }

        [JsonProperty("waybill_document_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WaybillDocumentUrl { get; set; }

        [JsonProperty("courier")]
        public object Courier { get; set; }

        [JsonProperty("is_motobox_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMotoboxRequired { get; set; }

        [JsonProperty("payment_method", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentMethod { get; set; }

        [JsonProperty("bank_card_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? BankCardId { get; set; }
    }
}
