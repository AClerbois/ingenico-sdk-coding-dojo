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
    /// Hosted Checkout specific information. Populated if the payment was created on the platform through a Hosted Checkout.
    /// </summary>
    [DataContract]
    public partial class HostedCheckoutSpecificOutput : Dictionary<String, Object>, IEquatable<HostedCheckoutSpecificOutput>
    { 
        /// <summary>
        /// The ID of the Hosted Checkout Session in which the payment was made.
        /// </summary>
        /// <value>The ID of the Hosted Checkout Session in which the payment was made.</value>
        [DataMember(Name="hostedCheckoutId")]
        public string HostedCheckoutId { get; set; }

        /// <summary>
        /// Using the Configuration Center it is possible to create multiple variations of your MyCheckout payment pages. By specifying a specific variant you can force the use of another variant then the default. This allows you to test out the effect of certain changes to your hosted mandate pages in a controlled manner. Please note that you need to specify the ID of the variant.
        /// </summary>
        /// <value>Using the Configuration Center it is possible to create multiple variations of your MyCheckout payment pages. By specifying a specific variant you can force the use of another variant then the default. This allows you to test out the effect of certain changes to your hosted mandate pages in a controlled manner. Please note that you need to specify the ID of the variant.</value>
        [DataMember(Name="variant")]
        public string Variant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostedCheckoutSpecificOutput {\n");
            sb.Append("  HostedCheckoutId: ").Append(HostedCheckoutId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HostedCheckoutSpecificOutput)obj);
        }

        /// <summary>
        /// Returns true if HostedCheckoutSpecificOutput instances are equal
        /// </summary>
        /// <param name="other">Instance of HostedCheckoutSpecificOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HostedCheckoutSpecificOutput other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HostedCheckoutId == other.HostedCheckoutId ||
                    HostedCheckoutId != null &&
                    HostedCheckoutId.Equals(other.HostedCheckoutId)
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
                    if (HostedCheckoutId != null)
                    hashCode = hashCode * 59 + HostedCheckoutId.GetHashCode();
                    if (Variant != null)
                    hashCode = hashCode * 59 + Variant.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HostedCheckoutSpecificOutput left, HostedCheckoutSpecificOutput right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HostedCheckoutSpecificOutput left, HostedCheckoutSpecificOutput right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
