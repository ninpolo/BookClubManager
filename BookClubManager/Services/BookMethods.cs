using BookClubManager.Data;
using BookClubManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookClubManager.Services;

public class BookMethods : IBookMethods
{
    private readonly BookClubDb context;

    public BookMethods(BookClubDb context)
    {
        this.context = context;
    }

    public async Task<List<Book>> GetAllAsync()
    {
        return await context.Books.ToListAsync();
    }

    public async Task<Book?> GetByIdAsync(int id)
    {
        return await context.Books.FindAsync(id);
    }

    public async Task AddAsync(Book book)
    {
        context.Books.Add(book);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Book book)
    {
        context.Books.Update(book);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var book = await context.Books.FindAsync(id);

        if (book != null)
        {
            context.Books.Remove(book);
            await context.SaveChangesAsync();
        }
    }
}