namespace Api.Repositories;

using System;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Entities;

public class UserRepo : IUserRepo
{
    private readonly PgSQLContext _context;
    public UserRepo(
        PgSQLContext context
    )
    {
        _context = context;
    }
    
    public User Add(User user)
    {
        user.id = Guid.NewGuid();
        return _context.Users.Add(user).Entity;
    }

    public async Task<User> AddAsync(User user)
    {
        user.id = Guid.NewGuid();
        user.create_time = DateTime.UtcNow;
        user.update_time = DateTime.UtcNow;

        var result = await _context.Users.AddAsync(user);
        return result.Entity;
    }


    public User GetUserById(Guid Id)
    {
        throw new NotImplementedException("Please implement");
    }

    public async Task<User> GetUserByIdAsync(Guid Id)
    {
        var query = from user in _context.Users
                    where user.id == Id
                    select user;

        Console.WriteLine(query.Count());

        User userinfo = await query.FirstOrDefaultAsync<User>() ?? new User();
        return userinfo;
    }
}


