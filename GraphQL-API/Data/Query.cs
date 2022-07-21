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
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Movie> GetMovies([Service] ApplicationDbContext context) => context.Movies;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superpower> GetSupperPower([Service] ApplicationDbContext context) => context.Superpowers;

    }
}
