namespace ITSubmissionForm
{
    class HelpdeskUser : User
    {
        public string Plan { get; private set; }
        public string Organization { get; set; }

        public HelpdeskUser(string HDUserName, string HDUserPass, string HDUserPhone1, string HDUserPhone2, string HDUserEmail, string HDUserAddr)
        {
            
            Name = HDUserName;
            Password = HDUserPass;
            Phone1 = HDUserPhone1;
            Phone2 = HDUserPhone2;
            Email = HDUserEmail;
            Address = HDUserAddr;
        }

        public string PlanInfo(string HDUserPlan)
        {
            Plan = HDUserPlan;
            return Prompt.ShowDialog("Organization:", "Who Owns Your HD Plan?");
        }
    }
}
