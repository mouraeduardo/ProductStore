using Microsoft.AspNetCore.Mvc;
using ProductStore.Domain.Models;

namespace ProductStore.Domain.Repository
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsers();
        public Task<User> InsertUser(User user);

        //public Task<ActionResult> UpdateUser(User user);
        //public Task<ActionResult> DeleteUser(User user);
        public Task<User> Login(string email, string password);

        public Task<bool> VerifyEmailExisting(string email);

        public Task<User> FindUserByUserId(long userId);

        public void UpdateUser(User user);

        public void DeleteUser(User user);
    }
}
