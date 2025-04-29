using System.ComponentModel.DataAnnotations;
namespace Data
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Director { get; set; }
        public string? Description { get; set; }
    }
}