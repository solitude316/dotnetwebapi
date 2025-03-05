using DotnetWebApi.Domain.Common;
using DotnetWebApi.Domain.Entities;

namespace DotnetWebApi.Domain.Events;

public class UserCompletedEvent : BaseEvent
{
    public User _user { get; }

    public UserCompletedEvent(User user)
    {
        _user = user;
    }
}