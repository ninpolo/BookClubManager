using BookClubManager.Data;
using BookClubManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookClubManager.Services;

public class ClubMethods : IClubMethods
{
    private readonly BookClubDb context;

    public ClubMethods(BookClubDb context)
    {
        this.context = context;
    }

    public async Task<List<Club>> GetAllAsync()
    {
        return await context.Clubs.ToListAsync();
    }

    public async Task<Club?> GetByIdAsync(int id)
    {
        return await context.Clubs
            .Include(c => c.Meetings)
                .ThenInclude(m => m.Book)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task AddAsync(Club club)
    {
        context.Clubs.Add(club);
        await context.SaveChangesAsync();
    }
}