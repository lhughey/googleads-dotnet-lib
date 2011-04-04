﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReportContract", Namespace="http://schemas.datacontract.org/2004/07/Google.Api.Ads.Dfa.Examples.Wcf")]
    [System.SerializableAttribute()]
    public partial class ReportContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long QueryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReportFilePathField;
        
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
        public bool IsSuccess {
            get {
                return this.IsSuccessField;
            }
            set {
                if ((this.IsSuccessField.Equals(value) != true)) {
                    this.IsSuccessField = value;
                    this.RaisePropertyChanged("IsSuccess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long QueryId {
            get {
                return this.QueryIdField;
            }
            set {
                if ((this.QueryIdField.Equals(value) != true)) {
                    this.QueryIdField = value;
                    this.RaisePropertyChanged("QueryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReportFilePath {
            get {
                return this.ReportFilePathField;
            }
            set {
                if ((object.ReferenceEquals(this.ReportFilePathField, value) != true)) {
                    this.ReportFilePathField = value;
                    this.RaisePropertyChanged("ReportFilePath");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AdType", Namespace="http://schemas.datacontract.org/2004/07/Google.Api.Ads.Dfa.v1_13")]
    [System.SerializableAttribute()]
    public partial class AdType : Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.Base {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Base", Namespace="http://schemas.datacontract.org/2004/07/Google.Api.Ads.Dfa.v1_13")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.AdType))]
    public partial class Base : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.ApiException dummyExceptionFieldField;
        
        private long idFieldField;
        
        private string nameFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.ApiException dummyExceptionField {
            get {
                return this.dummyExceptionFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.dummyExceptionFieldField, value) != true)) {
                    this.dummyExceptionFieldField = value;
                    this.RaisePropertyChanged("dummyExceptionField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long idField {
            get {
                return this.idFieldField;
            }
            set {
                if ((this.idFieldField.Equals(value) != true)) {
                    this.idFieldField = value;
                    this.RaisePropertyChanged("idField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string nameField {
            get {
                return this.nameFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.nameFieldField, value) != true)) {
                    this.nameFieldField = value;
                    this.RaisePropertyChanged("nameField");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ApiException", Namespace="http://schemas.datacontract.org/2004/07/Google.Api.Ads.Dfa.v1_13")]
    [System.SerializableAttribute()]
    public partial class ApiException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long errorCodeFieldField;
        
        private string errorMessageFieldField;
        
        private string messageFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long errorCodeField {
            get {
                return this.errorCodeFieldField;
            }
            set {
                if ((this.errorCodeFieldField.Equals(value) != true)) {
                    this.errorCodeFieldField = value;
                    this.RaisePropertyChanged("errorCodeField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string errorMessageField {
            get {
                return this.errorMessageFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.errorMessageFieldField, value) != true)) {
                    this.errorMessageFieldField = value;
                    this.RaisePropertyChanged("errorMessageField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string messageField {
            get {
                return this.messageFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.messageFieldField, value) != true)) {
                    this.messageFieldField = value;
                    this.RaisePropertyChanged("messageField");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AdTypeContract", Namespace="http://schemas.datacontract.org/2004/07/Google.Api.Ads.Dfa.Examples.Wcf")]
    [System.SerializableAttribute()]
    public partial class AdTypeContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.AdType[] AdTypesField;
        
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
        public Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.AdType[] AdTypes {
            get {
                return this.AdTypesField;
            }
            set {
                if ((object.ReferenceEquals(this.AdTypesField, value) != true)) {
                    this.AdTypesField = value;
                    this.RaisePropertyChanged("AdTypes");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServiceReference.IWcfService")]
    public interface IWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetReport", ReplyAction="http://tempuri.org/IWcfService/GetReportResponse")]
        bool GetReport(long queryId, string reportFilePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetReportUsingContract", ReplyAction="http://tempuri.org/IWcfService/GetReportUsingContractResponse")]
        Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.ReportContract GetReportUsingContract(Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.ReportContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetAdTypes", ReplyAction="http://tempuri.org/IWcfService/GetAdTypesResponse")]
        Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.AdType[] GetAdTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetAdTypesUsingContract", ReplyAction="http://tempuri.org/IWcfService/GetAdTypesUsingContractResponse")]
        Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.AdTypeContract GetAdTypesUsingContract(Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.AdTypeContract contract);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IWcfServiceChannel : Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.IWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class WcfServiceClient : System.ServiceModel.ClientBase<Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.IWcfService>, Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.IWcfService {
        
        public WcfServiceClient() {
        }
        
        public WcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool GetReport(long queryId, string reportFilePath) {
            return base.Channel.GetReport(queryId, reportFilePath);
        }
        
        public Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.ReportContract GetReportUsingContract(Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.ReportContract contract) {
            return base.Channel.GetReportUsingContract(contract);
        }
        
        public Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.AdType[] GetAdTypes() {
            return base.Channel.GetAdTypes();
        }
        
        public Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.AdTypeContract GetAdTypesUsingContract(Google.Api.Ads.Dfa.Examples.Wcf.WcfServiceReference.AdTypeContract contract) {
            return base.Channel.GetAdTypesUsingContract(contract);
        }
    }
}
