using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IClientService" в коде и файле конфигурации.
[ServiceContract]
public interface IService
{
    //Client
    [OperationContract]
    string ClientFind(int id);

    [OperationContract]
    void ClientCreate(Client client);

    [OperationContract]
    bool ClientUpdate(Client client);

    [OperationContract]
    bool ClientDelete(int id);


    //Service
    [OperationContract]
    string ServiceFind(int id);

    [OperationContract]
    void ServiceCreate(Service service);

    [OperationContract]
    bool ServiceUpdate(Service service);

    [OperationContract]
    bool ServiceDelete(int id);


    //Request
    [OperationContract]
    string RequestFind(int id);

    [OperationContract]
    void RequestCreate(Request request);

    [OperationContract]
    bool RequestUpdate(Request request);

    [OperationContract]
    bool RequestDelete(int id);
}
