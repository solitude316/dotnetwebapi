namespace Api.Repositories;

using Api.Entities;
public interface IUserRepo
{
    public User Add(User user);
    public Task<User> AddAsync(User user);
    public User GetUserById(Guid id);
    public Task<User> GetUserByIdAsync(Guid id);
}