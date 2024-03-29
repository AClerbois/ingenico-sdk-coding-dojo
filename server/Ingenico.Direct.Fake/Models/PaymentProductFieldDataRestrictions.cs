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

namespace Ingenico.Direct.Fake.Models
{ 
    /// <summary>
    /// Object containing data restrictions that apply to this field, like minimum and/or maximum length
    /// </summary>
    [DataContract]
    public partial class PaymentProductFieldDataRestrictions : IEquatable<PaymentProductFieldDataRestrictions>
    { 
        /// <summary>
        ///    * true - Indicates that this field is required   * false - Indicates that this field is optional
        /// </summary>
        /// <value>   * true - Indicates that this field is required   * false - Indicates that this field is optional</value>
        [DataMember(Name="isRequired")]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets Validators
        /// </summary>
        [DataMember(Name="validators")]
        public PaymentProductFieldValidators Validators { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProductFieldDataRestrictions {\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  Validators: ").Append(Validators).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PaymentProductFieldDataRestrictions)obj);
        }

        /// <summary>
        /// Returns true if PaymentProductFieldDataRestrictions instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentProductFieldDataRestrictions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProductFieldDataRestrictions other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsRequired == other.IsRequired ||
                    IsRequired != null &&
                    IsRequired.Equals(other.IsRequired)
                ) && 
                (
                    Validators == other.Validators ||
                    Validators != null &&
                    Validators.Equals(other.Validators)
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
                    if (IsRequired != null)
                    hashCode = hashCode * 59 + IsRequired.GetHashCode();
                    if (Validators != null)
                    hashCode = hashCode * 59 + Validators.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PaymentProductFieldDataRestrictions left, PaymentProductFieldDataRestrictions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentProductFieldDataRestrictions left, PaymentProductFieldDataRestrictions right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
