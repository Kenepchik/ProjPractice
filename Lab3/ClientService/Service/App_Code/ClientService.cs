using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя класса "ClientService" в коде, системе контроля версий и файле конфигурации.
public class ClientService : IClientService
{
    LabTwoProjPracticeEntities context = new LabTwoProjPracticeEntities();
    public void Create(Client client)
    {
        context.Clients.Add(new Client() { name = client.name, age = client.age, country = client.country, Requests = client.Requests });
        context.SaveChanges();
    }

    public bool Delete(int id)
    {
        var client = context.Clients.Find(id);
        if (client != null)
        {
            context.Clients.Remove(client);
            context.SaveChanges();
            return true;
        }
        return false;
    }


    public string Find(int id)
    {
        var client = context.Clients.Find(id);

        return JsonConvert.SerializeObject(client);
    }

    public bool Update(Client client)
    {
        var existingclient = context.Clients.Find(client.id);

        if(existingclient != null)
        {
            existingclient.name = client.name;
            existingclient.age = client.age;
            existingclient.country = client.country;
            existingclient.Requests = client.Requests;
            return true;
        }
        return false;
    }
}
