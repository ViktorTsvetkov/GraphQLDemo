using GraphQL.DataLoader;
using GraphQL.Types;
using GraphQLDemo.Models.Judge;
using GraphQLDemo.Repositories.Judge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Types.Judge
{
    public class SubmissionObject : ObjectGraphType<Submission>
    {
        public SubmissionObject(IDataLoaderContextAccessor accessor)
        {
            this.Field(x => x.Id);
            this.Field(x => x.ProblemId);
            this.Field(x => x.LanguageName);
            this.Field(x => x.Date);
            this.Field(x => x.Time);
            this.Field(x => x.Memory);
            this.Field(x => x.Points);
            this.Field(x => x.Status);
            this.Field(x => x.Source);
            this.FieldAsync<ListGraphType<SubmissionTestCaseObject>, List<SubmissionTestCase>>(
                nameof(Submission.TestCases),
                resolve: 
                    async context =>
                        (await accessor
                                .Context
                                .GetOrAddCollectionBatchLoader<int, SubmissionTestCase>(
                                                "GetTestCasesBySubmissionId",
                                                submissionIds => Task.FromResult(Database
                                                                                    .TestCases
                                                                                    .Where(t => submissionIds.Contains(t.SubmissionId))
                                                                                    .ToLookup(t => t.SubmissionId)))
                                .LoadAsync(context.Source.Id))
                                .ToList());
        }
    }
}
