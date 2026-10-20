using BookClubManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookClubManager.Data;

public class BookClubDb : DbContext
{
    public BookClubDb(DbContextOptions<BookClubDb> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Club> Clubs { get; set; } = null!;
    public DbSet<Meeting> Meetings { get; set; } = null!;
}