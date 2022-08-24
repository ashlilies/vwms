using vwmsweb.Models;

namespace vwmsweb.Services;

public class UserService
{
    public User? LoginUser(string username, string password)
    {
        using var db = new VwmsContext();
        var usernameLower = username.ToLower();  // ignore case
        var hashedPassword = HashPassword(password);
        var user = db.Users.FirstOrDefault(u => u.Username == usernameLower && u.PasswordHash == hashedPassword);
        return user;
    }

    private string HashPassword(string password)
    {
        using var md5 = System.Security.Cryptography.MD5.Create();
        var inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
        var hashBytes = md5.ComputeHash(inputBytes);

        return Convert.ToHexString(hashBytes);
    }
}