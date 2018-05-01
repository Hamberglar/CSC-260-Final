using System;

namespace ITSubmissionForm
{
    class Case
    {
        public int ID { get; private set; }
        public string Tech { get; private set; }
        public string Issue { get; private set; }
        public DateTime Date { get; private set; }

        public Case(string CaseTech, string CaseIssue, DateTime CaseDate)
        {
            //generate a random 4 digit number from system time seed
            Random rnd = new Random();
            ID = rnd.Next(1000, 9999);

            //set values for all the members based on arguments passed to the constructor
            Tech = CaseTech;
            Issue = CaseIssue;
            Date = CaseDate;
        }
    }
}
