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
 * APIs to manage eFolder related entities - document and attachment.
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
using SwaggerDateConverter = Elli.Api.Loans.EFolder.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.EFolder.Model
{
    /// <summary>
    /// EFolderDocumentContract
    /// </summary>
    [DataContract]
    public partial class EFolderDocumentContract :  IEquatable<EFolderDocumentContract>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TitleWithIndex
        /// </summary>
        [DataMember(Name="titleWithIndex", EmitDefaultValue=false)]
        public string TitleWithIndex { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name="applicationName", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or Sets MilestoneId
        /// </summary>
        [DataMember(Name="milestoneId", EmitDefaultValue=false)]
        public string MilestoneId { get; set; }

        /// <summary>
        /// Gets or Sets WebCenterAllowed
        /// </summary>
        [DataMember(Name="webCenterAllowed", EmitDefaultValue=false)]
        public bool? WebCenterAllowed { get; set; }

        /// <summary>
        /// Gets or Sets TpoAllowed
        /// </summary>
        [DataMember(Name="tpoAllowed", EmitDefaultValue=false)]
        public bool? TpoAllowed { get; set; }

        /// <summary>
        /// Gets or Sets ThirdPartyAllowed
        /// </summary>
        [DataMember(Name="thirdPartyAllowed", EmitDefaultValue=false)]
        public bool? ThirdPartyAllowed { get; set; }

        /// <summary>
        /// Gets or Sets IsProtected
        /// </summary>
        [DataMember(Name="isProtected", EmitDefaultValue=false)]
        public bool? IsProtected { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets DateExpected
        /// </summary>
        [DataMember(Name="dateExpected", EmitDefaultValue=false)]
        public DateTime? DateExpected { get; set; }

        /// <summary>
        /// Gets or Sets DaysDue
        /// </summary>
        [DataMember(Name="daysDue", EmitDefaultValue=false)]
        public int? DaysDue { get; set; }

        /// <summary>
        /// Gets or Sets DaysTillExpire
        /// </summary>
        [DataMember(Name="daysTillExpire", EmitDefaultValue=false)]
        public int? DaysTillExpire { get; set; }

        /// <summary>
        /// Gets or Sets RequestedFrom
        /// </summary>
        [DataMember(Name="requestedFrom", EmitDefaultValue=false)]
        public string RequestedFrom { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets DateExpires
        /// </summary>
        [DataMember(Name="dateExpires", EmitDefaultValue=false)]
        public DateTime? DateExpires { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusDate
        /// </summary>
        [DataMember(Name="statusDate", EmitDefaultValue=false)]
        public DateTime? StatusDate { get; set; }

        /// <summary>
        /// Gets or Sets IsRequested
        /// </summary>
        [DataMember(Name="isRequested", EmitDefaultValue=false)]
        public bool? IsRequested { get; set; }

        /// <summary>
        /// Gets or Sets DateRequested
        /// </summary>
        [DataMember(Name="dateRequested", EmitDefaultValue=false)]
        public DateTime? DateRequested { get; set; }

        /// <summary>
        /// Gets or Sets RequestedBy
        /// </summary>
        [DataMember(Name="requestedBy", EmitDefaultValue=false)]
        public string RequestedBy { get; set; }

        /// <summary>
        /// Gets or Sets IsRerequested
        /// </summary>
        [DataMember(Name="isRerequested", EmitDefaultValue=false)]
        public bool? IsRerequested { get; set; }

        /// <summary>
        /// Gets or Sets DateRerequested
        /// </summary>
        [DataMember(Name="dateRerequested", EmitDefaultValue=false)]
        public DateTime? DateRerequested { get; set; }

        /// <summary>
        /// Gets or Sets RerequestedBy
        /// </summary>
        [DataMember(Name="rerequestedBy", EmitDefaultValue=false)]
        public string RerequestedBy { get; set; }

        /// <summary>
        /// Gets or Sets IsReceived
        /// </summary>
        [DataMember(Name="isReceived", EmitDefaultValue=false)]
        public bool? IsReceived { get; set; }

        /// <summary>
        /// Gets or Sets DateReceived
        /// </summary>
        [DataMember(Name="dateReceived", EmitDefaultValue=false)]
        public DateTime? DateReceived { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedBy
        /// </summary>
        [DataMember(Name="receivedBy", EmitDefaultValue=false)]
        public string ReceivedBy { get; set; }

        /// <summary>
        /// Gets or Sets IsReviewed
        /// </summary>
        [DataMember(Name="isReviewed", EmitDefaultValue=false)]
        public bool? IsReviewed { get; set; }

        /// <summary>
        /// Gets or Sets DateReviewed
        /// </summary>
        [DataMember(Name="dateReviewed", EmitDefaultValue=false)]
        public DateTime? DateReviewed { get; set; }

        /// <summary>
        /// Gets or Sets ReviewedBy
        /// </summary>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public string ReviewedBy { get; set; }

        /// <summary>
        /// Gets or Sets IsReadyForUw
        /// </summary>
        [DataMember(Name="isReadyForUw", EmitDefaultValue=false)]
        public bool? IsReadyForUw { get; set; }

        /// <summary>
        /// Gets or Sets DateReadyForUw
        /// </summary>
        [DataMember(Name="dateReadyForUw", EmitDefaultValue=false)]
        public DateTime? DateReadyForUw { get; set; }

        /// <summary>
        /// Gets or Sets ReadyForUwBy
        /// </summary>
        [DataMember(Name="readyForUwBy", EmitDefaultValue=false)]
        public string ReadyForUwBy { get; set; }

        /// <summary>
        /// Gets or Sets IsReadyToShip
        /// </summary>
        [DataMember(Name="isReadyToShip", EmitDefaultValue=false)]
        public bool? IsReadyToShip { get; set; }

        /// <summary>
        /// Gets or Sets DateReadyToShip
        /// </summary>
        [DataMember(Name="dateReadyToShip", EmitDefaultValue=false)]
        public DateTime? DateReadyToShip { get; set; }

        /// <summary>
        /// Gets or Sets ReadyToShipBy
        /// </summary>
        [DataMember(Name="readyToShipBy", EmitDefaultValue=false)]
        public string ReadyToShipBy { get; set; }

        /// <summary>
        /// Gets or Sets EmnSignature
        /// </summary>
        [DataMember(Name="emnSignature", EmitDefaultValue=false)]
        public string EmnSignature { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentRequired
        /// </summary>
        [DataMember(Name="attachmentRequired", EmitDefaultValue=false)]
        public bool? AttachmentRequired { get; set; }

        /// <summary>
        /// Gets or Sets IsClosingDocument
        /// </summary>
        [DataMember(Name="isClosingDocument", EmitDefaultValue=false)]
        public bool? IsClosingDocument { get; set; }

        /// <summary>
        /// Gets or Sets IsPreClosingDocument
        /// </summary>
        [DataMember(Name="isPreClosingDocument", EmitDefaultValue=false)]
        public bool? IsPreClosingDocument { get; set; }

        /// <summary>
        /// Gets or Sets IsEDisclosuresDocument
        /// </summary>
        [DataMember(Name="isEDisclosuresDocument", EmitDefaultValue=false)]
        public bool? IsEDisclosuresDocument { get; set; }

        /// <summary>
        /// Gets or Sets IsSettlementServicesDocument
        /// </summary>
        [DataMember(Name="isSettlementServicesDocument", EmitDefaultValue=false)]
        public bool? IsSettlementServicesDocument { get; set; }

        /// <summary>
        /// Gets or Sets HasIncomeVerifications
        /// </summary>
        [DataMember(Name="hasIncomeVerifications", EmitDefaultValue=false)]
        public bool? HasIncomeVerifications { get; set; }

        /// <summary>
        /// Gets or Sets HasObligationVerifications
        /// </summary>
        [DataMember(Name="hasObligationVerifications", EmitDefaultValue=false)]
        public bool? HasObligationVerifications { get; set; }

        /// <summary>
        /// Gets or Sets HasAssetVerifications
        /// </summary>
        [DataMember(Name="hasAssetVerifications", EmitDefaultValue=false)]
        public bool? HasAssetVerifications { get; set; }

        /// <summary>
        /// Gets or Sets HasEmploymentVerifications
        /// </summary>
        [DataMember(Name="hasEmploymentVerifications", EmitDefaultValue=false)]
        public bool? HasEmploymentVerifications { get; set; }

        /// <summary>
        /// Gets or Sets DocGroups
        /// </summary>
        [DataMember(Name="docGroups", EmitDefaultValue=false)]
        public List<string> DocGroups { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public List<EFolderDocumentContractComments> Comments { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<EFolderDocumentContractAttachments> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<EFolderDocumentContractAttachments> Conditions { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<EFolderDocumentContractAttachments> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EFolderDocumentContract {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleWithIndex: ").Append(TitleWithIndex).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  MilestoneId: ").Append(MilestoneId).Append("\n");
            sb.Append("  WebCenterAllowed: ").Append(WebCenterAllowed).Append("\n");
            sb.Append("  TpoAllowed: ").Append(TpoAllowed).Append("\n");
            sb.Append("  ThirdPartyAllowed: ").Append(ThirdPartyAllowed).Append("\n");
            sb.Append("  IsProtected: ").Append(IsProtected).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  DateExpected: ").Append(DateExpected).Append("\n");
            sb.Append("  DaysDue: ").Append(DaysDue).Append("\n");
            sb.Append("  DaysTillExpire: ").Append(DaysTillExpire).Append("\n");
            sb.Append("  RequestedFrom: ").Append(RequestedFrom).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
            sb.Append("  IsRequested: ").Append(IsRequested).Append("\n");
            sb.Append("  DateRequested: ").Append(DateRequested).Append("\n");
            sb.Append("  RequestedBy: ").Append(RequestedBy).Append("\n");
            sb.Append("  IsRerequested: ").Append(IsRerequested).Append("\n");
            sb.Append("  DateRerequested: ").Append(DateRerequested).Append("\n");
            sb.Append("  RerequestedBy: ").Append(RerequestedBy).Append("\n");
            sb.Append("  IsReceived: ").Append(IsReceived).Append("\n");
            sb.Append("  DateReceived: ").Append(DateReceived).Append("\n");
            sb.Append("  ReceivedBy: ").Append(ReceivedBy).Append("\n");
            sb.Append("  IsReviewed: ").Append(IsReviewed).Append("\n");
            sb.Append("  DateReviewed: ").Append(DateReviewed).Append("\n");
            sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
            sb.Append("  IsReadyForUw: ").Append(IsReadyForUw).Append("\n");
            sb.Append("  DateReadyForUw: ").Append(DateReadyForUw).Append("\n");
            sb.Append("  ReadyForUwBy: ").Append(ReadyForUwBy).Append("\n");
            sb.Append("  IsReadyToShip: ").Append(IsReadyToShip).Append("\n");
            sb.Append("  DateReadyToShip: ").Append(DateReadyToShip).Append("\n");
            sb.Append("  ReadyToShipBy: ").Append(ReadyToShipBy).Append("\n");
            sb.Append("  EmnSignature: ").Append(EmnSignature).Append("\n");
            sb.Append("  AttachmentRequired: ").Append(AttachmentRequired).Append("\n");
            sb.Append("  IsClosingDocument: ").Append(IsClosingDocument).Append("\n");
            sb.Append("  IsPreClosingDocument: ").Append(IsPreClosingDocument).Append("\n");
            sb.Append("  IsEDisclosuresDocument: ").Append(IsEDisclosuresDocument).Append("\n");
            sb.Append("  IsSettlementServicesDocument: ").Append(IsSettlementServicesDocument).Append("\n");
            sb.Append("  HasIncomeVerifications: ").Append(HasIncomeVerifications).Append("\n");
            sb.Append("  HasObligationVerifications: ").Append(HasObligationVerifications).Append("\n");
            sb.Append("  HasAssetVerifications: ").Append(HasAssetVerifications).Append("\n");
            sb.Append("  HasEmploymentVerifications: ").Append(HasEmploymentVerifications).Append("\n");
            sb.Append("  DocGroups: ").Append(DocGroups).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as EFolderDocumentContract);
        }

        /// <summary>
        /// Returns true if EFolderDocumentContract instances are equal
        /// </summary>
        /// <param name="input">Instance of EFolderDocumentContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EFolderDocumentContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TitleWithIndex == input.TitleWithIndex ||
                    (this.TitleWithIndex != null &&
                    this.TitleWithIndex.Equals(input.TitleWithIndex))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationName == input.ApplicationName ||
                    (this.ApplicationName != null &&
                    this.ApplicationName.Equals(input.ApplicationName))
                ) && 
                (
                    this.MilestoneId == input.MilestoneId ||
                    (this.MilestoneId != null &&
                    this.MilestoneId.Equals(input.MilestoneId))
                ) && 
                (
                    this.WebCenterAllowed == input.WebCenterAllowed ||
                    (this.WebCenterAllowed != null &&
                    this.WebCenterAllowed.Equals(input.WebCenterAllowed))
                ) && 
                (
                    this.TpoAllowed == input.TpoAllowed ||
                    (this.TpoAllowed != null &&
                    this.TpoAllowed.Equals(input.TpoAllowed))
                ) && 
                (
                    this.ThirdPartyAllowed == input.ThirdPartyAllowed ||
                    (this.ThirdPartyAllowed != null &&
                    this.ThirdPartyAllowed.Equals(input.ThirdPartyAllowed))
                ) && 
                (
                    this.IsProtected == input.IsProtected ||
                    (this.IsProtected != null &&
                    this.IsProtected.Equals(input.IsProtected))
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
                ) && 
                (
                    this.DateExpected == input.DateExpected ||
                    (this.DateExpected != null &&
                    this.DateExpected.Equals(input.DateExpected))
                ) && 
                (
                    this.DaysDue == input.DaysDue ||
                    (this.DaysDue != null &&
                    this.DaysDue.Equals(input.DaysDue))
                ) && 
                (
                    this.DaysTillExpire == input.DaysTillExpire ||
                    (this.DaysTillExpire != null &&
                    this.DaysTillExpire.Equals(input.DaysTillExpire))
                ) && 
                (
                    this.RequestedFrom == input.RequestedFrom ||
                    (this.RequestedFrom != null &&
                    this.RequestedFrom.Equals(input.RequestedFrom))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.DateExpires == input.DateExpires ||
                    (this.DateExpires != null &&
                    this.DateExpires.Equals(input.DateExpires))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDate == input.StatusDate ||
                    (this.StatusDate != null &&
                    this.StatusDate.Equals(input.StatusDate))
                ) && 
                (
                    this.IsRequested == input.IsRequested ||
                    (this.IsRequested != null &&
                    this.IsRequested.Equals(input.IsRequested))
                ) && 
                (
                    this.DateRequested == input.DateRequested ||
                    (this.DateRequested != null &&
                    this.DateRequested.Equals(input.DateRequested))
                ) && 
                (
                    this.RequestedBy == input.RequestedBy ||
                    (this.RequestedBy != null &&
                    this.RequestedBy.Equals(input.RequestedBy))
                ) && 
                (
                    this.IsRerequested == input.IsRerequested ||
                    (this.IsRerequested != null &&
                    this.IsRerequested.Equals(input.IsRerequested))
                ) && 
                (
                    this.DateRerequested == input.DateRerequested ||
                    (this.DateRerequested != null &&
                    this.DateRerequested.Equals(input.DateRerequested))
                ) && 
                (
                    this.RerequestedBy == input.RerequestedBy ||
                    (this.RerequestedBy != null &&
                    this.RerequestedBy.Equals(input.RerequestedBy))
                ) && 
                (
                    this.IsReceived == input.IsReceived ||
                    (this.IsReceived != null &&
                    this.IsReceived.Equals(input.IsReceived))
                ) && 
                (
                    this.DateReceived == input.DateReceived ||
                    (this.DateReceived != null &&
                    this.DateReceived.Equals(input.DateReceived))
                ) && 
                (
                    this.ReceivedBy == input.ReceivedBy ||
                    (this.ReceivedBy != null &&
                    this.ReceivedBy.Equals(input.ReceivedBy))
                ) && 
                (
                    this.IsReviewed == input.IsReviewed ||
                    (this.IsReviewed != null &&
                    this.IsReviewed.Equals(input.IsReviewed))
                ) && 
                (
                    this.DateReviewed == input.DateReviewed ||
                    (this.DateReviewed != null &&
                    this.DateReviewed.Equals(input.DateReviewed))
                ) && 
                (
                    this.ReviewedBy == input.ReviewedBy ||
                    (this.ReviewedBy != null &&
                    this.ReviewedBy.Equals(input.ReviewedBy))
                ) && 
                (
                    this.IsReadyForUw == input.IsReadyForUw ||
                    (this.IsReadyForUw != null &&
                    this.IsReadyForUw.Equals(input.IsReadyForUw))
                ) && 
                (
                    this.DateReadyForUw == input.DateReadyForUw ||
                    (this.DateReadyForUw != null &&
                    this.DateReadyForUw.Equals(input.DateReadyForUw))
                ) && 
                (
                    this.ReadyForUwBy == input.ReadyForUwBy ||
                    (this.ReadyForUwBy != null &&
                    this.ReadyForUwBy.Equals(input.ReadyForUwBy))
                ) && 
                (
                    this.IsReadyToShip == input.IsReadyToShip ||
                    (this.IsReadyToShip != null &&
                    this.IsReadyToShip.Equals(input.IsReadyToShip))
                ) && 
                (
                    this.DateReadyToShip == input.DateReadyToShip ||
                    (this.DateReadyToShip != null &&
                    this.DateReadyToShip.Equals(input.DateReadyToShip))
                ) && 
                (
                    this.ReadyToShipBy == input.ReadyToShipBy ||
                    (this.ReadyToShipBy != null &&
                    this.ReadyToShipBy.Equals(input.ReadyToShipBy))
                ) && 
                (
                    this.EmnSignature == input.EmnSignature ||
                    (this.EmnSignature != null &&
                    this.EmnSignature.Equals(input.EmnSignature))
                ) && 
                (
                    this.AttachmentRequired == input.AttachmentRequired ||
                    (this.AttachmentRequired != null &&
                    this.AttachmentRequired.Equals(input.AttachmentRequired))
                ) && 
                (
                    this.IsClosingDocument == input.IsClosingDocument ||
                    (this.IsClosingDocument != null &&
                    this.IsClosingDocument.Equals(input.IsClosingDocument))
                ) && 
                (
                    this.IsPreClosingDocument == input.IsPreClosingDocument ||
                    (this.IsPreClosingDocument != null &&
                    this.IsPreClosingDocument.Equals(input.IsPreClosingDocument))
                ) && 
                (
                    this.IsEDisclosuresDocument == input.IsEDisclosuresDocument ||
                    (this.IsEDisclosuresDocument != null &&
                    this.IsEDisclosuresDocument.Equals(input.IsEDisclosuresDocument))
                ) && 
                (
                    this.IsSettlementServicesDocument == input.IsSettlementServicesDocument ||
                    (this.IsSettlementServicesDocument != null &&
                    this.IsSettlementServicesDocument.Equals(input.IsSettlementServicesDocument))
                ) && 
                (
                    this.HasIncomeVerifications == input.HasIncomeVerifications ||
                    (this.HasIncomeVerifications != null &&
                    this.HasIncomeVerifications.Equals(input.HasIncomeVerifications))
                ) && 
                (
                    this.HasObligationVerifications == input.HasObligationVerifications ||
                    (this.HasObligationVerifications != null &&
                    this.HasObligationVerifications.Equals(input.HasObligationVerifications))
                ) && 
                (
                    this.HasAssetVerifications == input.HasAssetVerifications ||
                    (this.HasAssetVerifications != null &&
                    this.HasAssetVerifications.Equals(input.HasAssetVerifications))
                ) && 
                (
                    this.HasEmploymentVerifications == input.HasEmploymentVerifications ||
                    (this.HasEmploymentVerifications != null &&
                    this.HasEmploymentVerifications.Equals(input.HasEmploymentVerifications))
                ) && 
                (
                    this.DocGroups == input.DocGroups ||
                    this.DocGroups != null &&
                    this.DocGroups.SequenceEqual(input.DocGroups)
                ) && 
                (
                    this.Comments == input.Comments ||
                    this.Comments != null &&
                    this.Comments.SequenceEqual(input.Comments)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.DocumentId != null)
                    hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TitleWithIndex != null)
                    hashCode = hashCode * 59 + this.TitleWithIndex.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationName != null)
                    hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.MilestoneId != null)
                    hashCode = hashCode * 59 + this.MilestoneId.GetHashCode();
                if (this.WebCenterAllowed != null)
                    hashCode = hashCode * 59 + this.WebCenterAllowed.GetHashCode();
                if (this.TpoAllowed != null)
                    hashCode = hashCode * 59 + this.TpoAllowed.GetHashCode();
                if (this.ThirdPartyAllowed != null)
                    hashCode = hashCode * 59 + this.ThirdPartyAllowed.GetHashCode();
                if (this.IsProtected != null)
                    hashCode = hashCode * 59 + this.IsProtected.GetHashCode();
                if (this.IsRequired != null)
                    hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.DateExpected != null)
                    hashCode = hashCode * 59 + this.DateExpected.GetHashCode();
                if (this.DaysDue != null)
                    hashCode = hashCode * 59 + this.DaysDue.GetHashCode();
                if (this.DaysTillExpire != null)
                    hashCode = hashCode * 59 + this.DaysTillExpire.GetHashCode();
                if (this.RequestedFrom != null)
                    hashCode = hashCode * 59 + this.RequestedFrom.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.DateExpires != null)
                    hashCode = hashCode * 59 + this.DateExpires.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDate != null)
                    hashCode = hashCode * 59 + this.StatusDate.GetHashCode();
                if (this.IsRequested != null)
                    hashCode = hashCode * 59 + this.IsRequested.GetHashCode();
                if (this.DateRequested != null)
                    hashCode = hashCode * 59 + this.DateRequested.GetHashCode();
                if (this.RequestedBy != null)
                    hashCode = hashCode * 59 + this.RequestedBy.GetHashCode();
                if (this.IsRerequested != null)
                    hashCode = hashCode * 59 + this.IsRerequested.GetHashCode();
                if (this.DateRerequested != null)
                    hashCode = hashCode * 59 + this.DateRerequested.GetHashCode();
                if (this.RerequestedBy != null)
                    hashCode = hashCode * 59 + this.RerequestedBy.GetHashCode();
                if (this.IsReceived != null)
                    hashCode = hashCode * 59 + this.IsReceived.GetHashCode();
                if (this.DateReceived != null)
                    hashCode = hashCode * 59 + this.DateReceived.GetHashCode();
                if (this.ReceivedBy != null)
                    hashCode = hashCode * 59 + this.ReceivedBy.GetHashCode();
                if (this.IsReviewed != null)
                    hashCode = hashCode * 59 + this.IsReviewed.GetHashCode();
                if (this.DateReviewed != null)
                    hashCode = hashCode * 59 + this.DateReviewed.GetHashCode();
                if (this.ReviewedBy != null)
                    hashCode = hashCode * 59 + this.ReviewedBy.GetHashCode();
                if (this.IsReadyForUw != null)
                    hashCode = hashCode * 59 + this.IsReadyForUw.GetHashCode();
                if (this.DateReadyForUw != null)
                    hashCode = hashCode * 59 + this.DateReadyForUw.GetHashCode();
                if (this.ReadyForUwBy != null)
                    hashCode = hashCode * 59 + this.ReadyForUwBy.GetHashCode();
                if (this.IsReadyToShip != null)
                    hashCode = hashCode * 59 + this.IsReadyToShip.GetHashCode();
                if (this.DateReadyToShip != null)
                    hashCode = hashCode * 59 + this.DateReadyToShip.GetHashCode();
                if (this.ReadyToShipBy != null)
                    hashCode = hashCode * 59 + this.ReadyToShipBy.GetHashCode();
                if (this.EmnSignature != null)
                    hashCode = hashCode * 59 + this.EmnSignature.GetHashCode();
                if (this.AttachmentRequired != null)
                    hashCode = hashCode * 59 + this.AttachmentRequired.GetHashCode();
                if (this.IsClosingDocument != null)
                    hashCode = hashCode * 59 + this.IsClosingDocument.GetHashCode();
                if (this.IsPreClosingDocument != null)
                    hashCode = hashCode * 59 + this.IsPreClosingDocument.GetHashCode();
                if (this.IsEDisclosuresDocument != null)
                    hashCode = hashCode * 59 + this.IsEDisclosuresDocument.GetHashCode();
                if (this.IsSettlementServicesDocument != null)
                    hashCode = hashCode * 59 + this.IsSettlementServicesDocument.GetHashCode();
                if (this.HasIncomeVerifications != null)
                    hashCode = hashCode * 59 + this.HasIncomeVerifications.GetHashCode();
                if (this.HasObligationVerifications != null)
                    hashCode = hashCode * 59 + this.HasObligationVerifications.GetHashCode();
                if (this.HasAssetVerifications != null)
                    hashCode = hashCode * 59 + this.HasAssetVerifications.GetHashCode();
                if (this.HasEmploymentVerifications != null)
                    hashCode = hashCode * 59 + this.HasEmploymentVerifications.GetHashCode();
                if (this.DocGroups != null)
                    hashCode = hashCode * 59 + this.DocGroups.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
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
