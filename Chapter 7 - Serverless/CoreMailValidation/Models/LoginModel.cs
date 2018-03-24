namespace CoreMailValidation.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ValidationMessage { get; set; } = "";
    }
}
