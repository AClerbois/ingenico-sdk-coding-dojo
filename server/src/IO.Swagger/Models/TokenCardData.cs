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
    /// Object containing the card tokenizable details
    /// </summary>
    [DataContract]
    public partial class TokenCardData : IEquatable<TokenCardData>
    { 
        /// <summary>
        /// Gets or Sets CardWithoutCvv
        /// </summary>
        [DataMember(Name="cardWithoutCvv")]
        public CardWithoutCvv CardWithoutCvv { get; set; }

        /// <summary>
        /// Date of the first transaction (for ATOS). Format: YYYYMMDD
        /// </summary>
        /// <value>Date of the first transaction (for ATOS). Format: YYYYMMDD</value>
        [DataMember(Name="firstTransactionDate")]
        public string FirstTransactionDate { get; set; }

        /// <summary>
        /// Reference of the provider (of the first transaction) - used to store the ATOS Transaction Certificate
        /// </summary>
        /// <value>Reference of the provider (of the first transaction) - used to store the ATOS Transaction Certificate</value>
        [DataMember(Name="providerReference")]
        public string ProviderReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenCardData {\n");
            sb.Append("  CardWithoutCvv: ").Append(CardWithoutCvv).Append("\n");
            sb.Append("  FirstTransactionDate: ").Append(FirstTransactionDate).Append("\n");
            sb.Append("  ProviderReference: ").Append(ProviderReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return obj.GetType() == GetType() && Equals((TokenCardData)obj);
        }

        /// <summary>
        /// Returns true if TokenCardData instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenCardData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenCardData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CardWithoutCvv == other.CardWithoutCvv ||
                    CardWithoutCvv != null &&
                    CardWithoutCvv.Equals(other.CardWithoutCvv)
                ) && 
                (
                    FirstTransactionDate == other.FirstTransactionDate ||
                    FirstTransactionDate != null &&
                    FirstTransactionDate.Equals(other.FirstTransactionDate)
                ) && 
                (
                    ProviderReference == other.ProviderReference ||
                    ProviderReference != null &&
                    ProviderReference.Equals(other.ProviderReference)
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
                    if (CardWithoutCvv != null)
                    hashCode = hashCode * 59 + CardWithoutCvv.GetHashCode();
                    if (FirstTransactionDate != null)
                    hashCode = hashCode * 59 + FirstTransactionDate.GetHashCode();
                    if (ProviderReference != null)
                    hashCode = hashCode * 59 + ProviderReference.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TokenCardData left, TokenCardData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TokenCardData left, TokenCardData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
