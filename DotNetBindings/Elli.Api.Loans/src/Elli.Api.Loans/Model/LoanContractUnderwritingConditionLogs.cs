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
    /// LoanContractUnderwritingConditionLogs
    /// </summary>
    [DataContract]
    public partial class LoanContractUnderwritingConditionLogs :  IEquatable<LoanContractUnderwritingConditionLogs>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AddedBy
        /// </summary>
        [DataMember(Name="addedBy", EmitDefaultValue=false)]
        public string AddedBy { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name="alerts", EmitDefaultValue=false)]
        public List<LoanContractAlerts> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets AllowToClearIndicator
        /// </summary>
        [DataMember(Name="allowToClearIndicator", EmitDefaultValue=false)]
        public bool? AllowToClearIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets ClearedBy
        /// </summary>
        [DataMember(Name="clearedBy", EmitDefaultValue=false)]
        public string ClearedBy { get; set; }

        /// <summary>
        /// Gets or Sets CommentList
        /// </summary>
        [DataMember(Name="commentList", EmitDefaultValue=false)]
        public List<LoanContractLogRecordCommentList> CommentList { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets DateAddedUtc
        /// </summary>
        [DataMember(Name="dateAddedUtc", EmitDefaultValue=false)]
        public DateTime? DateAddedUtc { get; set; }

        /// <summary>
        /// Gets or Sets DateClearedUtc
        /// </summary>
        [DataMember(Name="dateClearedUtc", EmitDefaultValue=false)]
        public DateTime? DateClearedUtc { get; set; }

        /// <summary>
        /// Gets or Sets DateFulfilledUtc
        /// </summary>
        [DataMember(Name="dateFulfilledUtc", EmitDefaultValue=false)]
        public DateTime? DateFulfilledUtc { get; set; }

        /// <summary>
        /// Gets or Sets DateReceivedUtc
        /// </summary>
        [DataMember(Name="dateReceivedUtc", EmitDefaultValue=false)]
        public DateTime? DateReceivedUtc { get; set; }

        /// <summary>
        /// Gets or Sets DateRejectedUtc
        /// </summary>
        [DataMember(Name="dateRejectedUtc", EmitDefaultValue=false)]
        public DateTime? DateRejectedUtc { get; set; }

        /// <summary>
        /// Gets or Sets DateReviewedUtc
        /// </summary>
        [DataMember(Name="dateReviewedUtc", EmitDefaultValue=false)]
        public DateTime? DateReviewedUtc { get; set; }

        /// <summary>
        /// Gets or Sets DateUtc
        /// </summary>
        [DataMember(Name="dateUtc", EmitDefaultValue=false)]
        public DateTime? DateUtc { get; set; }

        /// <summary>
        /// Gets or Sets DateWaivedUtc
        /// </summary>
        [DataMember(Name="dateWaivedUtc", EmitDefaultValue=false)]
        public DateTime? DateWaivedUtc { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets FileAttachmentsMigrated
        /// </summary>
        [DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
        public bool? FileAttachmentsMigrated { get; set; }

        /// <summary>
        /// Gets or Sets ForRoleId
        /// </summary>
        [DataMember(Name="forRoleId", EmitDefaultValue=false)]
        public int? ForRoleId { get; set; }

        /// <summary>
        /// Gets or Sets FulfilledBy
        /// </summary>
        [DataMember(Name="fulfilledBy", EmitDefaultValue=false)]
        public string FulfilledBy { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets IsExternalIndicator
        /// </summary>
        [DataMember(Name="isExternalIndicator", EmitDefaultValue=false)]
        public bool? IsExternalIndicator { get; set; }

        /// <summary>
        /// Gets or Sets IsInternalIndicator
        /// </summary>
        [DataMember(Name="isInternalIndicator", EmitDefaultValue=false)]
        public bool? IsInternalIndicator { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemSpecificIndicator
        /// </summary>
        [DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
        public bool? IsSystemSpecificIndicator { get; set; }

        /// <summary>
        /// Gets or Sets LogRecordIndex
        /// </summary>
        [DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
        public int? LogRecordIndex { get; set; }

        /// <summary>
        /// Gets or Sets PairId
        /// </summary>
        [DataMember(Name="pairId", EmitDefaultValue=false)]
        public string PairId { get; set; }

        /// <summary>
        /// Gets or Sets PriorTo
        /// </summary>
        [DataMember(Name="priorTo", EmitDefaultValue=false)]
        public string PriorTo { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedBy
        /// </summary>
        [DataMember(Name="receivedBy", EmitDefaultValue=false)]
        public string ReceivedBy { get; set; }

        /// <summary>
        /// Gets or Sets RejectedBy
        /// </summary>
        [DataMember(Name="rejectedBy", EmitDefaultValue=false)]
        public string RejectedBy { get; set; }

        /// <summary>
        /// Gets or Sets ReviewedBy
        /// </summary>
        [DataMember(Name="reviewedBy", EmitDefaultValue=false)]
        public string ReviewedBy { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets SystemId
        /// </summary>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public string SystemId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets WaivedBy
        /// </summary>
        [DataMember(Name="waivedBy", EmitDefaultValue=false)]
        public string WaivedBy { get; set; }

        /// <summary>
        /// Gets or Sets DateExpiredUtc
        /// </summary>
        [DataMember(Name="dateExpiredUtc", EmitDefaultValue=false)]
        public DateTime? DateExpiredUtc { get; set; }

        /// <summary>
        /// Gets or Sets Cleared
        /// </summary>
        [DataMember(Name="cleared", EmitDefaultValue=false)]
        public bool? Cleared { get; set; }

        /// <summary>
        /// Gets or Sets Reviewed
        /// </summary>
        [DataMember(Name="reviewed", EmitDefaultValue=false)]
        public bool? Reviewed { get; set; }

        /// <summary>
        /// Gets or Sets Waived
        /// </summary>
        [DataMember(Name="waived", EmitDefaultValue=false)]
        public bool? Waived { get; set; }

        /// <summary>
        /// Gets or Sets Rejected
        /// </summary>
        [DataMember(Name="rejected", EmitDefaultValue=false)]
        public bool? Rejected { get; set; }

        /// <summary>
        /// Gets or Sets Fulfilled
        /// </summary>
        [DataMember(Name="fulfilled", EmitDefaultValue=false)]
        public bool? Fulfilled { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public Object Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name="statusDescription", EmitDefaultValue=false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets Expected
        /// </summary>
        [DataMember(Name="expected", EmitDefaultValue=false)]
        public bool? Expected { get; set; }

        /// <summary>
        /// Gets or Sets DateExpected
        /// </summary>
        [DataMember(Name="dateExpected", EmitDefaultValue=false)]
        public DateTime? DateExpected { get; set; }

        /// <summary>
        /// Gets or Sets DateRequestedUtc
        /// </summary>
        [DataMember(Name="dateRequestedUtc", EmitDefaultValue=false)]
        public DateTime? DateRequestedUtc { get; set; }

        /// <summary>
        /// Gets or Sets RequestedBy
        /// </summary>
        [DataMember(Name="requestedBy", EmitDefaultValue=false)]
        public string RequestedBy { get; set; }

        /// <summary>
        /// Gets or Sets DateRerequestedUtc
        /// </summary>
        [DataMember(Name="dateRerequestedUtc", EmitDefaultValue=false)]
        public DateTime? DateRerequestedUtc { get; set; }

        /// <summary>
        /// Gets or Sets RerequestedBy
        /// </summary>
        [DataMember(Name="rerequestedBy", EmitDefaultValue=false)]
        public string RerequestedBy { get; set; }

        /// <summary>
        /// Gets or Sets DateReceived
        /// </summary>
        [DataMember(Name="dateReceived", EmitDefaultValue=false)]
        public DateTime? DateReceived { get; set; }

        /// <summary>
        /// Gets or Sets Received
        /// </summary>
        [DataMember(Name="received", EmitDefaultValue=false)]
        public bool? Received { get; set; }

        /// <summary>
        /// Gets or Sets Requested
        /// </summary>
        [DataMember(Name="requested", EmitDefaultValue=false)]
        public bool? Requested { get; set; }

        /// <summary>
        /// Gets or Sets Rerequested
        /// </summary>
        [DataMember(Name="rerequested", EmitDefaultValue=false)]
        public bool? Rerequested { get; set; }

        /// <summary>
        /// Gets or Sets IsPastDue
        /// </summary>
        [DataMember(Name="isPastDue", EmitDefaultValue=false)]
        public bool? IsPastDue { get; set; }

        /// <summary>
        /// Gets or Sets AlertsXml
        /// </summary>
        [DataMember(Name="alertsXml", EmitDefaultValue=false)]
        public string AlertsXml { get; set; }

        /// <summary>
        /// Gets or Sets CommentListXml
        /// </summary>
        [DataMember(Name="commentListXml", EmitDefaultValue=false)]
        public string CommentListXml { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractUnderwritingConditionLogs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AddedBy: ").Append(AddedBy).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  AllowToClearIndicator: ").Append(AllowToClearIndicator).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ClearedBy: ").Append(ClearedBy).Append("\n");
            sb.Append("  CommentList: ").Append(CommentList).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  DateAddedUtc: ").Append(DateAddedUtc).Append("\n");
            sb.Append("  DateClearedUtc: ").Append(DateClearedUtc).Append("\n");
            sb.Append("  DateFulfilledUtc: ").Append(DateFulfilledUtc).Append("\n");
            sb.Append("  DateReceivedUtc: ").Append(DateReceivedUtc).Append("\n");
            sb.Append("  DateRejectedUtc: ").Append(DateRejectedUtc).Append("\n");
            sb.Append("  DateReviewedUtc: ").Append(DateReviewedUtc).Append("\n");
            sb.Append("  DateUtc: ").Append(DateUtc).Append("\n");
            sb.Append("  DateWaivedUtc: ").Append(DateWaivedUtc).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  FileAttachmentsMigrated: ").Append(FileAttachmentsMigrated).Append("\n");
            sb.Append("  ForRoleId: ").Append(ForRoleId).Append("\n");
            sb.Append("  FulfilledBy: ").Append(FulfilledBy).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  IsExternalIndicator: ").Append(IsExternalIndicator).Append("\n");
            sb.Append("  IsInternalIndicator: ").Append(IsInternalIndicator).Append("\n");
            sb.Append("  IsSystemSpecificIndicator: ").Append(IsSystemSpecificIndicator).Append("\n");
            sb.Append("  LogRecordIndex: ").Append(LogRecordIndex).Append("\n");
            sb.Append("  PairId: ").Append(PairId).Append("\n");
            sb.Append("  PriorTo: ").Append(PriorTo).Append("\n");
            sb.Append("  ReceivedBy: ").Append(ReceivedBy).Append("\n");
            sb.Append("  RejectedBy: ").Append(RejectedBy).Append("\n");
            sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  WaivedBy: ").Append(WaivedBy).Append("\n");
            sb.Append("  DateExpiredUtc: ").Append(DateExpiredUtc).Append("\n");
            sb.Append("  Cleared: ").Append(Cleared).Append("\n");
            sb.Append("  Reviewed: ").Append(Reviewed).Append("\n");
            sb.Append("  Waived: ").Append(Waived).Append("\n");
            sb.Append("  Rejected: ").Append(Rejected).Append("\n");
            sb.Append("  Fulfilled: ").Append(Fulfilled).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Expected: ").Append(Expected).Append("\n");
            sb.Append("  DateExpected: ").Append(DateExpected).Append("\n");
            sb.Append("  DateRequestedUtc: ").Append(DateRequestedUtc).Append("\n");
            sb.Append("  RequestedBy: ").Append(RequestedBy).Append("\n");
            sb.Append("  DateRerequestedUtc: ").Append(DateRerequestedUtc).Append("\n");
            sb.Append("  RerequestedBy: ").Append(RerequestedBy).Append("\n");
            sb.Append("  DateReceived: ").Append(DateReceived).Append("\n");
            sb.Append("  Received: ").Append(Received).Append("\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
            sb.Append("  Rerequested: ").Append(Rerequested).Append("\n");
            sb.Append("  IsPastDue: ").Append(IsPastDue).Append("\n");
            sb.Append("  AlertsXml: ").Append(AlertsXml).Append("\n");
            sb.Append("  CommentListXml: ").Append(CommentListXml).Append("\n");
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
            return this.Equals(input as LoanContractUnderwritingConditionLogs);
        }

        /// <summary>
        /// Returns true if LoanContractUnderwritingConditionLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractUnderwritingConditionLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractUnderwritingConditionLogs input)
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
                    this.AddedBy == input.AddedBy ||
                    (this.AddedBy != null &&
                    this.AddedBy.Equals(input.AddedBy))
                ) && 
                (
                    this.Alerts == input.Alerts ||
                    this.Alerts != null &&
                    this.Alerts.SequenceEqual(input.Alerts)
                ) && 
                (
                    this.AllowToClearIndicator == input.AllowToClearIndicator ||
                    (this.AllowToClearIndicator != null &&
                    this.AllowToClearIndicator.Equals(input.AllowToClearIndicator))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ClearedBy == input.ClearedBy ||
                    (this.ClearedBy != null &&
                    this.ClearedBy.Equals(input.ClearedBy))
                ) && 
                (
                    this.CommentList == input.CommentList ||
                    this.CommentList != null &&
                    this.CommentList.SequenceEqual(input.CommentList)
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.DateAddedUtc == input.DateAddedUtc ||
                    (this.DateAddedUtc != null &&
                    this.DateAddedUtc.Equals(input.DateAddedUtc))
                ) && 
                (
                    this.DateClearedUtc == input.DateClearedUtc ||
                    (this.DateClearedUtc != null &&
                    this.DateClearedUtc.Equals(input.DateClearedUtc))
                ) && 
                (
                    this.DateFulfilledUtc == input.DateFulfilledUtc ||
                    (this.DateFulfilledUtc != null &&
                    this.DateFulfilledUtc.Equals(input.DateFulfilledUtc))
                ) && 
                (
                    this.DateReceivedUtc == input.DateReceivedUtc ||
                    (this.DateReceivedUtc != null &&
                    this.DateReceivedUtc.Equals(input.DateReceivedUtc))
                ) && 
                (
                    this.DateRejectedUtc == input.DateRejectedUtc ||
                    (this.DateRejectedUtc != null &&
                    this.DateRejectedUtc.Equals(input.DateRejectedUtc))
                ) && 
                (
                    this.DateReviewedUtc == input.DateReviewedUtc ||
                    (this.DateReviewedUtc != null &&
                    this.DateReviewedUtc.Equals(input.DateReviewedUtc))
                ) && 
                (
                    this.DateUtc == input.DateUtc ||
                    (this.DateUtc != null &&
                    this.DateUtc.Equals(input.DateUtc))
                ) && 
                (
                    this.DateWaivedUtc == input.DateWaivedUtc ||
                    (this.DateWaivedUtc != null &&
                    this.DateWaivedUtc.Equals(input.DateWaivedUtc))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.FileAttachmentsMigrated == input.FileAttachmentsMigrated ||
                    (this.FileAttachmentsMigrated != null &&
                    this.FileAttachmentsMigrated.Equals(input.FileAttachmentsMigrated))
                ) && 
                (
                    this.ForRoleId == input.ForRoleId ||
                    (this.ForRoleId != null &&
                    this.ForRoleId.Equals(input.ForRoleId))
                ) && 
                (
                    this.FulfilledBy == input.FulfilledBy ||
                    (this.FulfilledBy != null &&
                    this.FulfilledBy.Equals(input.FulfilledBy))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IsExternalIndicator == input.IsExternalIndicator ||
                    (this.IsExternalIndicator != null &&
                    this.IsExternalIndicator.Equals(input.IsExternalIndicator))
                ) && 
                (
                    this.IsInternalIndicator == input.IsInternalIndicator ||
                    (this.IsInternalIndicator != null &&
                    this.IsInternalIndicator.Equals(input.IsInternalIndicator))
                ) && 
                (
                    this.IsSystemSpecificIndicator == input.IsSystemSpecificIndicator ||
                    (this.IsSystemSpecificIndicator != null &&
                    this.IsSystemSpecificIndicator.Equals(input.IsSystemSpecificIndicator))
                ) && 
                (
                    this.LogRecordIndex == input.LogRecordIndex ||
                    (this.LogRecordIndex != null &&
                    this.LogRecordIndex.Equals(input.LogRecordIndex))
                ) && 
                (
                    this.PairId == input.PairId ||
                    (this.PairId != null &&
                    this.PairId.Equals(input.PairId))
                ) && 
                (
                    this.PriorTo == input.PriorTo ||
                    (this.PriorTo != null &&
                    this.PriorTo.Equals(input.PriorTo))
                ) && 
                (
                    this.ReceivedBy == input.ReceivedBy ||
                    (this.ReceivedBy != null &&
                    this.ReceivedBy.Equals(input.ReceivedBy))
                ) && 
                (
                    this.RejectedBy == input.RejectedBy ||
                    (this.RejectedBy != null &&
                    this.RejectedBy.Equals(input.RejectedBy))
                ) && 
                (
                    this.ReviewedBy == input.ReviewedBy ||
                    (this.ReviewedBy != null &&
                    this.ReviewedBy.Equals(input.ReviewedBy))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.WaivedBy == input.WaivedBy ||
                    (this.WaivedBy != null &&
                    this.WaivedBy.Equals(input.WaivedBy))
                ) && 
                (
                    this.DateExpiredUtc == input.DateExpiredUtc ||
                    (this.DateExpiredUtc != null &&
                    this.DateExpiredUtc.Equals(input.DateExpiredUtc))
                ) && 
                (
                    this.Cleared == input.Cleared ||
                    (this.Cleared != null &&
                    this.Cleared.Equals(input.Cleared))
                ) && 
                (
                    this.Reviewed == input.Reviewed ||
                    (this.Reviewed != null &&
                    this.Reviewed.Equals(input.Reviewed))
                ) && 
                (
                    this.Waived == input.Waived ||
                    (this.Waived != null &&
                    this.Waived.Equals(input.Waived))
                ) && 
                (
                    this.Rejected == input.Rejected ||
                    (this.Rejected != null &&
                    this.Rejected.Equals(input.Rejected))
                ) && 
                (
                    this.Fulfilled == input.Fulfilled ||
                    (this.Fulfilled != null &&
                    this.Fulfilled.Equals(input.Fulfilled))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Expected == input.Expected ||
                    (this.Expected != null &&
                    this.Expected.Equals(input.Expected))
                ) && 
                (
                    this.DateExpected == input.DateExpected ||
                    (this.DateExpected != null &&
                    this.DateExpected.Equals(input.DateExpected))
                ) && 
                (
                    this.DateRequestedUtc == input.DateRequestedUtc ||
                    (this.DateRequestedUtc != null &&
                    this.DateRequestedUtc.Equals(input.DateRequestedUtc))
                ) && 
                (
                    this.RequestedBy == input.RequestedBy ||
                    (this.RequestedBy != null &&
                    this.RequestedBy.Equals(input.RequestedBy))
                ) && 
                (
                    this.DateRerequestedUtc == input.DateRerequestedUtc ||
                    (this.DateRerequestedUtc != null &&
                    this.DateRerequestedUtc.Equals(input.DateRerequestedUtc))
                ) && 
                (
                    this.RerequestedBy == input.RerequestedBy ||
                    (this.RerequestedBy != null &&
                    this.RerequestedBy.Equals(input.RerequestedBy))
                ) && 
                (
                    this.DateReceived == input.DateReceived ||
                    (this.DateReceived != null &&
                    this.DateReceived.Equals(input.DateReceived))
                ) && 
                (
                    this.Received == input.Received ||
                    (this.Received != null &&
                    this.Received.Equals(input.Received))
                ) && 
                (
                    this.Requested == input.Requested ||
                    (this.Requested != null &&
                    this.Requested.Equals(input.Requested))
                ) && 
                (
                    this.Rerequested == input.Rerequested ||
                    (this.Rerequested != null &&
                    this.Rerequested.Equals(input.Rerequested))
                ) && 
                (
                    this.IsPastDue == input.IsPastDue ||
                    (this.IsPastDue != null &&
                    this.IsPastDue.Equals(input.IsPastDue))
                ) && 
                (
                    this.AlertsXml == input.AlertsXml ||
                    (this.AlertsXml != null &&
                    this.AlertsXml.Equals(input.AlertsXml))
                ) && 
                (
                    this.CommentListXml == input.CommentListXml ||
                    (this.CommentListXml != null &&
                    this.CommentListXml.Equals(input.CommentListXml))
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
                if (this.AddedBy != null)
                    hashCode = hashCode * 59 + this.AddedBy.GetHashCode();
                if (this.Alerts != null)
                    hashCode = hashCode * 59 + this.Alerts.GetHashCode();
                if (this.AllowToClearIndicator != null)
                    hashCode = hashCode * 59 + this.AllowToClearIndicator.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ClearedBy != null)
                    hashCode = hashCode * 59 + this.ClearedBy.GetHashCode();
                if (this.CommentList != null)
                    hashCode = hashCode * 59 + this.CommentList.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.DateAddedUtc != null)
                    hashCode = hashCode * 59 + this.DateAddedUtc.GetHashCode();
                if (this.DateClearedUtc != null)
                    hashCode = hashCode * 59 + this.DateClearedUtc.GetHashCode();
                if (this.DateFulfilledUtc != null)
                    hashCode = hashCode * 59 + this.DateFulfilledUtc.GetHashCode();
                if (this.DateReceivedUtc != null)
                    hashCode = hashCode * 59 + this.DateReceivedUtc.GetHashCode();
                if (this.DateRejectedUtc != null)
                    hashCode = hashCode * 59 + this.DateRejectedUtc.GetHashCode();
                if (this.DateReviewedUtc != null)
                    hashCode = hashCode * 59 + this.DateReviewedUtc.GetHashCode();
                if (this.DateUtc != null)
                    hashCode = hashCode * 59 + this.DateUtc.GetHashCode();
                if (this.DateWaivedUtc != null)
                    hashCode = hashCode * 59 + this.DateWaivedUtc.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.FileAttachmentsMigrated != null)
                    hashCode = hashCode * 59 + this.FileAttachmentsMigrated.GetHashCode();
                if (this.ForRoleId != null)
                    hashCode = hashCode * 59 + this.ForRoleId.GetHashCode();
                if (this.FulfilledBy != null)
                    hashCode = hashCode * 59 + this.FulfilledBy.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.IsExternalIndicator != null)
                    hashCode = hashCode * 59 + this.IsExternalIndicator.GetHashCode();
                if (this.IsInternalIndicator != null)
                    hashCode = hashCode * 59 + this.IsInternalIndicator.GetHashCode();
                if (this.IsSystemSpecificIndicator != null)
                    hashCode = hashCode * 59 + this.IsSystemSpecificIndicator.GetHashCode();
                if (this.LogRecordIndex != null)
                    hashCode = hashCode * 59 + this.LogRecordIndex.GetHashCode();
                if (this.PairId != null)
                    hashCode = hashCode * 59 + this.PairId.GetHashCode();
                if (this.PriorTo != null)
                    hashCode = hashCode * 59 + this.PriorTo.GetHashCode();
                if (this.ReceivedBy != null)
                    hashCode = hashCode * 59 + this.ReceivedBy.GetHashCode();
                if (this.RejectedBy != null)
                    hashCode = hashCode * 59 + this.RejectedBy.GetHashCode();
                if (this.ReviewedBy != null)
                    hashCode = hashCode * 59 + this.ReviewedBy.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.WaivedBy != null)
                    hashCode = hashCode * 59 + this.WaivedBy.GetHashCode();
                if (this.DateExpiredUtc != null)
                    hashCode = hashCode * 59 + this.DateExpiredUtc.GetHashCode();
                if (this.Cleared != null)
                    hashCode = hashCode * 59 + this.Cleared.GetHashCode();
                if (this.Reviewed != null)
                    hashCode = hashCode * 59 + this.Reviewed.GetHashCode();
                if (this.Waived != null)
                    hashCode = hashCode * 59 + this.Waived.GetHashCode();
                if (this.Rejected != null)
                    hashCode = hashCode * 59 + this.Rejected.GetHashCode();
                if (this.Fulfilled != null)
                    hashCode = hashCode * 59 + this.Fulfilled.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.Expected != null)
                    hashCode = hashCode * 59 + this.Expected.GetHashCode();
                if (this.DateExpected != null)
                    hashCode = hashCode * 59 + this.DateExpected.GetHashCode();
                if (this.DateRequestedUtc != null)
                    hashCode = hashCode * 59 + this.DateRequestedUtc.GetHashCode();
                if (this.RequestedBy != null)
                    hashCode = hashCode * 59 + this.RequestedBy.GetHashCode();
                if (this.DateRerequestedUtc != null)
                    hashCode = hashCode * 59 + this.DateRerequestedUtc.GetHashCode();
                if (this.RerequestedBy != null)
                    hashCode = hashCode * 59 + this.RerequestedBy.GetHashCode();
                if (this.DateReceived != null)
                    hashCode = hashCode * 59 + this.DateReceived.GetHashCode();
                if (this.Received != null)
                    hashCode = hashCode * 59 + this.Received.GetHashCode();
                if (this.Requested != null)
                    hashCode = hashCode * 59 + this.Requested.GetHashCode();
                if (this.Rerequested != null)
                    hashCode = hashCode * 59 + this.Rerequested.GetHashCode();
                if (this.IsPastDue != null)
                    hashCode = hashCode * 59 + this.IsPastDue.GetHashCode();
                if (this.AlertsXml != null)
                    hashCode = hashCode * 59 + this.AlertsXml.GetHashCode();
                if (this.CommentListXml != null)
                    hashCode = hashCode * 59 + this.CommentListXml.GetHashCode();
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
