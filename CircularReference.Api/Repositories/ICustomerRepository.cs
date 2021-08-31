using CircularReference.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace CircularReference.Api.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        IEnumerable<Customer> GetAllCustomers(int id);
    }
}
