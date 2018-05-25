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
    /// LoanFieldDataContract
    /// </summary>
    [DataContract]
    public partial class LoanFieldDataContract :  IEquatable<LoanFieldDataContract>, IValidatableObject
    {
    
        
        /// <summary>
        /// Unique Loan Field Id.
        /// </summary>
        /// <value>Unique Loan Field Id.</value>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        ///  Value for the loan field id.
        /// </summary>
        /// <value> Value for the loan field id.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Type of a field like Integer, String, YN(checkbox), Datetime, X ,YN ,STATE ,SSN ,ZIPCODE ,DATE ,PHONE ,DECIMAL DROPDOWNLIST ,AUDIT etc.
        /// </summary>
        /// <value>Type of a field like Integer, String, YN(checkbox), Datetime, X ,YN ,STATE ,SSN ,ZIPCODE ,DATE ,PHONE ,DECIMAL DROPDOWNLIST ,AUDIT etc.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Describes if the field is readOnly or is allowed to be edited.
        /// </summary>
        /// <value>Describes if the field is readOnly or is allowed to be edited.</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }

        /// <summary>
        /// This is a detailed explanation what field represents.
        /// </summary>
        /// <value>This is a detailed explanation what field represents.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Defines the type of field: date, datetime, decimal, int or string
        /// </summary>
        /// <value>Defines the type of field: date, datetime, decimal, int or string</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Represents possible options for field values for the field id.
        /// </summary>
        /// <value>Represents possible options for field values for the field id.</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<LoanFieldDataContractOptions> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanFieldDataContract {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as LoanFieldDataContract);
        }

        /// <summary>
        /// Returns true if LoanFieldDataContract instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanFieldDataContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanFieldDataContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this._ReadOnly == input._ReadOnly ||
                    (this._ReadOnly != null &&
                    this._ReadOnly.Equals(input._ReadOnly))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this._ReadOnly != null)
                    hashCode = hashCode * 59 + this._ReadOnly.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
