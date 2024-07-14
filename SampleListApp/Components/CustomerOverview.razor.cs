using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using SampleListApp.Services;

namespace SampleListApp.Components;

public partial class CustomerOverview
{
    [Parameter]
    public string ReturnId { get; set;}
    public List<Customer> Customers { get; set; } = new List<Customer>();

    protected async override Task OnInitializedAsync()
    {
        Customers = LoadCustomerData.Customers;

    }

    private async Task ScrollToElement()
    {
        await JS.InvokeVoidAsync("scrollToElementById", ReturnId);
    }
}
