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
    public partial class AbstractRedirectPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput, IEquatable<AbstractRedirectPaymentMethodSpecificInput>
    { 
        /// <summary>
        /// Gets or Sets ExpirationPeriod
        /// </summary>
        [DataMember(Name="expirationPeriod")]
        public int? ExpirationPeriod { get; set; }

        /// <summary>
        /// Gets or Sets RecurringPaymentSequenceIndicator
        /// </summary>
        [DataMember(Name="recurringPaymentSequenceIndicator")]
        public string RecurringPaymentSequenceIndicator { get; set; }

        /// <summary>
        /// Gets or Sets RequiresApproval
        /// </summary>
        [DataMember(Name="requiresApproval")]
        public bool? RequiresApproval { get; set; }

        /// <summary>
        /// ID of the token. This property is populated when the payment was done with a token or when the payment was tokenized.
        /// </summary>
        /// <value>ID of the token. This property is populated when the payment was done with a token or when the payment was tokenized.</value>
        [DataMember(Name="token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Tokenize
        /// </summary>
        [DataMember(Name="tokenize")]
        public bool? Tokenize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractRedirectPaymentMethodSpecificInput {\n");
            sb.Append("  ExpirationPeriod: ").Append(ExpirationPeriod).Append("\n");
            sb.Append("  RecurringPaymentSequenceIndicator: ").Append(RecurringPaymentSequenceIndicator).Append("\n");
            sb.Append("  RequiresApproval: ").Append(RequiresApproval).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Tokenize: ").Append(Tokenize).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AbstractRedirectPaymentMethodSpecificInput)obj);
        }

        /// <summary>
        /// Returns true if AbstractRedirectPaymentMethodSpecificInput instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractRedirectPaymentMethodSpecificInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractRedirectPaymentMethodSpecificInput other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ExpirationPeriod == other.ExpirationPeriod ||
                    ExpirationPeriod != null &&
                    ExpirationPeriod.Equals(other.ExpirationPeriod)
                ) && 
                (
                    RecurringPaymentSequenceIndicator == other.RecurringPaymentSequenceIndicator ||
                    RecurringPaymentSequenceIndicator != null &&
                    RecurringPaymentSequenceIndicator.Equals(other.RecurringPaymentSequenceIndicator)
                ) && 
                (
                    RequiresApproval == other.RequiresApproval ||
                    RequiresApproval != null &&
                    RequiresApproval.Equals(other.RequiresApproval)
                ) && 
                (
                    Token == other.Token ||
                    Token != null &&
                    Token.Equals(other.Token)
                ) && 
                (
                    Tokenize == other.Tokenize ||
                    Tokenize != null &&
                    Tokenize.Equals(other.Tokenize)
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
                    if (ExpirationPeriod != null)
                    hashCode = hashCode * 59 + ExpirationPeriod.GetHashCode();
                    if (RecurringPaymentSequenceIndicator != null)
                    hashCode = hashCode * 59 + RecurringPaymentSequenceIndicator.GetHashCode();
                    if (RequiresApproval != null)
                    hashCode = hashCode * 59 + RequiresApproval.GetHashCode();
                    if (Token != null)
                    hashCode = hashCode * 59 + Token.GetHashCode();
                    if (Tokenize != null)
                    hashCode = hashCode * 59 + Tokenize.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AbstractRedirectPaymentMethodSpecificInput left, AbstractRedirectPaymentMethodSpecificInput right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AbstractRedirectPaymentMethodSpecificInput left, AbstractRedirectPaymentMethodSpecificInput right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
