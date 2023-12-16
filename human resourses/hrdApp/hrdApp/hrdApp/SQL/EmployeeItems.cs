using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdApp.SQL
{
    class EmployeeItems
    {
        public string RegNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string AboutPassport { get; set; }
        public string ITN { get; set; }
        public string BirthDay { get; set; }
        public string Residence { get; set; }
        public string ActualResidence { get; set; }
        public string Phone { get; set; }
        public string Education { get; set; }
        public string Conviction { get; set; }
        public string AboutManWoman { get; set; }
        public string AboutParents { get; set; }
        public string AboutChildren { get; set; }
        public string photo_path { get; set; }
    }

    class FurloughItems
    {
        public string RegNumber { get; set; }
        public string StartDate { get; set; }
        public string CountDays { get; set; }
        public string MainSlave { get; set; }
    }

    class PostItems
    {
        public string RegNumber { get; set; }
        public string Post { get; set; }
        public string Qualification { get; set; }
        public string Salary { get; set; }
        public string WorkExperience { get; set; }
    }

    class FindItems
    {
        public string FindPost { get; set; }
    }

}
