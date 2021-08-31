using CircularReference.Api.EntityFramework;
using CircularReference.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CircularReference.Api.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _appDbContext.Customers
                .Include(c => c.Hardwares)
                .Include(c => c.Softwares);
        }

        public IEnumerable<Customer> GetAllCustomers(int id)
        {
            return _appDbContext.Customers.Where(c => c.Id == id)
                .Include(c => c.Hardwares)
                .Include(c => c.Softwares);
        }
    }
}
