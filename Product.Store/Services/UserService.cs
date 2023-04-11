using Microsoft.AspNetCore.Mvc;
using ProductStore.Domain.Models;
using ProductStore.Domain.Repository;
using ProductStore.Domain.Services;
using ProductStore.Util.Responses;
using ProductStore.Util.Security;

namespace ProductStore.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        public UserService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<UserResponse> InsertUser(User user)
        {
            if(await _userRepository.VerifyEmailExisting(user.Email))
                return new UserResponse("Email já em uso");

            if (await _userRepository.InsertUser(user) != null)
                return new UserResponse(user);
            else
                return new UserResponse("Erro ao adicionar usuario");
        }

        public async Task<UserResponse> Login(string email, string password)
        {
            try
            {
                User user = await _userRepository.Login(email, password);

                if (user != null)
                {
                    string token = AuthenticationFunction.GenerateToken(user, _configuration["SecurityKey"]);

                    return new UserResponse(true, user, token);
                }
                else
                {
                    return new UserResponse("Email ou Senha incorreto");
                }
            }
            catch (Exception)
            {
               throw;
            }
        }

        public async Task<UserResponse> UpdateUser(User user)
        {
            User userReturn = await _userRepository.FindUserByUserId(user.Id);

            if (userReturn != null) 
            {
                userReturn.Name = user.Name;
                userReturn.Email = user.Email;
                userReturn.Password = user.Password;
                userReturn.Cpf = user.Cpf;
                userReturn.TellPhone = user.TellPhone;

                _userRepository.UpdateUser(userReturn);

                return new UserResponse(userReturn);
            }
            else
            {
                return new UserResponse("usuario não encontrado");
            }
            
        }

        public async Task<UserResponse> DeleteUser(long userId)
        {
            User user = await _userRepository.FindUserByUserId(userId);

            if (user != null)
            {
                _userRepository.DeleteUser(user);
                return new UserResponse(user);
            }
            else
            {
                return new UserResponse("Usuario não encontrado");
            }

            
        }
    }
}
