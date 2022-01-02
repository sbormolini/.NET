// data
var names = new[] { "Nick", "Mike", "Maika", "Maya", "Davide", "Leon", "Damian", "Hans" };
var ages = new[] { 28, 12, 23, 34 };
var yearsOfExperience = new[] { 1, 2, 6, 10 };


// Chunk
IEnumerable<IEnumerable<T>> ChunkBy<T>(IEnumerable<T> source, int size)
{
    return source.Select((x, i) => new {Index = i, Value = x})
                 .GroupBy(x => x.Index / size)
                 .Select(x => x.Select(x => x.Value));
}
var chunked = ChunkBy(names, 4);
chunked = names.Chunk(4);


// TryGetNonEnumeratedCount
if (names.TryGetNonEnumeratedCount(out var nonEnumeratedCount))
{ }


// Zip
IEnumerable<(string Name, int Age, int YearsOfExperience)> devs = names.Zip(ages, yearsOfExperience);


// MaxBy, MinBy..
var youngest = devs.OrderBy(x => x.Age).First();
var oldest = devs.OrderByDescending(x => x.Age).First();

youngest = devs.MinBy(x => x.Age);
oldest = devs.MaxBy(x => x.Age);


// ElementAt
var name = names.ElementAt(0);
var namefromEnd1 = names.ElementAt(^1); // pwsh item[-1]
var slice = names.Take(2..4);
var lastThree = names.Take(^3..);


Console.WriteLine("Linq is nice!");