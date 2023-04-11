using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductStore.Domain.Models;
using ProductStore.Domain.Repository;
using ProductStore.Persistence;
using System.ComponentModel;

namespace ProductStore.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(AppDBContext context) : base(context) { }

        public async Task<List<User>> GetUserList()
        {
            try
            {
                return await _context.Users.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<User> InsertUser(User user)
        {

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> Login(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        }

        public async void UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async void DeleteUser(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> VerifyEmailExisting(string email)
        {
            if (await _context.Users.FirstOrDefaultAsync(x => x.Email == email) != null)
                return true;
            else
                return false;          
        }

        public async Task<User> FindUserByUserId(long userId)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
        }
    }
}
