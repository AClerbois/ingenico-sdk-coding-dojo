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
    public partial class Customer : CustomerBase, IEquatable<Customer>
    { 
        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name="contactDetails")]
        public ContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Fiscal registration number of the customer (CPF) with a length of 11 or the tax registration number of the company for a business customer (CNPJ) with a length of 14.
        /// </summary>
        /// <value>Fiscal registration number of the customer (CPF) with a length of 11 or the tax registration number of the company for a business customer (CNPJ) with a length of 14.</value>
        [DataMember(Name="fiscalNumber")]
        public string FiscalNumber { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets PersonalInformation
        /// </summary>
        [DataMember(Name="personalInformation")]
        public PersonalInformation PersonalInformation { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shippingAddress")]
        public AddressPersonal ShippingAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Customer {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
            sb.Append("  FiscalNumber: ").Append(FiscalNumber).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  PersonalInformation: ").Append(PersonalInformation).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Customer)obj);
        }

        /// <summary>
        /// Returns true if Customer instances are equal
        /// </summary>
        /// <param name="other">Instance of Customer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Customer other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BillingAddress == other.BillingAddress ||
                    BillingAddress != null &&
                    BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    ContactDetails == other.ContactDetails ||
                    ContactDetails != null &&
                    ContactDetails.Equals(other.ContactDetails)
                ) && 
                (
                    FiscalNumber == other.FiscalNumber ||
                    FiscalNumber != null &&
                    FiscalNumber.Equals(other.FiscalNumber)
                ) && 
                (
                    Locale == other.Locale ||
                    Locale != null &&
                    Locale.Equals(other.Locale)
                ) && 
                (
                    PersonalInformation == other.PersonalInformation ||
                    PersonalInformation != null &&
                    PersonalInformation.Equals(other.PersonalInformation)
                ) && 
                (
                    ShippingAddress == other.ShippingAddress ||
                    ShippingAddress != null &&
                    ShippingAddress.Equals(other.ShippingAddress)
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
                    if (BillingAddress != null)
                    hashCode = hashCode * 59 + BillingAddress.GetHashCode();
                    if (ContactDetails != null)
                    hashCode = hashCode * 59 + ContactDetails.GetHashCode();
                    if (FiscalNumber != null)
                    hashCode = hashCode * 59 + FiscalNumber.GetHashCode();
                    if (Locale != null)
                    hashCode = hashCode * 59 + Locale.GetHashCode();
                    if (PersonalInformation != null)
                    hashCode = hashCode * 59 + PersonalInformation.GetHashCode();
                    if (ShippingAddress != null)
                    hashCode = hashCode * 59 + ShippingAddress.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Customer left, Customer right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Customer left, Customer right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
