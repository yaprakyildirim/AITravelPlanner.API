using AITravelPlanner.Data;
using AITravelPlanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AITravelPlanner.Services.Services.Concrete
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> RegisterUserAsync(string userName, string name, string surName,string email, string passwordHash)
        {
            var user = new User
            {
                Name = name,
                SurName = surName,
                UserName = userName,
                Email = email,
                PasswordHash = passwordHash
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User?> AuthenticateUserAsync(string email, string passwordHash)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email && u.PasswordHash == passwordHash);
        }
    }
}
