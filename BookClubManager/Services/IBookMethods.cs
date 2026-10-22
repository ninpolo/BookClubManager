using BookClubManager.Data.Models;

namespace BookClubManager.Services;

public interface IBookMethods
{
    Task<List<Book>> GetAllAsync();

    Task<Book?> GetByIdAsync(int id);

    Task AddAsync(Book book);

    Task UpdateAsync(Book book);

    Task DeleteAsync(int id);
}