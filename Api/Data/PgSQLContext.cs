using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Api.Entities;

namespace Api.Data;

public class PgSQLContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PgSQLContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConneciton"));
    }

    // DB set
    public DbSet<User> Users {get; set;} = default!;

}