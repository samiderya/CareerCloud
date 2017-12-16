using CareerCloud.UnitTests.Assignment1Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.UnitTests.Assignment1Tests
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
            _types=Assembly.LoadFrom(_assemblyUnderTest).GetTypes();
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
        public void Assignment_1_Poco_ApplicationEducationPoco()
        {
            Type type = GetCharacteristics.GetType(_types, "ApplicationEducationPoco");
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
    }
}
