using DotnetWebApi.Domain.Entities;
using DotnetWebApi.Domain.Common;

namespace DotnetWebApi.Domain.Events;

public class AccountCreatedEvent : BaseEvent
{
    public Account _account {get; }
    
    public AccountCreatedEvent(Account account)
    {
        _account = account;
    }
}