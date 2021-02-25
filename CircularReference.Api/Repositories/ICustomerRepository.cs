using CircularReference.Shared.Models;
using System.Linq;

namespace CircularReference.Api.Repositories
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetAllCustomers();
        IQueryable<Customer> GetAllCustomers(int id);
    }
}
