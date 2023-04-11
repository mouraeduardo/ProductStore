using ProductStore.Domain.Models;

namespace ProductStore.Util.Responses
{
    public class UserResponse : BaseResponse
    {
        public User User { get; set; }

        public UserResponse(bool sucess, User user, string message) : base(sucess, message)
        {
            this.User = user;
        }

        public UserResponse(User user): this(true, user, string.Empty )  { }

        public UserResponse(string message) : this(false, null, message) { }
    }
}
