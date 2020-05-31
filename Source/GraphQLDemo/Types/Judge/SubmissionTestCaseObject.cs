using GraphQL.Types;
using GraphQLDemo.Models.Judge;

namespace GraphQLDemo.Types.Judge
{
    public class SubmissionTestCaseObject : ObjectGraphType<SubmissionTestCase>
    {
        public SubmissionTestCaseObject()
        {
            this.Field(x => x.Id);
            this.Field(x => x.SubmissionId);
            this.Field(x => x.Time);
            this.Field(x => x.Memory);
            this.Field(x => x.Status);
            this.Field(x => x.Output);
        }
    }
}
