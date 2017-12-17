using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Linq;
using CareerCloud.UnitTest.Assignment1Test.Utils;

namespace CareerCloud.UnitTest.Assignment1Test
{
    [TestCategory("Assignment 1 Poco Tests")]
    [TestClass]
    public class Assignment1Marking
    {
        private const string _assemblyUnderTest = "CareerCloud.Pocos.dll";
        private Type[] _types;
        [TestInitialize]
        public void Init()
        {
            _types = Assembly.LoadFrom(_assemblyUnderTest).GetTypes();
        }
        [TestMethod]
        public void Assignment_1_Poco_Creation()
        {
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantEducationPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantJobApplicationPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantProfilePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantResumePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantWorkHistoryPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicatSkillPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ComanyJobDescriptionPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyDescriptionPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyJobEducationPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyJobPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyJobSkillPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyLocationPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyProfilePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SecurityLoginLogPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SecurityLoginPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SecurityLoginRolePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SecurityRolePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SystemCountryCodePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SystemLanguageCodePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "IPoco"));
        }

        [TestMethod]
        public void Assignment1_Poco_ApplicationEducationPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "ApplicantEducationPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Applicant_Educations"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CertificateDiploma"), "Certificate_Diploma"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "CertificateDiploma"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "StartDate"), "Start_Date"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(DateTime?), "StartDate"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CompletionDate"), "Completion_Date"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(DateTime?), "CompletionDate"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CompletionPercent"), "Completion_Percent"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte?), "CompletionPercent"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Applicant"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Applicant"));
            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Major"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Major"));

        }
        [TestMethod]
        public void Assignment1_Poco_ApplicantJobApplicationPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "ApplicantJobApplicationPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type,"IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Applicant_Job_Applications"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Applicant"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Applicant"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Job"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Job"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "ApplicationDate"), "Application_Date"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(DateTime), "ApplicationDate"));
            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "ApplicationDate"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));
            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "TimeStamp"));



        }
        [TestMethod]
        public void Assignment1_Poco_ApplicantProfilePoco()
        {
            Type type = GetCharacteristics.GetType(_types, "ApplicantProfilePoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Applicant_Profiles"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Login"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Login"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CurrentSalary"), "Current_Salary"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(decimal?), "CurrentSalary"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CurrentRate"), "Current_Rate"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(decimal?), "CurrentRate"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Currency"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Currency"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CountryCode"), "Country_Code"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "CountryCode"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "StateProvinceCode"), "State_Province_Code"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "StateProvinceCode"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "StreetAddress"), "Street_Address"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "StreetAddress"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CityTown"), "City_Town"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "CityTown"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "ZipPostalCode"), "Zip_Postal_Code"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "ZipPostalCode"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "ZipPostalCode"), "Zip_Postal_Code"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "ZipPostalCode"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "TimeStamp"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));

        }
        [TestMethod]
        public void Assignment1_Poco_ApplicantResumePoco()
        {
            Type type = GetCharacteristics.GetType(_types, "ApplicantResumePoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Applicant_Resumes"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Applicant"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Applicant"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Resume"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Resume"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "LastUpdated"), "Last_Updated"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(DateTime?), "LastUpdated"));


        }
        [TestMethod]
        public void Assignment1_Poco_ApplicantWorkHistoryPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "ApplicantWorkHistoryPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Applicant_Work_History"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Applicant"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Applicant"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CompanyName"), "Company_Name"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "CompanyName"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CountryCode"), "Country_Code"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "CountryCode"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Location"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Location"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "JobTitle"), "Job_Title"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "JobTitle"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "JobDescription"), "Job_Description"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "JobDescription"));
            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "JobDescription"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "StartMonth"), "Start_Month"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(short), "StartMonth"));
            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "StartMonth"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "StartYear"), "Start_Year"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(int), "StartYear"));
            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "StartYear"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "EndMonth"), "End_Month"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(short), "EndMonth"));
            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "EndMonth"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "EndYear"), "End_Year"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(int), "EndYear"));
            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "EndYear"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "TimeStamp"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));



        }
        [TestMethod]
        public void Assignment1_Poco_ApplicatSkillPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "ApplicatSkillPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Applicant_Skills"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Applicant"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Applicant"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Skill"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Skill"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "SkillLevel"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "SkillLevel"), "Skill_Level"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "SkillLevel"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "StartMonth"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "StartMonth"), "Start_Month"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte), "StartMonth"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "StartYear"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "StartYear"), "Start_Year"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(int), "StartYear"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "EndMonth"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "EndMonth"), "End_Month"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte), "EndMonth"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "EndYear"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "EndYear"), "End_Year"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(int), "EndYear"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "TimeStamp"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));



        }
        [TestMethod]
        public void Assignment1_Poco_ComanyJobDescriptionPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "ComanyJobDescriptionPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Company_Jobs_Descriptions"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Job"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Job"));

          
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "JobName"), "Job_Name"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "JobName"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "JobDescription"), "Job_Description"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "JobDescription"));

   
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));


        }
        [TestMethod]
        public void Assignment1_Poco_CompanyDescriptionPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "CompanyDescriptionPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Company_Descriptions"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Company"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Company"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "LanguageId"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "LanguageId"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "LanguageId"), "LanguageID"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CompanyDescription"), "Company_Description"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "CompanyDescription"));
            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "CompanyDescription"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "TimeStamp"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));


        }
        [TestMethod]
        public void Assignment1_Poco_CompanyJobEducationPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "CompanyJobEducationPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Company_Job_Educations"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Job"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Job"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Major"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Major"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Importance"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Int16), "Importance"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "TimeStamp"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));


        }
        [TestMethod]
        public void Assignment1_Poco_CompanyJobPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "CompanyJobPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Company_Jobs"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Company"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Company"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "ProfileCreated"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "ProfileCreated"), "Profile_Created"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(DateTime), "ProfileCreated"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "IsInactive"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "IsInactive"), "Is_Inactive"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(bool), "IsInactive"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "IsCompanyHidden"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "IsCompanyHidden"), "Is_Company_Hidden"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(bool), "IsCompanyHidden"));


            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));


        }
        [TestMethod]
        public void Assignment1_Poco_CompanyJobSkillPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "CompanyJobSkillPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Company_Job_Skills"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Job"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Job"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Skill"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Skill"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "SkillLevel"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "SkillLevel"), "Skill_Level"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "SkillLevel"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Importance"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(int), "Importance"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "TimeStamp"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));


        }
        [TestMethod]
        public void Assignment1_Poco_CompanyLocationPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "CompanyLocationPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Company_Locations"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Company"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Company"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "CountryCode"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CountryCode"), "Country_Code"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "CountryCode"));

        
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "StateProvinceCode"), "State_Province_Code"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "StateProvinceCode"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "StreetAddress"), "Street_Address"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "StreetAddress"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CityTown"), "City_Town"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "CityTown"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "ZipPostalCode"), "Zip_Postal_Code"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "ZipPostalCode"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "TimeStamp"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));


        }
        [TestMethod]
        public void Assignment1_Poco_CompanyProfilePoco()
        {
            Type type = GetCharacteristics.GetType(_types, "CompanyProfilePoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Company_Profiles"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "RegistrationDate"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "RegistrationDate"), "Registration_Date"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(DateTime), "RegistrationDate"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CompanyWebsite"), "Company_Website"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "CompanyWebsite"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "ContactPhone"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "ContactPhone"), "Contact_Phone"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "ContactPhone"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "ContactName"), "Contact_Name"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "ContactName"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CompanyLogo"), "Company_Logo"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "CompanyLogo"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));




        }
        [TestMethod]
        public void Assignment1_Poco_SecurityLoginLogPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "SecurityLoginLogPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Security_Logins_Log"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Login"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Login"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "SourceIP"), "Source_IP"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "SourceIP"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "LogonDate"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "LogonDate"), "Logon_Date"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(DateTime), "LogonDate"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "IsSuccesful"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "IsSuccesful"), "Is_Succesful"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(bool), "IsSuccesful"));


        }
        [TestMethod]
        public void Assignment1_Poco_SecurityLoginPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "SecurityLoginPoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Security_Logins"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Login"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Login"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Password"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Password"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "CreatedDate"), "Created_Date"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(DateTime), "CreatedDate"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "AgreementAcceptedDate"), "Agreement_Accepted_Date"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(DateTime?), "AgreementAcceptedDate"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "IsLocked"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "IsLocked"), "Is_Locked"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(bool), "IsLocked"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "IsInactive"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "IsInactive"), "Is_Inactive"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(bool), "IsInactive"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "EmailAddress"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "EmailAddress"), "Email_Address"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "EmailAddress"));

          
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "PhoneNumber"), "Phone_Number"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "PhoneNumber"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "FullName"), "Full_Name"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "FullName"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "ForceChangePassword"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "ForceChangePassword"), "Force_Change_Password"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(bool), "ForceChangePassword"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "PrefferredLanguage"), "Prefferred_Language"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "PrefferredLanguage"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "TimeStamp"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));




        }
        [TestMethod]
        public void Assignment1_Poco_SecurityLoginRolePoco()
        {
            Type type = GetCharacteristics.GetType(_types, "SecurityLoginRolePoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Security_Logins_Roles"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Login"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Login"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Role"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Role"));

            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(byte[]), "TimeStamp"));

        }
        [TestMethod]
        public void Assignment1_Poco_SecurityRolePoco()
        {
            Type type = GetCharacteristics.GetType(_types, "SecurityRolePoco");
            Assert.IsTrue(GetCharacteristics.ImplementsInterface(type, "IPoco"));
            Assert.IsTrue(GetCharacteristics.HasTable(type, "Security_Roles"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Id")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(Guid), "Id"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Role"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Role"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "IsInactive"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(bool), "IsInactive"));


        }
        [TestMethod]
        public void Assignment1_Poco_SystemCountryCodePoco()
        {
            Type type = GetCharacteristics.GetType(_types, "SystemCountryCodePoco");
            Assert.IsTrue(GetCharacteristics.HasTable(type, "System_Country_Codes"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "Code")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Code"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Name"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Name"));


        }
        [TestMethod]
        public void Assignment1_Poco_SystemLanguageCodePoco()
        {
            Type type = GetCharacteristics.GetType(_types, "SystemLanguageCodePoco");
            Assert.IsTrue(GetCharacteristics.HasTable(type, "System_Language_Codes"));

            Assert.IsTrue(GetCharacteristics.HasKey(GetCharacteristics.GetProperty(type, "LanguageID")));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "LanguageID"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "Name"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "Name"));

            Assert.IsNotNull(GetCharacteristics.GetProperty(type, "NativeName"));
            Assert.IsTrue(GetCharacteristics.HasColumn(GetCharacteristics.GetProperty(type, "NativeName"), "Native_Name"));
            Assert.IsTrue(GetCharacteristics.GetPropertyType(type, typeof(string), "NativeName"));
        }
       

    }
}
