using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpClickEntregas.API.Models
{
    public partial class Order
    {
        [JsonProperty("order_id")]
        public object OrderId { get; set; }

        [JsonProperty("order_name")]
        public object OrderName { get; set; }

        [JsonProperty("vehicle_type_id")]
        public long VehicleTypeId { get; set; }

        [JsonProperty("created_datetime")]
        public DateTimeOffset CreatedDatetime { get; set; }

        [JsonProperty("finish_datetime")]
        public object FinishDatetime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_description")]
        public string StatusDescription { get; set; }

        [JsonProperty("matter")]
        public string Matter { get; set; }

        [JsonProperty("total_weight_kg")]
        public long TotalWeightKg { get; set; }

        [JsonProperty("is_client_notification_enabled")]
        public bool IsClientNotificationEnabled { get; set; }

        [JsonProperty("is_contact_person_notification_enabled")]
        public bool IsContactPersonNotificationEnabled { get; set; }

        [JsonProperty("loaders_count")]
        public long LoadersCount { get; set; }

        [JsonProperty("backpayment_details")]
        public object BackpaymentDetails { get; set; }

        [JsonProperty("points")]
        public List<OrderPoint> Points { get; set; }

        [JsonProperty("payment_amount")]
        public string PaymentAmount { get; set; }

        [JsonProperty("delivery_fee_amount")]
        public string DeliveryFeeAmount { get; set; }

        [JsonProperty("intercity_delivery_fee_amount")]
        public string IntercityDeliveryFeeAmount { get; set; }

        [JsonProperty("weight_fee_amount")]
        public string WeightFeeAmount { get; set; }

        [JsonProperty("insurance_amount")]
        public string InsuranceAmount { get; set; }

        [JsonProperty("insurance_fee_amount")]
        public string InsuranceFeeAmount { get; set; }

        [JsonProperty("loading_fee_amount")]
        public string LoadingFeeAmount { get; set; }

        [JsonProperty("money_transfer_fee_amount")]
        public string MoneyTransferFeeAmount { get; set; }

        [JsonProperty("suburban_delivery_fee_amount")]
        public string SuburbanDeliveryFeeAmount { get; set; }

        [JsonProperty("overnight_fee_amount")]
        public string OvernightFeeAmount { get; set; }

        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        [JsonProperty("backpayment_amount")]
        public string BackpaymentAmount { get; set; }

        [JsonProperty("cod_fee_amount")]
        public string CodFeeAmount { get; set; }

        [JsonProperty("backpayment_photo_url")]
        public object BackpaymentPhotoUrl { get; set; }

        [JsonProperty("itinerary_document_url")]
        public object ItineraryDocumentUrl { get; set; }

        [JsonProperty("waybill_document_url")]
        public object WaybillDocumentUrl { get; set; }

        [JsonProperty("courier")]
        public object Courier { get; set; }

        [JsonProperty("is_motobox_required")]
        public bool IsMotoboxRequired { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("bank_card_id")]
        public object BankCardId { get; set; }
    }
}
