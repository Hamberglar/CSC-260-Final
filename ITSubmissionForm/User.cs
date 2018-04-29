using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSubmissionForm
{
    public class User
    {
        public string Name { get; protected set; }
        public string Password { get; protected set; }
        public string Phone1 { get; protected set; }
        public string Phone2 { get; protected set; }
        public string Email { get; protected set; }
        public string Address { get; protected set; }

        public User()
        {
            throw new System.ArgumentException("You cannot submit a ticket without a name", "Error");
        }

        public User(string UserName, string UserPass, string UserPhone1, string UserPhone2, string UserEmail, string UserAddr)
        {
            Name = UserName;
            Password = UserPass;
            Phone1 = UserPhone1;
            Phone2 = UserPhone2;
            Email = UserEmail;
            Address = UserAddr;
        }
    }
}
