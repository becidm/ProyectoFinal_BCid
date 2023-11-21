using System.Runtime.Serialization;
using System.ServiceModel;
using Business_SeguridadApps.StructuresObj;

namespace WCFSeguridadApps
{
    [DataContract]
    public class SecurityInput
    {
        [DataMember]
        public string InputString { get; set; }
    }
    [DataContract]
    public class SanitizedInput
    {
        [DataMember]
        public string Value { get; set; }
    }
    [DataContract]
    public class CreditCardInf
    {
        [DataMember]
        public CreditCard creditCard { get; set; }
    }
    [DataContract]
    public class Result
    {
        [DataMember]
        public EncodingData encodingData { get; set; }
        [DataMember]
        public bool IsMatch { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
    [DataContract]
    public class Validate
    {
        [DataMember]
        public InputResult Output { get; set; }

        public Validate()
        {
            Output = new InputResult();
        }
    }
    [ServiceContract]
    public interface ISecurityProject
    {
        [OperationContract]
        Validate ValidateInputText(SecurityInput inputstring);
        [OperationContract]
        CreditCardInf GetCreditCardNum(SecurityInput inputText);
        [OperationContract]
        Result ProcessCreditCardNumber(SanitizedInput input);

    }
}
