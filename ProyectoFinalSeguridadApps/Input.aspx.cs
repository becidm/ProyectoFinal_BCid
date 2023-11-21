using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;
using ProyectoFinalSeguridadApps.WebService;


namespace ProyectoFinalSeguridadApps
{
    public partial class Input : System.Web.UI.Page
    {
        SecurityProjectClient WS = new SecurityProjectClient();

        //static readonly string notvalid_chr = @"['%&<>*;]";
        //static readonly string creditcard_pattern = @"[0-9]{16}|(([0-9]{4}[-|\s]){3}[0-9]{4})";
        //const string pattern = @"^[w] +[^'%&<>#*]/$";
        //static bool ValidateInputText(string inputstring)
        //{
        //    try
        //    {
        //        return Regex.IsMatch(inputstring, pattern);
        //    }
        //    catch (RegexMatchTimeoutException)
        //    {
        //        return false;
        //    }
        //}
        //static string GetCreditCardNum(string inputText)
        //{
        //    Match cardId = Regex.Match(inputText, creditcard_pattern);
        //    if (cardId.Success)
        //        return cardId.Value;
        //    else
        //        return string.Empty;
        //}
        //static int GetCreditCardNum_Index(string inputText)
        //{
        //    Match cardId = Regex.Match(inputText, creditcard_pattern);
        //    if (cardId.Success)
        //        return cardId.Index;
        //    else
        //        return 0;
        //}
       void ShowControls(bool enabled)
        {
            ltrCleaningText.Visible=enabled;
            lblCCMasked    .Visible=enabled;
            lblSHA256      .Visible=enabled;
            lblDecrypt     .Visible=enabled;
            lblEncrypted.Visible = enabled;
            //lblResult.Visible = enabled;
            lblMessage.Visible     = enabled;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowControls(false);
        }

        protected void btnValidateInput_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = txbInputText.Text;
                //string SanitizedInput = string.Empty;
                if (string.IsNullOrEmpty(inputText))
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = Resources.Labels.EmptyInput;
                }
                else
                {
                    SecurityInput si = new SecurityInput { InputString = inputText };
                    Validate result = WS.ValidateInputText(si);
                    //lblMessage.Text = result.Output.Message;
                    ltrCleaningText.Text =Resources.Labels.Sanitized+  result.Output.SanitizedString;
                    //if (result.Output.IsMatch)
                    //{
                    //    lblMessage.Text = "Input string is valid :) ";
                    //    ltrCleaningText.Text = string.Empty;
                    //    //SanitizedInput = result.Output.SanitizedString;
                    //}
                    //else
                    //{
                    //    //SanitizedInput = Regex.Replace(inputText, @notvalid_chr, "");
                    //    ltrCleaningText.Text = result.Output.SanitizedString;
                    //    lblMessage.Text = result.Output.Message;
                    //    //if (result.Output.SanitizedString.Length != inputText.Length)
                    //    //{
                    //    //    lblMessage.Text = "Sanitizing invalid characters were found ... " + result.Output.SanitizedString;
                    //    //}
                    //}

                    CreditCardInf cci = WS.GetCreditCardNum(new SecurityInput { InputString = result.Output.SanitizedString });

                    if (!cci.creditCard.IsValid)
                    //if (string.IsNullOrEmpty(cardNumber))
                    {
                        ShowControls(true);
                        lblMessage.Text = cci.creditCard.Message;
                        lblCCMasked.Text = string.Empty;
                        lblEncrypted.Text = string.Empty;
                        lblDecrypt.Text = string.Empty;
                        lblSHA256.Text = string.Empty;
                    }
                    else
                    {
                        ShowControls(true);
                        lblMessage.Text = string.Empty;
                        lblCCMasked.Text = Resources.Labels.MaskedValue + cci.creditCard.CreditCardMasked;
                        Result res = WS.ProcessCreditCardNumber(new SanitizedInput { Value = cci.creditCard.CreditCardNumber });//  ProcessCreditCardNumber(SanitizedInput,   cardNumber);
                        lblEncrypted.Text = Resources.Labels.Encrypdated + System.Text.Encoding.UTF8.GetString(res.encodingData.cryptoData.Encrypted);
                    lblDecrypt.Text = Resources.Labels.DecrypVal+ res.encodingData.cryptoData.Decrypted;
                        lblSHA256.Text =  Resources.Labels.SHAVal+  res.encodingData.SHA256;
                        lblMessage.Text = res.encodingData.cryptoData.Message;

                    }
                }
            }
            catch (ArgumentNullException)
            {
                lblMessage.Text = Resources.Labels.EmptyInput;
            }

        }

        protected void btnClean_Click(object sender, EventArgs e)
        {
            txbInputText.Text= string.Empty;
            lblMessage.Text = string.Empty;
            lblCCMasked.Text = string.Empty; 
            lblEncrypted.Text = string.Empty;
            lblDecrypt.Text = string.Empty;
            lblSHA256.Text = string.Empty;
        }
        //void ProcessCreditCardNumber (string SanitizedInput, string cardNumber)
        //{
        //    int index = GetCreditCardNum_Index(SanitizedInput);
        //    var cardNumber_left = new StringBuilder(SanitizedInput.Substring(0, index));
        //    var cardNumber_right = new StringBuilder(SanitizedInput.Substring(index + 19));
        //    string substring_aux = cardNumber.Substring(0, cardNumber.Length - 4);
        //    string visible_string = cardNumber.Substring(cardNumber.Length - 4);

        //    var masked_string = new StringBuilder();
        //    for (int i = 0; i < substring_aux.Length; i++)
        //    {
        //        if (substring_aux.Substring(i, 1).CompareTo("-") == 0 || string.IsNullOrWhiteSpace(substring_aux.Substring(i, 1)))
        //            masked_string.Append(substring_aux.Substring(i, 1));
        //        else
        //            masked_string.Append(substring_aux.Substring(i, 1).Replace(substring_aux.Substring(i, 1), "*"));

        //    }
        //    var cardNumber_masked = masked_string.Append(visible_string);
        //    string FinalCardNumber = (cardNumber_left.Append(cardNumber_masked).Append(cardNumber_right)).ToString();
        //    ltrCleaningText.Text = FinalCardNumber;
        //    lblSHA256.Text ="SHA256 Value: "+ GenerateSHA256(FinalCardNumber);
        //    AES256_EncryptManaged(FinalCardNumber); 

        //}
        //string GenerateSHA256(string MaskedInput)
        //{
        //    StringBuilder hash = new StringBuilder();

        //        using (SHA256 sha256 = SHA256.Create())
        //        {
        //            byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(MaskedInput));
        //            foreach (byte b in hashValue)
        //            {
        //                hash.Append(b.ToString("X2"));
        //            }
        //        }
        //        return hash.ToString();

        //}
        //void  AES256_EncryptManaged(string EncodedString)
        //{
        //    try
        //    {
        //        using (AesManaged aes_managed = new AesManaged())
        //        {
        //            byte[] encrypted = Encrypt(EncodedString, aes_managed.Key, aes_managed.IV);
        //            lblEncrypt.Text = Encoding.UTF8.GetString(encrypted);
        //            string decrypted = Decrypt(encrypted, aes_managed.Key, aes_managed.IV);
        //            lblDecrypt.Text = decrypted;

        //            if(EncodedString.CompareTo(decrypted)==0)
        //            {
        //                lblResult.Text = ":) Done";
        //            }
        //            else
        //            {
        //                lblResult.Text = " :( Error while processing de encrypt/decrypt input";
        //            }
        //        }
        //    }
        //    catch (Exception  ex)
        //    {
        //        throw; 
        //    } 
        //}

        //static byte[] Encrypt(string encryptedText, byte[] Key, byte[] IV)
        //{
        //    byte[] encrypted;

        //    using (AesManaged aes_managed = new AesManaged())
        //    {
        //        ICryptoTransform encryptor = aes_managed.CreateEncryptor(Key, IV);
        //        using( MemoryStream ms = new MemoryStream())
        //        {
        //            using(CryptoStream cs= new CryptoStream(ms,encryptor, CryptoStreamMode.Write))
        //            {
        //                using (StreamWriter sw = new StreamWriter(cs))
        //                    sw.Write(encryptedText);
        //                encrypted = ms.ToArray();
        //            }
        //        }
        //    }
        //    return encrypted;
        //}

        //static string Decrypt(byte[] encryptedText, byte[] Key, byte[] IV)
        //{
        //    string decryptText = string.Empty;
        //    using (AesManaged aes_managed = new AesManaged())
        //    {
        //        ICryptoTransform decryptor = aes_managed.CreateDecryptor(Key, IV);
        //        using (MemoryStream ms = new MemoryStream(encryptedText))
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
        //            {
        //                using (StreamReader reader = new StreamReader(cs))
        //                {
        //                    decryptText = reader.ReadToEnd();
        //                }
        //            }
        //        }

        //    }
        //    return decryptText;
        //}
    }
}