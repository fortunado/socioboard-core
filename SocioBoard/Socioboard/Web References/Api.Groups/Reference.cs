﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18063.
// 
#pragma warning disable 1591

namespace Socioboard.Api.Groups {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GroupsSoap", Namespace="http://tempuri.org/")]
    public partial class Groups : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddGroupOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGroupDetailsByGroupIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGroupDetailsByUserIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteGroupByUserIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteGroupByNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteGroupByIdOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Groups() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_Groups_Groups;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddGroupCompletedEventHandler AddGroupCompleted;
        
        /// <remarks/>
        public event GetGroupDetailsByGroupIdCompletedEventHandler GetGroupDetailsByGroupIdCompleted;
        
        /// <remarks/>
        public event GetGroupDetailsByUserIdCompletedEventHandler GetGroupDetailsByUserIdCompleted;
        
        /// <remarks/>
        public event DeleteGroupByUserIdCompletedEventHandler DeleteGroupByUserIdCompleted;
        
        /// <remarks/>
        public event DeleteGroupByNameCompletedEventHandler DeleteGroupByNameCompleted;
        
        /// <remarks/>
        public event DeleteGroupByIdCompletedEventHandler DeleteGroupByIdCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddGroup", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddGroup(string GroupName, string UserId) {
            object[] results = this.Invoke("AddGroup", new object[] {
                        GroupName,
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddGroupAsync(string GroupName, string UserId) {
            this.AddGroupAsync(GroupName, UserId, null);
        }
        
        /// <remarks/>
        public void AddGroupAsync(string GroupName, string UserId, object userState) {
            if ((this.AddGroupOperationCompleted == null)) {
                this.AddGroupOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddGroupOperationCompleted);
            }
            this.InvokeAsync("AddGroup", new object[] {
                        GroupName,
                        UserId}, this.AddGroupOperationCompleted, userState);
        }
        
        private void OnAddGroupOperationCompleted(object arg) {
            if ((this.AddGroupCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddGroupCompleted(this, new AddGroupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGroupDetailsByGroupId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetGroupDetailsByGroupId(string GroupId) {
            object[] results = this.Invoke("GetGroupDetailsByGroupId", new object[] {
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetGroupDetailsByGroupIdAsync(string GroupId) {
            this.GetGroupDetailsByGroupIdAsync(GroupId, null);
        }
        
        /// <remarks/>
        public void GetGroupDetailsByGroupIdAsync(string GroupId, object userState) {
            if ((this.GetGroupDetailsByGroupIdOperationCompleted == null)) {
                this.GetGroupDetailsByGroupIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGroupDetailsByGroupIdOperationCompleted);
            }
            this.InvokeAsync("GetGroupDetailsByGroupId", new object[] {
                        GroupId}, this.GetGroupDetailsByGroupIdOperationCompleted, userState);
        }
        
        private void OnGetGroupDetailsByGroupIdOperationCompleted(object arg) {
            if ((this.GetGroupDetailsByGroupIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGroupDetailsByGroupIdCompleted(this, new GetGroupDetailsByGroupIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGroupDetailsByUserId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetGroupDetailsByUserId(string UserId) {
            object[] results = this.Invoke("GetGroupDetailsByUserId", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetGroupDetailsByUserIdAsync(string UserId) {
            this.GetGroupDetailsByUserIdAsync(UserId, null);
        }
        
        /// <remarks/>
        public void GetGroupDetailsByUserIdAsync(string UserId, object userState) {
            if ((this.GetGroupDetailsByUserIdOperationCompleted == null)) {
                this.GetGroupDetailsByUserIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGroupDetailsByUserIdOperationCompleted);
            }
            this.InvokeAsync("GetGroupDetailsByUserId", new object[] {
                        UserId}, this.GetGroupDetailsByUserIdOperationCompleted, userState);
        }
        
        private void OnGetGroupDetailsByUserIdOperationCompleted(object arg) {
            if ((this.GetGroupDetailsByUserIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGroupDetailsByUserIdCompleted(this, new GetGroupDetailsByUserIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteGroupByUserId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteGroupByUserId(string UserId) {
            object[] results = this.Invoke("DeleteGroupByUserId", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteGroupByUserIdAsync(string UserId) {
            this.DeleteGroupByUserIdAsync(UserId, null);
        }
        
        /// <remarks/>
        public void DeleteGroupByUserIdAsync(string UserId, object userState) {
            if ((this.DeleteGroupByUserIdOperationCompleted == null)) {
                this.DeleteGroupByUserIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteGroupByUserIdOperationCompleted);
            }
            this.InvokeAsync("DeleteGroupByUserId", new object[] {
                        UserId}, this.DeleteGroupByUserIdOperationCompleted, userState);
        }
        
        private void OnDeleteGroupByUserIdOperationCompleted(object arg) {
            if ((this.DeleteGroupByUserIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteGroupByUserIdCompleted(this, new DeleteGroupByUserIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteGroupByName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteGroupByName(string UserId, string GroupName) {
            object[] results = this.Invoke("DeleteGroupByName", new object[] {
                        UserId,
                        GroupName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteGroupByNameAsync(string UserId, string GroupName) {
            this.DeleteGroupByNameAsync(UserId, GroupName, null);
        }
        
        /// <remarks/>
        public void DeleteGroupByNameAsync(string UserId, string GroupName, object userState) {
            if ((this.DeleteGroupByNameOperationCompleted == null)) {
                this.DeleteGroupByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteGroupByNameOperationCompleted);
            }
            this.InvokeAsync("DeleteGroupByName", new object[] {
                        UserId,
                        GroupName}, this.DeleteGroupByNameOperationCompleted, userState);
        }
        
        private void OnDeleteGroupByNameOperationCompleted(object arg) {
            if ((this.DeleteGroupByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteGroupByNameCompleted(this, new DeleteGroupByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteGroupById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteGroupById(string GroupId, string Userid) {
            object[] results = this.Invoke("DeleteGroupById", new object[] {
                        GroupId,
                        Userid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteGroupByIdAsync(string GroupId, string Userid) {
            this.DeleteGroupByIdAsync(GroupId, Userid, null);
        }
        
        /// <remarks/>
        public void DeleteGroupByIdAsync(string GroupId, string Userid, object userState) {
            if ((this.DeleteGroupByIdOperationCompleted == null)) {
                this.DeleteGroupByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteGroupByIdOperationCompleted);
            }
            this.InvokeAsync("DeleteGroupById", new object[] {
                        GroupId,
                        Userid}, this.DeleteGroupByIdOperationCompleted, userState);
        }
        
        private void OnDeleteGroupByIdOperationCompleted(object arg) {
            if ((this.DeleteGroupByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteGroupByIdCompleted(this, new DeleteGroupByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void AddGroupCompletedEventHandler(object sender, AddGroupCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddGroupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetGroupDetailsByGroupIdCompletedEventHandler(object sender, GetGroupDetailsByGroupIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGroupDetailsByGroupIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGroupDetailsByGroupIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetGroupDetailsByUserIdCompletedEventHandler(object sender, GetGroupDetailsByUserIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGroupDetailsByUserIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGroupDetailsByUserIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DeleteGroupByUserIdCompletedEventHandler(object sender, DeleteGroupByUserIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteGroupByUserIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteGroupByUserIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DeleteGroupByNameCompletedEventHandler(object sender, DeleteGroupByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteGroupByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteGroupByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DeleteGroupByIdCompletedEventHandler(object sender, DeleteGroupByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteGroupByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteGroupByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591