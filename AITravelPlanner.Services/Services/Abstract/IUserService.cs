using AITravelPlanner.Domain.Entities;

namespace AITravelPlanner.Services.Services.Abstract
{
    public interface IUserService
    {
        Task<User?> GetUserByIdAsync(int userId);
        Task<User?> AuthenticateUserAsync(string email, string passwordHash);
        Task<User> RegisterUserAsync(string userName, string name, string surName, string email, string passwordHash);
    }
}
