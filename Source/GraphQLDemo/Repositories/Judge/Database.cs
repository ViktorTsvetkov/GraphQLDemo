using GraphQLDemo.Models.Judge;
using System;
using System.Collections.Generic;

namespace GraphQLDemo.Repositories.Judge
{
    public static class Database
    {
        public static List<Problem> Problems => new List<Problem>()
        {
            new Problem() { Id = 1, Name = "Hello, Telerik Academy", Description = "Write a program that will print on the console Hello, Telerik Academy!." },
            new Problem() { Id = 2, Name = "Say Hello", Description = "Write a program that recieves the users name and prints Hello, <name>!." }
        };

        public static List<Submission> Submissions => new List<Submission>()
        {
            new Submission() { Id = 1, ProblemId = 1, Date = DateTime.UtcNow, LanguageName = "JavaScript", Status = "Accepted", Memory = 100, Time = 50, Points = 100, Source = "print('Hello, Telerik Academy!');" },
            new Submission() { Id = 2, ProblemId = 1, Date = DateTime.UtcNow, LanguageName = "C#", Status = "Compile Error", Memory = 0, Time = 0, Points = 0, Source = "print('Hello, Telerik Academy!');" },
            new Submission() { Id = 3, ProblemId = 2, Date = DateTime.UtcNow, LanguageName = "JavaScript", Status = "Accepted", Memory= 80, Time = 60, Points = 100, Source = "print(`Hello, ${gets()}!`);" }
        };

        public static List<SubmissionTestCase> TestCases => new List<SubmissionTestCase>()
        {
            new SubmissionTestCase() { Id = 1, SubmissionId = 1, Memory = 100, Time = 50, Status = "Accepted", Output = "Hello, Telerik Academy!" },
            new SubmissionTestCase() { Id = 2, SubmissionId = 2, Memory = 0, Time = 0, Status = "Compile Error", Output = string.Empty },
            new SubmissionTestCase() { Id = 3, SubmissionId = 3, Memory = 75, Time = 50, Status = "Accepted", Output = "Hello, Peter!" },
            new SubmissionTestCase() { Id = 4, SubmissionId = 3, Memory = 80, Time = 60, Status = "Accepted", Output = "Hello, Ivan!" },
            new SubmissionTestCase() { Id = 5, SubmissionId = 3, Memory = 75, Time = 50, Status = "Accepted", Output = "Hello, Gosho!" }
        };
    }
}
