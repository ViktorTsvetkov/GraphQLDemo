namespace GraphQLDemo.Schemas
{
    using GraphQL;
    using GraphQL.Types;

    public class MainSchema : Schema
    {
        public MainSchema(
            QueryObject query,
            MutationObject mutation,
            SubscriptionObject subscription,
            IDependencyResolver resolver)

            : base(resolver)
        {
            this.Query = query;
            this.Mutation = mutation;
            this.Subscription = subscription;
        }
    }
}
