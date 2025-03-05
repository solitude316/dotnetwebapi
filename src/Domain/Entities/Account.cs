using DotnetWebApi.Domain.Common;
using DotnetWebApi.Domain.Events;

namespace DotnetWebApi.Domain.Entities;

public class Account : BaseAuditableEntity
{
    public required string email { get; set; }

    public required string password { get; set; }

    public int active { get; set; }

    public DateTimeOffset latest_login { get; set; }

    private bool _done;

    public bool Done 
    {
        get => _done;
        set 
        {
            if (value && !_done)
            {
                AddDomainEvent(new AccountCompletedEvent(this));
            }

            _done = value;
        }
    }
}