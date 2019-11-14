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
    public partial class HostedCheckoutSpecificInput : Dictionary<String, Object>, IEquatable<HostedCheckoutSpecificInput>
    { 
        /// <summary>
        /// Gets or Sets IsRecurring
        /// </summary>
        [DataMember(Name="isRecurring")]
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets PaymentProductFilters
        /// </summary>
        [DataMember(Name="paymentProductFilters")]
        public PaymentProductFiltersHostedCheckout PaymentProductFilters { get; set; }

        /// <summary>
        /// Gets or Sets ReturnCancelState
        /// </summary>
        [DataMember(Name="returnCancelState")]
        public bool? ReturnCancelState { get; set; }

        /// <summary>
        /// Gets or Sets ReturnUrl
        /// </summary>
        [DataMember(Name="returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or Sets ShowResultPage
        /// </summary>
        [DataMember(Name="showResultPage")]
        public bool? ShowResultPage { get; set; }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name="tokens")]
        public string Tokens { get; set; }

        /// <summary>
        /// Gets or Sets ValidateShoppingCart
        /// </summary>
        [DataMember(Name="validateShoppingCart")]
        public bool? ValidateShoppingCart { get; set; }

        /// <summary>
        /// Gets or Sets Variant
        /// </summary>
        [DataMember(Name="variant")]
        public string Variant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostedCheckoutSpecificInput {\n");
            sb.Append("  IsRecurring: ").Append(IsRecurring).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  PaymentProductFilters: ").Append(PaymentProductFilters).Append("\n");
            sb.Append("  ReturnCancelState: ").Append(ReturnCancelState).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  ShowResultPage: ").Append(ShowResultPage).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
            sb.Append("  ValidateShoppingCart: ").Append(ValidateShoppingCart).Append("\n");
            sb.Append("  Variant: ").Append(Variant).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HostedCheckoutSpecificInput)obj);
        }

        /// <summary>
        /// Returns true if HostedCheckoutSpecificInput instances are equal
        /// </summary>
        /// <param name="other">Instance of HostedCheckoutSpecificInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostedCheckoutSpecificInput other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsRecurring == other.IsRecurring ||
                    IsRecurring != null &&
                    IsRecurring.Equals(other.IsRecurring)
                ) && 
                (
                    Locale == other.Locale ||
                    Locale != null &&
                    Locale.Equals(other.Locale)
                ) && 
                (
                    PaymentProductFilters == other.PaymentProductFilters ||
                    PaymentProductFilters != null &&
                    PaymentProductFilters.Equals(other.PaymentProductFilters)
                ) && 
                (
                    ReturnCancelState == other.ReturnCancelState ||
                    ReturnCancelState != null &&
                    ReturnCancelState.Equals(other.ReturnCancelState)
                ) && 
                (
                    ReturnUrl == other.ReturnUrl ||
                    ReturnUrl != null &&
                    ReturnUrl.Equals(other.ReturnUrl)
                ) && 
                (
                    ShowResultPage == other.ShowResultPage ||
                    ShowResultPage != null &&
                    ShowResultPage.Equals(other.ShowResultPage)
                ) && 
                (
                    Tokens == other.Tokens ||
                    Tokens != null &&
                    Tokens.Equals(other.Tokens)
                ) && 
                (
                    ValidateShoppingCart == other.ValidateShoppingCart ||
                    ValidateShoppingCart != null &&
                    ValidateShoppingCart.Equals(other.ValidateShoppingCart)
                ) && 
                (
                    Variant == other.Variant ||
                    Variant != null &&
                    Variant.Equals(other.Variant)
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
                    if (IsRecurring != null)
                    hashCode = hashCode * 59 + IsRecurring.GetHashCode();
                    if (Locale != null)
                    hashCode = hashCode * 59 + Locale.GetHashCode();
                    if (PaymentProductFilters != null)
                    hashCode = hashCode * 59 + PaymentProductFilters.GetHashCode();
                    if (ReturnCancelState != null)
                    hashCode = hashCode * 59 + ReturnCancelState.GetHashCode();
                    if (ReturnUrl != null)
                    hashCode = hashCode * 59 + ReturnUrl.GetHashCode();
                    if (ShowResultPage != null)
                    hashCode = hashCode * 59 + ShowResultPage.GetHashCode();
                    if (Tokens != null)
                    hashCode = hashCode * 59 + Tokens.GetHashCode();
                    if (ValidateShoppingCart != null)
                    hashCode = hashCode * 59 + ValidateShoppingCart.GetHashCode();
                    if (Variant != null)
                    hashCode = hashCode * 59 + Variant.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HostedCheckoutSpecificInput left, HostedCheckoutSpecificInput right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HostedCheckoutSpecificInput left, HostedCheckoutSpecificInput right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
