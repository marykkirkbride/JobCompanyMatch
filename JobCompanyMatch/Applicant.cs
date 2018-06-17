using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCompanyMatch
{
    public class Applicant
    {
        private static int lastUserID = 0;

        #region Properties
        /// <summary>
        /// A unique numeric User identifier that links Applicant Profile and User Profile
        /// </summary>
        public int UserID { get; private set; }
        /// <summary>
        /// Applicant's Email address 
        /// </summary>
        public string EmailAddress { get;  set; }
        /// <summary>
        /// Date and Time UserID was created
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Applicant Location
        /// </summary>
        public string ApplicantLocation { get; set; }
        /// <summary>
        /// Applicant Employment Type (Full time, Part time, Contract)
        /// </summary>
      
  
        public string CurrentPosition { get; set; }
        /// <summary>
        /// Applicant Work Experience Description
        /// </summary>
        public string WorkExperience { get; set; }
        /// <summary>
        /// Applicant Education Description
        /// </summary>
        public string EducationLevel { get; set; }
        /// <summary>
        /// Applicant Skills and Qualifications 
        /// </summary>
        public string Qualifications { get; set; }
        /// <summary>
        /// Applicant Desired Payscale
        /// </summary>
        public float Payscale { get; set; }
        /// <summary>
        /// JobMatch - Holds the ID of the job the applicant is applying for
        /// </summary>
        public int JobMatch { get; private set; }

        #endregion

        #region Constructor
        public Applicant()
        {
            //lastUserID += 1;
            //UserID = lastUserID;
            UserID = ++lastUserID;
            CreatedDate = DateTime.UtcNow;
            
        }

        /*
        public Applicant(string emailAddress) :this()
        {
            EmailAddress = emailAddress;
        }

        public Applicant(string emailAddress, string employmentType) :this(emailAddress)
        {
            EmploymentType = employmentType;
        }
        */
        #endregion

        #region Methods
        /// <summary>
        /// Method for Applicant to apply for Job
        /// </summary>
        /// <param name="jobID"></param>
        public void ApplyforJob(int jobID)
        {
            JobMatch= jobID;
        }
        #endregion


    }



}
