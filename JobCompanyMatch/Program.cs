using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCompanyMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var applicant = JobMatchFactory.CreateApplicant("test@test.com", "Seattle, WA");
            Console.WriteLine($"Email Address: {applicant.EmailAddress}," +
                $"Location: {applicant.ApplicantLocation}");

            var company = JobMatchFactory.CreateCompany("ACME Company", "Seattle, WA");
            Console.WriteLine($"Company Name: {company.CompanyName}," +
               $"Location: {company.CompanyLocation}");

            var jobPosting = JobMatchFactory.CreateJobPosting("Designer", "Create custom images for highend client.");
            Console.WriteLine($"Job Posting Title: {jobPosting.JobPostingTitle}," +
               $"Job Posting Description: {jobPosting.JobPostingDescription}");
             */

            
            Console.WriteLine("*******************************************");
            Console.WriteLine("******Welcome to Job/Company Match*********");
            while(true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Applicant");
                Console.WriteLine("2. Company");
                Console.WriteLine("3. Posting a Job");
                Console.WriteLine("Please select an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting  Job/Company Match.");
                        return;
                    case "1":
                        Console.WriteLine("Applicant Name: ");
                        var applicantName = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Company Name: ");
                        var companyName = Console.ReadLine();
                        break;
                    case "3":
                        var jobPostingTypes = Enum.GetNames(typeof(JobPostingType));
                        for (var i = 0; i < jobPostingTypes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1} {jobPostingTypes[i]}");
                        }
                        Console.WriteLine("Please select a type of Job Posting");
                        var jobPostingType = (JobPostingType)Enum.Parse(typeof(JobPostingType), Console.ReadLine());

                        //Getting errors will look at in this evening.
                        var jobPosting = JobMatchFactory.CreateJobPosting(JobPostingTitle, JobPostingDescripton);
                        Console.WriteLine($"Job Posting Title: {jobPosting.JobPostingTitle}," +
                            $"Job Posting Description: {jobPosting.JobPostingDescription}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
