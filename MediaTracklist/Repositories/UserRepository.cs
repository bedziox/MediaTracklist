using MediaTracklist.Data;
using MediaTracklist.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MediaTracklist.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DataContext _context;
    private readonly ILogger<UserRepository> _logger;

    public UserRepository(DataContext context, ILogger<UserRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<User?> GetAll()
    {
        return _context.Users.ToList();
    }

    public User? GetById(int userId)
    {
        return _context.Users.Find(userId);
    }

    public async void Insert(User user)
    {
        try
        {
            _context.Users.Add(user);
        }
        catch (Exception e)
        {
            _logger.LogError(e.ToString());
        }
    }

    public async void Update(User user)
    {
        _context.Entry(user).State = EntityState.Modified;
    }

    public async void Delete(int userId)
    {
        User user = _context.Users.Find(userId);
        if (user != null)
        {
            _context.Users.Remove(user);
        }
    }
    public void Save()
    {
        _context.SaveChanges();
    }
    
}