namespace Api.Dto;

public class CreateUserPayload
{
    public Api.Enums.Gender gender {get; set;}
    public string firstname {get; set;}

    public string lastname {get; set;}

    public string password {get; set;}
    
    public string email {get; set;}

    public DateTime birthday {get; set;}

}