using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductStore.Domain.Models;
using ProductStore.Domain.Services;
using ProductStore.Util.Responses;

namespace ProductStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("CreateAccount")]
        public async Task<ActionResult> InsertUser(User user)
        {
            UserResponse userResponse = await _userService.InsertUser(user);

            if (userResponse.Sucess)
            {
                return Ok("Conta Criada com sucesso");
            }
            else
            {
                return new BadRequestObjectResult(userResponse.Message);
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(string email, string password)
        {
            UserResponse userResponse = await _userService.Login(email, password);

            if (userResponse.Sucess)
            {
                return Ok($"Bem vindo {userResponse.User.Name}, seu token: {userResponse.Message}");
            }
            else
            {
                return new BadRequestObjectResult(userResponse.Message);
            }
        }

        [Authorize]
        [HttpDelete]
        [Route("CloseAccount")]
        public async Task<ActionResult> DeleteUser(long userId)
        {
            UserResponse userResponse = await _userService.DeleteUser(userId);

            return Ok(userResponse);
        }

        [Authorize]
        [HttpPut]
        [Route("UpdateAccount")]
        public async Task<ActionResult> UpdateUser(User user)
        {
            UserResponse userResponse = await _userService.UpdateUser(user);

            return Ok(userResponse);
        }

    }
}
