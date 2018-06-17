using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCompanyMatch
{

    
    public class Company
    {
        private static int lastCompanyID = 0;

        #region Properties
        /// <summary>
        /// A unique numeric Company ID that links Company Profile and Job Description
        /// </summary>
        public int CompanyID { get;  set; }
        /// <summary>
        /// Company Name
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Company Location
        /// </summary>
        public string CompanyLocation { get; set; }

        #endregion

        public Company()
        {
            //lastUserID += 1;
            //UserID = lastUserID;
            CompanyID = ++lastCompanyID;
       

        }

        public int CreateNewCompanyID()
        {
            return ++lastCompanyID;
        }
    }
}
