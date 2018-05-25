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
    /// LoanContractHudLoanDataSecondaryFinancingProviders
    /// </summary>
    [DataContract]
    public partial class LoanContractHudLoanDataSecondaryFinancingProviders :  IEquatable<LoanContractHudLoanDataSecondaryFinancingProviders>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FinancingAmount
        /// </summary>
        [DataMember(Name="financingAmount", EmitDefaultValue=false)]
        public double? FinancingAmount { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryFinancingProviderType
        /// </summary>
        [DataMember(Name="secondaryFinancingProviderType", EmitDefaultValue=false)]
        public string SecondaryFinancingProviderType { get; set; }

        /// <summary>
        /// Gets or Sets SellerFundedDapIndicator
        /// </summary>
        [DataMember(Name="sellerFundedDapIndicator", EmitDefaultValue=false)]
        public bool? SellerFundedDapIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets SourceFromFamilyIndicator
        /// </summary>
        [DataMember(Name="sourceFromFamilyIndicator", EmitDefaultValue=false)]
        public bool? SourceFromFamilyIndicator { get; set; }

        /// <summary>
        /// Gets or Sets SourceFromGovernmentIndicator
        /// </summary>
        [DataMember(Name="sourceFromGovernmentIndicator", EmitDefaultValue=false)]
        public bool? SourceFromGovernmentIndicator { get; set; }

        /// <summary>
        /// Gets or Sets SourceFromNPIndicator
        /// </summary>
        [DataMember(Name="sourceFromNPIndicator", EmitDefaultValue=false)]
        public bool? SourceFromNPIndicator { get; set; }

        /// <summary>
        /// Gets or Sets SourceFromOtherIndicator
        /// </summary>
        [DataMember(Name="sourceFromOtherIndicator", EmitDefaultValue=false)]
        public bool? SourceFromOtherIndicator { get; set; }

        /// <summary>
        /// Gets or Sets SourceOtherDetail
        /// </summary>
        [DataMember(Name="sourceOtherDetail", EmitDefaultValue=false)]
        public string SourceOtherDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractHudLoanDataSecondaryFinancingProviders {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FinancingAmount: ").Append(FinancingAmount).Append("\n");
            sb.Append("  SecondaryFinancingProviderType: ").Append(SecondaryFinancingProviderType).Append("\n");
            sb.Append("  SellerFundedDapIndicator: ").Append(SellerFundedDapIndicator).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SourceFromFamilyIndicator: ").Append(SourceFromFamilyIndicator).Append("\n");
            sb.Append("  SourceFromGovernmentIndicator: ").Append(SourceFromGovernmentIndicator).Append("\n");
            sb.Append("  SourceFromNPIndicator: ").Append(SourceFromNPIndicator).Append("\n");
            sb.Append("  SourceFromOtherIndicator: ").Append(SourceFromOtherIndicator).Append("\n");
            sb.Append("  SourceOtherDetail: ").Append(SourceOtherDetail).Append("\n");
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
            return this.Equals(input as LoanContractHudLoanDataSecondaryFinancingProviders);
        }

        /// <summary>
        /// Returns true if LoanContractHudLoanDataSecondaryFinancingProviders instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractHudLoanDataSecondaryFinancingProviders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractHudLoanDataSecondaryFinancingProviders input)
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
                    this.FinancingAmount == input.FinancingAmount ||
                    (this.FinancingAmount != null &&
                    this.FinancingAmount.Equals(input.FinancingAmount))
                ) && 
                (
                    this.SecondaryFinancingProviderType == input.SecondaryFinancingProviderType ||
                    (this.SecondaryFinancingProviderType != null &&
                    this.SecondaryFinancingProviderType.Equals(input.SecondaryFinancingProviderType))
                ) && 
                (
                    this.SellerFundedDapIndicator == input.SellerFundedDapIndicator ||
                    (this.SellerFundedDapIndicator != null &&
                    this.SellerFundedDapIndicator.Equals(input.SellerFundedDapIndicator))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.SourceFromFamilyIndicator == input.SourceFromFamilyIndicator ||
                    (this.SourceFromFamilyIndicator != null &&
                    this.SourceFromFamilyIndicator.Equals(input.SourceFromFamilyIndicator))
                ) && 
                (
                    this.SourceFromGovernmentIndicator == input.SourceFromGovernmentIndicator ||
                    (this.SourceFromGovernmentIndicator != null &&
                    this.SourceFromGovernmentIndicator.Equals(input.SourceFromGovernmentIndicator))
                ) && 
                (
                    this.SourceFromNPIndicator == input.SourceFromNPIndicator ||
                    (this.SourceFromNPIndicator != null &&
                    this.SourceFromNPIndicator.Equals(input.SourceFromNPIndicator))
                ) && 
                (
                    this.SourceFromOtherIndicator == input.SourceFromOtherIndicator ||
                    (this.SourceFromOtherIndicator != null &&
                    this.SourceFromOtherIndicator.Equals(input.SourceFromOtherIndicator))
                ) && 
                (
                    this.SourceOtherDetail == input.SourceOtherDetail ||
                    (this.SourceOtherDetail != null &&
                    this.SourceOtherDetail.Equals(input.SourceOtherDetail))
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
                if (this.FinancingAmount != null)
                    hashCode = hashCode * 59 + this.FinancingAmount.GetHashCode();
                if (this.SecondaryFinancingProviderType != null)
                    hashCode = hashCode * 59 + this.SecondaryFinancingProviderType.GetHashCode();
                if (this.SellerFundedDapIndicator != null)
                    hashCode = hashCode * 59 + this.SellerFundedDapIndicator.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SourceFromFamilyIndicator != null)
                    hashCode = hashCode * 59 + this.SourceFromFamilyIndicator.GetHashCode();
                if (this.SourceFromGovernmentIndicator != null)
                    hashCode = hashCode * 59 + this.SourceFromGovernmentIndicator.GetHashCode();
                if (this.SourceFromNPIndicator != null)
                    hashCode = hashCode * 59 + this.SourceFromNPIndicator.GetHashCode();
                if (this.SourceFromOtherIndicator != null)
                    hashCode = hashCode * 59 + this.SourceFromOtherIndicator.GetHashCode();
                if (this.SourceOtherDetail != null)
                    hashCode = hashCode * 59 + this.SourceOtherDetail.GetHashCode();
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
