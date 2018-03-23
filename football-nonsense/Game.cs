namespace football_nonsense
{
    public class Game
    {
        public Game(string homeTeam, string awayTeam, int homeTeamScore, int awayTeamScore)
        {
            HomeTeam = new Team(homeTeam);
            AwayTeam = new Team(awayTeam);
            HomeTeamScore = homeTeamScore;
            AwayTeamScore = awayTeamScore;
        }

        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Game game)
                return game.AwayTeam.Equals(AwayTeam) && game.HomeTeam.Equals(HomeTeam) &&
                       game.AwayTeamScore == AwayTeamScore && game.HomeTeamScore == HomeTeamScore;
            return false;
        }
    }
}