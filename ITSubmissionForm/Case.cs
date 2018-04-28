using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSubmissionForm
{
    class Case
    {
        public int CaseID { get; private set; }
        public string Tech { get; set; }
        public string Issue { get; set; }
        public DateTime Date { get; set; }

        public Case(string description)
        {
            Random rnd = new Random();
            CaseID = rnd.Next(1000, 9999);
            Issue = description;
        }
    }
}
