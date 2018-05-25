/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.2.0
 * 
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
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// LoanContractShipping
    /// </summary>
    [DataContract]
    public partial class LoanContractShipping :  IEquatable<LoanContractShipping>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ActualShipDate
        /// </summary>
        [DataMember(Name="actualShipDate", EmitDefaultValue=false)]
        public DateTime? ActualShipDate { get; set; }

        /// <summary>
        /// Gets or Sets CarrierName
        /// </summary>
        [DataMember(Name="carrierName", EmitDefaultValue=false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or Sets DownPaymentAmount
        /// </summary>
        [DataMember(Name="downPaymentAmount", EmitDefaultValue=false)]
        public double? DownPaymentAmount { get; set; }

        /// <summary>
        /// Gets or Sets InvestorDeliveryDate
        /// </summary>
        [DataMember(Name="investorDeliveryDate", EmitDefaultValue=false)]
        public DateTime? InvestorDeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets PackageTrackingNumber
        /// </summary>
        [DataMember(Name="packageTrackingNumber", EmitDefaultValue=false)]
        public string PackageTrackingNumber { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalFileStorageComments
        /// </summary>
        [DataMember(Name="physicalFileStorageComments", EmitDefaultValue=false)]
        public string PhysicalFileStorageComments { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalFileStorageId
        /// </summary>
        [DataMember(Name="physicalFileStorageId", EmitDefaultValue=false)]
        public string PhysicalFileStorageId { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalFileStorageLocation
        /// </summary>
        [DataMember(Name="physicalFileStorageLocation", EmitDefaultValue=false)]
        public string PhysicalFileStorageLocation { get; set; }

        /// <summary>
        /// Gets or Sets RecordingNumber
        /// </summary>
        [DataMember(Name="recordingNumber", EmitDefaultValue=false)]
        public string RecordingNumber { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentMethod
        /// </summary>
        [DataMember(Name="shipmentMethod", EmitDefaultValue=false)]
        public string ShipmentMethod { get; set; }

        /// <summary>
        /// Gets or Sets ShipperName
        /// </summary>
        [DataMember(Name="shipperName", EmitDefaultValue=false)]
        public string ShipperName { get; set; }

        /// <summary>
        /// Gets or Sets ShippingContacts
        /// </summary>
        [DataMember(Name="shippingContacts", EmitDefaultValue=false)]
        public List<LoanContractShippingShippingContacts> ShippingContacts { get; set; }

        /// <summary>
        /// Gets or Sets TargetDeliveryDate
        /// </summary>
        [DataMember(Name="targetDeliveryDate", EmitDefaultValue=false)]
        public DateTime? TargetDeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets PoolID
        /// </summary>
        [DataMember(Name="poolID", EmitDefaultValue=false)]
        public string PoolID { get; set; }

        /// <summary>
        /// Gets or Sets PoolNumber
        /// </summary>
        [DataMember(Name="poolNumber", EmitDefaultValue=false)]
        public string PoolNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractShipping {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActualShipDate: ").Append(ActualShipDate).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  DownPaymentAmount: ").Append(DownPaymentAmount).Append("\n");
            sb.Append("  InvestorDeliveryDate: ").Append(InvestorDeliveryDate).Append("\n");
            sb.Append("  PackageTrackingNumber: ").Append(PackageTrackingNumber).Append("\n");
            sb.Append("  PhysicalFileStorageComments: ").Append(PhysicalFileStorageComments).Append("\n");
            sb.Append("  PhysicalFileStorageId: ").Append(PhysicalFileStorageId).Append("\n");
            sb.Append("  PhysicalFileStorageLocation: ").Append(PhysicalFileStorageLocation).Append("\n");
            sb.Append("  RecordingNumber: ").Append(RecordingNumber).Append("\n");
            sb.Append("  ShipmentMethod: ").Append(ShipmentMethod).Append("\n");
            sb.Append("  ShipperName: ").Append(ShipperName).Append("\n");
            sb.Append("  ShippingContacts: ").Append(ShippingContacts).Append("\n");
            sb.Append("  TargetDeliveryDate: ").Append(TargetDeliveryDate).Append("\n");
            sb.Append("  PoolID: ").Append(PoolID).Append("\n");
            sb.Append("  PoolNumber: ").Append(PoolNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as LoanContractShipping);
        }

        /// <summary>
        /// Returns true if LoanContractShipping instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractShipping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractShipping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ActualShipDate == input.ActualShipDate ||
                    (this.ActualShipDate != null &&
                    this.ActualShipDate.Equals(input.ActualShipDate))
                ) && 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.DownPaymentAmount == input.DownPaymentAmount ||
                    (this.DownPaymentAmount != null &&
                    this.DownPaymentAmount.Equals(input.DownPaymentAmount))
                ) && 
                (
                    this.InvestorDeliveryDate == input.InvestorDeliveryDate ||
                    (this.InvestorDeliveryDate != null &&
                    this.InvestorDeliveryDate.Equals(input.InvestorDeliveryDate))
                ) && 
                (
                    this.PackageTrackingNumber == input.PackageTrackingNumber ||
                    (this.PackageTrackingNumber != null &&
                    this.PackageTrackingNumber.Equals(input.PackageTrackingNumber))
                ) && 
                (
                    this.PhysicalFileStorageComments == input.PhysicalFileStorageComments ||
                    (this.PhysicalFileStorageComments != null &&
                    this.PhysicalFileStorageComments.Equals(input.PhysicalFileStorageComments))
                ) && 
                (
                    this.PhysicalFileStorageId == input.PhysicalFileStorageId ||
                    (this.PhysicalFileStorageId != null &&
                    this.PhysicalFileStorageId.Equals(input.PhysicalFileStorageId))
                ) && 
                (
                    this.PhysicalFileStorageLocation == input.PhysicalFileStorageLocation ||
                    (this.PhysicalFileStorageLocation != null &&
                    this.PhysicalFileStorageLocation.Equals(input.PhysicalFileStorageLocation))
                ) && 
                (
                    this.RecordingNumber == input.RecordingNumber ||
                    (this.RecordingNumber != null &&
                    this.RecordingNumber.Equals(input.RecordingNumber))
                ) && 
                (
                    this.ShipmentMethod == input.ShipmentMethod ||
                    (this.ShipmentMethod != null &&
                    this.ShipmentMethod.Equals(input.ShipmentMethod))
                ) && 
                (
                    this.ShipperName == input.ShipperName ||
                    (this.ShipperName != null &&
                    this.ShipperName.Equals(input.ShipperName))
                ) && 
                (
                    this.ShippingContacts == input.ShippingContacts ||
                    this.ShippingContacts != null &&
                    this.ShippingContacts.SequenceEqual(input.ShippingContacts)
                ) && 
                (
                    this.TargetDeliveryDate == input.TargetDeliveryDate ||
                    (this.TargetDeliveryDate != null &&
                    this.TargetDeliveryDate.Equals(input.TargetDeliveryDate))
                ) && 
                (
                    this.PoolID == input.PoolID ||
                    (this.PoolID != null &&
                    this.PoolID.Equals(input.PoolID))
                ) && 
                (
                    this.PoolNumber == input.PoolNumber ||
                    (this.PoolNumber != null &&
                    this.PoolNumber.Equals(input.PoolNumber))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ActualShipDate != null)
                    hashCode = hashCode * 59 + this.ActualShipDate.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.DownPaymentAmount != null)
                    hashCode = hashCode * 59 + this.DownPaymentAmount.GetHashCode();
                if (this.InvestorDeliveryDate != null)
                    hashCode = hashCode * 59 + this.InvestorDeliveryDate.GetHashCode();
                if (this.PackageTrackingNumber != null)
                    hashCode = hashCode * 59 + this.PackageTrackingNumber.GetHashCode();
                if (this.PhysicalFileStorageComments != null)
                    hashCode = hashCode * 59 + this.PhysicalFileStorageComments.GetHashCode();
                if (this.PhysicalFileStorageId != null)
                    hashCode = hashCode * 59 + this.PhysicalFileStorageId.GetHashCode();
                if (this.PhysicalFileStorageLocation != null)
                    hashCode = hashCode * 59 + this.PhysicalFileStorageLocation.GetHashCode();
                if (this.RecordingNumber != null)
                    hashCode = hashCode * 59 + this.RecordingNumber.GetHashCode();
                if (this.ShipmentMethod != null)
                    hashCode = hashCode * 59 + this.ShipmentMethod.GetHashCode();
                if (this.ShipperName != null)
                    hashCode = hashCode * 59 + this.ShipperName.GetHashCode();
                if (this.ShippingContacts != null)
                    hashCode = hashCode * 59 + this.ShippingContacts.GetHashCode();
                if (this.TargetDeliveryDate != null)
                    hashCode = hashCode * 59 + this.TargetDeliveryDate.GetHashCode();
                if (this.PoolID != null)
                    hashCode = hashCode * 59 + this.PoolID.GetHashCode();
                if (this.PoolNumber != null)
                    hashCode = hashCode * 59 + this.PoolNumber.GetHashCode();
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
