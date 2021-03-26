/* 
 * SCILL API
 *
 * SCILL gives you the tools to activate, retain and grow your user base in your app or game by bringing you features well known in the gaming industry: Gamification. We take care of the services and technology involved so you can focus on your game and content.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@scillgame.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = SCILL.Client.SwaggerDateConverter;

namespace SCILL.Model
{
    /// <summary>
    /// Unlocking a battle pass requires some info to be sent so we can validate everything is ok
    /// </summary>
    [DataContract]
        public partial class BattlePassUnlockPayload :  IEquatable<BattlePassUnlockPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BattlePassUnlockPayload" /> class.
        /// </summary>
        /// <param name="purchasePrice">The purchase price. Set to 0 if this was free. The idea behind this is to provide information via an Admin Panel on average purchase price and to also allow showing users purchase info in their user account. (required).</param>
        /// <param name="purchaseCurrency">The currency (EUR, USD, etc) of the purchase price (required).</param>
        public BattlePassUnlockPayload(decimal? purchasePrice = default(decimal?), string purchaseCurrency = default(string))
        {
            // to ensure "purchasePrice" is required (not null)
            if (purchasePrice == null)
            {
                throw new InvalidDataException("purchasePrice is a required property for BattlePassUnlockPayload and cannot be null");
            }
            else
            {
                this.purchase_price = purchasePrice;
            }
            // to ensure "purchaseCurrency" is required (not null)
            if (purchaseCurrency == null)
            {
                throw new InvalidDataException("purchaseCurrency is a required property for BattlePassUnlockPayload and cannot be null");
            }
            else
            {
                this.purchase_currency = purchaseCurrency;
            }
        }
        
        /// <summary>
        /// The purchase price. Set to 0 if this was free. The idea behind this is to provide information via an Admin Panel on average purchase price and to also allow showing users purchase info in their user account.
        /// </summary>
        /// <value>The purchase price. Set to 0 if this was free. The idea behind this is to provide information via an Admin Panel on average purchase price and to also allow showing users purchase info in their user account.</value>
        [DataMember(Name="purchase_price", EmitDefaultValue=false)]
        public decimal? purchase_price { get; set; }

        /// <summary>
        /// The currency (EUR, USD, etc) of the purchase price
        /// </summary>
        /// <value>The currency (EUR, USD, etc) of the purchase price</value>
        [DataMember(Name="purchase_currency", EmitDefaultValue=false)]
        public string purchase_currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BattlePassUnlockPayload {\n");
            sb.Append("  purchase_price: ").Append(purchase_price).Append("\n");
            sb.Append("  purchase_currency: ").Append(purchase_currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BattlePassUnlockPayload);
        }

        /// <summary>
        /// Returns true if BattlePassUnlockPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of BattlePassUnlockPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BattlePassUnlockPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.purchase_price == input.purchase_price ||
                    (this.purchase_price != null &&
                    this.purchase_price.Equals(input.purchase_price))
                ) && 
                (
                    this.purchase_currency == input.purchase_currency ||
                    (this.purchase_currency != null &&
                    this.purchase_currency.Equals(input.purchase_currency))
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
                int hashCode = 41;
                if (this.purchase_price != null)
                    hashCode = hashCode * 59 + this.purchase_price.GetHashCode();
                if (this.purchase_currency != null)
                    hashCode = hashCode * 59 + this.purchase_currency.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
