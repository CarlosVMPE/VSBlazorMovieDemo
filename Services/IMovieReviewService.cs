using VSCodeBlazorMovieReview.Models;

namespace VSCodeBlazorMovieReview.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}