using CircularReference.Api.EntityFramework;
using CircularReference.Shared.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _appDbContext.Customers
                .Include(c => c.Hardwares)
                .Include(c => c.Softwares)
                .ToListAsync();            
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers(int id)
        {
            return await _appDbContext.Customers.Where(c => c.Id == id)
                .Include(c => c.Hardwares)
                .Include(c => c.Softwares)
                .ToListAsync();
        }
    }
}
