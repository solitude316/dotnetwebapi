// using DotnetWebApi.Application.Common.Interfaces;

using System.Data;
using MediatR;
using DotnetWebApi.Domain.Entities;
using DotnetWebApi.Domain.Events;
using Dapper;

namespace DotnetWebApi.Application.Users.Commands.CreateUser;

public record CreateUserCommand : IRequest<Guid>
{
    public string? first_name { get; init; }

    public string? latest_name { get; init; }

    public int gender { get; init;}

    public DateTime day_of_birth { get; init;}

    
}

public class CreateUserHandler : IRequestHandler<CreateUserCommand, Guid> 
{
    private IDbConnection _connection;

    public CreateUserHandler(IDbConnection connection) 
    {
        _connection = connection;
    }

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellation)
    {
        var entity = new User() {
            id = Guid.NewGuid(),
            first_name = request.first_name,
            last_name = request.latest_name,
            gender = request.gender,
            day_of_birth = request.day_of_birth
        };

        var sql = @"INSERT INTO USERS 
                (id, first_name, latest_name, gender, day_of_birth, created_at, create_by, updated_at, updated_by) 
                VALUES 
                (@id, @first_name, @latest_name, @gender, @day_of_birth, @created_at, @created_by, @updated_at, @updated_by)";

        _connection.Open();
    
        var afectedRows = await _connection.ExecuteAsync(sql, entity);

        if (afectedRows == 1 ) {
            return entity.id;
        }

        return Guid.Empty;
    }
}