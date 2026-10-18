using System.ComponentModel.DataAnnotations;

namespace BookClubManager.Data.Models;

public class Club
{
    public int Id { get; set; }

    [Required]
    [StringLength(60)]
    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}