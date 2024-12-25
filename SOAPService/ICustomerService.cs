using System.ServiceModel;

namespace SOAPService
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        string GetCustomerDetails(int customerId);
    }
}
