using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IClientService" в коде и файле конфигурации.
[ServiceContract]
public interface IClientService
{
    [OperationContract]
    string Find(int id);

    [OperationContract]
    void Create(Client client);

    [OperationContract]
    bool Update(Client client);

    [OperationContract]
    bool Delete(int id);

}
