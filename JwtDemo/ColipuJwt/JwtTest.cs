using JWT;
using System;

namespace ColipuJwt
{
    public class JwtTest
    {
        private const string SecretKey = "Colipu-PricingContract-Api";
        private const string ApplicationId = "PricingContract";

        public static string GenerateJwt()
        {
            long tiemStamp = DateTimeHelper.ConvertToTimeStamp(DateTime.Now.AddDays(1));

            return JsonWebToken.Encode(new { applicationId = ApplicationId, issAt = tiemStamp }, SecretKey, JwtHashAlgorithm.HS256);
        }
    }
}
