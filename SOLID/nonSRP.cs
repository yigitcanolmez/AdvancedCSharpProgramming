namespace SOLID
{
    public class UserService
    {
        public void Register(User user)
        {
            if (!ValidatePassword(user.Password))
                throw new Exception("Incorrect Mail Format");

            if (!ValidateEmail(user.Email))
                throw new Exception("Incorrect Mail Format");

            Console.WriteLine("Successfully registered!");
        }
        private bool ValidatePassword(string password) => password.Length > 5 && password.Length < 16;
        private bool ValidateEmail(string email) => email.Contains("@");
    }

    public class MailService
    {
        public void SendWelcomeMail(SendMailDto sendMailDto)
        {
            Console.WriteLine(sendMailDto.Message);
        }

    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class SendMailDto
    {
        public string Mail { get; set; }
        public string Message { get; set; }
    }
}
