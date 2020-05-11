﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AllServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class Client : object
    {
        
        private int ageField;
        
        private string countryField;
        
        private int idField;
        
        private string nameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Service", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class Service : object
    {
        
        private string complexityField;
        
        private int idField;
        
        private string nameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string complexity
        {
            get
            {
                return this.complexityField;
            }
            set
            {
                this.complexityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Request", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class Request : object
    {
        
        private AllServiceReference.Client ClientField;
        
        private int client_idField;
        
        private int idField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AllServiceReference.Client Client
        {
            get
            {
                return this.ClientField;
            }
            set
            {
                this.ClientField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int client_id
        {
            get
            {
                return this.client_idField;
            }
            set
            {
                this.client_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AllServiceReference.IService")]
    public interface IService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ClientFind", ReplyAction="http://tempuri.org/IService/ClientFindResponse")]
        System.Threading.Tasks.Task<string> ClientFindAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ClientCreate", ReplyAction="http://tempuri.org/IService/ClientCreateResponse")]
        System.Threading.Tasks.Task ClientCreateAsync(AllServiceReference.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ClientUpdate", ReplyAction="http://tempuri.org/IService/ClientUpdateResponse")]
        System.Threading.Tasks.Task<bool> ClientUpdateAsync(AllServiceReference.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ClientDelete", ReplyAction="http://tempuri.org/IService/ClientDeleteResponse")]
        System.Threading.Tasks.Task<bool> ClientDeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ServiceFind", ReplyAction="http://tempuri.org/IService/ServiceFindResponse")]
        System.Threading.Tasks.Task<string> ServiceFindAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ServiceCreate", ReplyAction="http://tempuri.org/IService/ServiceCreateResponse")]
        System.Threading.Tasks.Task ServiceCreateAsync(AllServiceReference.Service service);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ServiceUpdate", ReplyAction="http://tempuri.org/IService/ServiceUpdateResponse")]
        System.Threading.Tasks.Task<bool> ServiceUpdateAsync(AllServiceReference.Service service);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ServiceDelete", ReplyAction="http://tempuri.org/IService/ServiceDeleteResponse")]
        System.Threading.Tasks.Task<bool> ServiceDeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RequestFind", ReplyAction="http://tempuri.org/IService/RequestFindResponse")]
        System.Threading.Tasks.Task<string> RequestFindAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RequestCreate", ReplyAction="http://tempuri.org/IService/RequestCreateResponse")]
        System.Threading.Tasks.Task RequestCreateAsync(AllServiceReference.Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RequestUpdate", ReplyAction="http://tempuri.org/IService/RequestUpdateResponse")]
        System.Threading.Tasks.Task<bool> RequestUpdateAsync(AllServiceReference.Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RequestDelete", ReplyAction="http://tempuri.org/IService/RequestDeleteResponse")]
        System.Threading.Tasks.Task<bool> RequestDeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IServiceChannel : AllServiceReference.IService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<AllServiceReference.IService>, AllServiceReference.IService
    {
        
        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceClient() : 
                base(ServiceClient.GetDefaultBinding(), ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> ClientFindAsync(int id)
        {
            return base.Channel.ClientFindAsync(id);
        }
        
        public System.Threading.Tasks.Task ClientCreateAsync(AllServiceReference.Client client)
        {
            return base.Channel.ClientCreateAsync(client);
        }
        
        public System.Threading.Tasks.Task<bool> ClientUpdateAsync(AllServiceReference.Client client)
        {
            return base.Channel.ClientUpdateAsync(client);
        }
        
        public System.Threading.Tasks.Task<bool> ClientDeleteAsync(int id)
        {
            return base.Channel.ClientDeleteAsync(id);
        }
        
        public System.Threading.Tasks.Task<string> ServiceFindAsync(int id)
        {
            return base.Channel.ServiceFindAsync(id);
        }
        
        public System.Threading.Tasks.Task ServiceCreateAsync(AllServiceReference.Service service)
        {
            return base.Channel.ServiceCreateAsync(service);
        }
        
        public System.Threading.Tasks.Task<bool> ServiceUpdateAsync(AllServiceReference.Service service)
        {
            return base.Channel.ServiceUpdateAsync(service);
        }
        
        public System.Threading.Tasks.Task<bool> ServiceDeleteAsync(int id)
        {
            return base.Channel.ServiceDeleteAsync(id);
        }
        
        public System.Threading.Tasks.Task<string> RequestFindAsync(int id)
        {
            return base.Channel.RequestFindAsync(id);
        }
        
        public System.Threading.Tasks.Task RequestCreateAsync(AllServiceReference.Request request)
        {
            return base.Channel.RequestCreateAsync(request);
        }
        
        public System.Threading.Tasks.Task<bool> RequestUpdateAsync(AllServiceReference.Request request)
        {
            return base.Channel.RequestUpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<bool> RequestDeleteAsync(int id)
        {
            return base.Channel.RequestDeleteAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:28830/Service.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService,
        }
    }
}
