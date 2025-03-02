using System.Security.Cryptography;
using AITravelPlanner.Data;
using AITravelPlanner.Domain.Entities;
using AITravelPlanner.Services.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace AITravelPlanner.Services.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> RegisterUserAsync(string userName, string name, string surName, string email, string password)
        {
            var hashedPassword = HashPassword(password);

            var user = new User
            {
                Name = name,
                SurName = surName,
                UserName = userName,
                Email = email,
                PasswordHash = hashedPassword
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }


        public async Task<User?> AuthenticateUserAsync(string email, string password)
        {
            var hashedPassword = HashPassword(password);
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.PasswordHash == hashedPassword);
        }


        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

    }
}
