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

        //Apparently I need a default constructor so that the subclass can have the elements of this class passed to it?
        //I don't quite understand why it can't just make that work automatically. Auto-implemented properties seems about equally realistic.
        public User()
        {
        }

        public User(string UserName, string UserPass, string UserPhone1, string UserPhone2, string UserEmail, string UserAddr)
        {
            //set values for all the members based on arguments passed to the constructor
            Name = UserName;
            Password = UserPass;
            Phone1 = UserPhone1;
            Phone2 = UserPhone2;
            Email = UserEmail;
            Address = UserAddr;
        }
    }
}
