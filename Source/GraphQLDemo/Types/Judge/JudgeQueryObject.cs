using GraphQL.Types;
using GraphQLDemo.Models.Judge;
using GraphQLDemo.Repositories.Judge;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Types.Judge
{
    public class JudgeQueryObject : ObjectGraphType<object>
    {
        public JudgeQueryObject()
        {
            this.FieldAsync<ProblemObject, Problem>(
                "Problem",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>() { Name = "id" }),
                resolve: context => Task.FromResult(Database.Problems.FirstOrDefault(p => p.Id == context.GetArgument<int>("id"))));

            this.FieldAsync<ListGraphType<ProblemObject>, List<Problem>>(
                "Problems",
                resolve: context => Task.FromResult(Database.Problems));
        }
    }
}
