namespace GraphQLDemo.Models.Judge
{
    public class SubmissionTestCase
    {
        public int Id { get; set; }

        public int SubmissionId { get; set; }

        public double Time { get; set; }

        public double Memory { get; set; }

        public string Status { get; set; }

        public string Output { get; set; }
    }
}
