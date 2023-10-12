using System.ComponentModel.DataAnnotations;

namespace FootballWarsAPI.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img_Name { get; set; }
        public List<Club> Clubs { get; set; }
    }
}
