//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9151
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.9151.
// 
namespace Calbee.WMS.Services.AuthorizeService {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IAuthorizeService", Namespace="http://tempuri.org/")]
    public partial class AuthorizeService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public AuthorizeService() {
            this.Url = "http://43.229.78.24/WMSService/AuthorizeService.svc";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IAuthorizeService/Authorize", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public User Authorize([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string user_name, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password) {
            object[] results = this.Invoke("Authorize", new object[] {
                        user_name,
                        password});
            return ((User)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAuthorize(string user_name, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Authorize", new object[] {
                        user_name,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public User EndAuthorize(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((User)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IAuthorizeService/GetMenuFunctions", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Authorize")]
        public Menu[] GetMenuFunctions(int userGroupId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool userGroupIdSpecified) {
            object[] results = this.Invoke("GetMenuFunctions", new object[] {
                        userGroupId,
                        userGroupIdSpecified});
            return ((Menu[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetMenuFunctions(int userGroupId, bool userGroupIdSpecified, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetMenuFunctions", new object[] {
                        userGroupId,
                        userGroupIdSpecified}, callback, asyncState);
        }
        
        /// <remarks/>
        public Menu[] EndGetMenuFunctions(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Menu[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Authorize")]
    public partial class User {
        
        private string descriptionField;
        
        private int employeeIdField;
        
        private bool employeeIdFieldSpecified;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string passwordField;
        
        private int userGroupIdField;
        
        private bool userGroupIdFieldSpecified;
        
        private int userIdField;
        
        private bool userIdFieldSpecified;
        
        private string userNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public int EmployeeId {
            get {
                return this.employeeIdField;
            }
            set {
                this.employeeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmployeeIdSpecified {
            get {
                return this.employeeIdFieldSpecified;
            }
            set {
                this.employeeIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public int UserGroupId {
            get {
                return this.userGroupIdField;
            }
            set {
                this.userGroupIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserGroupIdSpecified {
            get {
                return this.userGroupIdFieldSpecified;
            }
            set {
                this.userGroupIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int UserId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserIdSpecified {
            get {
                return this.userIdFieldSpecified;
            }
            set {
                this.userIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Authorize")]
    public partial class Menu {
        
        private string descriptionField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private bool isActiveField;
        
        private bool isActiveFieldSpecified;
        
        private string menuCodeField;
        
        private string menuGroupField;
        
        private string menuNameField;
        
        private string platformField;
        
        private string resourceKeyField;
        
        private int sequenceField;
        
        private bool sequenceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool IsActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsActiveSpecified {
            get {
                return this.isActiveFieldSpecified;
            }
            set {
                this.isActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string MenuCode {
            get {
                return this.menuCodeField;
            }
            set {
                this.menuCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string MenuGroup {
            get {
                return this.menuGroupField;
            }
            set {
                this.menuGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string MenuName {
            get {
                return this.menuNameField;
            }
            set {
                this.menuNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Platform {
            get {
                return this.platformField;
            }
            set {
                this.platformField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ResourceKey {
            get {
                return this.resourceKeyField;
            }
            set {
                this.resourceKeyField = value;
            }
        }
        
        /// <remarks/>
        public int Sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SequenceSpecified {
            get {
                return this.sequenceFieldSpecified;
            }
            set {
                this.sequenceFieldSpecified = value;
            }
        }
    }
}
