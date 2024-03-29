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
    /// Object containing the specific input details for mobile payments
    /// </summary>
    [DataContract]
    public partial class MobilePaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput, IEquatable<MobilePaymentMethodSpecificInput>
    { 
        /// <summary>
        /// Determines the type of the authorization that will be used. Allowed values:   * FINAL_AUTHORIZATION - The payment creation results in an authorization that is ready for capture. Final authorizations can&#39;t be reversed and need to be captured for the full amount within 7 days.   * PRE_AUTHORIZATION - The payment creation results in a pre-authorization that is ready for capture. Pre-authortizations can be reversed and can be captured within 30 days. The capture amount can be lower than the authorized amount.   * SALE - The payment creation results in an authorization that is already captured at the moment of approval.    Only used with some acquirers, ingnored for acquirers that don&#39;t support this. In case the acquirer doesn&#39;t allow this to be specified the authorizationMode is &#39;unspecified&#39;, which behaves similar to a final authorization.
        /// </summary>
        /// <value>Determines the type of the authorization that will be used. Allowed values:   * FINAL_AUTHORIZATION - The payment creation results in an authorization that is ready for capture. Final authorizations can&#39;t be reversed and need to be captured for the full amount within 7 days.   * PRE_AUTHORIZATION - The payment creation results in a pre-authorization that is ready for capture. Pre-authortizations can be reversed and can be captured within 30 days. The capture amount can be lower than the authorized amount.   * SALE - The payment creation results in an authorization that is already captured at the moment of approval.    Only used with some acquirers, ingnored for acquirers that don&#39;t support this. In case the acquirer doesn&#39;t allow this to be specified the authorizationMode is &#39;unspecified&#39;, which behaves similar to a final authorization.</value>
        [DataMember(Name="authorizationMode")]
        public string AuthorizationMode { get; set; }

        /// <summary>
        /// Gets or Sets DecryptedPaymentData
        /// </summary>
        [DataMember(Name="decryptedPaymentData")]
        public DecryptedPaymentData DecryptedPaymentData { get; set; }

        /// <summary>
        /// The payment data if we will do the decryption of the encrypted payment data.   Typically you&#39;d use encryptedCustomerInput in the root of the create payment request to provide the encrypted payment data instead.   * For Apple Pay, the encrypted payment data can be found in property data of the PKPayment.token.paymentData property.
        /// </summary>
        /// <value>The payment data if we will do the decryption of the encrypted payment data.   Typically you&#39;d use encryptedCustomerInput in the root of the create payment request to provide the encrypted payment data instead.   * For Apple Pay, the encrypted payment data can be found in property data of the PKPayment.token.paymentData property.</value>
        [DataMember(Name="encryptedPaymentData")]
        public string EncryptedPaymentData { get; set; }

        /// <summary>
        /// Gets or Sets RequiresApproval
        /// </summary>
        [DataMember(Name="requiresApproval")]
        public bool? RequiresApproval { get; set; }

        /// <summary>
        ///    * true &#x3D; Fraud scoring will be skipped for this transaction   * false &#x3D; Fraud scoring will not be skipped for this transaction    Note: This is only possible if your account in our system is setup for Fraud scoring and if your configuration in our system allows you to override it per transaction.
        /// </summary>
        /// <value>   * true &#x3D; Fraud scoring will be skipped for this transaction   * false &#x3D; Fraud scoring will not be skipped for this transaction    Note: This is only possible if your account in our system is setup for Fraud scoring and if your configuration in our system allows you to override it per transaction.</value>
        [DataMember(Name="skipFraudService")]
        public bool? SkipFraudService { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transactionId")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobilePaymentMethodSpecificInput {\n");
            sb.Append("  AuthorizationMode: ").Append(AuthorizationMode).Append("\n");
            sb.Append("  DecryptedPaymentData: ").Append(DecryptedPaymentData).Append("\n");
            sb.Append("  EncryptedPaymentData: ").Append(EncryptedPaymentData).Append("\n");
            sb.Append("  RequiresApproval: ").Append(RequiresApproval).Append("\n");
            sb.Append("  SkipFraudService: ").Append(SkipFraudService).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MobilePaymentMethodSpecificInput)obj);
        }

        /// <summary>
        /// Returns true if MobilePaymentMethodSpecificInput instances are equal
        /// </summary>
        /// <param name="other">Instance of MobilePaymentMethodSpecificInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobilePaymentMethodSpecificInput other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AuthorizationMode == other.AuthorizationMode ||
                    AuthorizationMode != null &&
                    AuthorizationMode.Equals(other.AuthorizationMode)
                ) && 
                (
                    DecryptedPaymentData == other.DecryptedPaymentData ||
                    DecryptedPaymentData != null &&
                    DecryptedPaymentData.Equals(other.DecryptedPaymentData)
                ) && 
                (
                    EncryptedPaymentData == other.EncryptedPaymentData ||
                    EncryptedPaymentData != null &&
                    EncryptedPaymentData.Equals(other.EncryptedPaymentData)
                ) && 
                (
                    RequiresApproval == other.RequiresApproval ||
                    RequiresApproval != null &&
                    RequiresApproval.Equals(other.RequiresApproval)
                ) && 
                (
                    SkipFraudService == other.SkipFraudService ||
                    SkipFraudService != null &&
                    SkipFraudService.Equals(other.SkipFraudService)
                ) && 
                (
                    TransactionId == other.TransactionId ||
                    TransactionId != null &&
                    TransactionId.Equals(other.TransactionId)
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
                    if (AuthorizationMode != null)
                    hashCode = hashCode * 59 + AuthorizationMode.GetHashCode();
                    if (DecryptedPaymentData != null)
                    hashCode = hashCode * 59 + DecryptedPaymentData.GetHashCode();
                    if (EncryptedPaymentData != null)
                    hashCode = hashCode * 59 + EncryptedPaymentData.GetHashCode();
                    if (RequiresApproval != null)
                    hashCode = hashCode * 59 + RequiresApproval.GetHashCode();
                    if (SkipFraudService != null)
                    hashCode = hashCode * 59 + SkipFraudService.GetHashCode();
                    if (TransactionId != null)
                    hashCode = hashCode * 59 + TransactionId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MobilePaymentMethodSpecificInput left, MobilePaymentMethodSpecificInput right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MobilePaymentMethodSpecificInput left, MobilePaymentMethodSpecificInput right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
