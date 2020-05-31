using System.Collections.Generic;

namespace GraphQLDemo.Models.Judge
{
    public class Problem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Submission> Submissions { get; set; }
    }
}
