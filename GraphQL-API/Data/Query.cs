using GraphQL_API.Model;

namespace GraphQL_API.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
           context.Superheroes;
    }
}
