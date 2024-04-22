namespace E_Sports_WebApp.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public int NumberOfPlayers { get; set; }
        public List<Player> Players { get; set; }
        public int TournamentsPlayed { get; set; }
        public int TournamentsWon { get; set; }
        public string CurrentRanking { get; set; }

    }
}
