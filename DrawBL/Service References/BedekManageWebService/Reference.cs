﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrawBL.BedekManageWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://bedek-online.co.il/", ConfigurationName="BedekManageWebService.ManageServiceSoap")]
    public interface ManageServiceSoap {
        
        // CODEGEN: Generating message contract since element name TryItResult from namespace http://bedek-online.co.il/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://bedek-online.co.il/TryIt", ReplyAction="*")]
        DrawBL.BedekManageWebService.TryItResponse TryIt(DrawBL.BedekManageWebService.TryItRequest request);
        
        // CODEGEN: Generating message contract since element name TreeText from namespace http://bedek-online.co.il/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://bedek-online.co.il/GetProjectsTree", ReplyAction="*")]
        DrawBL.BedekManageWebService.GetProjectsTreeResponse GetProjectsTree(DrawBL.BedekManageWebService.GetProjectsTreeRequest request);
        
        // CODEGEN: Generating message contract since element name tableName from namespace http://bedek-online.co.il/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://bedek-online.co.il/AddNewProblem", ReplyAction="*")]
        DrawBL.BedekManageWebService.AddNewProblemResponse AddNewProblem(DrawBL.BedekManageWebService.AddNewProblemRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TryItRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TryIt", Namespace="http://bedek-online.co.il/", Order=0)]
        public DrawBL.BedekManageWebService.TryItRequestBody Body;
        
        public TryItRequest() {
        }
        
        public TryItRequest(DrawBL.BedekManageWebService.TryItRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class TryItRequestBody {
        
        public TryItRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TryItResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TryItResponse", Namespace="http://bedek-online.co.il/", Order=0)]
        public DrawBL.BedekManageWebService.TryItResponseBody Body;
        
        public TryItResponse() {
        }
        
        public TryItResponse(DrawBL.BedekManageWebService.TryItResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://bedek-online.co.il/")]
    public partial class TryItResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TryItResult;
        
        public TryItResponseBody() {
        }
        
        public TryItResponseBody(string TryItResult) {
            this.TryItResult = TryItResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProjectsTreeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProjectsTree", Namespace="http://bedek-online.co.il/", Order=0)]
        public DrawBL.BedekManageWebService.GetProjectsTreeRequestBody Body;
        
        public GetProjectsTreeRequest() {
        }
        
        public GetProjectsTreeRequest(DrawBL.BedekManageWebService.GetProjectsTreeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetProjectsTreeRequestBody {
        
        public GetProjectsTreeRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProjectsTreeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProjectsTreeResponse", Namespace="http://bedek-online.co.il/", Order=0)]
        public DrawBL.BedekManageWebService.GetProjectsTreeResponseBody Body;
        
        public GetProjectsTreeResponse() {
        }
        
        public GetProjectsTreeResponse(DrawBL.BedekManageWebService.GetProjectsTreeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://bedek-online.co.il/")]
    public partial class GetProjectsTreeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool GetProjectsTreeResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string TreeText;
        
        public GetProjectsTreeResponseBody() {
        }
        
        public GetProjectsTreeResponseBody(bool GetProjectsTreeResult, string TreeText) {
            this.GetProjectsTreeResult = GetProjectsTreeResult;
            this.TreeText = TreeText;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddNewProblemRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddNewProblem", Namespace="http://bedek-online.co.il/", Order=0)]
        public DrawBL.BedekManageWebService.AddNewProblemRequestBody Body;
        
        public AddNewProblemRequest() {
        }
        
        public AddNewProblemRequest(DrawBL.BedekManageWebService.AddNewProblemRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://bedek-online.co.il/")]
    public partial class AddNewProblemRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string tableName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int itemId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string problemDescription;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string reporter;
        
        public AddNewProblemRequestBody() {
        }
        
        public AddNewProblemRequestBody(string tableName, int itemId, string problemDescription, string reporter) {
            this.tableName = tableName;
            this.itemId = itemId;
            this.problemDescription = problemDescription;
            this.reporter = reporter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddNewProblemResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddNewProblemResponse", Namespace="http://bedek-online.co.il/", Order=0)]
        public DrawBL.BedekManageWebService.AddNewProblemResponseBody Body;
        
        public AddNewProblemResponse() {
        }
        
        public AddNewProblemResponse(DrawBL.BedekManageWebService.AddNewProblemResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://bedek-online.co.il/")]
    public partial class AddNewProblemResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AddNewProblemResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int newId;
        
        public AddNewProblemResponseBody() {
        }
        
        public AddNewProblemResponseBody(bool AddNewProblemResult, int newId) {
            this.AddNewProblemResult = AddNewProblemResult;
            this.newId = newId;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ManageServiceSoapChannel : DrawBL.BedekManageWebService.ManageServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManageServiceSoapClient : System.ServiceModel.ClientBase<DrawBL.BedekManageWebService.ManageServiceSoap>, DrawBL.BedekManageWebService.ManageServiceSoap {
        
        public ManageServiceSoapClient() {
        }
        
        public ManageServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManageServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManageServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManageServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DrawBL.BedekManageWebService.TryItResponse DrawBL.BedekManageWebService.ManageServiceSoap.TryIt(DrawBL.BedekManageWebService.TryItRequest request) {
            return base.Channel.TryIt(request);
        }
        
        public string TryIt() {
            DrawBL.BedekManageWebService.TryItRequest inValue = new DrawBL.BedekManageWebService.TryItRequest();
            inValue.Body = new DrawBL.BedekManageWebService.TryItRequestBody();
            DrawBL.BedekManageWebService.TryItResponse retVal = ((DrawBL.BedekManageWebService.ManageServiceSoap)(this)).TryIt(inValue);
            return retVal.Body.TryItResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DrawBL.BedekManageWebService.GetProjectsTreeResponse DrawBL.BedekManageWebService.ManageServiceSoap.GetProjectsTree(DrawBL.BedekManageWebService.GetProjectsTreeRequest request) {
            return base.Channel.GetProjectsTree(request);
        }
        
        public bool GetProjectsTree(out string TreeText) {
            DrawBL.BedekManageWebService.GetProjectsTreeRequest inValue = new DrawBL.BedekManageWebService.GetProjectsTreeRequest();
            inValue.Body = new DrawBL.BedekManageWebService.GetProjectsTreeRequestBody();
            DrawBL.BedekManageWebService.GetProjectsTreeResponse retVal = ((DrawBL.BedekManageWebService.ManageServiceSoap)(this)).GetProjectsTree(inValue);
            TreeText = retVal.Body.TreeText;
            return retVal.Body.GetProjectsTreeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DrawBL.BedekManageWebService.AddNewProblemResponse DrawBL.BedekManageWebService.ManageServiceSoap.AddNewProblem(DrawBL.BedekManageWebService.AddNewProblemRequest request) {
            return base.Channel.AddNewProblem(request);
        }
        
        public bool AddNewProblem(string tableName, int itemId, string problemDescription, string reporter, out int newId) {
            DrawBL.BedekManageWebService.AddNewProblemRequest inValue = new DrawBL.BedekManageWebService.AddNewProblemRequest();
            inValue.Body = new DrawBL.BedekManageWebService.AddNewProblemRequestBody();
            inValue.Body.tableName = tableName;
            inValue.Body.itemId = itemId;
            inValue.Body.problemDescription = problemDescription;
            inValue.Body.reporter = reporter;
            DrawBL.BedekManageWebService.AddNewProblemResponse retVal = ((DrawBL.BedekManageWebService.ManageServiceSoap)(this)).AddNewProblem(inValue);
            newId = retVal.Body.newId;
            return retVal.Body.AddNewProblemResult;
        }
    }
}
