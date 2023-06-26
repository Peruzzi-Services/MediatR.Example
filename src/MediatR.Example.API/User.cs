namespace MediatR.Example.API;

public class User
{
    public Guid Id { get; set; } = Guid.Empty; 
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
