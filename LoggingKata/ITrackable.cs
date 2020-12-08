namespace LoggingKata
{

    public class TacoBell : ITrackable 
    {
        public string Name { get; set; }
        public Point Location { get; set; }
    }
    public interface  ITrackable
    {
        string Name { get; set; }
        Point Location { get; set; }
    }
}