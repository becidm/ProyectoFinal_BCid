using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_SeguridadApps.StructuresObj
{
    //The following structures will help us with the transmission of the data between back and front end.

    /// <summary>
    /// Receives the first input from the user.
    /// </summary>
    public class InputResult
    {
        public bool IsMatch { get; set; }
        public string Message { get; set; }
        public string SanitizedString { get; set; }
    }

    /// <summary>
    /// Receives the Credit Card and return the expected values.
    /// </summary>
    public class CreditCard
    {
        public bool IsValid { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardMasked { get; set; }
        public int Index { get; set; }
        public string Message { get; set; }
    }
    /// <summary>
    /// Returns the encrypted and decrypted value of the credit card number
    /// </summary>
    public class CryptoData{
        public byte[] Encrypted { get; set; }
        public string Decrypted { get; set; }
        public string Message { get; set; }
        public bool Done { get; set; }
        }
    /// <summary>
    /// Returns the card number encrypted/decrypted and the SHA256 value.
    /// </summary>
    public class EncodingData
    {
        public CryptoData cryptoData { get; set; }
        public string SHA256 { get; set; }
        public string Message { get; set; }
    }
}
