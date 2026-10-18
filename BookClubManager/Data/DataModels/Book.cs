using System.ComponentModel.DataAnnotations;

namespace BookClubManager.Data.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!;


        [Required]
        [StringLength(40)]
        public string Author { get; set; } = null!;

        public int PageCount { get; set; }
    }
}