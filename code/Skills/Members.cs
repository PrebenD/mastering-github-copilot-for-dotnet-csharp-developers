using System;

namespace Skills;

public class Members
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public Members( string name, string role, string email, string phoneNumber )
    {
        Name = name;
        Role = role;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}
