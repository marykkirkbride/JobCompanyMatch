using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCompanyMatch
{
    public class User
    {
        #region Properties
        /// <summary>
        /// A unique numeric User identifier that links Applicant Profile and User Profile
        /// </summary>
        public int UserID { get; private set; }
        /// <summary>
        /// User First Name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// User Last Name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// User Email Address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// User City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// User State
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// User Zip Code
        /// </summary>
        public int ZipCode { get; set; }
        #endregion
    }

   
}
