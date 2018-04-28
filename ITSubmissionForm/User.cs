using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSubmissionForm
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        private static string DefaultUsername = "Anonymous";

        public User()
        {
            new User(DefaultUsername);
        }

        public User(string UserName)
        {
            Name = UserName;
        }
    }
}
