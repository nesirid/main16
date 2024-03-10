public class LoginService
{
    public void Login(string email, string password)
    {
        // Userleri burda yaratmaq olar yada bazadan qelen, sadece logic hessesidi.

        string validEmail = "nesirid@code.edu.az";
        string validPassword = "ucanqariska";
        
        if (password.Length < 6 || email.Length < 6 || !email.Contains('@') )
        {
            throw new WeakPasswordException("");
        }
        if (email != validEmail || password != validPassword)
        {
            throw new InvalidCredentialsException("Email ve ya Parol sefdi");
        }

        Console.WriteLine("Ugurla daxil olundu");
    }

}