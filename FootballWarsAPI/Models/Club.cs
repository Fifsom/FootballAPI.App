namespace FootballWarsAPI.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img_Name { get; set; }
        public League League { get; set; }
        public int LeagueId { get; set; }
        public List<Player> Players { get; set; }
    }
}
