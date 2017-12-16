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

        }
        [TestMethod]
        public void Assignment1_Poco_ApplicatSkillPoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_ComanyJobDescriptionPoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_CompanyDescriptionPoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_CompanyJobEducationPoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_CompanyJobPoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_CompanyJobSkillPoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_CompanyLocationPoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_CompanyProfilePoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_SecurityLoginLogPoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_SecurityLoginPoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_SecurityLoginRolePoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_SecurityRolePoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_SystemCountryCodePoco()
        {

        }
        [TestMethod]
        public void Assignment1_Poco_SystemLanguageCodePoco()
        {

        }
       

    }
}
