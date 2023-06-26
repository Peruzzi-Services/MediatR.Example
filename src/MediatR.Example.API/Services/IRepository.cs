namespace MediatR.Example.API.Services;

public interface IRepository<TEntity>
{
    Task<TEntity> CreateAsync(TEntity entity, CancellationToken token);
}
