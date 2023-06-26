namespace MediatR.Example.API.Requests;

public class CreateUserCommand : IRequest<User>
{
    public CreateUserCommand(User user)
    {
        User = user;
    }

    public User User { get; }
}
