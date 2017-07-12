using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace certificate_issuing.Domains
{
    public class certificate
    {
        public int Id { get; set; }
        public string StudentsID { get; set; }
        public string AdmNo { get; set; }
        public DateTime DateJoined { get; set; }
        public string StudentsFullNames { get; set; }
        public DateTime dob { get; set; }
        public string course { get; set; }
        public int year { get; set; }
        public string guardiansName { get; set; }
        public string guardiansContact { get; set; }
        public string guardianEmail { get; set; }
    }
}