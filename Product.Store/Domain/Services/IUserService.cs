using ProductStore.Domain.Models;
using ProductStore.Util.Responses;

namespace ProductStore.Domain.Services
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
        public Task<UserResponse> InsertUser(User user);
        public Task<UserResponse> Login(string email, string password);
        public Task<UserResponse> UpdateUser(User user);
        public Task<UserResponse> DeleteUser(long userId);
    }
}
