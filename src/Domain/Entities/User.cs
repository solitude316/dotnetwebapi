using DotnetWebApi.Domain.Common;
using System;

namespace DotnetWebApi.Domain.Entities;

public class User : BaseAuditableEntity
{
    public string? first_name { get; set; }

    public string? last_name { get; set; }

    public int gender { get; set; }

    public DateTime day_of_birth { get; set;}
}