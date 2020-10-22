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
    /// BattlePassLevelId
    /// </summary>
    [DataContract]
        public partial class BattlePassLevelId :  IEquatable<BattlePassLevelId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BattlePassLevelId" /> class.
        /// </summary>
        /// <param name="battlePassLevelId">The level id, i.e. battle_pass_level_id of the BattlePassLevel object (required).</param>
        public BattlePassLevelId(string battlePassLevelId = default(string))
        {
            // to ensure "battlePassLevelId" is required (not null)
            if (battlePassLevelId == null)
            {
                throw new InvalidDataException("battlePassLevelId is a required property for BattlePassLevelId and cannot be null");
            }
            else
            {
                this.battle_pass_level_id = battlePassLevelId;
            }
        }
        
        /// <summary>
        /// The level id, i.e. battle_pass_level_id of the BattlePassLevel object
        /// </summary>
        /// <value>The level id, i.e. battle_pass_level_id of the BattlePassLevel object</value>
        [DataMember(Name="battle_pass_level_id", EmitDefaultValue=false)]
        public string battle_pass_level_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BattlePassLevelId {\n");
            sb.Append("  battle_pass_level_id: ").Append(battle_pass_level_id).Append("\n");
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
            return this.Equals(input as BattlePassLevelId);
        }

        /// <summary>
        /// Returns true if BattlePassLevelId instances are equal
        /// </summary>
        /// <param name="input">Instance of BattlePassLevelId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BattlePassLevelId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.battle_pass_level_id == input.battle_pass_level_id ||
                    (this.battle_pass_level_id != null &&
                    this.battle_pass_level_id.Equals(input.battle_pass_level_id))
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
                if (this.battle_pass_level_id != null)
                    hashCode = hashCode * 59 + this.battle_pass_level_id.GetHashCode();
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
