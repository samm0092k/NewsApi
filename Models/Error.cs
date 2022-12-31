using NewsApi.Constants;

namespace NewsApi.Models
{
    public class Error
    {
        public ErrorCodes Code { get; set; }
        public string Message { get; set; }
    }
}
