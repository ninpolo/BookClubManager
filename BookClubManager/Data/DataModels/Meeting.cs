using System.ComponentModel.DataAnnotations;

namespace BookClubManager.Data.Models;

public class Meeting
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    [Required]
    [StringLength(40)]
    public string Location { get; set; } = null!;

    public Book Book { get; set; } = null!;
    public int BookId { get; set; }

    public Club Club { get; set; } = null!;
    public int ClubId { get; set; }
    
}