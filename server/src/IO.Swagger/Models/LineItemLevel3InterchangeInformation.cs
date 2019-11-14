/*
 * Ingenico Direct
 *
 *  # Introduction  The Ingenico Direct API has been designed as a REST API. It uses the HTTP protocol as its foundation. Each resource is accessible under a clearly named URL and the HTTP response codes are used to relay status. HTTP Verbs like GET and POST are used to interact with the resources. To support accessibility by clients directly, as opposed to your server, our servers support cross-origin resource sharing. We use JSON for all of our payloads, including error messages   All these characteristics mean that you will be able to use standard off the shelf software to interact with Ingenico ePayments. To make the integration even easier, Ingenico ePayments also has SDKs that wrap both the complete Server API as well as the complete Client API. 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class LineItemLevel3InterchangeInformation : Dictionary<String, Object>, IEquatable<LineItemLevel3InterchangeInformation>
    { 
        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="discountAmount")]
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// Gets or Sets LineAmountTotal
        /// </summary>
        [DataMember(Name="lineAmountTotal")]
        public long? LineAmountTotal { get; set; }

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name="productCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets ProductPrice
        /// </summary>
        [DataMember(Name="productPrice")]
        public long? ProductPrice { get; set; }

        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name="productType")]
        public string ProductType { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="taxAmount")]
        public long? TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemLevel3InterchangeInformation {\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  LineAmountTotal: ").Append(LineAmountTotal).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ProductPrice: ").Append(ProductPrice).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((LineItemLevel3InterchangeInformation)obj);
        }

        /// <summary>
        /// Returns true if LineItemLevel3InterchangeInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItemLevel3InterchangeInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemLevel3InterchangeInformation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DiscountAmount == other.DiscountAmount ||
                    DiscountAmount != null &&
                    DiscountAmount.Equals(other.DiscountAmount)
                ) && 
                (
                    LineAmountTotal == other.LineAmountTotal ||
                    LineAmountTotal != null &&
                    LineAmountTotal.Equals(other.LineAmountTotal)
                ) && 
                (
                    ProductCode == other.ProductCode ||
                    ProductCode != null &&
                    ProductCode.Equals(other.ProductCode)
                ) && 
                (
                    ProductPrice == other.ProductPrice ||
                    ProductPrice != null &&
                    ProductPrice.Equals(other.ProductPrice)
                ) && 
                (
                    ProductType == other.ProductType ||
                    ProductType != null &&
                    ProductType.Equals(other.ProductType)
                ) && 
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    TaxAmount == other.TaxAmount ||
                    TaxAmount != null &&
                    TaxAmount.Equals(other.TaxAmount)
                ) && 
                (
                    Unit == other.Unit ||
                    Unit != null &&
                    Unit.Equals(other.Unit)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (DiscountAmount != null)
                    hashCode = hashCode * 59 + DiscountAmount.GetHashCode();
                    if (LineAmountTotal != null)
                    hashCode = hashCode * 59 + LineAmountTotal.GetHashCode();
                    if (ProductCode != null)
                    hashCode = hashCode * 59 + ProductCode.GetHashCode();
                    if (ProductPrice != null)
                    hashCode = hashCode * 59 + ProductPrice.GetHashCode();
                    if (ProductType != null)
                    hashCode = hashCode * 59 + ProductType.GetHashCode();
                    if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (TaxAmount != null)
                    hashCode = hashCode * 59 + TaxAmount.GetHashCode();
                    if (Unit != null)
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LineItemLevel3InterchangeInformation left, LineItemLevel3InterchangeInformation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LineItemLevel3InterchangeInformation left, LineItemLevel3InterchangeInformation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
