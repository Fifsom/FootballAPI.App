namespace FootballWarsAPI.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img_Name { get; set; }
        public Club Club { get; set; }
        public int ClubId { get; set; }
    }
}
