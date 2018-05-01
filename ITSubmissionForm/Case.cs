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
            Random rnd = new Random();
            ID = rnd.Next(1000, 9999);
            Tech = CaseTech;
            Issue = CaseIssue;
            Date = CaseDate;
        }
    }
}
