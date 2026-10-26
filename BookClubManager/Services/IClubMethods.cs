using BookClubManager.Data.Models;

namespace BookClubManager.Services;

public interface IClubMethods
{
    Task<List<Club>> GetAllAsync();

    Task<Club?> GetByIdAsync(int id);

    Task AddAsync(Club club);
}