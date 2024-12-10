using System.Security.Cryptography;
using System.Text;

public static class KeyGenerator
{
    public static string GenerateSecureKey(string Password, string salt, int keySize = 256, int iterations = 10000)
    {
        using (var deriveBytes = new Rfc2898DeriveBytes(Password, Encoding.UTF8.GetBytes(salt), iterations))
        {
            return Convert.ToBase64String(deriveBytes.GetBytes(keySize / 8)); // Convert keySize (in bits) to bytes
        }
    }
}
