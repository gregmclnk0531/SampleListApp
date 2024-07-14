using Microsoft.AspNetCore.Components;
using SampleListApp.Services;

namespace SampleListApp.Components.Pages;

public partial class CustomerDetail
{
    [Parameter]
    public string CustomerId { get; set;}

    public Customer Customer { get; set;} = new Customer();
    public string ReturnId { get; set;} = string.Empty;

    protected override void OnInitialized()
    {
        Customer = LoadCustomerData.Customers.Single(e => e.CustomerId == CustomerId);
        ReturnId = Customer.CustomerId;
    }
}
