using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени класса "Service" в коде, SVC-файле и файле конфигурации.
public class Service : IService
{
    public async Task<string> GetDataAsync()
    {
        var link = "http://www.mocky.io/v2/5c7db5e13100005a00375fda";
        HttpClient http = new HttpClient();
        HttpResponseMessage response = await http.GetAsync(link);
        return await response.Content.ReadAsStringAsync();
    }
}
