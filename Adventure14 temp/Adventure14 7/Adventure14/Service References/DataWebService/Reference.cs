﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adventure14.DataWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int BusinessEntityIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressLine1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressLine2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipField;
        
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
        public int BusinessEntityID {
            get {
                return this.BusinessEntityIDField;
            }
            set {
                if ((this.BusinessEntityIDField.Equals(value) != true)) {
                    this.BusinessEntityIDField = value;
                    this.RaisePropertyChanged("BusinessEntityID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string JobTitle {
            get {
                return this.JobTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.JobTitleField, value) != true)) {
                    this.JobTitleField = value;
                    this.RaisePropertyChanged("JobTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string AddressLine1 {
            get {
                return this.AddressLine1Field;
            }
            set {
                if ((object.ReferenceEquals(this.AddressLine1Field, value) != true)) {
                    this.AddressLine1Field = value;
                    this.RaisePropertyChanged("AddressLine1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string AddressLine2 {
            get {
                return this.AddressLine2Field;
            }
            set {
                if ((object.ReferenceEquals(this.AddressLine2Field, value) != true)) {
                    this.AddressLine2Field = value;
                    this.RaisePropertyChanged("AddressLine2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipField, value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Departments", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Departments : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int DepartmentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupNameField;
        
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
        public int DepartmentID {
            get {
                return this.DepartmentIDField;
            }
            set {
                if ((this.DepartmentIDField.Equals(value) != true)) {
                    this.DepartmentIDField = value;
                    this.RaisePropertyChanged("DepartmentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string GroupName {
            get {
                return this.GroupNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupNameField, value) != true)) {
                    this.GroupNameField = value;
                    this.RaisePropertyChanged("GroupName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentEmployee", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class DepartmentEmployee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int BusinessEntityIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupNameField;
        
        private System.DateTime StartDateField;
        
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
        public int BusinessEntityID {
            get {
                return this.BusinessEntityIDField;
            }
            set {
                if ((this.BusinessEntityIDField.Equals(value) != true)) {
                    this.BusinessEntityIDField = value;
                    this.RaisePropertyChanged("BusinessEntityID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string GroupName {
            get {
                return this.GroupNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupNameField, value) != true)) {
                    this.GroupNameField = value;
                    this.RaisePropertyChanged("GroupName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataWebService.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name getListEmployeesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getListEmployees", ReplyAction="*")]
        Adventure14.DataWebService.getListEmployeesResponse getListEmployees(Adventure14.DataWebService.getListEmployeesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getListEmployees", ReplyAction="*")]
        System.Threading.Tasks.Task<Adventure14.DataWebService.getListEmployeesResponse> getListEmployeesAsync(Adventure14.DataWebService.getListEmployeesRequest request);
        
        // CODEGEN: Generating message contract since element name getListDepartmentsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getListDepartments", ReplyAction="*")]
        Adventure14.DataWebService.getListDepartmentsResponse getListDepartments(Adventure14.DataWebService.getListDepartmentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getListDepartments", ReplyAction="*")]
        System.Threading.Tasks.Task<Adventure14.DataWebService.getListDepartmentsResponse> getListDepartmentsAsync(Adventure14.DataWebService.getListDepartmentsRequest request);
        
        // CODEGEN: Generating message contract since element name DepartmentName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEmployeeByDepartment", ReplyAction="*")]
        Adventure14.DataWebService.getEmployeeByDepartmentResponse getEmployeeByDepartment(Adventure14.DataWebService.getEmployeeByDepartmentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEmployeeByDepartment", ReplyAction="*")]
        System.Threading.Tasks.Task<Adventure14.DataWebService.getEmployeeByDepartmentResponse> getEmployeeByDepartmentAsync(Adventure14.DataWebService.getEmployeeByDepartmentRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListEmployeesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListEmployees", Namespace="http://tempuri.org/", Order=0)]
        public Adventure14.DataWebService.getListEmployeesRequestBody Body;
        
        public getListEmployeesRequest() {
        }
        
        public getListEmployeesRequest(Adventure14.DataWebService.getListEmployeesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getListEmployeesRequestBody {
        
        public getListEmployeesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListEmployeesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListEmployeesResponse", Namespace="http://tempuri.org/", Order=0)]
        public Adventure14.DataWebService.getListEmployeesResponseBody Body;
        
        public getListEmployeesResponse() {
        }
        
        public getListEmployeesResponse(Adventure14.DataWebService.getListEmployeesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getListEmployeesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Adventure14.DataWebService.Employee[] getListEmployeesResult;
        
        public getListEmployeesResponseBody() {
        }
        
        public getListEmployeesResponseBody(Adventure14.DataWebService.Employee[] getListEmployeesResult) {
            this.getListEmployeesResult = getListEmployeesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListDepartmentsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListDepartments", Namespace="http://tempuri.org/", Order=0)]
        public Adventure14.DataWebService.getListDepartmentsRequestBody Body;
        
        public getListDepartmentsRequest() {
        }
        
        public getListDepartmentsRequest(Adventure14.DataWebService.getListDepartmentsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getListDepartmentsRequestBody {
        
        public getListDepartmentsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getListDepartmentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getListDepartmentsResponse", Namespace="http://tempuri.org/", Order=0)]
        public Adventure14.DataWebService.getListDepartmentsResponseBody Body;
        
        public getListDepartmentsResponse() {
        }
        
        public getListDepartmentsResponse(Adventure14.DataWebService.getListDepartmentsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getListDepartmentsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Adventure14.DataWebService.Departments[] getListDepartmentsResult;
        
        public getListDepartmentsResponseBody() {
        }
        
        public getListDepartmentsResponseBody(Adventure14.DataWebService.Departments[] getListDepartmentsResult) {
            this.getListDepartmentsResult = getListDepartmentsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getEmployeeByDepartmentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getEmployeeByDepartment", Namespace="http://tempuri.org/", Order=0)]
        public Adventure14.DataWebService.getEmployeeByDepartmentRequestBody Body;
        
        public getEmployeeByDepartmentRequest() {
        }
        
        public getEmployeeByDepartmentRequest(Adventure14.DataWebService.getEmployeeByDepartmentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getEmployeeByDepartmentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DepartmentName;
        
        public getEmployeeByDepartmentRequestBody() {
        }
        
        public getEmployeeByDepartmentRequestBody(string DepartmentName) {
            this.DepartmentName = DepartmentName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getEmployeeByDepartmentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getEmployeeByDepartmentResponse", Namespace="http://tempuri.org/", Order=0)]
        public Adventure14.DataWebService.getEmployeeByDepartmentResponseBody Body;
        
        public getEmployeeByDepartmentResponse() {
        }
        
        public getEmployeeByDepartmentResponse(Adventure14.DataWebService.getEmployeeByDepartmentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getEmployeeByDepartmentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Adventure14.DataWebService.DepartmentEmployee[] getEmployeeByDepartmentResult;
        
        public getEmployeeByDepartmentResponseBody() {
        }
        
        public getEmployeeByDepartmentResponseBody(Adventure14.DataWebService.DepartmentEmployee[] getEmployeeByDepartmentResult) {
            this.getEmployeeByDepartmentResult = getEmployeeByDepartmentResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Adventure14.DataWebService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Adventure14.DataWebService.WebService1Soap>, Adventure14.DataWebService.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Adventure14.DataWebService.getListEmployeesResponse Adventure14.DataWebService.WebService1Soap.getListEmployees(Adventure14.DataWebService.getListEmployeesRequest request) {
            return base.Channel.getListEmployees(request);
        }
        
        public Adventure14.DataWebService.Employee[] getListEmployees() {
            Adventure14.DataWebService.getListEmployeesRequest inValue = new Adventure14.DataWebService.getListEmployeesRequest();
            inValue.Body = new Adventure14.DataWebService.getListEmployeesRequestBody();
            Adventure14.DataWebService.getListEmployeesResponse retVal = ((Adventure14.DataWebService.WebService1Soap)(this)).getListEmployees(inValue);
            return retVal.Body.getListEmployeesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Adventure14.DataWebService.getListEmployeesResponse> Adventure14.DataWebService.WebService1Soap.getListEmployeesAsync(Adventure14.DataWebService.getListEmployeesRequest request) {
            return base.Channel.getListEmployeesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Adventure14.DataWebService.getListEmployeesResponse> getListEmployeesAsync() {
            Adventure14.DataWebService.getListEmployeesRequest inValue = new Adventure14.DataWebService.getListEmployeesRequest();
            inValue.Body = new Adventure14.DataWebService.getListEmployeesRequestBody();
            return ((Adventure14.DataWebService.WebService1Soap)(this)).getListEmployeesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Adventure14.DataWebService.getListDepartmentsResponse Adventure14.DataWebService.WebService1Soap.getListDepartments(Adventure14.DataWebService.getListDepartmentsRequest request) {
            return base.Channel.getListDepartments(request);
        }
        
        public Adventure14.DataWebService.Departments[] getListDepartments() {
            Adventure14.DataWebService.getListDepartmentsRequest inValue = new Adventure14.DataWebService.getListDepartmentsRequest();
            inValue.Body = new Adventure14.DataWebService.getListDepartmentsRequestBody();
            Adventure14.DataWebService.getListDepartmentsResponse retVal = ((Adventure14.DataWebService.WebService1Soap)(this)).getListDepartments(inValue);
            return retVal.Body.getListDepartmentsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Adventure14.DataWebService.getListDepartmentsResponse> Adventure14.DataWebService.WebService1Soap.getListDepartmentsAsync(Adventure14.DataWebService.getListDepartmentsRequest request) {
            return base.Channel.getListDepartmentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Adventure14.DataWebService.getListDepartmentsResponse> getListDepartmentsAsync() {
            Adventure14.DataWebService.getListDepartmentsRequest inValue = new Adventure14.DataWebService.getListDepartmentsRequest();
            inValue.Body = new Adventure14.DataWebService.getListDepartmentsRequestBody();
            return ((Adventure14.DataWebService.WebService1Soap)(this)).getListDepartmentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Adventure14.DataWebService.getEmployeeByDepartmentResponse Adventure14.DataWebService.WebService1Soap.getEmployeeByDepartment(Adventure14.DataWebService.getEmployeeByDepartmentRequest request) {
            return base.Channel.getEmployeeByDepartment(request);
        }
        
        public Adventure14.DataWebService.DepartmentEmployee[] getEmployeeByDepartment(string DepartmentName) {
            Adventure14.DataWebService.getEmployeeByDepartmentRequest inValue = new Adventure14.DataWebService.getEmployeeByDepartmentRequest();
            inValue.Body = new Adventure14.DataWebService.getEmployeeByDepartmentRequestBody();
            inValue.Body.DepartmentName = DepartmentName;
            Adventure14.DataWebService.getEmployeeByDepartmentResponse retVal = ((Adventure14.DataWebService.WebService1Soap)(this)).getEmployeeByDepartment(inValue);
            return retVal.Body.getEmployeeByDepartmentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Adventure14.DataWebService.getEmployeeByDepartmentResponse> Adventure14.DataWebService.WebService1Soap.getEmployeeByDepartmentAsync(Adventure14.DataWebService.getEmployeeByDepartmentRequest request) {
            return base.Channel.getEmployeeByDepartmentAsync(request);
        }
        
        public System.Threading.Tasks.Task<Adventure14.DataWebService.getEmployeeByDepartmentResponse> getEmployeeByDepartmentAsync(string DepartmentName) {
            Adventure14.DataWebService.getEmployeeByDepartmentRequest inValue = new Adventure14.DataWebService.getEmployeeByDepartmentRequest();
            inValue.Body = new Adventure14.DataWebService.getEmployeeByDepartmentRequestBody();
            inValue.Body.DepartmentName = DepartmentName;
            return ((Adventure14.DataWebService.WebService1Soap)(this)).getEmployeeByDepartmentAsync(inValue);
        }
    }
}