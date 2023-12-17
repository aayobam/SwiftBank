using Microsoft.AspNetCore.Identity;

namespace SwiftBankApi.Domain;

public class User: IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly Dob { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }= string.Empty;
    public bool IsActive { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}