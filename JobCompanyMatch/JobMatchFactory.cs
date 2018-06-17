using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCompanyMatch
{
    

    //Similar to Bank Class
     static class JobMatchFactory
    {
        private static List<Company> companies = new List<Company>();


        //Factory Method for Company
        public static Company CreateCompany(string companyName, string companyLocation)
        {
            var company = new Company
            {
                CompanyName = companyName,
                CompanyLocation = companyLocation
            };
            companies.Add(company);
            return company;
        }
        //Factory Method for Applicant
        public static Applicant CreateApplicant(string emailAddress, string applicantLocation)
        {
            var applicant = new Applicant
            {
                EmailAddress = emailAddress,
                ApplicantLocation = applicantLocation
            };
            return applicant;
        }

        //Factory Method for Job Posting
        //public static JobPosting CreateJobPosting(int companyID, string jobPostingTitle, string jobPostingDescription)
        public static JobPosting CreateJobPosting(JobPostingType jobPostingTitle, JobPostingType jobPostingDescription, string employmentType)
        {
            var jobPosting = new JobPosting
            {
                //CompanyID = companyID,
                JobPostingType JobPostingTitle = JobPostingType.JobPostingTitle,
                JobPostingType JobPostingDescription = JobPostingType.JobPostingDescription,
                EmploymentType = employmentType
            };
            return jobPosting;
        }

    }
}
