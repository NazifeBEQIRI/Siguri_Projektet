using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Server_TCP
{
    class Jwt
    {
        Shfrytezuesi m = new Shfrytezuesi();
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        private static RSAParameters privateKey = rsa.ExportParameters(true);

        public String createToken(String userId, String email, String emriMbiemri, String llojiFatures, int viti, Decimal vleraEuro, String muaji)
        {
            var payload = new Dictionary<string, object>
        {
            { "userId", userId },
            { "email", email },
            {"emriMbiemri", emriMbiemri },
            {"llojiFatures", llojiFatures },
            {"viti", viti },
            {"vleraEuro", vleraEuro },
            {"muaji", muaji },
        };
            const string secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";

            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
            var token = encoder.Encode(payload, privateKey.ToString());
            return token;
        }
        
    }
}
