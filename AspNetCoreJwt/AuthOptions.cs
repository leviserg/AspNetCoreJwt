using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace AspNetCoreJwt
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer"; // token issuer
        public const string AUDIENCE = "AspNetCoreJwt"; // token consumer - your application
        const string KEY = "mysupersecret_secretkey!123";   // encruption key
        public const int LIFETIME = 1; // token lifecycle
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
