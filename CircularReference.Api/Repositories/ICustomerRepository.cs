using CircularReference.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularReference.Api.Repositories
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetAllCustomers();
        IQueryable<Customer> GetAllCustomers(int id);
    }
}
