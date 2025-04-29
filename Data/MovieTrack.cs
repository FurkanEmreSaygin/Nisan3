using System.ComponentModel.DataAnnotations;
namespace Data
{
    public class MovieTrack
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public string? Status { get; set; }
    }
}