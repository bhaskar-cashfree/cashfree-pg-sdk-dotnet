/*
 * New Payment Gateway APIs
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2022-01-01
 * Contact: nextgenapi@cashfree.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = cashfreepg.Client.OpenAPIDateConverter;

namespace cashfreepg.Model
{
    /// <summary>
    /// CFOrder
    /// </summary>
    [DataContract(Name = "CFOrder")]
    public partial class CFOrder : IEquatable<CFOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFOrder" /> class.
        /// </summary>
        /// <param name="cfOrderId">cfOrderId.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="entity">entity.</param>
        /// <param name="orderCurrency">orderCurrency.</param>
        /// <param name="orderAmount">orderAmount.</param>
        /// <param name="orderStatus">orderStatus.</param>
        /// <param name="orderToken">orderToken.</param>
        /// <param name="orderExpiryTime">orderExpiryTime.</param>
        /// <param name="orderNote">orderNote.</param>
        /// <param name="paymentLink">paymentLink.</param>
        /// <param name="customerDetails">customerDetails.</param>
        /// <param name="orderMeta">orderMeta.</param>
        /// <param name="payments">payments.</param>
        /// <param name="settlements">settlements.</param>
        /// <param name="refunds">refunds.</param>
        public CFOrder(int? cfOrderId = default(int?), string? orderId = default(string?), string? entity = default(string?), string? orderCurrency = default(string?), decimal? orderAmount = default(decimal?), string? orderStatus = default(string?), string? orderToken = default(string?), string? orderExpiryTime = default(string?), string? orderNote = default(string?), string? paymentLink = default(string?), CFCustomerDetails? customerDetails = default(CFCustomerDetails?), CFOrderMeta? orderMeta = default(CFOrderMeta?), CFPaymentURLObject? payments = default(CFPaymentURLObject?), CFSettlementURLObject? settlements = default(CFSettlementURLObject?), CFRefundURLObject? refunds = default(CFRefundURLObject?))
        {
            this.CfOrderId = cfOrderId;
            this.OrderId = orderId;
            this.Entity = entity;
            this.OrderCurrency = orderCurrency;
            this.OrderAmount = orderAmount;
            this.OrderStatus = orderStatus;
            this.OrderToken = orderToken;
            this.OrderExpiryTime = orderExpiryTime;
            this.OrderNote = orderNote;
            this.PaymentLink = paymentLink;
            this.CustomerDetails = customerDetails;
            this.OrderMeta = orderMeta;
            this.Payments = payments;
            this.Settlements = settlements;
            this.Refunds = refunds;
        }

        /// <summary>
        /// Gets or Sets CfOrderId
        /// </summary>
        [DataMember(Name = "cf_order_id", EmitDefaultValue = false)]
        public int? CfOrderId { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string? OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public string? Entity { get; set; }

        /// <summary>
        /// Gets or Sets OrderCurrency
        /// </summary>
        [DataMember(Name = "order_currency", EmitDefaultValue = false)]
        public string? OrderCurrency { get; set; }

        /// <summary>
        /// Gets or Sets OrderAmount
        /// </summary>
        [DataMember(Name = "order_amount", EmitDefaultValue = false)]
        public decimal? OrderAmount { get; set; }

        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string? OrderStatus { get; set; }

        /// <summary>
        /// Gets or Sets OrderToken
        /// </summary>
        [DataMember(Name = "order_token", EmitDefaultValue = false)]
        public string? OrderToken { get; set; }

        /// <summary>
        /// Gets or Sets OrderExpiryTime
        /// </summary>
        [DataMember(Name = "order_expiry_time", EmitDefaultValue = false)]
        public string? OrderExpiryTime { get; set; }

        /// <summary>
        /// Gets or Sets OrderNote
        /// </summary>
        [DataMember(Name = "order_note", EmitDefaultValue = false)]
        public string? OrderNote { get; set; }

        /// <summary>
        /// Gets or Sets PaymentLink
        /// </summary>
        [DataMember(Name = "payment_link", EmitDefaultValue = false)]
        public string? PaymentLink { get; set; }

        /// <summary>
        /// Gets or Sets CustomerDetails
        /// </summary>
        [DataMember(Name = "customer_details", EmitDefaultValue = false)]
        public CFCustomerDetails? CustomerDetails { get; set; }

        /// <summary>
        /// Gets or Sets OrderMeta
        /// </summary>
        [DataMember(Name = "order_meta", EmitDefaultValue = false)]
        public CFOrderMeta? OrderMeta { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public CFPaymentURLObject? Payments { get; set; }

        /// <summary>
        /// Gets or Sets Settlements
        /// </summary>
        [DataMember(Name = "settlements", EmitDefaultValue = false)]
        public CFSettlementURLObject? Settlements { get; set; }

        /// <summary>
        /// Gets or Sets Refunds
        /// </summary>
        [DataMember(Name = "refunds", EmitDefaultValue = false)]
        public CFRefundURLObject? Refunds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFOrder {\n");
            sb.Append("  CfOrderId: ").Append(CfOrderId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  OrderCurrency: ").Append(OrderCurrency).Append("\n");
            sb.Append("  OrderAmount: ").Append(OrderAmount).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OrderToken: ").Append(OrderToken).Append("\n");
            sb.Append("  OrderExpiryTime: ").Append(OrderExpiryTime).Append("\n");
            sb.Append("  OrderNote: ").Append(OrderNote).Append("\n");
            sb.Append("  PaymentLink: ").Append(PaymentLink).Append("\n");
            sb.Append("  CustomerDetails: ").Append(CustomerDetails).Append("\n");
            sb.Append("  OrderMeta: ").Append(OrderMeta).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Settlements: ").Append(Settlements).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return this.Equals(input as CFOrder);
        }

        /// <summary>
        /// Returns true if CFOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of CFOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFOrder? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CfOrderId == input.CfOrderId ||
                    this.CfOrderId.Equals(input.CfOrderId)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.OrderCurrency == input.OrderCurrency ||
                    (this.OrderCurrency != null &&
                    this.OrderCurrency.Equals(input.OrderCurrency))
                ) && 
                (
                    this.OrderAmount == input.OrderAmount ||
                    this.OrderAmount.Equals(input.OrderAmount)
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.OrderToken == input.OrderToken ||
                    (this.OrderToken != null &&
                    this.OrderToken.Equals(input.OrderToken))
                ) && 
                (
                    this.OrderExpiryTime == input.OrderExpiryTime ||
                    (this.OrderExpiryTime != null &&
                    this.OrderExpiryTime.Equals(input.OrderExpiryTime))
                ) && 
                (
                    this.OrderNote == input.OrderNote ||
                    (this.OrderNote != null &&
                    this.OrderNote.Equals(input.OrderNote))
                ) && 
                (
                    this.PaymentLink == input.PaymentLink ||
                    (this.PaymentLink != null &&
                    this.PaymentLink.Equals(input.PaymentLink))
                ) && 
                (
                    this.CustomerDetails == input.CustomerDetails ||
                    (this.CustomerDetails != null &&
                    this.CustomerDetails.Equals(input.CustomerDetails))
                ) && 
                (
                    this.OrderMeta == input.OrderMeta ||
                    (this.OrderMeta != null &&
                    this.OrderMeta.Equals(input.OrderMeta))
                ) && 
                (
                    this.Payments == input.Payments ||
                    (this.Payments != null &&
                    this.Payments.Equals(input.Payments))
                ) && 
                (
                    this.Settlements == input.Settlements ||
                    (this.Settlements != null &&
                    this.Settlements.Equals(input.Settlements))
                ) && 
                (
                    this.Refunds == input.Refunds ||
                    (this.Refunds != null &&
                    this.Refunds.Equals(input.Refunds))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.CfOrderId.GetHashCode();
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.Entity != null)
                {
                    hashCode = (hashCode * 59) + this.Entity.GetHashCode();
                }
                if (this.OrderCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.OrderCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OrderAmount.GetHashCode();
                if (this.OrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.OrderStatus.GetHashCode();
                }
                if (this.OrderToken != null)
                {
                    hashCode = (hashCode * 59) + this.OrderToken.GetHashCode();
                }
                if (this.OrderExpiryTime != null)
                {
                    hashCode = (hashCode * 59) + this.OrderExpiryTime.GetHashCode();
                }
                if (this.OrderNote != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNote.GetHashCode();
                }
                if (this.PaymentLink != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentLink.GetHashCode();
                }
                if (this.CustomerDetails != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerDetails.GetHashCode();
                }
                if (this.OrderMeta != null)
                {
                    hashCode = (hashCode * 59) + this.OrderMeta.GetHashCode();
                }
                if (this.Payments != null)
                {
                    hashCode = (hashCode * 59) + this.Payments.GetHashCode();
                }
                if (this.Settlements != null)
                {
                    hashCode = (hashCode * 59) + this.Settlements.GetHashCode();
                }
                if (this.Refunds != null)
                {
                    hashCode = (hashCode * 59) + this.Refunds.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
