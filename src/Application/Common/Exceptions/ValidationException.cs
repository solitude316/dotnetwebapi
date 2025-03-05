using FluentValidation.Results;

namespace DotnetWebApi.Application.Common.Exceptions;

public class ValidationException : Exception
{
    public IDictionary<string, string[]> _Errors { get; }

    public ValidationException()
        : base("Exception...")
    {
        _Errors = new Dictionary<string, string[]>();
    }

    public ValidationException(IEnumerable<ValidationFailure> failures) 
        : this()
    {
        _Errors = failures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }
}