﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CSCAssignment2Client.emailservice {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EmailWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class EmailWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getTenRecentImagesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getImagesByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback addImageOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendActivationEmailOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidateActivationOperationCompleted;
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public EmailWebService() {
            this.Url = global::CSCAssignment2Client.Properties.Settings.Default.CSCAssignment2Client_emailservice_EmailWebService;
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
        public event getTenRecentImagesCompletedEventHandler getTenRecentImagesCompleted;
        
        /// <remarks/>
        public event getImagesByIDCompletedEventHandler getImagesByIDCompleted;
        
        /// <remarks/>
        public event addImageCompletedEventHandler addImageCompleted;
        
        /// <remarks/>
        public event SendActivationEmailCompletedEventHandler SendActivationEmailCompleted;
        
        /// <remarks/>
        public event ValidateActivationCompletedEventHandler ValidateActivationCompleted;
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getTenRecentImages", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getTenRecentImages() {
            object[] results = this.Invoke("getTenRecentImages", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getTenRecentImagesAsync() {
            this.getTenRecentImagesAsync(null);
        }
        
        /// <remarks/>
        public void getTenRecentImagesAsync(object userState) {
            if ((this.getTenRecentImagesOperationCompleted == null)) {
                this.getTenRecentImagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTenRecentImagesOperationCompleted);
            }
            this.InvokeAsync("getTenRecentImages", new object[0], this.getTenRecentImagesOperationCompleted, userState);
        }
        
        private void OngetTenRecentImagesOperationCompleted(object arg) {
            if ((this.getTenRecentImagesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTenRecentImagesCompleted(this, new getTenRecentImagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getImagesByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getImagesByID(int userid) {
            object[] results = this.Invoke("getImagesByID", new object[] {
                        userid});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getImagesByIDAsync(int userid) {
            this.getImagesByIDAsync(userid, null);
        }
        
        /// <remarks/>
        public void getImagesByIDAsync(int userid, object userState) {
            if ((this.getImagesByIDOperationCompleted == null)) {
                this.getImagesByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetImagesByIDOperationCompleted);
            }
            this.InvokeAsync("getImagesByID", new object[] {
                        userid}, this.getImagesByIDOperationCompleted, userState);
        }
        
        private void OngetImagesByIDOperationCompleted(object arg) {
            if ((this.getImagesByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getImagesByIDCompleted(this, new getImagesByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addImage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int addImage(string inUploadedBy, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] inImageData) {
            object[] results = this.Invoke("addImage", new object[] {
                        inUploadedBy,
                        inImageData});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void addImageAsync(string inUploadedBy, byte[] inImageData) {
            this.addImageAsync(inUploadedBy, inImageData, null);
        }
        
        /// <remarks/>
        public void addImageAsync(string inUploadedBy, byte[] inImageData, object userState) {
            if ((this.addImageOperationCompleted == null)) {
                this.addImageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddImageOperationCompleted);
            }
            this.InvokeAsync("addImage", new object[] {
                        inUploadedBy,
                        inImageData}, this.addImageOperationCompleted, userState);
        }
        
        private void OnaddImageOperationCompleted(object arg) {
            if ((this.addImageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addImageCompleted(this, new addImageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendActivationEmail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SendActivationEmail(int userID, string txtEmail, string txtUsername) {
            this.Invoke("SendActivationEmail", new object[] {
                        userID,
                        txtEmail,
                        txtUsername});
        }
        
        /// <remarks/>
        public void SendActivationEmailAsync(int userID, string txtEmail, string txtUsername) {
            this.SendActivationEmailAsync(userID, txtEmail, txtUsername, null);
        }
        
        /// <remarks/>
        public void SendActivationEmailAsync(int userID, string txtEmail, string txtUsername, object userState) {
            if ((this.SendActivationEmailOperationCompleted == null)) {
                this.SendActivationEmailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendActivationEmailOperationCompleted);
            }
            this.InvokeAsync("SendActivationEmail", new object[] {
                        userID,
                        txtEmail,
                        txtUsername}, this.SendActivationEmailOperationCompleted, userState);
        }
        
        private void OnSendActivationEmailOperationCompleted(object arg) {
            if ((this.SendActivationEmailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendActivationEmailCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ValidateActivation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ValidateActivation(string validationCode) {
            object[] results = this.Invoke("ValidateActivation", new object[] {
                        validationCode});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ValidateActivationAsync(string validationCode) {
            this.ValidateActivationAsync(validationCode, null);
        }
        
        /// <remarks/>
        public void ValidateActivationAsync(string validationCode, object userState) {
            if ((this.ValidateActivationOperationCompleted == null)) {
                this.ValidateActivationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidateActivationOperationCompleted);
            }
            this.InvokeAsync("ValidateActivation", new object[] {
                        validationCode}, this.ValidateActivationOperationCompleted, userState);
        }
        
        private void OnValidateActivationOperationCompleted(object arg) {
            if ((this.ValidateActivationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidateActivationCompleted(this, new ValidateActivationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void getTenRecentImagesCompletedEventHandler(object sender, getTenRecentImagesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTenRecentImagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTenRecentImagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void getImagesByIDCompletedEventHandler(object sender, getImagesByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getImagesByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getImagesByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void addImageCompletedEventHandler(object sender, addImageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addImageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addImageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void SendActivationEmailCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void ValidateActivationCompletedEventHandler(object sender, ValidateActivationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidateActivationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidateActivationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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