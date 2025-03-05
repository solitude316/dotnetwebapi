using DotnetWebApi.Domain.Entities;
using DotnetWebApi.Domain.Common;

namespace DotnetWebApi.Domain.Events;

public class UserCreatedEvent : BaseEvent
{
    public User _user {get; }
    
    public UserCreatedEvent(User user)
    {
        _user = user;
    }
}