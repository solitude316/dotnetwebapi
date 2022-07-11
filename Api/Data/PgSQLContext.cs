namespace Api.Data;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Entities;

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
    public DbSet<User>? Users {get; set;}
}