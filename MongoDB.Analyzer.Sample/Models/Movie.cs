namespace MongoDB.Analyzer.Sample.Models
{
    public enum Genre 
    {
        Action,
        Drama, 
        Comedy
    };

    public record Movie
    {
        public string? Title { get; set; }
        public int Score { get; set; }
        public Genre Genre { get; set; }
        public string? Reviews { get; set; }
    }
}