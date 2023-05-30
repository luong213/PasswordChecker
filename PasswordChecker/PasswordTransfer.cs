using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    internal class PasswordTransfer
    {
        // Password maxlength
        private const int PASS_MAX_LENGTH = 128;
        // Maximum number of long digits
        private const int PREFIX_LENGTH = 4;
        // Embedding-enabled character array
        private static readonly char[] USABLE_CHARS_ARRAY
            ={  'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                 '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
             };
        private PasswordTransfer()
        {
        }
        // Encrypt password
        public static string Encrypt(string password)
        {
            MemoryStream outStream = new MemoryStream();
            TripleDES tdes = TripleDES.Create();
            using (CryptoStream encStream = new CryptoStream(outStream, tdes.CreateEncryptor(GetKey(), GetIV()), CryptoStreamMode.Write))
            {
                // Create a fixed-length string with an embedded password
                string fixedLengthPass = EmbedPasswordInFixedString(password);
                // Convert to byte array
                byte[] data = ToByte(fixedLengthPass);
                // Encryption
                encStream.Write(data, 0, data.Length);
                encStream.Close();
                // Convert to Base64
                return Convert.ToBase64String(outStream.ToArray());
            }
        }
        // Decrypt password
        public static string Decrypt(string encryptedPassword)
        {
            MemoryStream outStream = new MemoryStream();
            TripleDES tdes = TripleDES.Create();
            using (CryptoStream decStream = new CryptoStream(outStream, tdes.CreateDecryptor(GetKey(), GetIV()), CryptoStreamMode.Write))
            {
                // Decrypt Base64
                byte[] data = Convert.FromBase64String(encryptedPassword);
                // Decryption
                decStream.Write(data, 0, data.Length);
                decStream.Close();
                // Convert to string
                string embeddedPass = ToString(outStream.ToArray());
                // Retrieval of password
                return GetEmbeddedPassword(embeddedPass);
            }
        }
        // Specified key (System.Security.Cryptography.SymmetricAlgorithm.Key)
        private static byte[] GetKey()
        {
            // 192ビット
            short[] src = { 0xd1, 0x56, 0x36, 0x98, 0xaa, 0xbc, 0x09, 0xe2, 0x96, 0xbf, 0x89, 0x8e, 0x41, 0xcb, 0xe4, 0x16, 0x2b, 0xac, 0xea, 0xdd, 0x50, 0xc3, 0x5b, 0x5f };
            byte[] key = new byte[src.Length];
            for (int i = 0; i < src.Length; i++)
            {
                key[i] = Convert.ToByte(src[i]);
            }
            return key;
        }
        // Initialization vector (System.Security.Cryptography.SymmetricAlgorithm.IV)
        private static byte[] GetIV()
        {
            // 64ビット
            short[] src = { 0xfd, 0xb3, 0x2d, 0xe3, 0x61, 0xcd, 0xf1, 0xd3 };
            byte[] iv = new byte[src.Length];
            for (int i = 0; i < src.Length; i++)
            {
                iv[i] = Convert.ToByte(src[i]);
            }
            return iv;
        }
        // Extract the password from fixed length string
        private static string GetEmbeddedPassword(string str)
        {
            int length = int.Parse(str.Substring(0, PREFIX_LENGTH));
            return str.Substring(PREFIX_LENGTH, length);
        }
        // Embed password in fixed length string
        private static string EmbedPasswordInFixedString(string pass)
        {
            StringBuilder b = new StringBuilder(PASS_MAX_LENGTH);
            b.Append(string.Format("{0:0000}", pass.Length));
            b.Append(pass);
            b.Append(CreateRandomString(USABLE_CHARS_ARRAY, PASS_MAX_LENGTH - pass.Length));
            return b.ToString();
        }
        // Creates a random string using only the specified characters
        private static string CreateRandomString(char[] chars, int length)
        {
            byte[] r = new byte[length];
            RandomNumberGenerator p = RandomNumberGenerator.Create();
            p.GetBytes(r);
            StringBuilder b = new StringBuilder(length);
            for (int i = 0; i < r.Length; i++)
            {
                b.Append(chars[r[i] % chars.Length]);
            }
            return b.ToString();
        }
        // Convert string to byte array
        private static byte[] ToByte(string src)
        {
            return System.Text.Encoding.ASCII.GetBytes(src);
        }
        // Convert byte array to string
        private static string ToString(byte[] src)
        {
            return System.Text.Encoding.ASCII.GetString(src);
        }
    }
}
