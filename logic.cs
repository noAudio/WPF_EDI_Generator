﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrLitovs837pGenerator
{
    class logic
    {
        Dictionary<string, string> records = new Dictionary<string, string>() 
        {
            {"PayerName", "Anthem"},
            {"PayerID", "BC001"},
            {"PayerCity", "Los Angeles"},
            {"PayerState", "CA"},
            {"PayerZip", "90034"},
            {"Medicare", "***"},
            {"Medicaid", "***"},
            {"FECA", "***"},
            {"Tricare", "***"},
            {"GroupHealthPlan", "***"},
            {"Champva", "***"},
            {"Other", "X"},
            {"InsuredsIDNo", "R555M333"},
            {"PatientLastName", "Smith"},
            {"PatientFirstName", "John"},
            {"PatientMiddleNameInitial", "M"},
            {"PatientDOBMonth", "9"},
            {"PatientDOBDay", "13"},
            {"PatientDOBYear", "91"},
            {"PatientGenderM", "***"},
            {"PatientGenderF", "X"},
            {"InsuredsLastName", "Smith"},
            {"InsuredsFirstName", "John"},
            {"InsuredsMiddleNameInitial", "M"},
            {"PatientsAddressStreetNo", "7360 TEST 38 ST"},
            {"PatientsCity", "Los Angeles"},
            {"PatientsState", "CA"},
            {"PatientZipCode", "90025" },
            {"PatientRelationshipToInsuredSpouse", "***"},
            {"PatientRelationshipToInsuredChild", "***"},
            {"PatientRelationshipToInsuredOther", "***"},
            {"PatientRelationshipToInsuredSelf", "X"},
            {"InsuredsAddressStreetNo", "7360 TEST 38 ST"},
            {"InsuredsCity", "Los Angeles"},
            {"InsuredsState", "CA"},
            {"InsuredsZipCode", "90025"},
            {"InsuredsGenderFemale", "***"},
            {"InsuredsGenderMale", "X"},
            {"InsuredsOtherNameLastFirstMInitial", "***"},
            {"InsuredsPolicyOrGroupNumberOther", "***"},
            {"InsurancePlanNameOrProgramName", "***"},
            {"AutoAccidentState", "***"},
            {"PatientConditionOtherAccidentNo", "X"},
            {"PaitentConditionOtherAccidentX", "***"},
            {"PatientConditionAutoAccidentX", "***"},
            {"PatientConditionAutoNo", "X"},
            {"PatientConditionAutoNumber", "X"},
            {"PatientConditionEmploymentX", "***"},
            {"ClaimCodesDesignatedByNUCC", "***"},
            {"OtherHealthPlanYes", "***"},
            {"OtherHealthPlanNo", "***"},
            {"InsuredsPolicyGroupOrFECANo", "***"},
            {"InsuredsDOBMonth", "9"},
            {"InsuredsDOBDate", "13"},
            {"InsuredsDOBYear", "91"},
            {"OtherHealthBenefitPlanYes", "***"},
            {"OtherHealthBenefitPlanNo", "***"},
            {"SignatureOnFileYes", "X"},
            {"Date", "2/18/2019"},
            {"InsuredAuthorizedSignatureYes", "X"},
            {"DateOfCurrentIllness", "***"},
            {"Qualifier", "***"},
            {"CurrentIllnessMonth", "***"},
            {"CurrentIllnessYear", "***"},
            {"ReferringProviderID", "***"},
            {"ICDIndicator0=icd10", "0"},
            {"DiagnosisA", "F411"},
            {"DiagnosisB", "***"},
            {"DiagnosisC", "***"},
            {"DiagnosisD", "***"},
            {"DiagnosisE", "***"},
            {"DateOfServiceFromMonth", "2"},
            {"DateOfServiceFromDay", "18"},
            {"DateOfServiceFromYear", "19"},
            {"POS", "11"},
            {"EMG", "***"},
            {"CPT/HCPS", "90834"},
            {"ModifierA", "HH"},
            {"ModifierB", "***"},
            {"ModifierC", "***"},
            {"ModifierD", "***"},
            {"DiagnosisPointer", "A"},
            {"Charges", "290"},
            {"ChargesDecim", "0"},
            {"GDaysOrUnits", "1"},
            {"EPSDT", "***"},
            {"IQualifer", "***"},
            {"RenderingProviderID", "1538252892"},
            {"FederalTaxIDNumber", "711021176"},
            {"SSN", "***"},
            {"EIN", "X"},
            {"PatientAccountNo", "1111111111"},
            {"AcceptAssignmentAlways", "X"},
            {"TotalCharge", "290"},
            {"TotalChargeDecim", "***"},
            {"AmountPaid", "0"},
            {"AmountPaidDecim", "25"},
            {"ServiceFacultyName", "AAP"},
            {"ServiceFacultyAddress", "2001 S Barrington Ave Suite 301"},
            {"ServiceFacultyCity", "Los Angeles"},
            {"ServiceFacultyState", "CA" },
            {"ServiceFacultyZip", "90025"},
            {"FacilityProviderNPI", "1497893291"},
            {"FaciltyProviderOtherID", ""},
            {"BillingProviderFullName", "AAP"},
            {"BillingProviderAddress", "2001 S Barrington Ave Suite 301"},
            {"BillingProviderCity", "Los Angeles"},
            {"BillingProviderState", "CA"},
            {"BillingProviderZip", "90025"},
            {"BillingProviderPhoneAreaCode", "310"},
            {"BillingProviderPhoneNumber", "3232717796"},
            {"BillingProviderNPI", "1497893291"},
            {"BillingProviderOtherID", ""},
            {"RenderingNPI", "1538252812"}
        };

        Dictionary<string, string> edi_claim = new Dictionary<string, string>()
        {
            // Loop  2000A Section
            {"Loop2000A/BillingProvider/Hierarchy/1/20/1", "HL*1*20*1~" },
            {"Loop2000A/BillingProvider/Name", "NM1*85*2*" + records["BillingProviderFullName"] },
            {"Loop2000A/BillingProvider/InfoCont", "CLINIC*****XX*" + records["BillingProviderNPI"] + "~"},
            {"Loop2000A/BillingProvider/StreetAddress", "N3*" + records["BillingProviderAddress"] + "~"},
            {"Loop2000A/BillingProvider/CityStateAndZip", "N4*" + records["BillingProviderCity"] + "*" + records["BillingProviderState"] + "*" + records["BillingProviderZip"] + "~" },
            {"Loop2000A/BillingProvider/Reference/TaxID/EIN", "REF*EI*" + records[""] + "~"},
            {"Loop2000A/BillingProvider/InformationContact", "PERC*IC*" + records[""] + "*TE*" + records[""] + "~"},
            {"Loop2000A/BillingProvider/NM1/87/2", "NM1*87*2*~" },
            {"Loop2000A/BillingProvider/StreetAddress", "N3*" + records[""] + "~"},
            {"Loop2000A/BillingProvider/CityStateAndZipCode", "N4*" + records[""] + "*" + records[""] + "~"}
        };
    }
}
