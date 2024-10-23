using Bizer;

namespace BizerDemo.Contracts;

[ApiRoute("api/users")]
public interface IUserService
{
    [Get]
    Task<IEnumerable<User>> GetUsersAsync();
    [Post]
    Task<User> CreateAsync(User user);
}