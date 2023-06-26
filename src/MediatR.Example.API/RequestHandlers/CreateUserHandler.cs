namespace MediatR.Example.API.RequestHandlers;
using Requests;
using Services;


public class CreateUserHandler : IRequestHandler<CreateUserCommand, User>
{
    private readonly IRepository<User> _userRepository;

    public CreateUserHandler(IRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle( CreateUserCommand request, CancellationToken token)
    {
        var newUser = await _userRepository.CreateAsync(request.User, token);
        return newUser;
    }
}
