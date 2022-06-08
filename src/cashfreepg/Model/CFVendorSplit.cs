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
    /// CFVendorSplit
    /// </summary>
    [DataContract(Name = "CFVendorSplit")]
    public partial class CFVendorSplit : IEquatable<CFVendorSplit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFVendorSplit" /> class.
        /// </summary>
        /// <param name="vendorId">Vendor id created in Cashfree system.</param>
        /// <param name="amount">Amount which will be associated with this vendor.</param>
        /// <param name="percentage">Percentage of order amount which shall get added to vendor account.</param>
        public CFVendorSplit(string? vendorId = default(string?), decimal? amount = default(decimal?), decimal? percentage = default(decimal?))
        {
            this.VendorId = vendorId;
            this.Amount = amount;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Vendor id created in Cashfree system
        /// </summary>
        /// <value>Vendor id created in Cashfree system</value>
        [DataMember(Name = "vendor_id", EmitDefaultValue = false)]
        public string? VendorId { get; set; }

        /// <summary>
        /// Amount which will be associated with this vendor
        /// </summary>
        /// <value>Amount which will be associated with this vendor</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Percentage of order amount which shall get added to vendor account
        /// </summary>
        /// <value>Percentage of order amount which shall get added to vendor account</value>
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFVendorSplit {\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(input as CFVendorSplit);
        }

        /// <summary>
        /// Returns true if CFVendorSplit instances are equal
        /// </summary>
        /// <param name="input">Instance of CFVendorSplit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFVendorSplit? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
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
                if (this.VendorId != null)
                {
                    hashCode = (hashCode * 59) + this.VendorId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                hashCode = (hashCode * 59) + this.Percentage.GetHashCode();
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