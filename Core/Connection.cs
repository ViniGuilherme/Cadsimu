namespace CadSimuLike.Core
{
    public class Connection
    {
        public string From { get; }
        public string To { get; }

        public Connection(string from, string to)
        {
            From = from;
            To = to;
        }
    }
}