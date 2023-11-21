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
        void ShowControls(bool enabled)
        {
            ltrCleaningText.Visible = enabled;
            lblCCMasked.Visible = enabled;
            lblSHA256.Visible = enabled;
            lblDecrypt.Visible = enabled;
            lblEncrypted.Visible = enabled;
            lblMessage.Visible = enabled;
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
                if (string.IsNullOrEmpty(inputText))
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = Resources.Labels.EmptyInput;
                }
                else
                {
                    SecurityInput si = new SecurityInput { InputString = inputText };
                    Validate result = WS.ValidateInputText(si);
                    ltrCleaningText.Text = Resources.Labels.Sanitized + result.Output.SanitizedString;

                    CreditCardInf cci = WS.GetCreditCardNum(new SecurityInput { InputString = result.Output.SanitizedString });

                    if (!cci.creditCard.IsValid)
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
                        Result res = WS.ProcessCreditCardNumber(new SanitizedInput { Value = cci.creditCard.CreditCardNumber });
                        lblEncrypted.Text = Resources.Labels.Encrypdated + System.Text.Encoding.UTF8.GetString(res.encodingData.cryptoData.Encrypted);
                        lblDecrypt.Text = Resources.Labels.DecrypVal + res.encodingData.cryptoData.Decrypted;
                        lblSHA256.Text = Resources.Labels.SHAVal + res.encodingData.SHA256;
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
            txbInputText.Text = string.Empty;
            lblMessage.Text = string.Empty;
            lblCCMasked.Text = string.Empty;
            lblEncrypted.Text = string.Empty;
            lblDecrypt.Text = string.Empty;
            lblSHA256.Text = string.Empty;
        }

    }
}