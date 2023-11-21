using System.Text.RegularExpressions;
using Business_SeguridadApps.StructuresObj;
using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Business_SeguridadApps
{
    public class BusinessRules
    {

        static readonly string notvalid_chr = @"['%&<>*;]"; // Not valid characters 
        static readonly string creditcard_pattern = @"[0-9]{16}|(([0-9]{4}[-|\s]){3}[0-9]{4})"; // This is the pattern to validate the input value has a credit card number. 
        const string pattern = @"^[w] +[^'%&<>#*]/$";  // pattern for any input value.

        /// <summary>
        /// Iif the input string does not march with the expected pattern return false.
        /// </summary>
        /// <param name="InputString"></param>
        /// <returns></returns>
        bool ValidateMatch(string InputString)
        {
            try
            {
                return Regex.IsMatch(InputString, pattern);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

        }
        /// <summary>
        /// Validate if the input string march with the expected pattern.
        /// </summary>
        /// <param name="InputString"></param>
        /// <returns></returns>
        public InputResult ValidateInputText(string InputString)
        {
            InputResult result = new InputResult();
            try
            {
                result.IsMatch = ValidateMatch(InputString);
                if (!result.IsMatch)
                {// Replace the invalid characters from the input string. 
                    result.SanitizedString = Regex.Replace(InputString, @notvalid_chr, "");
                    if (result.SanitizedString.Length < InputString.Length)
                    {
                        result.Message = "Sanitizing invalid characters were found ... " + result.SanitizedString;
                    }
                    result.IsMatch = true;
                }
                else
                {
                    /// if input string matches with the pattern, returns the value and message to confirm. 
                    result.SanitizedString = InputString;
                    result.Message = "Input string is valid. :) ";
                }
            }
            catch (RegexMatchTimeoutException ex)
            {
                result.IsMatch = false;
                result.Message = ex.Message;
            }
            return result;
        }
        /// <summary>
        /// Receives the input from user and gets the credit card number if exists. 
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public CreditCard GetCreditCardInfo(string inputText)
        {
            CreditCard cc = new CreditCard();
            try
            {
                cc.CreditCardNumber = GetCreditCardNum(inputText);
                cc.Index = GetCreditCardNum_Index(inputText);
                if (!string.IsNullOrEmpty(cc.CreditCardNumber))
                {
                    cc.IsValid = true;
                    int index = GetCreditCardNum_Index(cc.CreditCardNumber);
                    var cardNumber_left = new StringBuilder(cc.CreditCardNumber.Substring(0, index));
                    var cardNumber_right = new StringBuilder(cc.CreditCardNumber.Substring(index + 19));
                    string substring_aux = cc.CreditCardNumber.Substring(0, cc.CreditCardNumber.Length - 4);
                    string visible_string = cc.CreditCardNumber.Substring(cc.CreditCardNumber.Length - 4);

                    var masked_string = new StringBuilder();
                    for (int i = 0; i < substring_aux.Length; i++)
                    {
                        if (substring_aux.Substring(i, 1).CompareTo("-") == 0 || string.IsNullOrWhiteSpace(substring_aux.Substring(i, 1)))
                            masked_string.Append(substring_aux.Substring(i, 1));
                        else
                            masked_string.Append(substring_aux.Substring(i, 1).Replace(substring_aux.Substring(i, 1), "*"));

                    }
                    var cardNumber_masked = masked_string.Append(visible_string);
                    cc.CreditCardMasked= (cardNumber_left.Append(cardNumber_masked).Append(cardNumber_right)).ToString();
                }
                else
                {
                    cc.Message  = "Ingrese un número de tarjeta débito/crédito para continuar. (XXXX-XXXX-XXXX-XXXX)";
                    throw new Exception(cc.Message);
                }
            }
            catch (Exception ex)
            { 
                cc.IsValid = false;
            }
            return cc;

        }
        /// <summary>
        /// returns the card number if it matches with the establish pattern .
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        string GetCreditCardNum(string inputText)
        {
            Match cardId = Regex.Match(inputText, creditcard_pattern);
            if (cardId.Success)
                return cardId.Value;
            else
                return string.Empty;
        }
        /// <summary>
        /// Gets the index where the credit card number starts into the input string. 
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        int GetCreditCardNum_Index(string inputText)
        {
            Match cardId = Regex.Match(inputText, creditcard_pattern);
            if (cardId.Success)
                return cardId.Index;
            else
                return 0;
        }
        ///<summary>
        /// Encode the credit card number with AES256 and SHA256 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public EncodingData EncodingCreditCard(string data)
        {
            EncodingData ed = new EncodingData();
            try
            {
                ed.cryptoData = AES256_EncryptManaged(data);
                ed.SHA256 = GenerateSHA256(data);
            }
            catch (Exception ex)
            {
                ed.Message = ex.Message;
            }
            return ed;
        }
        /// <summary>
        /// Returns the SHA256 value for the input string.
        /// </summary>
        /// <param name="MaskedInput"></param>
        /// <returns></returns>
        string GenerateSHA256(string MaskedInput)
        {
            StringBuilder hash = new StringBuilder();

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(MaskedInput));
                foreach (byte b in hashValue)
                {
                    hash.Append(b.ToString("X2"));
                }
            }
            return hash.ToString();

        }
        /// <summary>
        /// Method to manage the encrypt and decrypt process. 
        /// </summary>
        /// <param name="EncodedString"></param>
        /// <returns></returns>
        CryptoData AES256_EncryptManaged(string EncodedString)
        {
            CryptoData cd = new CryptoData();
            try
            {
                using (AesManaged aes_managed = new AesManaged())
                {
                    cd.Encrypted = Encrypt(EncodedString, aes_managed.Key, aes_managed.IV);
                    cd.Decrypted = Decrypt(cd.Encrypted, aes_managed.Key, aes_managed.IV);

                    if (EncodedString.CompareTo(cd.Decrypted) == 0)
                    {
                        cd.Message = ":) Proceso Finalizado";
                        cd.Done = true;
                    }
                    else
                    {
                        cd.Done = false;
                        cd.Message = " :( Ocurrió un error durante el proceso de encriptación/desencriptación de la entrada.";
                    }
                }
            }
            catch (Exception ex)
            {
                cd.Message = ex.Message;
                cd.Done = false;
            }
            return cd;
        }
        /// <summary>
        /// returns the encrypted value (byte[]) 
        /// </summary>
        /// <param name="encryptedText"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        byte[] Encrypt(string encryptedText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;

            using (AesManaged aes_managed = new AesManaged())
            {
                ICryptoTransform encryptor = aes_managed.CreateEncryptor(Key, IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(encryptedText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            return encrypted;
        }
        /// <summary>
        /// Decrypt the encrypted value received.
        /// </summary>
        /// <param name="encryptedText"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        string Decrypt(byte[] encryptedText, byte[] Key, byte[] IV)
        {
            string decryptText = string.Empty;
            using (AesManaged aes_managed = new AesManaged())
            {
                ICryptoTransform decryptor = aes_managed.CreateDecryptor(Key, IV);
                using (MemoryStream ms = new MemoryStream(encryptedText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            decryptText = reader.ReadToEnd();
                        }
                    }
                }

            }
            return decryptText;
        }
    }
}
