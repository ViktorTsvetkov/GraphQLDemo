using GraphQL.Types;
using GraphQLDemo.Types.Judge;
using GraphQLDemo.Types.StarWars;

namespace GraphQLDemo.Schemas
{
    public class QueryObject : ObjectGraphType<object>
    {
        public QueryObject()
        {
            this.Field<StarWarsQueryObject>("StarWars", resolve: _ => new object());
            this.Field<JudgeQueryObject>("Judge", resolve: _ => new object());
        }
    }
}
