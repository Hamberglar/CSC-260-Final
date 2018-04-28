using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSubmissionForm
{
    class HelpdeskUser : User
    {
        public string Plan { get; private set; }
        public string Organization { get; set; }

        public HelpdeskUser(string UserName, string HDPlan)
        {
            Name = UserName;
            Plan = HDPlan;
        }
    }
}
