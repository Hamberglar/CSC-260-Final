namespace ITSubmissionForm
{
    class HelpdeskUser : User
    {
        public string Plan { get; private set; }
        public string Organization { get; set; }

        public HelpdeskUser(string HDUserName, string HDUserPass, string HDUserPhone1, string HDUserPhone2, string HDUserEmail, string HDUserAddr)
        {
            //set values for all the members based on arguments passed to the constructor
            Name = HDUserName;
            Password = HDUserPass;
            Phone1 = HDUserPhone1;
            Phone2 = HDUserPhone2;
            Email = HDUserEmail;
            Address = HDUserAddr;
        }

        //Like I said in the base, this override is pretty useless, but it could be expanded upon if we went further with this project.
        public override string UpdateDetails(string HDUserPlan)
        {
            //set values for all the members based on arguments passed to this function
            Plan = HDUserPlan;

            //return a value that the user inputs
            return Prompt.ShowDialog("Organization:", "Who Owns Your HD Plan?");

            //you could also make this function void and use:
            //Organization = Prompt.ShowDialog("Organization:", "Who Owns Your HD Plan?");
            //I elected not to, since this feels more flexible. Not sure what else you'd use it for, but why not?
        }
    }
}
