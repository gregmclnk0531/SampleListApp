using SampleListApp.Services;
using Newtonsoft.Json;
using System.Reflection;

namespace SampleListApp.Components;

public class LoadCustomerData
{
    public static List<Customer>? _customers = new List<Customer>();

    public static List<Customer>? Customers
    {
        get
        {
            _customers = InitializeMockCustomerData();
            return _customers;
        }
    }

    private static List<Customer> InitializeMockCustomerData()
    {

        List<Customer> customers = new List<Customer>();
        string rootPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "wwwroot");
        rootPath += "/Data/CustomerList.json";

        customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(rootPath));

        return customers;
    }
}
