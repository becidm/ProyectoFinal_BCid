﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinalSeguridadApps.WebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SecurityInput", Namespace="http://schemas.datacontract.org/2004/07/WCFSeguridadApps")]
    [System.SerializableAttribute()]
    public partial class SecurityInput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InputStringField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InputString {
            get {
                return this.InputStringField;
            }
            set {
                if ((object.ReferenceEquals(this.InputStringField, value) != true)) {
                    this.InputStringField = value;
                    this.RaisePropertyChanged("InputString");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Validate", Namespace="http://schemas.datacontract.org/2004/07/WCFSeguridadApps")]
    [System.SerializableAttribute()]
    public partial class Validate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProyectoFinalSeguridadApps.WebService.InputResult OutputField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProyectoFinalSeguridadApps.WebService.InputResult Output {
            get {
                return this.OutputField;
            }
            set {
                if ((object.ReferenceEquals(this.OutputField, value) != true)) {
                    this.OutputField = value;
                    this.RaisePropertyChanged("Output");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InputResult", Namespace="http://schemas.datacontract.org/2004/07/Business_SeguridadApps.StructuresObj")]
    [System.SerializableAttribute()]
    public partial class InputResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsMatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SanitizedStringField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsMatch {
            get {
                return this.IsMatchField;
            }
            set {
                if ((this.IsMatchField.Equals(value) != true)) {
                    this.IsMatchField = value;
                    this.RaisePropertyChanged("IsMatch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SanitizedString {
            get {
                return this.SanitizedStringField;
            }
            set {
                if ((object.ReferenceEquals(this.SanitizedStringField, value) != true)) {
                    this.SanitizedStringField = value;
                    this.RaisePropertyChanged("SanitizedString");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreditCardInf", Namespace="http://schemas.datacontract.org/2004/07/WCFSeguridadApps")]
    [System.SerializableAttribute()]
    public partial class CreditCardInf : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProyectoFinalSeguridadApps.WebService.CreditCard creditCardField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProyectoFinalSeguridadApps.WebService.CreditCard creditCard {
            get {
                return this.creditCardField;
            }
            set {
                if ((object.ReferenceEquals(this.creditCardField, value) != true)) {
                    this.creditCardField = value;
                    this.RaisePropertyChanged("creditCard");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreditCard", Namespace="http://schemas.datacontract.org/2004/07/Business_SeguridadApps.StructuresObj")]
    [System.SerializableAttribute()]
    public partial class CreditCard : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditCardMaskedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditCardNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IndexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsValidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreditCardMasked {
            get {
                return this.CreditCardMaskedField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditCardMaskedField, value) != true)) {
                    this.CreditCardMaskedField = value;
                    this.RaisePropertyChanged("CreditCardMasked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreditCardNumber {
            get {
                return this.CreditCardNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditCardNumberField, value) != true)) {
                    this.CreditCardNumberField = value;
                    this.RaisePropertyChanged("CreditCardNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Index {
            get {
                return this.IndexField;
            }
            set {
                if ((this.IndexField.Equals(value) != true)) {
                    this.IndexField = value;
                    this.RaisePropertyChanged("Index");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsValid {
            get {
                return this.IsValidField;
            }
            set {
                if ((this.IsValidField.Equals(value) != true)) {
                    this.IsValidField = value;
                    this.RaisePropertyChanged("IsValid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SanitizedInput", Namespace="http://schemas.datacontract.org/2004/07/WCFSeguridadApps")]
    [System.SerializableAttribute()]
    public partial class SanitizedInput : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/WCFSeguridadApps")]
    [System.SerializableAttribute()]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsMatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProyectoFinalSeguridadApps.WebService.EncodingData encodingDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsMatch {
            get {
                return this.IsMatchField;
            }
            set {
                if ((this.IsMatchField.Equals(value) != true)) {
                    this.IsMatchField = value;
                    this.RaisePropertyChanged("IsMatch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProyectoFinalSeguridadApps.WebService.EncodingData encodingData {
            get {
                return this.encodingDataField;
            }
            set {
                if ((object.ReferenceEquals(this.encodingDataField, value) != true)) {
                    this.encodingDataField = value;
                    this.RaisePropertyChanged("encodingData");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EncodingData", Namespace="http://schemas.datacontract.org/2004/07/Business_SeguridadApps.StructuresObj")]
    [System.SerializableAttribute()]
    public partial class EncodingData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SHA256Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProyectoFinalSeguridadApps.WebService.CryptoData cryptoDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SHA256 {
            get {
                return this.SHA256Field;
            }
            set {
                if ((object.ReferenceEquals(this.SHA256Field, value) != true)) {
                    this.SHA256Field = value;
                    this.RaisePropertyChanged("SHA256");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProyectoFinalSeguridadApps.WebService.CryptoData cryptoData {
            get {
                return this.cryptoDataField;
            }
            set {
                if ((object.ReferenceEquals(this.cryptoDataField, value) != true)) {
                    this.cryptoDataField = value;
                    this.RaisePropertyChanged("cryptoData");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CryptoData", Namespace="http://schemas.datacontract.org/2004/07/Business_SeguridadApps.StructuresObj")]
    [System.SerializableAttribute()]
    public partial class CryptoData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DecryptedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] EncryptedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Decrypted {
            get {
                return this.DecryptedField;
            }
            set {
                if ((object.ReferenceEquals(this.DecryptedField, value) != true)) {
                    this.DecryptedField = value;
                    this.RaisePropertyChanged("Decrypted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Done {
            get {
                return this.DoneField;
            }
            set {
                if ((this.DoneField.Equals(value) != true)) {
                    this.DoneField = value;
                    this.RaisePropertyChanged("Done");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Encrypted {
            get {
                return this.EncryptedField;
            }
            set {
                if ((object.ReferenceEquals(this.EncryptedField, value) != true)) {
                    this.EncryptedField = value;
                    this.RaisePropertyChanged("Encrypted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebService.ISecurityProject")]
    public interface ISecurityProject {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityProject/ValidateInputText", ReplyAction="http://tempuri.org/ISecurityProject/ValidateInputTextResponse")]
        ProyectoFinalSeguridadApps.WebService.Validate ValidateInputText(ProyectoFinalSeguridadApps.WebService.SecurityInput inputstring);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityProject/ValidateInputText", ReplyAction="http://tempuri.org/ISecurityProject/ValidateInputTextResponse")]
        System.Threading.Tasks.Task<ProyectoFinalSeguridadApps.WebService.Validate> ValidateInputTextAsync(ProyectoFinalSeguridadApps.WebService.SecurityInput inputstring);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityProject/GetCreditCardNum", ReplyAction="http://tempuri.org/ISecurityProject/GetCreditCardNumResponse")]
        ProyectoFinalSeguridadApps.WebService.CreditCardInf GetCreditCardNum(ProyectoFinalSeguridadApps.WebService.SecurityInput inputText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityProject/GetCreditCardNum", ReplyAction="http://tempuri.org/ISecurityProject/GetCreditCardNumResponse")]
        System.Threading.Tasks.Task<ProyectoFinalSeguridadApps.WebService.CreditCardInf> GetCreditCardNumAsync(ProyectoFinalSeguridadApps.WebService.SecurityInput inputText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityProject/ProcessCreditCardNumber", ReplyAction="http://tempuri.org/ISecurityProject/ProcessCreditCardNumberResponse")]
        ProyectoFinalSeguridadApps.WebService.Result ProcessCreditCardNumber(ProyectoFinalSeguridadApps.WebService.SanitizedInput input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityProject/ProcessCreditCardNumber", ReplyAction="http://tempuri.org/ISecurityProject/ProcessCreditCardNumberResponse")]
        System.Threading.Tasks.Task<ProyectoFinalSeguridadApps.WebService.Result> ProcessCreditCardNumberAsync(ProyectoFinalSeguridadApps.WebService.SanitizedInput input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISecurityProjectChannel : ProyectoFinalSeguridadApps.WebService.ISecurityProject, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SecurityProjectClient : System.ServiceModel.ClientBase<ProyectoFinalSeguridadApps.WebService.ISecurityProject>, ProyectoFinalSeguridadApps.WebService.ISecurityProject {
        
        public SecurityProjectClient() {
        }
        
        public SecurityProjectClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SecurityProjectClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecurityProjectClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecurityProjectClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProyectoFinalSeguridadApps.WebService.Validate ValidateInputText(ProyectoFinalSeguridadApps.WebService.SecurityInput inputstring) {
            return base.Channel.ValidateInputText(inputstring);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinalSeguridadApps.WebService.Validate> ValidateInputTextAsync(ProyectoFinalSeguridadApps.WebService.SecurityInput inputstring) {
            return base.Channel.ValidateInputTextAsync(inputstring);
        }
        
        public ProyectoFinalSeguridadApps.WebService.CreditCardInf GetCreditCardNum(ProyectoFinalSeguridadApps.WebService.SecurityInput inputText) {
            return base.Channel.GetCreditCardNum(inputText);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinalSeguridadApps.WebService.CreditCardInf> GetCreditCardNumAsync(ProyectoFinalSeguridadApps.WebService.SecurityInput inputText) {
            return base.Channel.GetCreditCardNumAsync(inputText);
        }
        
        public ProyectoFinalSeguridadApps.WebService.Result ProcessCreditCardNumber(ProyectoFinalSeguridadApps.WebService.SanitizedInput input) {
            return base.Channel.ProcessCreditCardNumber(input);
        }
        
        public System.Threading.Tasks.Task<ProyectoFinalSeguridadApps.WebService.Result> ProcessCreditCardNumberAsync(ProyectoFinalSeguridadApps.WebService.SanitizedInput input) {
            return base.Channel.ProcessCreditCardNumberAsync(input);
        }
    }
}
