public class LoginController
{
    private LoginService _loginService;

    public LoginController(LoginService loginService)
    {
        _loginService = loginService;
    }

    public void ProcessLogin(string email, string password)
    {
        try
        {
            _loginService.Login(email, password);
        }
        catch (InvalidCredentialsException ex)
        {
            Console.WriteLine($"Daxil olunmadi: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Sef oldu: {ex.Message}");
        }
    }
}