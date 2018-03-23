using System.Text.RegularExpressions;

namespace football_nonsense
{
    public class RawGameParser
    {
        private readonly string _rawString;

        public RawGameParser(string RawGame)
        {
            _rawString = RawGame;
        }


        //"Bournemouth 0-1 Aston Villa"
        public Game ParseGame()
        {
            var match = new Regex(@"^(\w[\w\s]+)\s+(\d+)-(\d+)\s+(\w[\w\s]+)$").Match(_rawString);
            return new Game(match.Groups[1].Value, match.Groups[4].Value, int.Parse(match.Groups[2].Value),
                int.Parse(match.Groups[3].Value));
        }
    }
}