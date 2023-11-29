using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_json.modal
{
   
        public class AuthorizedContact
        {
            public string EnrollmentCustomerContactId { get; set; }
            public int ContactTypeId { get; set; }
            public string EnrollmentContactCustomerId { get; set; }
            public string EnrollmentServiceAccountId { get; set; }
            public object AddressId { get; set; }
            public string FirstName { get; set; }
            public string ContactName { get; set; }
            public string ContactNameKana { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public bool IsEnrollmentCustomerContactActive { get; set; }
            public string CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime? LastModifiedDate { get; set; }
            public bool IsPrimary { get; set; }
            public string Prefix { get; set; }
            public string Suffix { get; set; }
            public string ContactTypeCode { get; set; }
            public string OtherContact { get; set; }
            public string DepartmentName { get; set; }
            public bool IsDoNotEmail { get; set; }
            public string StaffName { get; set; }
            public string StaffNameKana { get; set; }
            public string CompanyNameKana { get; set; }
            public string CompanyName { get; set; }
            public AuthorizedContactAddress AuthorizedContactAddress { get; set; }
            public List<AuthorizedContactEmailList> AuthorizedContactEmailList { get; set; }
            public List<AuthorizedContactPhoneList> AuthorizedContactPhoneList { get; set; }
        }

        public class AuthorizedContactAddress
        {
            public string AddressId { get; set; }
            public object AddressTypeId { get; set; }
            public string AttentionTo { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string Address3 { get; set; }
            public string Address4 { get; set; }
            public string Address5 { get; set; }
            public string BuildingName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip5 { get; set; }
            public string Zip4 { get; set; }
            public bool? IsAddressActive { get; set; }
            public object CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime LastModifyDate { get; set; }
            public string CountryCode { get; set; }
            public string PostalCode { get; set; }
            public object County { get; set; }
            public string Chome { get; set; }
            public string Banchi { get; set; }
            public string Gou { get; set; }
            public string BuildingNumber { get; set; }
            public string RoomNumber { get; set; }
        }

        public class AuthorizedContactEmailList
        {
            public string EnrollmentCustomerContactEmailId { get; set; }
            public string EnrollmentCustomerContactId { get; set; }
            public string EmailId { get; set; }
            public bool IsEnrollmentCustomerContactEmailActive { get; set; }
            public string CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime? LastModifiedDate { get; set; }
            public bool IsEnrollmentCustomerContactEmailPrimary { get; set; }
            public string EmailTypeCode { get; set; }
            public Email Email { get; set; }
        }

        public class AuthorizedContactPhoneList
        {
            public string EnrollmentCustomerContactPhoneId { get; set; }
            public string EnrollmentCustomerContactId { get; set; }
            public string PhoneId { get; set; }
            public bool IsEnrollmentCustomerContactPhoneActive { get; set; }
            public string CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime? LastModifiedDate { get; set; }
            public bool IsEnrollmentCustomerContactPhonePrimary { get; set; }
            public string PhoneTypeCode { get; set; }
            public Phone Phone { get; set; }
            public string LastModifiedDat { get; set; }
            public string Displaying { get; set; }
        }

        public class Email
        {
            public string EmailId { get; set; }
            public object EnrollmentCustomerContactEmailId { get; set; }
            public int EmailTypeId { get; set; }
            public string EmailAddress { get; set; }
            public bool IsEmailActive { get; set; }
            public string CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime? LastModifyDate { get; set; }
        }

        public class EnrollmentAttributes
        {
            public object EnrollmentCustomerAttributeId { get; set; }
            public object EnrollmentAttributesCustomerId { get; set; }
            public object AttributeKey1 { get; set; }
            public object AttributeValue1 { get; set; }
            public object AttributeKey2 { get; set; }
            public object AttributeValue2 { get; set; }
            public object AttributeKey3 { get; set; }
            public object AttributeValue3 { get; set; }
            public object AttributeKey4 { get; set; }
            public object AttributeValue4 { get; set; }
            public object AttributeKey5 { get; set; }
            public object AttributeValue5 { get; set; }
            public bool IsEnrollmentAttributesActive { get; set; }
            public object CreatedByName { get; set; }
            public object CreateDate { get; set; }
            public object LastModifiedByName { get; set; }
            public DateTime LastModifyDate { get; set; }
        }

        public class EnrollmentCustomer
        {
            public string EnrollmentCustomerId { get; set; }
            public string EnrollmentId { get; set; }
            public object CustomerTypeId { get; set; }
            public object CompanyName { get; set; }
            public object CompanyNameKana { get; set; }
            public object DBA { get; set; }
            public object TaxID { get; set; }
            public object BillTypeId { get; set; }
            public object BillFormatId { get; set; }
            public object LanguageId { get; set; }
            public object BillingAddressId { get; set; }
            public string CustomerCorrelationId { get; set; }
            public object ReferenceCustomerId { get; set; }
            public object InvoiceDeliveryMethod { get; set; }
            public bool IsCustomerActive { get; set; }
            public string CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime LastModifiedDate { get; set; }
            public object FirstName { get; set; }
            public object MiddleName { get; set; }
            public object LastName { get; set; }
            public string CustomerName { get; set; }
            public string CustomerNameKana { get; set; }
            public DateTime? BirthDate { get; set; }
            public object Last4SSN { get; set; }
            public object Suffix { get; set; }
            public object Prefix { get; set; }
            public object PaymentTermsOverride { get; set; }
            public object DeliveryTypeId { get; set; }
            public string CustomerTypeCode { get; set; }
            public object BillTypeCode { get; set; }
            public object BillFormatCode { get; set; }
            public string LanguageCode { get; set; }
            public string DeliveryTypeCode { get; set; }
            public object ReferenceCustomerNumber { get; set; }
            public object KanaName { get; set; }
            public string PaymentCategoryCode { get; set; }
            public bool IsMember { get; set; }
            public string MemberName { get; set; }
            public string MemberNumber { get; set; }
            public string ReferralCode { get; set; }
            public object FriendReferralCode { get; set; }
            public bool IsNewConstruction { get; set; }
            public List<AuthorizedContact> AuthorizedContact { get; set; }
            public MailingAddress MailingAddress { get; set; }
            public List<ServiceAccount> ServiceAccount { get; set; }
            public object AutoRechargeConfigs { get; set; }
            public object PaymentDetails { get; set; }
            public EnrollmentAttributes EnrollmentAttributes { get; set; }
        }

        public class EnrollmentHikariService
        {
            public string ConfirmationNumber { get; set; }
            public object HikariCustomerNumber { get; set; }
            public object AuthorizeContactId { get; set; }
            public object UtilityAccountNumber { get; set; }
            public string DivertedOrNewConstruction { get; set; }
            public object DiversionConsentNumber { get; set; }
            public bool ApplicationForPhone { get; set; }
            public bool ApplicationForTv { get; set; }
            public bool ApplicationForRemoteSupport { get; set; }
            public bool IsActive { get; set; }
            public object OrderTypeId { get; set; }
            public object StatusId { get; set; }
            public object ServiceStartDate { get; set; }
            public object ServiceEndDate { get; set; }
            public object ServiceCancellationDate { get; set; }
            public object ExpectedSuspensionDate { get; set; }
            public int NumberofDelinquentPayments { get; set; }
            public string Comment { get; set; }
        }

        public class ExtendedProperty
        {
            public object EnrollmentCustomerAttributeId { get; set; }
            public string EnrollmentCustomerId { get; set; }
            public string Attribute { get; set; }
            public string Value { get; set; }
            public bool IsEnrollmentCustomerAttributeActive { get; set; }
            public object CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime LastModifiedDate { get; set; }
        }

        public class MailingAddress
        {
            public string AddressId { get; set; }
            public object AddressTypeId { get; set; }
            public object AttentionTo { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public object Address3 { get; set; }
            public object Address4 { get; set; }
            public object Address5 { get; set; }
            public object BuildingName { get; set; }
            public object City { get; set; }
            public object State { get; set; }
            public string Zip5 { get; set; }
            public string Zip4 { get; set; }
            public object IsAddressActive { get; set; }
            public object CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime LastModifyDate { get; set; }
            public object CountryCode { get; set; }
            public string PostalCode { get; set; }
            public object County { get; set; }
            public string Chome { get; set; }
            public string Banchi { get; set; }
            public string Gou { get; set; }
            public string BuildingNumber { get; set; }
            public string RoomNumber { get; set; }
        }

        public class Phone
        {
            public string PhoneId { get; set; }
            public object EnrollmentCustomerContactPhoneId { get; set; }
            public int PhoneTypeId { get; set; }
            public string PhoneCountryCode { get; set; }
            public string PhoneAreaCode { get; set; }
            public string PhoneNumber { get; set; }
            public string SubscriberNumber { get; set; }
            public string PhoneExtension { get; set; }
            public bool IsSMSAllowed { get; set; }
            public object IsDoNotCall { get; set; }
            public bool IsPhoneActive { get; set; }
            public string CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime? LastModifyDate { get; set; }
        }

        public class Root
        {
            public object EnrollmentBatchDetailId { get; set; }
            public int EnrollmentSalesTypeId { get; set; }
            public int EnrollmentStatusId { get; set; }
            public string CorrelationId { get; set; }
            public bool? TermsofServiceAgreement { get; set; }
            public bool? TermsofUseAgreement { get; set; }
            public bool IsActive { get; set; }
            public string EnrollmentSourceCode { get; set; }
            public string? ConfirmationNumber { get; set; }
            public object EnrollmentHoldReasonCode { get; set; }
            public object TPVCode { get; set; }
            public string EnrollmentStatusCode { get; set; }
            public string EnrollmentStatusReasonCode { get; set; }
            public object EnrollmentStatusJSON { get; set; }
            public bool IsPicked { get; set; }
            public int LastCompletedStep { get; set; }
            public object ReferenceNumber { get; set; }
            public int? Latitude { get; set; }
            public int? Longitude { get; set; }
            public object DepositDate { get; set; }
            public List<object> Deposit { get; set; }
            public EnrollmentCustomer EnrollmentCustomer { get; set; }
            public List<ExtendedProperty> ExtendedProperties { get; set; }
            public object RequestDate { get; set; }
            public int DivisionId { get; set; }
            public string DivisionName { get; set; }
            public string DivisionCode { get; set; }
            public object CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime LastModifiedDate { get; set; }
            public string id { get; set; }
            public string _rid { get; set; }
            public string _self { get; set; }
            public string _etag { get; set; }
            public string _attachments { get; set; }
            public int _ts { get; set; }
        }

        public class ServiceAccount
        {
            public string EnrollmentServiceAccountId { get; set; }
            public string EnrollmentServiceAccountCustomerId { get; set; }
            public int ServiceTypeId { get; set; }
            public int ClientId { get; set; }
            public string ClientCode { get; set; }
            public int UtilityId { get; set; }
            public string AddressId { get; set; }
            public string UtilityAccountNumber { get; set; }
            public string MeterNumber { get; set; }
            public object NameKey { get; set; }
            public bool IsUnmetered { get; set; }
            public bool IsTOU { get; set; }
            public object TransactionHoldReasonId { get; set; }
            public object TransactionRequestTypeId { get; set; }
            public DateTime TransactionReleaseDate { get; set; }
            public DateTime TransactionRequestedEffectiveDate { get; set; }
            public object ContractNumber { get; set; }
            public object PromoCode { get; set; }
            public DateTime ContractStartDate { get; set; }
            public DateTime ContractEndDate { get; set; }
            public int ContractTerm { get; set; }
            public DateTime ContractSignedDate { get; set; }
            public object SalesAgency { get; set; }
            public object SalesAgent { get; set; }
            public object CommissionAmount { get; set; }
            public object TPVCode { get; set; }
            public object ReferenceServiceAccountId { get; set; }
            public bool IsEnrollmentServiceAccountActive { get; set; }
            public object CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime LastModifiedDate { get; set; }
            public object RateClassId { get; set; }
            public object LoadProfileId { get; set; }
            public bool IsTransationHold { get; set; }
            public object SalesAgentCode { get; set; }
            public object RateClassCode { get; set; }
            public object LoadProfileCode { get; set; }
            public string SalesChannelCode { get; set; }
            public string SalesChannelPartnerCode { get; set; }
            public object ContractTypeId { get; set; }
            public object ChannelFeeAmount { get; set; }
            public object ContractSourceId { get; set; }
            public string ServiceTypeCode { get; set; }
            public string UtilityCode { get; set; }
            public string TransactionHoldReasonCode { get; set; }
            public string TransactionRequestTypeCode { get; set; }
            public string ContractTypeCode { get; set; }
            public string ContractSourceCode { get; set; }
            public object SalesAgencyCode { get; set; }
            public object SalesAgentEmail { get; set; }
            public object CommissionTypeCode { get; set; }
            public object ReferenceBillingAccountNumber { get; set; }
            public object UtilityBillingAccountNumber { get; set; }
            public string RateScheduleName { get; set; }
            public object ProductCode { get; set; }
            public bool IsTransactionHold { get; set; }
            public string ProductTypeCode { get; set; }
            public string ProductTypeName { get; set; }
            public string UtilityRateCode { get; set; }
            public object EnergyRate { get; set; }
            public object EnergyRateUOM { get; set; }
            public object CancelFeeType { get; set; }
            public object MonthlyFee { get; set; }
            public object CancelFee { get; set; }
            public string CrmUtilityAccountNumber { get; set; }
            public int RateAmount { get; set; }
            public bool IsVariableRate { get; set; }
            public object MonthlyFeeUOM { get; set; }
            public int VoltageTypeId { get; set; }
            public string WheelingServiceCalculationTypeCode { get; set; }
            public object AmpereSizeCode { get; set; }
            public object AmpereBreakerAvailabilityCode { get; set; }
            public object PeakCapacityAllowanceCode { get; set; }
            public object MinPriceContractCode { get; set; }
            public object MaxAmpereBreakerCapacity { get; set; }
            public object DroppingRetailerCode { get; set; }
            public object OtherRetailer { get; set; }
            public object DroppingRetailerCustomerNumber { get; set; }
            public object NextMeterReadDate { get; set; }
            public object NextNextMeterReadDate { get; set; }
            public object MeterReadDate { get; set; }
            public object MeterIntervalCode1 { get; set; }
            public object BreakerKwCapacity { get; set; }
            public object BreakerKvaCapacity { get; set; }
            public object SupplyLineTypeCode { get; set; }
            public object PremiseStatus { get; set; }
            public string WheelingServiceCalculationTypeName { get; set; }
            public int AmpereMaxCapacity { get; set; }
            public object UniversalService { get; set; }
            public object UtilityNameNativeDescription { get; set; }
            public object MeterCycle { get; set; }
            public object PowerFactor { get; set; }
            public bool IsConfirmationSent { get; set; }
            public object MemberName { get; set; }
            public object MemberNumber { get; set; }
            public object AcceptedTermsCode { get; set; }
            public object FixedEnergyRate { get; set; }
            public object SummerEnergyRate { get; set; }
            public object NonSummerEnergyRate { get; set; }
            public object SummerWeekdayRate { get; set; }
            public object SummerWeekendRate { get; set; }
            public object NonSummerWeekdayRate { get; set; }
            public object NonSummerWeekendRate { get; set; }
            public object Peak { get; set; }
            public object SummerDaytime { get; set; }
            public object NonSummerDaytime { get; set; }
            public object OffPeak { get; set; }
            public object BasicChargeKW { get; set; }
            public int MoveInTime { get; set; }
            public bool IsRequestedEffectiveDateOverridden { get; set; }
            public object OfferCode { get; set; }
            public ServiceAddress ServiceAddress { get; set; }
            public EnrollmentHikariService EnrollmentHikariService { get; set; }
            public object SalesBranchCode { get; set; }
            public object SalesAgentName { get; set; }
            public object AgentCustomerCode { get; set; }
        }

        public class ServiceAddress
        {
            public string AddressId { get; set; }
            public object AddressTypeId { get; set; }
            public object AttentionTo { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public object Address3 { get; set; }
            public object Address4 { get; set; }
            public object Address5 { get; set; }
            public string BuildingName { get; set; }
            public object City { get; set; }
            public object State { get; set; }
            public string Zip5 { get; set; }
            public string Zip4 { get; set; }
            public object IsAddressActive { get; set; }
            public object CreatedByName { get; set; }
            public DateTime CreateDate { get; set; }
            public string LastModifiedByName { get; set; }
            public DateTime LastModifyDate { get; set; }
            public object CountryCode { get; set; }
            public string PostalCode { get; set; }
            public object County { get; set; }
            public string Chome { get; set; }
            public string Banchi { get; set; }
            public string Gou { get; set; }
            public string BuildingNumber { get; set; }
            public string RoomNumber { get; set; }
        }
        public class method
        {

            public object? confirnum { get; set; }
            public object? CompName { get; set; }
            public object? BDate { get; set; }
            public object? Paymode { get; set; }
            public object? utilityAC { get; set; }
            public object? Contract { get; set; }
            public object? Divcode { get; set; }
            public object? Credate { get; set; }

        }
        public class record
        {
            public int id { get; set; }
            public string name { get; set; }
        }
}


