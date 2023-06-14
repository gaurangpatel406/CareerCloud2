using CareerCloud.Pocos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;

namespace CareerCloud.UnitTests.Assignment2
{
    [TestCategory("Assignment 2 Tests"), TestClass]
    public class Assingment2MarkingBase
    {
        private ApplicantEducationPoco _applicantEducation;

        [TestMethod]
        public void Assignment2_DeepDive_CRUD_Test_ApplicantEducationRepository()
        {
            using (TransactionScope Scope = new TransactionScope())
            {
                _dbConstraints.DisableConstraintsForPoco(_applicantEducation.GetType());
                ApplicantEducationAdd();
                ApplicantEducationCheck();
                ApplicantEducationUpdate();
                ApplicantEducationCheck();
                ApplicantEducationRemove();
                _dbConstraints.EnableConstraintsForPoco(_applicantEducation.GetType());
            }
        }

        [TestMethod]
        public void Assignment2_DeepDive_CRUD_Test_ApplicantJobApplicationRepository()
        {
            using (TransactionScope Scope = new TransactionScope())
            {
                _dbConstraints.DisableConstraintsForPoco(_applicantJobApplication.GetType());
                ApplicantJobApplicationAdd();
                ApplicantJobApplicationCheck();
                ApplicantJobApplicationUpdate();
                ApplicantJobApplicationCheck();
                ApplicantJobApplicationRemove();
                _dbConstraints.EnableConstraintsForPoco(_applicantJobApplication.GetType());
            }
        }
    }
}