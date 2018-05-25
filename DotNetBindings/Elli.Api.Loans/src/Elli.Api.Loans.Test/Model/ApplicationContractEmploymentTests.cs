/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Model;
using Elli.Api.Loans.Client;
using System.Reflection;

namespace Elli.Api.Loans.Test
{
    /// <summary>
    ///  Class for testing ApplicationContractEmployment
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ApplicationContractEmploymentTests
    {
        // TODO uncomment below to declare an instance variable for ApplicationContractEmployment
        //private ApplicationContractEmployment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ApplicationContractEmployment
            //instance = new ApplicationContractEmployment();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApplicationContractEmployment
        /// </summary>
        [Test]
        public void ApplicationContractEmploymentInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ApplicationContractEmployment
            //Assert.IsInstanceOfType<ApplicationContractEmployment> (instance, "variable 'instance' is a ApplicationContractEmployment");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'EntityDeleted'
        /// </summary>
        [Test]
        public void EntityDeletedTest()
        {
            // TODO unit test for the property 'EntityDeleted'
        }
        /// <summary>
        /// Test the property 'AddressCity'
        /// </summary>
        [Test]
        public void AddressCityTest()
        {
            // TODO unit test for the property 'AddressCity'
        }
        /// <summary>
        /// Test the property 'AddressPostalCode'
        /// </summary>
        [Test]
        public void AddressPostalCodeTest()
        {
            // TODO unit test for the property 'AddressPostalCode'
        }
        /// <summary>
        /// Test the property 'AddressState'
        /// </summary>
        [Test]
        public void AddressStateTest()
        {
            // TODO unit test for the property 'AddressState'
        }
        /// <summary>
        /// Test the property 'AddressStreetLine1'
        /// </summary>
        [Test]
        public void AddressStreetLine1Test()
        {
            // TODO unit test for the property 'AddressStreetLine1'
        }
        /// <summary>
        /// Test the property 'AltId'
        /// </summary>
        [Test]
        public void AltIdTest()
        {
            // TODO unit test for the property 'AltId'
        }
        /// <summary>
        /// Test the property 'Attention'
        /// </summary>
        [Test]
        public void AttentionTest()
        {
            // TODO unit test for the property 'Attention'
        }
        /// <summary>
        /// Test the property 'BasePayAmount'
        /// </summary>
        [Test]
        public void BasePayAmountTest()
        {
            // TODO unit test for the property 'BasePayAmount'
        }
        /// <summary>
        /// Test the property 'BonusAmount'
        /// </summary>
        [Test]
        public void BonusAmountTest()
        {
            // TODO unit test for the property 'BonusAmount'
        }
        /// <summary>
        /// Test the property 'BusinessName'
        /// </summary>
        [Test]
        public void BusinessNameTest()
        {
            // TODO unit test for the property 'BusinessName'
        }
        /// <summary>
        /// Test the property 'BusinessOwnedPercent'
        /// </summary>
        [Test]
        public void BusinessOwnedPercentTest()
        {
            // TODO unit test for the property 'BusinessOwnedPercent'
        }
        /// <summary>
        /// Test the property 'BusinessPhone'
        /// </summary>
        [Test]
        public void BusinessPhoneTest()
        {
            // TODO unit test for the property 'BusinessPhone'
        }
        /// <summary>
        /// Test the property 'CommissionsAmount'
        /// </summary>
        [Test]
        public void CommissionsAmountTest()
        {
            // TODO unit test for the property 'CommissionsAmount'
        }
        /// <summary>
        /// Test the property 'CurrentEmploymentIndicator'
        /// </summary>
        [Test]
        public void CurrentEmploymentIndicatorTest()
        {
            // TODO unit test for the property 'CurrentEmploymentIndicator'
        }
        /// <summary>
        /// Test the property 'BadgeOrEmployeeID'
        /// </summary>
        [Test]
        public void BadgeOrEmployeeIDTest()
        {
            // TODO unit test for the property 'BadgeOrEmployeeID'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'EmployerComments'
        /// </summary>
        [Test]
        public void EmployerCommentsTest()
        {
            // TODO unit test for the property 'EmployerComments'
        }
        /// <summary>
        /// Test the property 'EmployerName'
        /// </summary>
        [Test]
        public void EmployerNameTest()
        {
            // TODO unit test for the property 'EmployerName'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'Fax'
        /// </summary>
        [Test]
        public void FaxTest()
        {
            // TODO unit test for the property 'Fax'
        }
        /// <summary>
        /// Test the property 'MonthlyIncomeAmount'
        /// </summary>
        [Test]
        public void MonthlyIncomeAmountTest()
        {
            // TODO unit test for the property 'MonthlyIncomeAmount'
        }
        /// <summary>
        /// Test the property 'NoLinkToDocTrackIndicator'
        /// </summary>
        [Test]
        public void NoLinkToDocTrackIndicatorTest()
        {
            // TODO unit test for the property 'NoLinkToDocTrackIndicator'
        }
        /// <summary>
        /// Test the property 'OtherAmount'
        /// </summary>
        [Test]
        public void OtherAmountTest()
        {
            // TODO unit test for the property 'OtherAmount'
        }
        /// <summary>
        /// Test the property 'OvertimeAmount'
        /// </summary>
        [Test]
        public void OvertimeAmountTest()
        {
            // TODO unit test for the property 'OvertimeAmount'
        }
        /// <summary>
        /// Test the property 'Owner'
        /// </summary>
        [Test]
        public void OwnerTest()
        {
            // TODO unit test for the property 'Owner'
        }
        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
        }
        /// <summary>
        /// Test the property 'PositionDescription'
        /// </summary>
        [Test]
        public void PositionDescriptionTest()
        {
            // TODO unit test for the property 'PositionDescription'
        }
        /// <summary>
        /// Test the property 'PrintAttachmentIndicator'
        /// </summary>
        [Test]
        public void PrintAttachmentIndicatorTest()
        {
            // TODO unit test for the property 'PrintAttachmentIndicator'
        }
        /// <summary>
        /// Test the property 'PrintUserNameIndicator'
        /// </summary>
        [Test]
        public void PrintUserNameIndicatorTest()
        {
            // TODO unit test for the property 'PrintUserNameIndicator'
        }
        /// <summary>
        /// Test the property 'SelfEmployedIndicator'
        /// </summary>
        [Test]
        public void SelfEmployedIndicatorTest()
        {
            // TODO unit test for the property 'SelfEmployedIndicator'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'TimeInLineOfWorkMonths'
        /// </summary>
        [Test]
        public void TimeInLineOfWorkMonthsTest()
        {
            // TODO unit test for the property 'TimeInLineOfWorkMonths'
        }
        /// <summary>
        /// Test the property 'TimeInLineOfWorkYears'
        /// </summary>
        [Test]
        public void TimeInLineOfWorkYearsTest()
        {
            // TODO unit test for the property 'TimeInLineOfWorkYears'
        }
        /// <summary>
        /// Test the property 'TimeOnJobTermMonths'
        /// </summary>
        [Test]
        public void TimeOnJobTermMonthsTest()
        {
            // TODO unit test for the property 'TimeOnJobTermMonths'
        }
        /// <summary>
        /// Test the property 'TimeOnJobTermYears'
        /// </summary>
        [Test]
        public void TimeOnJobTermYearsTest()
        {
            // TODO unit test for the property 'TimeOnJobTermYears'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'TitleFax'
        /// </summary>
        [Test]
        public void TitleFaxTest()
        {
            // TODO unit test for the property 'TitleFax'
        }
        /// <summary>
        /// Test the property 'TitlePhone'
        /// </summary>
        [Test]
        public void TitlePhoneTest()
        {
            // TODO unit test for the property 'TitlePhone'
        }
        /// <summary>
        /// Test the property 'VerificationRequestDate'
        /// </summary>
        [Test]
        public void VerificationRequestDateTest()
        {
            // TODO unit test for the property 'VerificationRequestDate'
        }
        /// <summary>
        /// Test the property 'Contact'
        /// </summary>
        [Test]
        public void ContactTest()
        {
            // TODO unit test for the property 'Contact'
        }

    }

}
