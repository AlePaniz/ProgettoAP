﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgettoAP.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IDBService")]
    public interface IDBService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/Connessione", ReplyAction="http://tempuri.org/IDBService/ConnessioneResponse")]
        void Connessione();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/Connessione", ReplyAction="http://tempuri.org/IDBService/ConnessioneResponse")]
        System.Threading.Tasks.Task ConnessioneAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/Login", ReplyAction="http://tempuri.org/IDBService/LoginResponse")]
        bool Login(string user, string psw, bool organizzatore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/Login", ReplyAction="http://tempuri.org/IDBService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string user, string psw, bool organizzatore);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBServiceChannel : ProgettoAP.ServiceReference.IDBService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBServiceClient : System.ServiceModel.ClientBase<ProgettoAP.ServiceReference.IDBService>, ProgettoAP.ServiceReference.IDBService {
        
        public DBServiceClient() {
        }
        
        public DBServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Connessione() {
            base.Channel.Connessione();
        }
        
        public System.Threading.Tasks.Task ConnessioneAsync() {
            return base.Channel.ConnessioneAsync();
        }
        
        public bool Login(string user, string psw, bool organizzatore) {
            return base.Channel.Login(user, psw, organizzatore);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string user, string psw, bool organizzatore) {
            return base.Channel.LoginAsync(user, psw, organizzatore);
        }
    }
}