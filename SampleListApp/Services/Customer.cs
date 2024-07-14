namespace SampleListApp.Services;

public class Customer
{
    public string CustomerId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set;} = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string CreditScore { get; set; } = string.Empty;

    public Customer () {}

    public Customer (string customerId, string firstName, string lastName, string phoneNumber, string creditScore)
    {
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        CreditScore = creditScore;
    }
}
