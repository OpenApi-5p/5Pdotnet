using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using System.Text;

namespace _5paisaAPI
{
    public class CommonMethod
    {
        private static string _MyKey;
        public CommonMethod(string MyKey)
        {
            _MyKey = MyKey;
        }

        public static string Encrypt_Vendor(string value)
        {
            try
            {
                var _key = Convert.FromBase64String(_MyKey);
                var _iv = new byte[] { 83, 71, 26, 58, 54, 35, 22, 11, 83, 71, 26, 58, 54, 35, 22, 11 };

                var encoding2 = new UTF8Encoding();

                byte[] data = encoding2.GetBytes(value);

                var keyBuilder = new Rfc2898DeriveBytes(_MyKey, _iv);

                var ms = new MemoryStream();

                var aes = new RijndaelManaged();

                aes.KeySize = 256;

                // A byte array filled with pseudo-random key bytes.
                aes.IV = keyBuilder.GetBytes(Convert.ToInt32(aes.BlockSize / 8));
                aes.Key = keyBuilder.GetBytes(Convert.ToInt32(aes.KeySize / 8));

                var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);

                cs.Write(data, 0, data.Length);

                cs.FlushFinalBlock();

                byte[] EncData = ms.GetBuffer();
                Array.Resize(ref EncData, (int)(ms.Position - 1L + 1));
                return Convert.ToBase64String(EncData);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public string GetIPAddress()
        {
            var strIPAddress = "";
            try
            {
                string strHostName = Dns.GetHostName();
                IPAddress[] ipaddress = Dns.GetHostAddresses(strHostName);
                foreach (IPAddress ip in ipaddress)
                {
                    strIPAddress = ip.ToString();
                }
            }
            catch (Exception ex)
            {
                strIPAddress = "";
            }

            return strIPAddress;
        }
    }
}
