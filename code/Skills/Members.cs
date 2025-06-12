using System;

namespace Skills;

public class Members
{
    public string Role { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public Members(string role, string email, string phoneNumber, string firstName, string lastName)
    {
        Role = role;
        Email = email;
        PhoneNumber = phoneNumber;
        FirstName = firstName;
        LastName = lastName;
    }
    public void ShowMemberInfo()
    {
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Role: {Role}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
    }
}
