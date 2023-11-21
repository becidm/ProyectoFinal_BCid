using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_SeguridadApps.StructuresObj
{
    public class InputResult
    {
        public bool IsMatch { get; set; }
        public string Message { get; set; }
        public string SanitizedString { get; set; }
    }

    public class CreditCard
    {
        public bool IsValid { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardMasked { get; set; }
        public int Index { get; set; }
        public string Message { get; set; }
    }

    public class CryptoData{
        public byte[] Encrypted { get; set; }
        public string Decrypted { get; set; }
        public string Message { get; set; }
        public bool Done { get; set; }
        }
    public class EncodingData
    {
        public CryptoData cryptoData { get; set; }
        public string SHA256 { get; set; }
        public string Message { get; set; }
    }
}
