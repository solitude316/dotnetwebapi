namespace Api.Helpers;
using System.Security.Cryptography;
using System.Text;

public class StringHelper
{
    public static string GetSha256Hash(string value)
    {
        using var hash = SHA256.Create();
        var byteArray = hash.ComputeHash(Encoding.UTF8.GetBytes(value));
        return Convert.ToHexString(byteArray).ToLower();
    }
}