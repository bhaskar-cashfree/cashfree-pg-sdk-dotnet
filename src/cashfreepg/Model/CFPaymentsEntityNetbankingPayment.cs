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
    /// CFPaymentsEntityNetbankingPayment
    /// </summary>
    [DataContract(Name = "CFPaymentsEntityNetbankingPayment")]
    public partial class CFPaymentsEntityNetbankingPayment : IEquatable<CFPaymentsEntityNetbankingPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFPaymentsEntityNetbankingPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CFPaymentsEntityNetbankingPayment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFPaymentsEntityNetbankingPayment" /> class.
        /// </summary>
        /// <param name="channel">channel (required).</param>
        /// <param name="netbankingBankCode">netbankingBankCode (required).</param>
        /// <param name="netbankingBankName">netbankingBankName (required).</param>
        public CFPaymentsEntityNetbankingPayment(string channel = "link", string? netbankingBankCode = default(string?), string? netbankingBankName = default(string?))
        {
            // to ensure "channel" is required (not null)
            if (channel == null) {
                throw new ArgumentNullException("channel is a required property for CFPaymentsEntityNetbankingPayment and cannot be null");
            }
            this.Channel = channel;
            // to ensure "netbankingBankCode" is required (not null)
            if (netbankingBankCode == null) {
                throw new ArgumentNullException("netbankingBankCode is a required property for CFPaymentsEntityNetbankingPayment and cannot be null");
            }
            this.NetbankingBankCode = netbankingBankCode;
            this.NetbankingBankName = netbankingBankName;
        }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = false)]
        public string? Channel { get; set; }

        /// <summary>
        /// Gets or Sets NetbankingBankCode
        /// </summary>
        [DataMember(Name = "netbanking_bank_code", IsRequired = true, EmitDefaultValue = false)]
        public string? NetbankingBankCode { get; set; }

        /// <summary>
        /// Gets or Sets NetbankingBankName
        /// </summary>
        [DataMember(Name = "netbanking_bank_name", IsRequired = true, EmitDefaultValue = false)]
        public string? NetbankingBankName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFPaymentsEntityNetbankingPayment {\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  NetbankingBankCode: ").Append(NetbankingBankCode).Append("\n");
            sb.Append("  NetbankingBankName: ").Append(NetbankingBankName).Append("\n");
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
            return this.Equals(input as CFPaymentsEntityNetbankingPayment);
        }

        /// <summary>
        /// Returns true if CFPaymentsEntityNetbankingPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of CFPaymentsEntityNetbankingPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFPaymentsEntityNetbankingPayment? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.NetbankingBankCode == input.NetbankingBankCode ||
                    (this.NetbankingBankCode != null &&
                    this.NetbankingBankCode.Equals(input.NetbankingBankCode))
                ) && 
                (
                    this.NetbankingBankName == input.NetbankingBankName ||
                    (this.NetbankingBankName != null &&
                    this.NetbankingBankName.Equals(input.NetbankingBankName))
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
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                if (this.NetbankingBankCode != null)
                {
                    hashCode = (hashCode * 59) + this.NetbankingBankCode.GetHashCode();
                }
                if (this.NetbankingBankName != null)
                {
                    hashCode = (hashCode * 59) + this.NetbankingBankName.GetHashCode();
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