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
    /// Given name(s) or first name(s) of the customer
    /// </summary>
    [DataContract]
    public partial class PersonalNameBase : Dictionary<String, Object>, IEquatable<PersonalNameBase>
    { 
        /// <summary>
        /// Given name(s) or first name(s) of the customer
        /// </summary>
        /// <value>Given name(s) or first name(s) of the customer</value>
        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Surname(s) or last name(s) of the customer
        /// </summary>
        /// <value>Surname(s) or last name(s) of the customer</value>
        [DataMember(Name="surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Middle name - In between first name and surname - of the customer
        /// </summary>
        /// <value>Middle name - In between first name and surname - of the customer</value>
        [DataMember(Name="surnamePrefix")]
        public string SurnamePrefix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalNameBase {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  SurnamePrefix: ").Append(SurnamePrefix).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PersonalNameBase)obj);
        }

        /// <summary>
        /// Returns true if PersonalNameBase instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonalNameBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalNameBase other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    Surname == other.Surname ||
                    Surname != null &&
                    Surname.Equals(other.Surname)
                ) && 
                (
                    SurnamePrefix == other.SurnamePrefix ||
                    SurnamePrefix != null &&
                    SurnamePrefix.Equals(other.SurnamePrefix)
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
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (Surname != null)
                    hashCode = hashCode * 59 + Surname.GetHashCode();
                    if (SurnamePrefix != null)
                    hashCode = hashCode * 59 + SurnamePrefix.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PersonalNameBase left, PersonalNameBase right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PersonalNameBase left, PersonalNameBase right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
