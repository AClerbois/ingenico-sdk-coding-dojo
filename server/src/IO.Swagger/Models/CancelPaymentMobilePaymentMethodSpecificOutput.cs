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
    /// Object that holds specific information on cancelled card payments
    /// </summary>
    [DataContract]
    public partial class CancelPaymentMobilePaymentMethodSpecificOutput : Dictionary<String, Object>, IEquatable<CancelPaymentMobilePaymentMethodSpecificOutput>
    { 
        /// <summary>
        /// Result of the authorization reversal request Possible values are: * 00 - Successful reversal * 0, 8 or 11 - Reversal request submitted * 5 or 55 - Reversal request declined or referred * empty or 98 - The provider did not provide a response
        /// </summary>
        /// <value>Result of the authorization reversal request Possible values are: * 00 - Successful reversal * 0, 8 or 11 - Reversal request submitted * 5 or 55 - Reversal request declined or referred * empty or 98 - The provider did not provide a response</value>
        [DataMember(Name="voidResponseId")]
        public string VoidResponseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelPaymentMobilePaymentMethodSpecificOutput {\n");
            sb.Append("  VoidResponseId: ").Append(VoidResponseId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CancelPaymentMobilePaymentMethodSpecificOutput)obj);
        }

        /// <summary>
        /// Returns true if CancelPaymentMobilePaymentMethodSpecificOutput instances are equal
        /// </summary>
        /// <param name="other">Instance of CancelPaymentMobilePaymentMethodSpecificOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelPaymentMobilePaymentMethodSpecificOutput other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    VoidResponseId == other.VoidResponseId ||
                    VoidResponseId != null &&
                    VoidResponseId.Equals(other.VoidResponseId)
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
                    if (VoidResponseId != null)
                    hashCode = hashCode * 59 + VoidResponseId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CancelPaymentMobilePaymentMethodSpecificOutput left, CancelPaymentMobilePaymentMethodSpecificOutput right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CancelPaymentMobilePaymentMethodSpecificOutput left, CancelPaymentMobilePaymentMethodSpecificOutput right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
