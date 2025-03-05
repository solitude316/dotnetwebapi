using DotnetWebApi.Domain.Common;
using DotnetWebApi.Domain.Entities;

namespace DotnetWebApi.Domain.Events;

public class AccountCompletedEvent : BaseEvent
{
    public Account _account { get; }

    public AccountCompletedEvent(Account account)
    {
        _account = account;
    }
}