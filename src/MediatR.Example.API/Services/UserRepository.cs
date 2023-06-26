namespace MediatR.Example.API.Services;

public class UserRepository : IRepository<User>
{
    public Task<User> CreateAsync(User user, CancellationToken token)
    {
        user.Id = Guid.NewGuid();
        return Task.FromResult(user);
    }
}
