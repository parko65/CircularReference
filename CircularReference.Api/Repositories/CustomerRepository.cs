using CircularReference.Api.EntityFramework;
using CircularReference.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularReference.Api.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IQueryable<Customer> GetAllCustomers()
        {
            return _appDbContext.Customers.Include(c => c.Hardwares).Include(c => c.Softwares);
        }

        public IQueryable<Customer> GetAllCustomers(int id)
        {
            return _appDbContext.Customers.Where(c => c.Id == id).Include(c => c.Hardwares).Include(c => c.Softwares);
        }
    }
}
