using MongoDB.Analyzer.Sample.Models;
using MongoDB.Driver;

namespace MongoDB.Analyzer.Sample.Basic;

public class BuilderSample
{
    public async Task<List<Movie>> GetMovies(double minScore, Genre genre, string titleSearchTerm)
    {
        var mongoClient = new MongoClient(@"mongodb://localhost:27017");
        var db = mongoClient.GetDatabase("testdb");
        var moviesCollection = db.GetCollection<Movie>("movies");

        // Filter definition (analyzer provides mql as information message)
        var filter = Builders<Movie>.Filter.Eq(m => m.Genre, genre) &
            Builders<Movie>.Filter.Gte(m => m.Score, minScore) &
            Builders<Movie>.Filter.Regex(m => m.Title, titleSearchTerm);

        // Sort definition (analyzer provides mql as information message)
        var sort = Builders<Movie>.Sort.Ascending(m => m.Score)
                                       .Descending(m => m.Title);

        var movies = await moviesCollection.Find(filter).Sort(sort).ToListAsync();

        return movies;
    }

    public void NotSupoortedFilter()
    {
        var filter = Builders<Movie>.Filter.Gt(m => m.Reviews.Length, 2);
    }
}
