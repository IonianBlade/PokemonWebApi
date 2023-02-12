namespace PokemonWebApi.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
    }
}
