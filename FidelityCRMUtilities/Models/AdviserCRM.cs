﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fidelity.CRMUtilities.Models
{

    public class AdviserCRM
    {
        public Account account { get; set; }
        public Agency agency { get; set; }
        public Contact contact { get; set; }
    }

    public class Account
    {
        public string odataetag { get; set; }
        public string ItemInternalId { get; set; }
        public string openrevenue_date { get; set; }
        public string territorycode { get; set; }
        public string _territorycode_label { get; set; }
        public string _owningbusinessunit_value { get; set; }
        public string _owningbusinessunit_type { get; set; }
        public string creditonhold { get; set; }
        public string donotbulkemail { get; set; }
        public string address2_composite { get; set; }
        public string createdon { get; set; }
        public string openrevenue { get; set; }
        public string importsequencenumber { get; set; }
        public string address1_postalcode { get; set; }
        public string opendeals_state { get; set; }
        public string telephone1 { get; set; }
        public string businesstypecode { get; set; }
        public string _businesstypecode_label { get; set; }
        public string preferredcontactmethodcode { get; set; }
        public string _preferredcontactmethodcode_label { get; set; }
        public string donotpostalmail { get; set; }
        public string donotbulkpostalmail { get; set; }
        public string _ownerid_value { get; set; }
        public string _ownerid_type { get; set; }
        public string address1_line1 { get; set; }
        public string name { get; set; }
        public string address1_line3 { get; set; }
        public string address1_city { get; set; }
        public string donotemail { get; set; }
        public string donotphone { get; set; }
        public string address1_composite { get; set; }
        public string address2_addresstypecode { get; set; }
        public string _address2_addresstypecode_label { get; set; }
        public string opendeals_date { get; set; }
        public string accountid { get; set; }
        public string _transactioncurrencyid_value { get; set; }
        public string _transactioncurrencyid_type { get; set; }
        public string donotsendmm { get; set; }
        public string exchangerate { get; set; }
        public string openrevenue_state { get; set; }
        public string _modifiedby_value { get; set; }
        public string _modifiedby_type { get; set; }
        public string address2_city { get; set; }
        public string emailaddress1 { get; set; }
        public string statecode { get; set; }
        public string _statecode_label { get; set; }
        public string statuscode { get; set; }
        public string _statuscode_label { get; set; }
        public string shippingmethodcode { get; set; }
        public string _shippingmethodcode_label { get; set; }
        public string followemail { get; set; }
        public string modifiedon { get; set; }
        public string fdl_perorgid { get; set; }
        public string openrevenue_base { get; set; }
        public string versionnumber { get; set; }
        public string _createdby_value { get; set; }
        public string _createdby_type { get; set; }
        public string fax { get; set; }
        public string address2_line2 { get; set; }
        public string opendeals { get; set; }
        public string donotfax { get; set; }
        public string merged { get; set; }
        public string address1_addresstypecode { get; set; }
        public string _address1_addresstypecode_label { get; set; }
        public string customersizecode { get; set; }
        public string _customersizecode_label { get; set; }
        public string marketingonly { get; set; }
        public string accountratingcode { get; set; }
        public string _accountratingcode_label { get; set; }
        public string participatesinworkflow { get; set; }
        public string accountclassificationcode { get; set; }
        public string _accountclassificationcode_label { get; set; }
        public string address2_line3 { get; set; }
        public string fdl_tradingname { get; set; }
        public string address2_line1 { get; set; }
        public string address1_telephone1 { get; set; }
        public string address1_postofficebox { get; set; }
        public string marketcap { get; set; }
        public string address1_name { get; set; }
        public string emailaddress3 { get; set; }
        public string address1_telephone3 { get; set; }
        public string address2_county { get; set; }
        public string address2_upszone { get; set; }
        public string numberofemployees { get; set; }
        public string address1_line2 { get; set; }
        public string yominame { get; set; }
        public string teamsfollowed { get; set; }
        public string address2_longitude { get; set; }
        public string ownershipcode { get; set; }
        public string _ownershipcode_label { get; set; }
        public string timezoneruleversionnumber { get; set; }
        public string primarysatoriid { get; set; }
        public string _masterid_value { get; set; }
        public string address1_telephone2 { get; set; }
        public string address2_fax { get; set; }
        public string _slaid_value { get; set; }
        public string aging60_base { get; set; }
        public string accountcategorycode { get; set; }
        public string _accountcategorycode_label { get; set; }
        public string entityimage { get; set; }
        public string revenue { get; set; }
        public string fdl_authorisedsignatory { get; set; }
        public string timespentbymeonemailandmeetings { get; set; }
        public string tickersymbol { get; set; }
        public string address2_telephone1 { get; set; }
        public string address2_name { get; set; }
        public string accountnumber { get; set; }
        public string address1_stateorprovince { get; set; }
        public string industrycode { get; set; }
        public string _industrycode_label { get; set; }
        public string address1_latitude { get; set; }
        public string paymenttermscode { get; set; }
        public string _paymenttermscode_label { get; set; }
        public string address2_utcoffset { get; set; }
        public string _modifiedonbehalfby_value { get; set; }
        public string utcconversiontimezonecode { get; set; }
        public string ftpsiteurl { get; set; }
        public string stockexchange { get; set; }
        public string address2_telephone3 { get; set; }
        public string _owningteam_value { get; set; }
        public string aging60 { get; set; }
        public string _defaultpricelevelid_value { get; set; }
        public string aging30 { get; set; }
        public string entityimage_url { get; set; }
        public string sharesoutstanding { get; set; }
        public string address2_latitude { get; set; }
        public string stageid { get; set; }
        public string preferredappointmenttimecode { get; set; }
        public string _preferredappointmenttimecode_label { get; set; }
        public string aging90_base { get; set; }
        public string address1_fax { get; set; }
        public string _originatingleadid_value { get; set; }
        public string description { get; set; }
        public string address2_stateorprovince { get; set; }
        public string overriddencreatedon { get; set; }
        public string address1_country { get; set; }
        public string _slainvokedid_value { get; set; }
        public string address1_primarycontactname { get; set; }
        public string onholdtime { get; set; }
        public string _createdbyexternalparty_value { get; set; }
        public string traversedpath { get; set; }
        public string processid { get; set; }
        public string _createdonbehalfby_value { get; set; }
        public string _modifiedbyexternalparty_value { get; set; }
        public string aging90 { get; set; }
        public string address2_postalcode { get; set; }
        public string address1_shippingmethodcode { get; set; }
        public string entityimage_timestamp { get; set; }
        public string fdl_irdnumber { get; set; }
        public string address1_upszone { get; set; }
        public string address2_primarycontactname { get; set; }
        public string primarytwitterid { get; set; }
        public string _preferredserviceid_value { get; set; }
        public string customertypecode { get; set; }
        public string _customertypecode_label { get; set; }
        public string address2_postofficebox { get; set; }
        public string _primarycontactid_value { get; set; }
        public string address1_freighttermscode { get; set; }
        public string address1_longitude { get; set; }
        public string telephone2 { get; set; }
        public string lastusedincampaign { get; set; }
        public string _preferredsystemuserid_value { get; set; }
        public string creditlimit_base { get; set; }
        public string telephone3 { get; set; }
        public string preferredappointmentdaycode { get; set; }
        public string _preferredappointmentdaycode_label { get; set; }
        public string websiteurl { get; set; }
        public string sic { get; set; }
        public string _preferredequipmentid_value { get; set; }
        public string creditlimit { get; set; }
        public string lastonholdtime { get; set; }
        public string entityimageid { get; set; }
        public string aging30_base { get; set; }
        public string _territoryid_value { get; set; }
        public string address1_county { get; set; }
        public string marketcap_base { get; set; }
        public string address2_country { get; set; }
        public string fdl_accounttype { get; set; }
        public string _fdl_accounttype_label { get; set; }
        public string address1_utcoffset { get; set; }
        public string emailaddress2 { get; set; }
        public string _parentaccountid_value { get; set; }
        public string revenue_base { get; set; }
        public string address2_telephone2 { get; set; }
    }

    public class Agency
    {
        public string odataetag { get; set; }
        public string ItemInternalId { get; set; }
        public string fdl_subletterreturned { get; set; }
        public string fdl_documentsreturned { get; set; }
        public string fdl_fspstatus { get; set; }
        public string _fdl_fspstatus_label { get; set; }
        public string fdl_tworeferences { get; set; }
        public string fdl_picover { get; set; }
        public string fdl_gstregistered { get; set; }
        public string fdl_banknumber { get; set; }
        public string fdl_partnershipprogramme { get; set; }
        public string fdl_agreementid { get; set; }
        public string fdl_aaregisteredcompanyname { get; set; }
        public string fdl_email { get; set; }
        public string fdl_dateappointed { get; set; }
        public string fdl_profmember { get; set; }
        public string fdl_ir330 { get; set; }
        public string fdl_preferrednbuwlocation { get; set; }
        public string fdl_fsp { get; set; }
        public string fdl_interviewedadviser { get; set; }
        public string fdl_bankverification { get; set; }
        public string fdl_generalmanagersignoff { get; set; }
        public string modifiedon { get; set; }
        public string fdl_commissiontermssplits { get; set; }
        public string fdl_onboardingstatus { get; set; }
        public string _fdl_onboardingstatus_label { get; set; }
        public string importsequencenumber { get; set; }
        public string fdl_representative { get; set; }
        public string _fdl_representative_label { get; set; }
        public string fdl_address2street2 { get; set; }
        public string fdl_address2street3 { get; set; }
        public string fdl_address2street1 { get; set; }
        public string _ownerid_value { get; set; }
        public string _ownerid_type { get; set; }
        public string fdl_agreementsent2 { get; set; }
        public string fdl_renewalsowned { get; set; }
        public string _fdl_renewalsowned_label { get; set; }
        public string fdl_address1street1 { get; set; }
        public string fdl_address1street3 { get; set; }
        public string fdl_picompany { get; set; }
        public string fdl_debtcollection { get; set; }
        public string _createdby_value { get; set; }
        public string _createdby_type { get; set; }
        public string fdl_address1city { get; set; }
        public string fdl_adviseradminobp { get; set; }
        public string fdl_advisertype { get; set; }
        public string _fdl_advisertype_label { get; set; }
        public string fdl_adviserapplication { get; set; }
        public string fdl_bdmreport { get; set; }
        public string fdl_fmacheck { get; set; }
        public string fdl_companycert { get; set; }
        public string fdl_traininglocation { get; set; }
        public string _fdl_traininglocation_label { get; set; }
        public string timezoneruleversionnumber { get; set; }
        public string fdl_newagencyagreementsent { get; set; }
        public string statuscode { get; set; }
        public string _statuscode_label { get; set; }
        public string createdon { get; set; }
        public string fdl_sublettersent { get; set; }
        public string fdl_address2city { get; set; }
        public string fdl_subpaiddirect { get; set; }
        public string fdl_references { get; set; }
        public string _fdl_adviserid_value { get; set; }
        public string _fdl_adviserid_type { get; set; }
        public string fdl_servicecategory { get; set; }
        public string _fdl_servicecategory_label { get; set; }
        public string fdl_deedsent { get; set; }
        public string fdl_alternateemail { get; set; }
        public string _fdl_alternateemail_label { get; set; }
        public string fdl_contactdetailscorrect { get; set; }
        public string fdl_existingagency { get; set; }
        public string versionnumber { get; set; }
        public string fdl_perorgid { get; set; }
        public string fdl_incentives { get; set; }
        public string fdl_region { get; set; }
        public string _fdl_region_label { get; set; }
        public string fdl_advisernumber { get; set; }
        public string fdl_countersigned { get; set; }
        public string fdl_agencyid { get; set; }
        public string fdl_creditbelow400 { get; set; }
        public string fdl_subpaiddirectform { get; set; }
        public string fdl_senttonib { get; set; }
        public string fdl_addresscommsto { get; set; }
        public string fdl_apolloversion { get; set; }
        public string _fdl_apolloversion_label { get; set; }
        public string fdl_financials { get; set; }
        public string _modifiedby_value { get; set; }
        public string _modifiedby_type { get; set; }
        public string fdl_password { get; set; }
        public string fdl_mdc { get; set; }
        public string fdl_disclosureread { get; set; }
        public string fdl_filesuploaded { get; set; }
        public string fdl_registrationno { get; set; }
        public string fdl_setupcomplete { get; set; }
        public string fdl_bankname { get; set; }
        public string fdl_disclosurestatement { get; set; }
        public string fdl_agreementsent { get; set; }
        public string fdl_donemigration { get; set; }
        public string fdl_salesteamleadersignoff { get; set; }
        public string _fdl_companyid_value { get; set; }
        public string _fdl_companyid_type { get; set; }
        public string fdl_gst { get; set; }
        public string fdl_dealergroupset { get; set; }
        public string _owningbusinessunit_value { get; set; }
        public string _owningbusinessunit_type { get; set; }
        public string fdl_advisercategory { get; set; }
        public string _fdl_advisercategory_label { get; set; }
        public string statecode { get; set; }
        public string _statecode_label { get; set; }
        public string fdl_disputesresolution { get; set; }
        public string fdl_primaryemail { get; set; }
        public string _fdl_primaryemail_label { get; set; }
        public string fdl_irdnumber { get; set; }
        public string fdl_nib { get; set; }
        public string fdl_name { get; set; }
        public string fdl_notesexceptionsrequired { get; set; }
        public string _fdl_completedby_value { get; set; }
        public string _fdl_finaplicenseholder_value { get; set; }
        public string fdl_aatradingname { get; set; }
        public string fdl_lastemaileddate { get; set; }
        public string fdl_levelofcover { get; set; }
        public string fdl_rfadateregistered { get; set; }
        public string _createdonbehalfby_value { get; set; }
        public string _owningteam_value { get; set; }
        public string fdl_creditcheck1 { get; set; }
        public string fdl_fax { get; set; }
        public string fdl_nibcode { get; set; }
        public string fdl_relationshiptype { get; set; }
        public string _fdl_relationshiptype_label { get; set; }
        public string overriddencreatedon { get; set; }
        public string fdl_datejoinedgroup { get; set; }
        public string fdl_accreditation { get; set; }
        public string _fdl_dealergroupid_value { get; set; }
        public string _stageid_value { get; set; }
        public string fdl_address2country { get; set; }
        public string fdl_marketocomms { get; set; }
        public string fdl_lastappointmentdate { get; set; }
        public string fdl_businessphone { get; set; }
        public string fdl_lastphonecontactdate { get; set; }
        public string fdl_primaryemailreceives { get; set; }
        public string fdl_afadateregistered { get; set; }
        public string fdl_address1street2 { get; set; }
        public string fdl_structuretype { get; set; }
        public string _fdl_structuretype_label { get; set; }
        public string traversedpath { get; set; }
        public string fdl_nbkam { get; set; }
        public string _fdl_nbkam_label { get; set; }
        public string fdl_terminationdate { get; set; }
        public string _fdl_parentagencyid_value { get; set; }
        public string fdl_alternateemailreceives { get; set; }
        public string fdl_tollfreephone { get; set; }
        public string fdl_address1postcode { get; set; }
        public string _fdl_keyaccountmanagerid_value { get; set; }
        public string fdl_wht { get; set; }
        public string utcconversiontimezonecode { get; set; }
        public string fdl_nzhloffice { get; set; }
        public string _modifiedonbehalfby_value { get; set; }
        public string fdl_nzhlcode { get; set; }
        public string fdl_email2 { get; set; }
        public string fdl_pistartdate { get; set; }
        public string processid { get; set; }
        public string fdl_commissionrate { get; set; }
        public string fdl_email3 { get; set; }
        public string fdl_address1country { get; set; }
        public string fdl_disputesresolutionmembership { get; set; }
        public string _fdl_disputesresolutionmembership_label { get; set; }
        public string fdl_piexpirydate { get; set; }
        public string fdl_mobile { get; set; }
        public string fdl_address2postcode { get; set; }
    }

    public class Contact
    {
        public string odatacontext { get; set; }
        public string odataetag { get; set; }
        public string ItemInternalId { get; set; }
        public string customertypecode { get; set; }
        public string _customertypecode_label { get; set; }
        public string address2_addresstypecode { get; set; }
        public string _address2_addresstypecode_label { get; set; }
        public string birthdate { get; set; }
        public string merged { get; set; }
        public string _modifiedby_value { get; set; }
        public string _modifiedby_type { get; set; }
        public string territorycode { get; set; }
        public string _territorycode_label { get; set; }
        public string emailaddress1 { get; set; }
        public string haschildrencode { get; set; }
        public string _haschildrencode_label { get; set; }
        public string exchangerate { get; set; }
        public string preferredappointmenttimecode { get; set; }
        public string _preferredappointmenttimecode_label { get; set; }
        public string address1_line3 { get; set; }
        public string address2_city { get; set; }
        public string isbackofficecustomer { get; set; }
        public string _owningbusinessunit_value { get; set; }
        public string _owningbusinessunit_type { get; set; }
        public string importsequencenumber { get; set; }
        public string address2_line3 { get; set; }
        public string address2_line2 { get; set; }
        public string address2_line1 { get; set; }
        public string address1_composite { get; set; }
        public string lastname { get; set; }
        public string donotpostalmail { get; set; }
        public string marketingonly { get; set; }
        public string donotphone { get; set; }
        public string preferredcontactmethodcode { get; set; }
        public string _preferredcontactmethodcode_label { get; set; }
        public string educationcode { get; set; }
        public string _educationcode_label { get; set; }
        public string _ownerid_value { get; set; }
        public string _ownerid_type { get; set; }
        public string fdl_grouplife100k { get; set; }
        public string customersizecode { get; set; }
        public string _customersizecode_label { get; set; }
        public string firstname { get; set; }
        public string yomifullname { get; set; }
        public string donotemail { get; set; }
        public string fdl_grouplife50k { get; set; }
        public string fullname { get; set; }
        public string timezoneruleversionnumber { get; set; }
        public string msdyn_gdproptout { get; set; }
        public string statuscode { get; set; }
        public string _statuscode_label { get; set; }
        public string createdon { get; set; }
        public string versionnumber { get; set; }
        public string donotsendmm { get; set; }
        public string donotfax { get; set; }
        public string leadsourcecode { get; set; }
        public string _leadsourcecode_label { get; set; }
        public string fdl_title { get; set; }
        public string _fdl_title_label { get; set; }
        public string address1_line1 { get; set; }
        public string modifiedon { get; set; }
        public string creditonhold { get; set; }
        public string telephone1 { get; set; }
        public string _transactioncurrencyid_value { get; set; }
        public string _transactioncurrencyid_type { get; set; }
        public string address1_addresstypecode { get; set; }
        public string _address1_addresstypecode_label { get; set; }
        public string donotbulkemail { get; set; }
        public string fdl_perorgid { get; set; }
        public string followemail { get; set; }
        public string shippingmethodcode { get; set; }
        public string _shippingmethodcode_label { get; set; }
        public string _createdby_value { get; set; }
        public string _createdby_type { get; set; }
        public string address1_city { get; set; }
        public string donotbulkpostalmail { get; set; }
        public string fax { get; set; }
        public string contactid { get; set; }
        public string address2_composite { get; set; }
        public string participatesinworkflow { get; set; }
        public string statecode { get; set; }
        public string _statecode_label { get; set; }
        public string fdl_contacttype { get; set; }
        public string _fdl_contacttype_label { get; set; }
        public string emailaddress3 { get; set; }
        public string address3_telephone3 { get; set; }
        public string mobilephone { get; set; }
        public string utcconversiontimezonecode { get; set; }
        public string _preferredserviceid_value { get; set; }
        public string address3_shippingmethodcode { get; set; }
        public string address3_postalcode { get; set; }
        public string annualincome { get; set; }
        public string telephone3 { get; set; }
        public string address1_primarycontactname { get; set; }
        public string address3_city { get; set; }
        public string lastonholdtime { get; set; }
        public string address2_stateorprovince { get; set; }
        public string assistantphone { get; set; }
        public string lastusedincampaign { get; set; }
        public string address3_freighttermscode { get; set; }
        public string fdl_avpcategory { get; set; }
        public string _fdl_avpcategory_label { get; set; }
        public string pager { get; set; }
        public string employeeid { get; set; }
        public string address1_latitude { get; set; }
        public string _parentcustomerid_value { get; set; }
        public string fdl_lastemaileddate { get; set; }
        public string managername { get; set; }
        public string address1_name { get; set; }
        public string department { get; set; }
        public string address3_country { get; set; }
        public string address2_telephone1 { get; set; }
        public string address2_primarycontactname { get; set; }
        public string address2_latitude { get; set; }
        public string address2_postalcode { get; set; }
        public string entityimage_timestamp { get; set; }
        public string _originatingleadid_value { get; set; }
        public string _masterid_value { get; set; }
        public string _createdonbehalfby_value { get; set; }
        public string address3_postofficebox { get; set; }
        public string business2 { get; set; }
        public string address3_county { get; set; }
        public string address1_freighttermscode { get; set; }
        public string fdl_legalname { get; set; }
        public string address3_addresstypecode { get; set; }
        public string _address3_addresstypecode_label { get; set; }
        public string address1_longitude { get; set; }
        public string aging90_base { get; set; }
        public string spousesname { get; set; }
        public string address3_primarycontactname { get; set; }
        public string familystatuscode { get; set; }
        public string _familystatuscode_label { get; set; }
        public string home2 { get; set; }
        public string address2_utcoffset { get; set; }
        public string aging60 { get; set; }
        public string childrensnames { get; set; }
        public string fdl_lastphonecontactdate { get; set; }
        public string telephone2 { get; set; }
        public string yomimiddlename { get; set; }
        public string _modifiedonbehalfby_value { get; set; }
        public string jobtitle { get; set; }
        public string address3_utcoffset { get; set; }
        public string address1_telephone3 { get; set; }
        public string stageid { get; set; }
        public string gendercode { get; set; }
        public string _gendercode_label { get; set; }
        public string creditlimit_base { get; set; }
        public string address3_line1 { get; set; }
        public string address1_county { get; set; }
        public string _createdbyexternalparty_value { get; set; }
        public string entityimageid { get; set; }
        public string address1_telephone2 { get; set; }
        public string address1_fax { get; set; }
        public string address3_line2 { get; set; }
        public string externaluseridentifier { get; set; }
        public string aging30_base { get; set; }
        public string callback { get; set; }
        public string _preferredequipmentid_value { get; set; }
        public string emailaddress2 { get; set; }
        public string fdl_lastappointmentdate { get; set; }
        public string managerphone { get; set; }
        public string preferredappointmentdaycode { get; set; }
        public string _preferredappointmentdaycode_label { get; set; }
        public string websiteurl { get; set; }
        public string description { get; set; }
        public string address1_telephone1 { get; set; }
        public string address3_composite { get; set; }
        public string address3_fax { get; set; }
        public string _owningteam_value { get; set; }
        public string numberofchildren { get; set; }
        public string subscriptionid { get; set; }
        public string aging90 { get; set; }
        public string address3_latitude { get; set; }
        public string aging60_base { get; set; }
        public string fdl_nibcategory { get; set; }
        public string _fdl_nibcategory_label { get; set; }
        public string entityimage { get; set; }
        public string _modifiedbyexternalparty_value { get; set; }
        public string paymenttermscode { get; set; }
        public string _paymenttermscode_label { get; set; }
        public string address3_name { get; set; }
        public string processid { get; set; }
        public string fdl_interests { get; set; }
        public string ftpsiteurl { get; set; }
        public string address1_shippingmethodcode { get; set; }
        public string _preferredsystemuserid_value { get; set; }
        public string address2_telephone2 { get; set; }
        public string _slainvokedid_value { get; set; }
        public string address3_telephone1 { get; set; }
        public string nickname { get; set; }
        public string address1_postofficebox { get; set; }
        public string address2_postofficebox { get; set; }
        public string assistantname { get; set; }
        public string address2_country { get; set; }
        public string _accountid_value { get; set; }
        public string address2_name { get; set; }
        public string address3_longitude { get; set; }
        public string onholdtime { get; set; }
        public string address2_telephone3 { get; set; }
        public string address3_upszone { get; set; }
        public string aging30 { get; set; }
        public string address2_upszone { get; set; }
        public string address1_upszone { get; set; }
        public string creditlimit { get; set; }
        public string accountrolecode { get; set; }
        public string _accountrolecode_label { get; set; }
        public string salutation { get; set; }
        public string suffix { get; set; }
        public string traversedpath { get; set; }
        public string address1_utcoffset { get; set; }
        public string address1_postalcode { get; set; }
        public string governmentid { get; set; }
        public string address1_stateorprovince { get; set; }
        public string annualincome_base { get; set; }
        public string address1_country { get; set; }
        public string address3_stateorprovince { get; set; }
        public string company { get; set; }
        public string address1_line2 { get; set; }
        public string address2_longitude { get; set; }
        public string address3_telephone2 { get; set; }
        public string yomifirstname { get; set; }
        public string fdl_irdnumber { get; set; }
        public string address2_county { get; set; }
        public string teamsfollowed { get; set; }
        public string fdl_languages { get; set; }
        public string anniversary { get; set; }
        public string _parentcontactid_value { get; set; }
        public string address2_fax { get; set; }
        public string yomilastname { get; set; }
        public string entityimage_url { get; set; }
        public string _defaultpricelevelid_value { get; set; }
        public string _slaid_value { get; set; }
        public string middlename { get; set; }
        public string address3_line3 { get; set; }
        public string overriddencreatedon { get; set; }
        public string timespentbymeonemailandmeetings { get; set; }
    }

}