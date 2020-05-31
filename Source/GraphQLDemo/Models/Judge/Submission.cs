using System;
using System.Collections.Generic;

namespace GraphQLDemo.Models.Judge
{
    public class Submission
    {
        public int Id { get; set; }

        public int ProblemId { get; set; }

        public string LanguageName { get; set; }

        public DateTime Date { get; set; }

        public double Time { get; set; }

        public double Memory { get; set; }

        public double Points { get; set; }

        public string Status { get; set; }

        public string Source { get; set; }

        public List<SubmissionTestCase> TestCases { get; set; }
    }
}
