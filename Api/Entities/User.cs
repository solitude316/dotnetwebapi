namespace Entities;

using System;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public Guid id {get; set;}

    [Required]
    [DataType(DataType.EmailAddress)]
    public string? email {get; set;}
    
    [Required]
    [StringLength(64)]
    public string? password {get; set;}
    
    [Required]
    public string? firstname {get; set;}
    
    [Required]
    public string? lastname {get; set;}

    [DataType(DataType.Date)]
    public DateTime? Birthday {get; set;}
    
    [Required]
    public Enums.Gender gender {get; set;}

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime create_time {get; set;}

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime update_date {get; set;}

    public User()
    {
        id = Guid.NewGuid();
    }
}