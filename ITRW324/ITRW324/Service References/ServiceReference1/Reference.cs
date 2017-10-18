﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITRW324.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ServiceSoap")]
    public interface ServiceSoap {
        
        // CODEGEN: Generating message contract since element name sName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        ITRW324.ServiceReference1.InsertResponse Insert(ITRW324.ServiceReference1.InsertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<ITRW324.ServiceReference1.InsertResponse> InsertAsync(ITRW324.ServiceReference1.InsertRequest request);
        
        // CODEGEN: Generating message contract since element name GetDocumentsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDocuments", ReplyAction="*")]
        ITRW324.ServiceReference1.GetDocumentsResponse GetDocuments(ITRW324.ServiceReference1.GetDocumentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDocuments", ReplyAction="*")]
        System.Threading.Tasks.Task<ITRW324.ServiceReference1.GetDocumentsResponse> GetDocumentsAsync(ITRW324.ServiceReference1.GetDocumentsRequest request);
        
        // CODEGEN: Generating message contract since element name sName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Createuser", ReplyAction="*")]
        ITRW324.ServiceReference1.CreateuserResponse Createuser(ITRW324.ServiceReference1.CreateuserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Createuser", ReplyAction="*")]
        System.Threading.Tasks.Task<ITRW324.ServiceReference1.CreateuserResponse> CreateuserAsync(ITRW324.ServiceReference1.CreateuserRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert", Namespace="http://tempuri.org/", Order=0)]
        public ITRW324.ServiceReference1.InsertRequestBody Body;
        
        public InsertRequest() {
        }
        
        public InsertRequest(ITRW324.ServiceReference1.InsertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sHash;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public byte[] bData;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int iUserID;
        
        public InsertRequestBody() {
        }
        
        public InsertRequestBody(string sName, string sType, string sHash, byte[] bData, int iUserID) {
            this.sName = sName;
            this.sType = sType;
            this.sHash = sHash;
            this.bData = bData;
            this.iUserID = iUserID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertResponse", Namespace="http://tempuri.org/", Order=0)]
        public ITRW324.ServiceReference1.InsertResponseBody Body;
        
        public InsertResponse() {
        }
        
        public InsertResponse(ITRW324.ServiceReference1.InsertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertResult;
        
        public InsertResponseBody() {
        }
        
        public InsertResponseBody(string InsertResult) {
            this.InsertResult = InsertResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDocumentsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDocuments", Namespace="http://tempuri.org/", Order=0)]
        public ITRW324.ServiceReference1.GetDocumentsRequestBody Body;
        
        public GetDocumentsRequest() {
        }
        
        public GetDocumentsRequest(ITRW324.ServiceReference1.GetDocumentsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDocumentsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int iUserID;
        
        public GetDocumentsRequestBody() {
        }
        
        public GetDocumentsRequestBody(int iUserID) {
            this.iUserID = iUserID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDocumentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDocumentsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ITRW324.ServiceReference1.GetDocumentsResponseBody Body;
        
        public GetDocumentsResponse() {
        }
        
        public GetDocumentsResponse(ITRW324.ServiceReference1.GetDocumentsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDocumentsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ITRW324.ServiceReference1.ArrayOfString[] GetDocumentsResult;
        
        public GetDocumentsResponseBody() {
        }
        
        public GetDocumentsResponseBody(ITRW324.ServiceReference1.ArrayOfString[] GetDocumentsResult) {
            this.GetDocumentsResult = GetDocumentsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateuserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Createuser", Namespace="http://tempuri.org/", Order=0)]
        public ITRW324.ServiceReference1.CreateuserRequestBody Body;
        
        public CreateuserRequest() {
        }
        
        public CreateuserRequest(ITRW324.ServiceReference1.CreateuserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateuserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sPassword;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sEmail;
        
        public CreateuserRequestBody() {
        }
        
        public CreateuserRequestBody(string sName, string sPassword, string sEmail) {
            this.sName = sName;
            this.sPassword = sPassword;
            this.sEmail = sEmail;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateuserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateuserResponse", Namespace="http://tempuri.org/", Order=0)]
        public ITRW324.ServiceReference1.CreateuserResponseBody Body;
        
        public CreateuserResponse() {
        }
        
        public CreateuserResponse(ITRW324.ServiceReference1.CreateuserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateuserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CreateuserResult;
        
        public CreateuserResponseBody() {
        }
        
        public CreateuserResponseBody(string CreateuserResult) {
            this.CreateuserResult = CreateuserResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : ITRW324.ServiceReference1.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<ITRW324.ServiceReference1.ServiceSoap>, ITRW324.ServiceReference1.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ITRW324.ServiceReference1.InsertResponse ITRW324.ServiceReference1.ServiceSoap.Insert(ITRW324.ServiceReference1.InsertRequest request) {
            return base.Channel.Insert(request);
        }
        
        public string Insert(string sName, string sType, string sHash, byte[] bData, int iUserID) {
            ITRW324.ServiceReference1.InsertRequest inValue = new ITRW324.ServiceReference1.InsertRequest();
            inValue.Body = new ITRW324.ServiceReference1.InsertRequestBody();
            inValue.Body.sName = sName;
            inValue.Body.sType = sType;
            inValue.Body.sHash = sHash;
            inValue.Body.bData = bData;
            inValue.Body.iUserID = iUserID;
            ITRW324.ServiceReference1.InsertResponse retVal = ((ITRW324.ServiceReference1.ServiceSoap)(this)).Insert(inValue);
            return retVal.Body.InsertResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ITRW324.ServiceReference1.InsertResponse> ITRW324.ServiceReference1.ServiceSoap.InsertAsync(ITRW324.ServiceReference1.InsertRequest request) {
            return base.Channel.InsertAsync(request);
        }
        
        public System.Threading.Tasks.Task<ITRW324.ServiceReference1.InsertResponse> InsertAsync(string sName, string sType, string sHash, byte[] bData, int iUserID) {
            ITRW324.ServiceReference1.InsertRequest inValue = new ITRW324.ServiceReference1.InsertRequest();
            inValue.Body = new ITRW324.ServiceReference1.InsertRequestBody();
            inValue.Body.sName = sName;
            inValue.Body.sType = sType;
            inValue.Body.sHash = sHash;
            inValue.Body.bData = bData;
            inValue.Body.iUserID = iUserID;
            return ((ITRW324.ServiceReference1.ServiceSoap)(this)).InsertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ITRW324.ServiceReference1.GetDocumentsResponse ITRW324.ServiceReference1.ServiceSoap.GetDocuments(ITRW324.ServiceReference1.GetDocumentsRequest request) {
            return base.Channel.GetDocuments(request);
        }
        
        public ITRW324.ServiceReference1.ArrayOfString[] GetDocuments(int iUserID) {
            ITRW324.ServiceReference1.GetDocumentsRequest inValue = new ITRW324.ServiceReference1.GetDocumentsRequest();
            inValue.Body = new ITRW324.ServiceReference1.GetDocumentsRequestBody();
            inValue.Body.iUserID = iUserID;
            ITRW324.ServiceReference1.GetDocumentsResponse retVal = ((ITRW324.ServiceReference1.ServiceSoap)(this)).GetDocuments(inValue);
            return retVal.Body.GetDocumentsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ITRW324.ServiceReference1.GetDocumentsResponse> ITRW324.ServiceReference1.ServiceSoap.GetDocumentsAsync(ITRW324.ServiceReference1.GetDocumentsRequest request) {
            return base.Channel.GetDocumentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ITRW324.ServiceReference1.GetDocumentsResponse> GetDocumentsAsync(int iUserID) {
            ITRW324.ServiceReference1.GetDocumentsRequest inValue = new ITRW324.ServiceReference1.GetDocumentsRequest();
            inValue.Body = new ITRW324.ServiceReference1.GetDocumentsRequestBody();
            inValue.Body.iUserID = iUserID;
            return ((ITRW324.ServiceReference1.ServiceSoap)(this)).GetDocumentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ITRW324.ServiceReference1.CreateuserResponse ITRW324.ServiceReference1.ServiceSoap.Createuser(ITRW324.ServiceReference1.CreateuserRequest request) {
            return base.Channel.Createuser(request);
        }
        
        public string Createuser(string sName, string sPassword, string sEmail) {
            ITRW324.ServiceReference1.CreateuserRequest inValue = new ITRW324.ServiceReference1.CreateuserRequest();
            inValue.Body = new ITRW324.ServiceReference1.CreateuserRequestBody();
            inValue.Body.sName = sName;
            inValue.Body.sPassword = sPassword;
            inValue.Body.sEmail = sEmail;
            ITRW324.ServiceReference1.CreateuserResponse retVal = ((ITRW324.ServiceReference1.ServiceSoap)(this)).Createuser(inValue);
            return retVal.Body.CreateuserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ITRW324.ServiceReference1.CreateuserResponse> ITRW324.ServiceReference1.ServiceSoap.CreateuserAsync(ITRW324.ServiceReference1.CreateuserRequest request) {
            return base.Channel.CreateuserAsync(request);
        }
        
        public System.Threading.Tasks.Task<ITRW324.ServiceReference1.CreateuserResponse> CreateuserAsync(string sName, string sPassword, string sEmail) {
            ITRW324.ServiceReference1.CreateuserRequest inValue = new ITRW324.ServiceReference1.CreateuserRequest();
            inValue.Body = new ITRW324.ServiceReference1.CreateuserRequestBody();
            inValue.Body.sName = sName;
            inValue.Body.sPassword = sPassword;
            inValue.Body.sEmail = sEmail;
            return ((ITRW324.ServiceReference1.ServiceSoap)(this)).CreateuserAsync(inValue);
        }
    }
}
