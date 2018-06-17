using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCompanyMatch
{
    //KAL: Issues with the ENUM. Is this the best use of an ENUM? I swaped the enum JobPosting.cs (Job Posting Type.) I have errors I cannot resolve. 
    enum JobPostingType
    {
        JobPostingTitle,
        JobPostingDescription
        
    }

    public class JobPosting
    {
        #region Properties
        /// <summary>
        /// A unique numeric Company ID that links Company Profile and Job Description
        /// </summary>
        public int CompanyID { get;  set; }
        /// <summary>
        /// A unique ID identifier that is assigned to the Job Description
        /// </summary>
        public int JobDescriptionID { get; set; }
        /// <summary>
        /// Location of Position
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Employment type (Full time, Part time, Contract)
        /// </summary>
        public string EmploymentType { get; set; }
        /// <summary>
        /// Estimated Start Date of Position
        /// </summary>
        public int StartDate { get; set; }
        /// <summary>
        /// Short description of company and culture
        /// </summary>
        public int EducationLevel { get; set; }
        /// <summary>
        /// Job Posting Title
        /// </summary>
        public JobPostingType JobPostingTitle { get; set; }
        /// <summary>
        /// <summary>
        /// Job Posting Description
        /// </summary>
        public JobPostingType JobPostingDescription { get; set; }
        /// <summary>
        /// Job Qualifications (Skills, Software)
        /// </summary>
        public string Qualifications { get; set; }
        /// <summary>
        /// Job Estimated Payscale
        /// </summary>
        public decimal Payscale { get; set; }
        #endregion

        #region Method
        //Select applicant and check to see if they applied
        public bool SelectApplicant(Applicant applicant)
        {
            if (applicant.JobMatch == JobDescriptionID)
            {
                return true;
            }
            return false;
        }
        #endregion

    }
}