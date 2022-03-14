using MongoDB.Analyzer.Sample.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB.Analyzer.Sample;

public class Linq3Sample
{
    public void NotSupportedInLinq2Expressions()
    {
        var mongoClient = new MongoClient(@"mongodb://localhost:27017");
        var db = mongoClient.GetDatabase("testdb");
        var moviesCollection = db.GetCollection<Movie>("movies").AsQueryable();

        // Trim()
        _ = moviesCollection.Where(m => m.Title.Trim() == "Avatar");

        // Substring()
        _ = moviesCollection.Where(m => m.Producer.Substring(0, 6) == "James");
    }
}
