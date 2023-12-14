using SmartEssayChecker.API.Models.Users;

namespace SmartEssayChecker.API.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask<User> InsertUserAsync(User user);
    IQueryable<User> SelectAllUsers();
    ValueTask<User> SelectUserByIdAsync(Guid userId);
    ValueTask<User> UpdateUserAsync(User user);
    ValueTask<User> DeleteUserAsync(User user);
}