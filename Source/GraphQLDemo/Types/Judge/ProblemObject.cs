using GraphQL.DataLoader;
using GraphQL.Types;
using GraphQLDemo.Models.Judge;
using GraphQLDemo.Repositories.Judge;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Types.Judge
{
    public class ProblemObject : ObjectGraphType<Problem>
    {
        public ProblemObject(IDataLoaderContextAccessor accessor)
        {
            this.Field(x => x.Id);
            this.Field(x => x.Name);
            this.Field(x => x.Description);
            this.FieldAsync<ListGraphType<SubmissionObject>, List<Submission>>(
                nameof(Problem.Submissions),
                resolve:
                    async context =>
                        (await accessor
                                .Context
                                .GetOrAddCollectionBatchLoader<int, Submission>(
                                                "GetSubmissionsByProblemId",
                                                problemIds => Task.FromResult(Database
                                                                                .Submissions
                                                                                .Where(s => problemIds.Contains(s.ProblemId))
                                                                                .ToLookup(s => s.ProblemId)))
                                .LoadAsync(context.Source.Id))
                                .ToList());
        }
    }
}
