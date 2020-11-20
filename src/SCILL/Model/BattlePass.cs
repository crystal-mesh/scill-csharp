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
    /// BattlePass
    /// </summary>
    [DataContract]
        public partial class BattlePass :  IEquatable<BattlePass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BattlePass" /> class.
        /// </summary>
        /// <param name="battlePassId">The unique id of this battle pass. (required).</param>
        /// <param name="appId">The unique id of the app (required).</param>
        /// <param name="battlePassName">The name of the battle bass. You can set that in the Admin Panel. The language is set with the query parameter language. See documentation for more info on that..</param>
        /// <param name="battlePassDescription">The description of the battle bass. You can set that in the Admin Panel and it can also be HTML. The language is set with the query parameter language. See documentation for more info on that..</param>
        /// <param name="battlePassShortDescription">A short description of the battle bass. You can set that in the Admin Panel and it can also be HTML. The language is set with the query parameter language. See documentation for more info on that..</param>
        /// <param name="battlePassDisclaimer">Use this to provide some terms and conditions following along this battle passes purchase..</param>
        /// <param name="battlePassPriority">The priority of the battle pass. I.e. if multiple are available you can use this field to sort them..</param>
        /// <param name="packageSkuIos">If you want to sell Battle Passes you can use this field to trigger in-app purchase products within your mobile app. You can set this value in the Admin Panel. This one is for iOS. (required).</param>
        /// <param name="packageSkuAndroid">If you want to sell Battle Passes you can use this field to trigger in-app purchase products within your mobile app. You can set this value in the Admin Panel. Use this to set the package string for Android. (required).</param>
        /// <param name="image">The mobile sized image name. For example you can use image and image_desktop to build a srcset in HTML or use them and size manually where you need them..</param>
        /// <param name="imageDesktop">The desktop sized image name or URL.</param>
        /// <param name="startDate">The date (in iso format) when the Battle Pass starts. Tracking begins once this date is passed. (required).</param>
        /// <param name="endDate">The date (in iso format) when the Battle Pass ends. Tracking stops once the end is reached and users will not be able to progress further than what they have achieved up to that point. (required).</param>
        /// <param name="readMoreLink">If the Battle Pass costs “money” you may want to route the user to a web site/page, where they can learn more about this battle pass. You can also use this field to route the user inside your application by providing a path or whatever works for you. (required).</param>
        /// <param name="isUnlockedIncrementally">Indicates if one level after the other must be activated or if users can activate whichever level they want. Typically battle passes are unlocked level by level, but if battle passes are used for other applications (like user referal programs) it can be useful to set this to false..</param>
        /// <param name="isActive">Indicated if this battle pass is active..</param>
        /// <param name="purchasedAt">The date in iso format when the user purchased/unlocked this Battle Pass..</param>
        /// <param name="canPurchaseWithMoney">Indicates that this Battle Pass can be purchased via in-app purchase. This can be set in the Admin Panel..</param>
        /// <param name="canPurchaseWithCoins">Indicates that this Battle Pass can be purchased with SCILL Coins. This can be set in the Admin Panel..</param>
        public BattlePass(string battlePassId = default(string), string appId = default(string), string battlePassName = default(string), string battlePassDescription = default(string), string battlePassShortDescription = default(string), string battlePassDisclaimer = default(string), int? battlePassPriority = default(int?), string packageSkuIos = default(string), string packageSkuAndroid = default(string), string image = default(string), string imageDesktop = default(string), string startDate = default(string), string endDate = default(string), string readMoreLink = default(string), bool? isUnlockedIncrementally = default(bool?), bool? isActive = default(bool?), string purchasedAt = default(string), bool? canPurchaseWithMoney = default(bool?), bool? canPurchaseWithCoins = default(bool?))
        {
            // to ensure "battlePassId" is required (not null)
            if (battlePassId == null)
            {
                throw new InvalidDataException("battlePassId is a required property for BattlePass and cannot be null");
            }
            else
            {
                this.battle_pass_id = battlePassId;
            }
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new InvalidDataException("appId is a required property for BattlePass and cannot be null");
            }
            else
            {
                this.app_id = appId;
            }
            // to ensure "packageSkuIos" is required (not null)
            if (packageSkuIos == null)
            {
                throw new InvalidDataException("packageSkuIos is a required property for BattlePass and cannot be null");
            }
            else
            {
                this.package_sku_ios = packageSkuIos;
            }
            // to ensure "packageSkuAndroid" is required (not null)
            if (packageSkuAndroid == null)
            {
                throw new InvalidDataException("packageSkuAndroid is a required property for BattlePass and cannot be null");
            }
            else
            {
                this.package_sku_android = packageSkuAndroid;
            }
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for BattlePass and cannot be null");
            }
            else
            {
                this.start_date = startDate;
            }
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new InvalidDataException("endDate is a required property for BattlePass and cannot be null");
            }
            else
            {
                this.end_date = endDate;
            }
            // to ensure "readMoreLink" is required (not null)
            if (readMoreLink == null)
            {
                throw new InvalidDataException("readMoreLink is a required property for BattlePass and cannot be null");
            }
            else
            {
                this.read_more_link = readMoreLink;
            }
            this.battle_pass_name = battlePassName;
            this.battle_pass_description = battlePassDescription;
            this.battle_pass_short_description = battlePassShortDescription;
            this.battle_pass_disclaimer = battlePassDisclaimer;
            this.battle_pass_priority = battlePassPriority;
            this.image = image;
            this.image_desktop = imageDesktop;
            this.is_unlocked_incrementally = isUnlockedIncrementally;
            this.is_active = isActive;
            this.purchased_at = purchasedAt;
            this.can_purchase_with_money = canPurchaseWithMoney;
            this.can_purchase_with_coins = canPurchaseWithCoins;
        }
        
        /// <summary>
        /// The unique id of this battle pass.
        /// </summary>
        /// <value>The unique id of this battle pass.</value>
        [DataMember(Name="battle_pass_id", EmitDefaultValue=false)]
        public string battle_pass_id { get; set; }

        /// <summary>
        /// The unique id of the app
        /// </summary>
        /// <value>The unique id of the app</value>
        [DataMember(Name="app_id", EmitDefaultValue=false)]
        public string app_id { get; set; }

        /// <summary>
        /// The name of the battle bass. You can set that in the Admin Panel. The language is set with the query parameter language. See documentation for more info on that.
        /// </summary>
        /// <value>The name of the battle bass. You can set that in the Admin Panel. The language is set with the query parameter language. See documentation for more info on that.</value>
        [DataMember(Name="battle_pass_name", EmitDefaultValue=false)]
        public string battle_pass_name { get; set; }

        /// <summary>
        /// The description of the battle bass. You can set that in the Admin Panel and it can also be HTML. The language is set with the query parameter language. See documentation for more info on that.
        /// </summary>
        /// <value>The description of the battle bass. You can set that in the Admin Panel and it can also be HTML. The language is set with the query parameter language. See documentation for more info on that.</value>
        [DataMember(Name="battle_pass_description", EmitDefaultValue=false)]
        public string battle_pass_description { get; set; }

        /// <summary>
        /// A short description of the battle bass. You can set that in the Admin Panel and it can also be HTML. The language is set with the query parameter language. See documentation for more info on that.
        /// </summary>
        /// <value>A short description of the battle bass. You can set that in the Admin Panel and it can also be HTML. The language is set with the query parameter language. See documentation for more info on that.</value>
        [DataMember(Name="battle_pass_short_description", EmitDefaultValue=false)]
        public string battle_pass_short_description { get; set; }

        /// <summary>
        /// Use this to provide some terms and conditions following along this battle passes purchase.
        /// </summary>
        /// <value>Use this to provide some terms and conditions following along this battle passes purchase.</value>
        [DataMember(Name="battle_pass_disclaimer", EmitDefaultValue=false)]
        public string battle_pass_disclaimer { get; set; }

        /// <summary>
        /// The priority of the battle pass. I.e. if multiple are available you can use this field to sort them.
        /// </summary>
        /// <value>The priority of the battle pass. I.e. if multiple are available you can use this field to sort them.</value>
        [DataMember(Name="battle_pass_priority", EmitDefaultValue=false)]
        public int? battle_pass_priority { get; set; }

        /// <summary>
        /// If you want to sell Battle Passes you can use this field to trigger in-app purchase products within your mobile app. You can set this value in the Admin Panel. This one is for iOS.
        /// </summary>
        /// <value>If you want to sell Battle Passes you can use this field to trigger in-app purchase products within your mobile app. You can set this value in the Admin Panel. This one is for iOS.</value>
        [DataMember(Name="package_sku_ios", EmitDefaultValue=false)]
        public string package_sku_ios { get; set; }

        /// <summary>
        /// If you want to sell Battle Passes you can use this field to trigger in-app purchase products within your mobile app. You can set this value in the Admin Panel. Use this to set the package string for Android.
        /// </summary>
        /// <value>If you want to sell Battle Passes you can use this field to trigger in-app purchase products within your mobile app. You can set this value in the Admin Panel. Use this to set the package string for Android.</value>
        [DataMember(Name="package_sku_android", EmitDefaultValue=false)]
        public string package_sku_android { get; set; }

        /// <summary>
        /// The mobile sized image name. For example you can use image and image_desktop to build a srcset in HTML or use them and size manually where you need them.
        /// </summary>
        /// <value>The mobile sized image name. For example you can use image and image_desktop to build a srcset in HTML or use them and size manually where you need them.</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string image { get; set; }

        /// <summary>
        /// The desktop sized image name or URL
        /// </summary>
        /// <value>The desktop sized image name or URL</value>
        [DataMember(Name="image_desktop", EmitDefaultValue=false)]
        public string image_desktop { get; set; }

        /// <summary>
        /// The date (in iso format) when the Battle Pass starts. Tracking begins once this date is passed.
        /// </summary>
        /// <value>The date (in iso format) when the Battle Pass starts. Tracking begins once this date is passed.</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string start_date { get; set; }

        /// <summary>
        /// The date (in iso format) when the Battle Pass ends. Tracking stops once the end is reached and users will not be able to progress further than what they have achieved up to that point.
        /// </summary>
        /// <value>The date (in iso format) when the Battle Pass ends. Tracking stops once the end is reached and users will not be able to progress further than what they have achieved up to that point.</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string end_date { get; set; }

        /// <summary>
        /// If the Battle Pass costs “money” you may want to route the user to a web site/page, where they can learn more about this battle pass. You can also use this field to route the user inside your application by providing a path or whatever works for you.
        /// </summary>
        /// <value>If the Battle Pass costs “money” you may want to route the user to a web site/page, where they can learn more about this battle pass. You can also use this field to route the user inside your application by providing a path or whatever works for you.</value>
        [DataMember(Name="read_more_link", EmitDefaultValue=false)]
        public string read_more_link { get; set; }

        /// <summary>
        /// Indicates if one level after the other must be activated or if users can activate whichever level they want. Typically battle passes are unlocked level by level, but if battle passes are used for other applications (like user referal programs) it can be useful to set this to false.
        /// </summary>
        /// <value>Indicates if one level after the other must be activated or if users can activate whichever level they want. Typically battle passes are unlocked level by level, but if battle passes are used for other applications (like user referal programs) it can be useful to set this to false.</value>
        [DataMember(Name="is_unlocked_incrementally", EmitDefaultValue=false)]
        public bool? is_unlocked_incrementally { get; set; }

        /// <summary>
        /// Indicated if this battle pass is active.
        /// </summary>
        /// <value>Indicated if this battle pass is active.</value>
        [DataMember(Name="is_active", EmitDefaultValue=false)]
        public bool? is_active { get; set; }

        /// <summary>
        /// The date in iso format when the user purchased/unlocked this Battle Pass.
        /// </summary>
        /// <value>The date in iso format when the user purchased/unlocked this Battle Pass.</value>
        [DataMember(Name="purchased_at", EmitDefaultValue=false)]
        public string purchased_at { get; set; }

        /// <summary>
        /// Indicates that this Battle Pass can be purchased via in-app purchase. This can be set in the Admin Panel.
        /// </summary>
        /// <value>Indicates that this Battle Pass can be purchased via in-app purchase. This can be set in the Admin Panel.</value>
        [DataMember(Name="can_purchase_with_money", EmitDefaultValue=false)]
        public bool? can_purchase_with_money { get; set; }

        /// <summary>
        /// Indicates that this Battle Pass can be purchased with SCILL Coins. This can be set in the Admin Panel.
        /// </summary>
        /// <value>Indicates that this Battle Pass can be purchased with SCILL Coins. This can be set in the Admin Panel.</value>
        [DataMember(Name="can_purchase_with_coins", EmitDefaultValue=false)]
        public bool? can_purchase_with_coins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BattlePass {\n");
            sb.Append("  battle_pass_id: ").Append(battle_pass_id).Append("\n");
            sb.Append("  app_id: ").Append(app_id).Append("\n");
            sb.Append("  battle_pass_name: ").Append(battle_pass_name).Append("\n");
            sb.Append("  battle_pass_description: ").Append(battle_pass_description).Append("\n");
            sb.Append("  battle_pass_short_description: ").Append(battle_pass_short_description).Append("\n");
            sb.Append("  battle_pass_disclaimer: ").Append(battle_pass_disclaimer).Append("\n");
            sb.Append("  battle_pass_priority: ").Append(battle_pass_priority).Append("\n");
            sb.Append("  package_sku_ios: ").Append(package_sku_ios).Append("\n");
            sb.Append("  package_sku_android: ").Append(package_sku_android).Append("\n");
            sb.Append("  image: ").Append(image).Append("\n");
            sb.Append("  image_desktop: ").Append(image_desktop).Append("\n");
            sb.Append("  start_date: ").Append(start_date).Append("\n");
            sb.Append("  end_date: ").Append(end_date).Append("\n");
            sb.Append("  read_more_link: ").Append(read_more_link).Append("\n");
            sb.Append("  is_unlocked_incrementally: ").Append(is_unlocked_incrementally).Append("\n");
            sb.Append("  is_active: ").Append(is_active).Append("\n");
            sb.Append("  purchased_at: ").Append(purchased_at).Append("\n");
            sb.Append("  can_purchase_with_money: ").Append(can_purchase_with_money).Append("\n");
            sb.Append("  can_purchase_with_coins: ").Append(can_purchase_with_coins).Append("\n");
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
            return this.Equals(input as BattlePass);
        }

        /// <summary>
        /// Returns true if BattlePass instances are equal
        /// </summary>
        /// <param name="input">Instance of BattlePass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BattlePass input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.battle_pass_id == input.battle_pass_id ||
                    (this.battle_pass_id != null &&
                    this.battle_pass_id.Equals(input.battle_pass_id))
                ) && 
                (
                    this.app_id == input.app_id ||
                    (this.app_id != null &&
                    this.app_id.Equals(input.app_id))
                ) && 
                (
                    this.battle_pass_name == input.battle_pass_name ||
                    (this.battle_pass_name != null &&
                    this.battle_pass_name.Equals(input.battle_pass_name))
                ) && 
                (
                    this.battle_pass_description == input.battle_pass_description ||
                    (this.battle_pass_description != null &&
                    this.battle_pass_description.Equals(input.battle_pass_description))
                ) && 
                (
                    this.battle_pass_short_description == input.battle_pass_short_description ||
                    (this.battle_pass_short_description != null &&
                    this.battle_pass_short_description.Equals(input.battle_pass_short_description))
                ) && 
                (
                    this.battle_pass_disclaimer == input.battle_pass_disclaimer ||
                    (this.battle_pass_disclaimer != null &&
                    this.battle_pass_disclaimer.Equals(input.battle_pass_disclaimer))
                ) && 
                (
                    this.battle_pass_priority == input.battle_pass_priority ||
                    (this.battle_pass_priority != null &&
                    this.battle_pass_priority.Equals(input.battle_pass_priority))
                ) && 
                (
                    this.package_sku_ios == input.package_sku_ios ||
                    (this.package_sku_ios != null &&
                    this.package_sku_ios.Equals(input.package_sku_ios))
                ) && 
                (
                    this.package_sku_android == input.package_sku_android ||
                    (this.package_sku_android != null &&
                    this.package_sku_android.Equals(input.package_sku_android))
                ) && 
                (
                    this.image == input.image ||
                    (this.image != null &&
                    this.image.Equals(input.image))
                ) && 
                (
                    this.image_desktop == input.image_desktop ||
                    (this.image_desktop != null &&
                    this.image_desktop.Equals(input.image_desktop))
                ) && 
                (
                    this.start_date == input.start_date ||
                    (this.start_date != null &&
                    this.start_date.Equals(input.start_date))
                ) && 
                (
                    this.end_date == input.end_date ||
                    (this.end_date != null &&
                    this.end_date.Equals(input.end_date))
                ) && 
                (
                    this.read_more_link == input.read_more_link ||
                    (this.read_more_link != null &&
                    this.read_more_link.Equals(input.read_more_link))
                ) && 
                (
                    this.is_unlocked_incrementally == input.is_unlocked_incrementally ||
                    (this.is_unlocked_incrementally != null &&
                    this.is_unlocked_incrementally.Equals(input.is_unlocked_incrementally))
                ) && 
                (
                    this.is_active == input.is_active ||
                    (this.is_active != null &&
                    this.is_active.Equals(input.is_active))
                ) && 
                (
                    this.purchased_at == input.purchased_at ||
                    (this.purchased_at != null &&
                    this.purchased_at.Equals(input.purchased_at))
                ) && 
                (
                    this.can_purchase_with_money == input.can_purchase_with_money ||
                    (this.can_purchase_with_money != null &&
                    this.can_purchase_with_money.Equals(input.can_purchase_with_money))
                ) && 
                (
                    this.can_purchase_with_coins == input.can_purchase_with_coins ||
                    (this.can_purchase_with_coins != null &&
                    this.can_purchase_with_coins.Equals(input.can_purchase_with_coins))
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
                if (this.battle_pass_id != null)
                    hashCode = hashCode * 59 + this.battle_pass_id.GetHashCode();
                if (this.app_id != null)
                    hashCode = hashCode * 59 + this.app_id.GetHashCode();
                if (this.battle_pass_name != null)
                    hashCode = hashCode * 59 + this.battle_pass_name.GetHashCode();
                if (this.battle_pass_description != null)
                    hashCode = hashCode * 59 + this.battle_pass_description.GetHashCode();
                if (this.battle_pass_short_description != null)
                    hashCode = hashCode * 59 + this.battle_pass_short_description.GetHashCode();
                if (this.battle_pass_disclaimer != null)
                    hashCode = hashCode * 59 + this.battle_pass_disclaimer.GetHashCode();
                if (this.battle_pass_priority != null)
                    hashCode = hashCode * 59 + this.battle_pass_priority.GetHashCode();
                if (this.package_sku_ios != null)
                    hashCode = hashCode * 59 + this.package_sku_ios.GetHashCode();
                if (this.package_sku_android != null)
                    hashCode = hashCode * 59 + this.package_sku_android.GetHashCode();
                if (this.image != null)
                    hashCode = hashCode * 59 + this.image.GetHashCode();
                if (this.image_desktop != null)
                    hashCode = hashCode * 59 + this.image_desktop.GetHashCode();
                if (this.start_date != null)
                    hashCode = hashCode * 59 + this.start_date.GetHashCode();
                if (this.end_date != null)
                    hashCode = hashCode * 59 + this.end_date.GetHashCode();
                if (this.read_more_link != null)
                    hashCode = hashCode * 59 + this.read_more_link.GetHashCode();
                if (this.is_unlocked_incrementally != null)
                    hashCode = hashCode * 59 + this.is_unlocked_incrementally.GetHashCode();
                if (this.is_active != null)
                    hashCode = hashCode * 59 + this.is_active.GetHashCode();
                if (this.purchased_at != null)
                    hashCode = hashCode * 59 + this.purchased_at.GetHashCode();
                if (this.can_purchase_with_money != null)
                    hashCode = hashCode * 59 + this.can_purchase_with_money.GetHashCode();
                if (this.can_purchase_with_coins != null)
                    hashCode = hashCode * 59 + this.can_purchase_with_coins.GetHashCode();
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
