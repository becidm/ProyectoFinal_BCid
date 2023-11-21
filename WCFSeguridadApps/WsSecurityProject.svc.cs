
using Business_SeguridadApps;
using System;

namespace WCFSeguridadApps
{
    public class WsSecurityProject : ISecurityProject
    {/// <summary>
     /// Returns if the input string is valid. Cleans the value if it has invalid characters. 
     /// </summary>
     /// <param name="inputstring"></param>
     /// <returns></returns>
        public Validate ValidateInputText(SecurityInput inputstring)
        {

            Validate result = new Validate();
            try
            {
                BusinessRules manager = new BusinessRules();
                result.Output = manager.ValidateInputText(inputstring.InputString);
            }
            catch (Exception ex)
            {
                result.Output.Message = ex.Message;
                result.Output.IsMatch = false;
            }
            return result;
        }
        /// <summary>
        /// Gets the Credit Card Number from the input string and the masked value of it 
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public CreditCardInf GetCreditCardNum(SecurityInput inputText)
        {
            CreditCardInf cc = new CreditCardInf();
            try
            {
                BusinessRules manager = new BusinessRules();
                cc.creditCard = manager.GetCreditCardInfo(inputText.InputString);
            }
            catch (Exception ex)
            {
                cc.creditCard.IsValid = false;
                cc.creditCard.Message = ex.Message;
            }
            return cc;
        }

        /// <summary>
        /// Processes the credit card number to encrypt / decrypt the card number. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Result ProcessCreditCardNumber(SanitizedInput input)
        {
            BusinessRules manager = new BusinessRules();
            Result res = new Result();

            try
            {
                res.encodingData = manager.EncodingCreditCard(input.Value);
            }
            catch (Exception ex)
            {

                res.Message = ex.Message;
            }
            return res;
        }
    }
}
