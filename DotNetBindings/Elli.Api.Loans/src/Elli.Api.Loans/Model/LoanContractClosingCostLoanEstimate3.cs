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
    /// LoanContractClosingCostLoanEstimate3
    /// </summary>
    [DataContract]
    public partial class LoanContractClosingCostLoanEstimate3 :  IEquatable<LoanContractClosingCostLoanEstimate3>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LenderLicenseID
        /// </summary>
        [DataMember(Name="lenderLicenseID", EmitDefaultValue=false)]
        public string LenderLicenseID { get; set; }

        /// <summary>
        /// Gets or Sets LenderEmail
        /// </summary>
        [DataMember(Name="lenderEmail", EmitDefaultValue=false)]
        public string LenderEmail { get; set; }

        /// <summary>
        /// Gets or Sets LenderPhone
        /// </summary>
        [DataMember(Name="lenderPhone", EmitDefaultValue=false)]
        public string LenderPhone { get; set; }

        /// <summary>
        /// Gets or Sets LenderLoanOfficer
        /// </summary>
        [DataMember(Name="lenderLoanOfficer", EmitDefaultValue=false)]
        public string LenderLoanOfficer { get; set; }

        /// <summary>
        /// Gets or Sets LenderLoanOfficerNMLSId
        /// </summary>
        [DataMember(Name="lenderLoanOfficerNMLSId", EmitDefaultValue=false)]
        public string LenderLoanOfficerNMLSId { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBrokerLicenseID
        /// </summary>
        [DataMember(Name="mortgageBrokerLicenseID", EmitDefaultValue=false)]
        public string MortgageBrokerLicenseID { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBrokerEmail
        /// </summary>
        [DataMember(Name="mortgageBrokerEmail", EmitDefaultValue=false)]
        public string MortgageBrokerEmail { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBrokerPhone
        /// </summary>
        [DataMember(Name="mortgageBrokerPhone", EmitDefaultValue=false)]
        public string MortgageBrokerPhone { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBrokerLoanOfficer
        /// </summary>
        [DataMember(Name="mortgageBrokerLoanOfficer", EmitDefaultValue=false)]
        public string MortgageBrokerLoanOfficer { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBrokerLoanOfficerNMLSId
        /// </summary>
        [DataMember(Name="mortgageBrokerLoanOfficerNMLSId", EmitDefaultValue=false)]
        public string MortgageBrokerLoanOfficerNMLSId { get; set; }

        /// <summary>
        /// Gets or Sets Appraisal
        /// </summary>
        [DataMember(Name="appraisal", EmitDefaultValue=false)]
        public string Appraisal { get; set; }

        /// <summary>
        /// Gets or Sets Assumption
        /// </summary>
        [DataMember(Name="assumption", EmitDefaultValue=false)]
        public string Assumption { get; set; }

        /// <summary>
        /// Gets or Sets HomeownerInsurance
        /// </summary>
        [DataMember(Name="homeownerInsurance", EmitDefaultValue=false)]
        public bool? HomeownerInsurance { get; set; }

        /// <summary>
        /// Gets or Sets Servicing
        /// </summary>
        [DataMember(Name="servicing", EmitDefaultValue=false)]
        public string Servicing { get; set; }

        /// <summary>
        /// Gets or Sets ConstructionLoan
        /// </summary>
        [DataMember(Name="constructionLoan", EmitDefaultValue=false)]
        public bool? ConstructionLoan { get; set; }

        /// <summary>
        /// Gets or Sets TotalInterestPercentage
        /// </summary>
        [DataMember(Name="totalInterestPercentage", EmitDefaultValue=false)]
        public double? TotalInterestPercentage { get; set; }

        /// <summary>
        /// Gets or Sets TotalInterestPercentageUI
        /// </summary>
        [DataMember(Name="totalInterestPercentageUI", EmitDefaultValue=false)]
        public string TotalInterestPercentageUI { get; set; }

        /// <summary>
        /// Gets or Sets In5YearsTotalYouWillHavePaid
        /// </summary>
        [DataMember(Name="in5YearsTotalYouWillHavePaid", EmitDefaultValue=false)]
        public int? In5YearsTotalYouWillHavePaid { get; set; }

        /// <summary>
        /// Gets or Sets In5YearsPrincipalYouWillHavePaidOff
        /// </summary>
        [DataMember(Name="in5YearsPrincipalYouWillHavePaidOff", EmitDefaultValue=false)]
        public int? In5YearsPrincipalYouWillHavePaidOff { get; set; }

        /// <summary>
        /// Gets or Sets SignatureType
        /// </summary>
        [DataMember(Name="signatureType", EmitDefaultValue=false)]
        public string SignatureType { get; set; }

        /// <summary>
        /// Gets or Sets LenderLicenseState
        /// </summary>
        [DataMember(Name="lenderLicenseState", EmitDefaultValue=false)]
        public string LenderLicenseState { get; set; }

        /// <summary>
        /// Gets or Sets LenderLoanOfficerLicenseState
        /// </summary>
        [DataMember(Name="lenderLoanOfficerLicenseState", EmitDefaultValue=false)]
        public string LenderLoanOfficerLicenseState { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBrokerLicenseState
        /// </summary>
        [DataMember(Name="mortgageBrokerLicenseState", EmitDefaultValue=false)]
        public string MortgageBrokerLicenseState { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBrokerLoanOfficerLicenseState
        /// </summary>
        [DataMember(Name="mortgageBrokerLoanOfficerLicenseState", EmitDefaultValue=false)]
        public string MortgageBrokerLoanOfficerLicenseState { get; set; }

        /// <summary>
        /// Gets or Sets MortgageLenderLoanOfficerLicenseID
        /// </summary>
        [DataMember(Name="mortgageLenderLoanOfficerLicenseID", EmitDefaultValue=false)]
        public string MortgageLenderLoanOfficerLicenseID { get; set; }

        /// <summary>
        /// Gets or Sets MortgageBrokerLoanOfficerLicenseID
        /// </summary>
        [DataMember(Name="mortgageBrokerLoanOfficerLicenseID", EmitDefaultValue=false)]
        public string MortgageBrokerLoanOfficerLicenseID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractClosingCostLoanEstimate3 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LenderLicenseID: ").Append(LenderLicenseID).Append("\n");
            sb.Append("  LenderEmail: ").Append(LenderEmail).Append("\n");
            sb.Append("  LenderPhone: ").Append(LenderPhone).Append("\n");
            sb.Append("  LenderLoanOfficer: ").Append(LenderLoanOfficer).Append("\n");
            sb.Append("  LenderLoanOfficerNMLSId: ").Append(LenderLoanOfficerNMLSId).Append("\n");
            sb.Append("  MortgageBrokerLicenseID: ").Append(MortgageBrokerLicenseID).Append("\n");
            sb.Append("  MortgageBrokerEmail: ").Append(MortgageBrokerEmail).Append("\n");
            sb.Append("  MortgageBrokerPhone: ").Append(MortgageBrokerPhone).Append("\n");
            sb.Append("  MortgageBrokerLoanOfficer: ").Append(MortgageBrokerLoanOfficer).Append("\n");
            sb.Append("  MortgageBrokerLoanOfficerNMLSId: ").Append(MortgageBrokerLoanOfficerNMLSId).Append("\n");
            sb.Append("  Appraisal: ").Append(Appraisal).Append("\n");
            sb.Append("  Assumption: ").Append(Assumption).Append("\n");
            sb.Append("  HomeownerInsurance: ").Append(HomeownerInsurance).Append("\n");
            sb.Append("  Servicing: ").Append(Servicing).Append("\n");
            sb.Append("  ConstructionLoan: ").Append(ConstructionLoan).Append("\n");
            sb.Append("  TotalInterestPercentage: ").Append(TotalInterestPercentage).Append("\n");
            sb.Append("  TotalInterestPercentageUI: ").Append(TotalInterestPercentageUI).Append("\n");
            sb.Append("  In5YearsTotalYouWillHavePaid: ").Append(In5YearsTotalYouWillHavePaid).Append("\n");
            sb.Append("  In5YearsPrincipalYouWillHavePaidOff: ").Append(In5YearsPrincipalYouWillHavePaidOff).Append("\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  LenderLicenseState: ").Append(LenderLicenseState).Append("\n");
            sb.Append("  LenderLoanOfficerLicenseState: ").Append(LenderLoanOfficerLicenseState).Append("\n");
            sb.Append("  MortgageBrokerLicenseState: ").Append(MortgageBrokerLicenseState).Append("\n");
            sb.Append("  MortgageBrokerLoanOfficerLicenseState: ").Append(MortgageBrokerLoanOfficerLicenseState).Append("\n");
            sb.Append("  MortgageLenderLoanOfficerLicenseID: ").Append(MortgageLenderLoanOfficerLicenseID).Append("\n");
            sb.Append("  MortgageBrokerLoanOfficerLicenseID: ").Append(MortgageBrokerLoanOfficerLicenseID).Append("\n");
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
            return this.Equals(input as LoanContractClosingCostLoanEstimate3);
        }

        /// <summary>
        /// Returns true if LoanContractClosingCostLoanEstimate3 instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractClosingCostLoanEstimate3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractClosingCostLoanEstimate3 input)
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
                    this.LenderLicenseID == input.LenderLicenseID ||
                    (this.LenderLicenseID != null &&
                    this.LenderLicenseID.Equals(input.LenderLicenseID))
                ) && 
                (
                    this.LenderEmail == input.LenderEmail ||
                    (this.LenderEmail != null &&
                    this.LenderEmail.Equals(input.LenderEmail))
                ) && 
                (
                    this.LenderPhone == input.LenderPhone ||
                    (this.LenderPhone != null &&
                    this.LenderPhone.Equals(input.LenderPhone))
                ) && 
                (
                    this.LenderLoanOfficer == input.LenderLoanOfficer ||
                    (this.LenderLoanOfficer != null &&
                    this.LenderLoanOfficer.Equals(input.LenderLoanOfficer))
                ) && 
                (
                    this.LenderLoanOfficerNMLSId == input.LenderLoanOfficerNMLSId ||
                    (this.LenderLoanOfficerNMLSId != null &&
                    this.LenderLoanOfficerNMLSId.Equals(input.LenderLoanOfficerNMLSId))
                ) && 
                (
                    this.MortgageBrokerLicenseID == input.MortgageBrokerLicenseID ||
                    (this.MortgageBrokerLicenseID != null &&
                    this.MortgageBrokerLicenseID.Equals(input.MortgageBrokerLicenseID))
                ) && 
                (
                    this.MortgageBrokerEmail == input.MortgageBrokerEmail ||
                    (this.MortgageBrokerEmail != null &&
                    this.MortgageBrokerEmail.Equals(input.MortgageBrokerEmail))
                ) && 
                (
                    this.MortgageBrokerPhone == input.MortgageBrokerPhone ||
                    (this.MortgageBrokerPhone != null &&
                    this.MortgageBrokerPhone.Equals(input.MortgageBrokerPhone))
                ) && 
                (
                    this.MortgageBrokerLoanOfficer == input.MortgageBrokerLoanOfficer ||
                    (this.MortgageBrokerLoanOfficer != null &&
                    this.MortgageBrokerLoanOfficer.Equals(input.MortgageBrokerLoanOfficer))
                ) && 
                (
                    this.MortgageBrokerLoanOfficerNMLSId == input.MortgageBrokerLoanOfficerNMLSId ||
                    (this.MortgageBrokerLoanOfficerNMLSId != null &&
                    this.MortgageBrokerLoanOfficerNMLSId.Equals(input.MortgageBrokerLoanOfficerNMLSId))
                ) && 
                (
                    this.Appraisal == input.Appraisal ||
                    (this.Appraisal != null &&
                    this.Appraisal.Equals(input.Appraisal))
                ) && 
                (
                    this.Assumption == input.Assumption ||
                    (this.Assumption != null &&
                    this.Assumption.Equals(input.Assumption))
                ) && 
                (
                    this.HomeownerInsurance == input.HomeownerInsurance ||
                    (this.HomeownerInsurance != null &&
                    this.HomeownerInsurance.Equals(input.HomeownerInsurance))
                ) && 
                (
                    this.Servicing == input.Servicing ||
                    (this.Servicing != null &&
                    this.Servicing.Equals(input.Servicing))
                ) && 
                (
                    this.ConstructionLoan == input.ConstructionLoan ||
                    (this.ConstructionLoan != null &&
                    this.ConstructionLoan.Equals(input.ConstructionLoan))
                ) && 
                (
                    this.TotalInterestPercentage == input.TotalInterestPercentage ||
                    (this.TotalInterestPercentage != null &&
                    this.TotalInterestPercentage.Equals(input.TotalInterestPercentage))
                ) && 
                (
                    this.TotalInterestPercentageUI == input.TotalInterestPercentageUI ||
                    (this.TotalInterestPercentageUI != null &&
                    this.TotalInterestPercentageUI.Equals(input.TotalInterestPercentageUI))
                ) && 
                (
                    this.In5YearsTotalYouWillHavePaid == input.In5YearsTotalYouWillHavePaid ||
                    (this.In5YearsTotalYouWillHavePaid != null &&
                    this.In5YearsTotalYouWillHavePaid.Equals(input.In5YearsTotalYouWillHavePaid))
                ) && 
                (
                    this.In5YearsPrincipalYouWillHavePaidOff == input.In5YearsPrincipalYouWillHavePaidOff ||
                    (this.In5YearsPrincipalYouWillHavePaidOff != null &&
                    this.In5YearsPrincipalYouWillHavePaidOff.Equals(input.In5YearsPrincipalYouWillHavePaidOff))
                ) && 
                (
                    this.SignatureType == input.SignatureType ||
                    (this.SignatureType != null &&
                    this.SignatureType.Equals(input.SignatureType))
                ) && 
                (
                    this.LenderLicenseState == input.LenderLicenseState ||
                    (this.LenderLicenseState != null &&
                    this.LenderLicenseState.Equals(input.LenderLicenseState))
                ) && 
                (
                    this.LenderLoanOfficerLicenseState == input.LenderLoanOfficerLicenseState ||
                    (this.LenderLoanOfficerLicenseState != null &&
                    this.LenderLoanOfficerLicenseState.Equals(input.LenderLoanOfficerLicenseState))
                ) && 
                (
                    this.MortgageBrokerLicenseState == input.MortgageBrokerLicenseState ||
                    (this.MortgageBrokerLicenseState != null &&
                    this.MortgageBrokerLicenseState.Equals(input.MortgageBrokerLicenseState))
                ) && 
                (
                    this.MortgageBrokerLoanOfficerLicenseState == input.MortgageBrokerLoanOfficerLicenseState ||
                    (this.MortgageBrokerLoanOfficerLicenseState != null &&
                    this.MortgageBrokerLoanOfficerLicenseState.Equals(input.MortgageBrokerLoanOfficerLicenseState))
                ) && 
                (
                    this.MortgageLenderLoanOfficerLicenseID == input.MortgageLenderLoanOfficerLicenseID ||
                    (this.MortgageLenderLoanOfficerLicenseID != null &&
                    this.MortgageLenderLoanOfficerLicenseID.Equals(input.MortgageLenderLoanOfficerLicenseID))
                ) && 
                (
                    this.MortgageBrokerLoanOfficerLicenseID == input.MortgageBrokerLoanOfficerLicenseID ||
                    (this.MortgageBrokerLoanOfficerLicenseID != null &&
                    this.MortgageBrokerLoanOfficerLicenseID.Equals(input.MortgageBrokerLoanOfficerLicenseID))
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
                if (this.LenderLicenseID != null)
                    hashCode = hashCode * 59 + this.LenderLicenseID.GetHashCode();
                if (this.LenderEmail != null)
                    hashCode = hashCode * 59 + this.LenderEmail.GetHashCode();
                if (this.LenderPhone != null)
                    hashCode = hashCode * 59 + this.LenderPhone.GetHashCode();
                if (this.LenderLoanOfficer != null)
                    hashCode = hashCode * 59 + this.LenderLoanOfficer.GetHashCode();
                if (this.LenderLoanOfficerNMLSId != null)
                    hashCode = hashCode * 59 + this.LenderLoanOfficerNMLSId.GetHashCode();
                if (this.MortgageBrokerLicenseID != null)
                    hashCode = hashCode * 59 + this.MortgageBrokerLicenseID.GetHashCode();
                if (this.MortgageBrokerEmail != null)
                    hashCode = hashCode * 59 + this.MortgageBrokerEmail.GetHashCode();
                if (this.MortgageBrokerPhone != null)
                    hashCode = hashCode * 59 + this.MortgageBrokerPhone.GetHashCode();
                if (this.MortgageBrokerLoanOfficer != null)
                    hashCode = hashCode * 59 + this.MortgageBrokerLoanOfficer.GetHashCode();
                if (this.MortgageBrokerLoanOfficerNMLSId != null)
                    hashCode = hashCode * 59 + this.MortgageBrokerLoanOfficerNMLSId.GetHashCode();
                if (this.Appraisal != null)
                    hashCode = hashCode * 59 + this.Appraisal.GetHashCode();
                if (this.Assumption != null)
                    hashCode = hashCode * 59 + this.Assumption.GetHashCode();
                if (this.HomeownerInsurance != null)
                    hashCode = hashCode * 59 + this.HomeownerInsurance.GetHashCode();
                if (this.Servicing != null)
                    hashCode = hashCode * 59 + this.Servicing.GetHashCode();
                if (this.ConstructionLoan != null)
                    hashCode = hashCode * 59 + this.ConstructionLoan.GetHashCode();
                if (this.TotalInterestPercentage != null)
                    hashCode = hashCode * 59 + this.TotalInterestPercentage.GetHashCode();
                if (this.TotalInterestPercentageUI != null)
                    hashCode = hashCode * 59 + this.TotalInterestPercentageUI.GetHashCode();
                if (this.In5YearsTotalYouWillHavePaid != null)
                    hashCode = hashCode * 59 + this.In5YearsTotalYouWillHavePaid.GetHashCode();
                if (this.In5YearsPrincipalYouWillHavePaidOff != null)
                    hashCode = hashCode * 59 + this.In5YearsPrincipalYouWillHavePaidOff.GetHashCode();
                if (this.SignatureType != null)
                    hashCode = hashCode * 59 + this.SignatureType.GetHashCode();
                if (this.LenderLicenseState != null)
                    hashCode = hashCode * 59 + this.LenderLicenseState.GetHashCode();
                if (this.LenderLoanOfficerLicenseState != null)
                    hashCode = hashCode * 59 + this.LenderLoanOfficerLicenseState.GetHashCode();
                if (this.MortgageBrokerLicenseState != null)
                    hashCode = hashCode * 59 + this.MortgageBrokerLicenseState.GetHashCode();
                if (this.MortgageBrokerLoanOfficerLicenseState != null)
                    hashCode = hashCode * 59 + this.MortgageBrokerLoanOfficerLicenseState.GetHashCode();
                if (this.MortgageLenderLoanOfficerLicenseID != null)
                    hashCode = hashCode * 59 + this.MortgageLenderLoanOfficerLicenseID.GetHashCode();
                if (this.MortgageBrokerLoanOfficerLicenseID != null)
                    hashCode = hashCode * 59 + this.MortgageBrokerLoanOfficerLicenseID.GetHashCode();
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
