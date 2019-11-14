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
    public partial class MandateContactDetails : Dictionary<String, Object>, IEquatable<MandateContactDetails>
    { 
        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MandateContactDetails {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MandateContactDetails)obj);
        }

        /// <summary>
        /// Returns true if MandateContactDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of MandateContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MandateContactDetails other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EmailAddress == other.EmailAddress ||
                    EmailAddress != null &&
                    EmailAddress.Equals(other.EmailAddress)
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
                    if (EmailAddress != null)
                    hashCode = hashCode * 59 + EmailAddress.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MandateContactDetails left, MandateContactDetails right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MandateContactDetails left, MandateContactDetails right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
