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
    /// 
    /// </summary>
    [DataContract]
    public partial class BankAccountBbanRefund : BankAccountBban, IEquatable<BankAccountBbanRefund>
    { 
        /// <summary>
        /// Gets or Sets BankCity
        /// </summary>
        [DataMember(Name="bankCity")]
        public string BankCity { get; set; }

        /// <summary>
        /// Gets or Sets PatronymicName
        /// </summary>
        [DataMember(Name="patronymicName")]
        public string PatronymicName { get; set; }

        /// <summary>
        /// Gets or Sets SwiftCode
        /// </summary>
        [DataMember(Name="swiftCode")]
        public string SwiftCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccountBbanRefund {\n");
            sb.Append("  BankCity: ").Append(BankCity).Append("\n");
            sb.Append("  PatronymicName: ").Append(PatronymicName).Append("\n");
            sb.Append("  SwiftCode: ").Append(SwiftCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BankAccountBbanRefund)obj);
        }

        /// <summary>
        /// Returns true if BankAccountBbanRefund instances are equal
        /// </summary>
        /// <param name="other">Instance of BankAccountBbanRefund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountBbanRefund other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BankCity == other.BankCity ||
                    BankCity != null &&
                    BankCity.Equals(other.BankCity)
                ) && 
                (
                    PatronymicName == other.PatronymicName ||
                    PatronymicName != null &&
                    PatronymicName.Equals(other.PatronymicName)
                ) && 
                (
                    SwiftCode == other.SwiftCode ||
                    SwiftCode != null &&
                    SwiftCode.Equals(other.SwiftCode)
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
                    if (BankCity != null)
                    hashCode = hashCode * 59 + BankCity.GetHashCode();
                    if (PatronymicName != null)
                    hashCode = hashCode * 59 + PatronymicName.GetHashCode();
                    if (SwiftCode != null)
                    hashCode = hashCode * 59 + SwiftCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankAccountBbanRefund left, BankAccountBbanRefund right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankAccountBbanRefund left, BankAccountBbanRefund right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}