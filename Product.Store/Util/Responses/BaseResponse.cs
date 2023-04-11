namespace ProductStore.Util.Responses
{
    public class BaseResponse
    {
        public bool Sucess { get; protected set; }
        public string Message { get; protected set; }

        public BaseResponse(bool sucess, string message)
        {
            this.Sucess = sucess;
            this.Message = message;
        }
    }
}
