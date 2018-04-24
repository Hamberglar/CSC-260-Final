using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSubmissionForm
{
    public class User
    {
        private string _Name { get; set; }
        private string _Phone1 { get; set; }
        private string _Phone2 { get; set; }
        private string _Email { get; set; }
        private string _Address1 { get; set; }
        private string _Address2 { get; set; }
        private string DefaultUsername;

        /*public string Name { get => _Name; set => _Name = value; }
        public string Phone1 { get => _Phone1; set => _Phone1 = value; }
        public string Phone2 { get => _Phone2; set => _Phone2 = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Address1 { get => _Address1; set => _Address1 = value; }
        public string Address2 { get => _Address2; set => _Address2 = value; }*/

        public User()
        {
            new User(DefaultUsername);
        }

        public User(string UserName)
        {
            this._Name = UserName;
        }
    }
}
