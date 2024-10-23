namespace BizerDemo.Contracts.Impl;

public class UserService : IUserService
{
    private static List<User> Users { get; set; } = default!;
    public Task<IEnumerable<User>> GetUsersAsync()
    {
        return Task.FromResult(Users.AsEnumerable());
    }

    public Task<User> CreateAsync(User user)
    {
        ArgumentNullException.ThrowIfNull(user);
        Users.Add(user);
        return Task.FromResult(user);
    }
}