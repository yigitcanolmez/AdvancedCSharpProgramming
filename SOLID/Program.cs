using SOLID;

internal class Program
{
    public Program()
    {

    }
    private static void Main(string[] args)
    {
        var userService = new UserService();
        var mailService = new MailService();

        User user = new()
        {
            Email = "abc@gmail.com",
            Name = "abc",
            Password = "1234567890"
        };

        userService.Register(user);

        var registerMail = new SendMailDto()
        {
            Mail = user.Email,
            Message = "WELCOME!"
        };

        mailService.SendWelcomeMail(registerMail);


    }
}