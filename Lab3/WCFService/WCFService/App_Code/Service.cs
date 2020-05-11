using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя класса "ClientService" в коде, системе контроля версий и файле конфигурации.
public partial class Service : IService
{
    LabTwoProjPracticeEntities context = new LabTwoProjPracticeEntities();

    //Client
    public string ClientFind(int id)
    {
        return JsonConvert.SerializeObject(context.Clients.Find(id), Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize
        });
    }

    public void ClientCreate(Client client)
    {
        context.Clients.Add(new Client() { name = client.name, age = client.age, country = client.country, Requests = client.Requests });
        context.SaveChanges();
    }

    public bool ClientUpdate(Client client)
    {
        var exClient = context.Clients.Find(client.id);

        if (exClient != null)
        {
            exClient.name = client.name;
            exClient.age = client.age;
            exClient.country = client.country;
            exClient.Requests = client.Requests;
            return true;
        }
        return false;
    }

    public bool ClientDelete(int id)
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



    //Service
    public string ServiceFind(int id)
    {
        return JsonConvert.SerializeObject(context.Services.Find(id), Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize
        });
    }

    public void ServiceCreate(Service service)
    {
        context.Services.Add(new Service() { name = service.name, complexity = service.complexity, Requests = service.Requests });
        context.SaveChanges();
    }

    public bool ServiceUpdate(Service service)
    {
        var exService = context.Services.Find(service.id);

        if (exService != null)
        {
            exService.name = service.name;
            exService.complexity = service.complexity;
            exService.Requests = service.Requests;
            return true;
        }
        return false;
    }

    public bool ServiceDelete(int id)
    {
        var service = context.Services.Find(id);
        if (service != null)
        {
            context.Services.Remove(service);
            context.SaveChanges();
            return true;
        }
        return false;
    }



    //Request
    public string RequestFind(int id)
    {
        return JsonConvert.SerializeObject(context.Requests.Find(id), Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize
        });
    }

    public void RequestCreate(Request request)
    {
        context.Requests.Add(new Request() { client_id = request.client_id, Services = request.Services});
        context.SaveChanges();
    }

    public bool RequestUpdate(Request request)
    {
        var exRequest = context.Requests.Find(request.id);

        if (exRequest != null)
        {
            exRequest.client_id = request.client_id;
            exRequest.Services = request.Services;
            return true;
        }
        return false;
    }

    public bool RequestDelete(int id)
    {
        var request = context.Requests.Find(id);
        if (request != null)
        {
            context.Requests.Remove(request);
            context.SaveChanges();
            return true;
        }
        return false;
    }
}
