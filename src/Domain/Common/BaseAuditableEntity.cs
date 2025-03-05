namespace DotnetWebApi.Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    private Guid _id;
    public required Guid id 
    { 
        get => _id; 
        set {
            if (_id == Guid.Empty) {
                _id = value;
            }
        } 
    }

    private DateTimeOffset? _created_at { get; set; }
    public DateTimeOffset? created_at {
        get => _created_at;
        set {
            if (!_created_at.HasValue)
            {
                _created_at = value;
            }
        }
    }

    // public DateTimeOffset created_at { get; set; }

    public string? created_by { get; set; } = "";

    public DateTimeOffset updated_at { get; set; } = DateTime.Now;

    public string? updated_by { get; set; } = "";
}