namespace Api.Entities;

using System;
using System.ComponentModel.DataAnnotations;
using Api.Enums;

public class User
{
    [Key]
    public Guid id {get; set;}

    [Required]
    [DataType(DataType.EmailAddress)]
    public string email {get; set;} = default!;
    
    [Required]
    [StringLength(64)]
    public string password {get; set;} = default!;
    
    [Required]
    public string firstname {get; set;} = default!;
    
    [Required]
    public string lastname {get; set;} = default!;

    [DataType(DataType.Date)]
    public DateTime? birthday {get; set;} = default!;
    
    [Required]
    public Enums.Gender gender {get; set;} = default!;

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime create_time {get; set;}

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime update_time {get; set;}

    public User()
    {
        id = Guid.NewGuid();
        create_time = DateTime.Now;
        update_time = DateTime.Now;
    }
}