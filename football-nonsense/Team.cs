namespace football_nonsense
{
    public class Team
    {
        public Team(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Team team)
                return team.Name == Name;
            return false;
        }
    }
}