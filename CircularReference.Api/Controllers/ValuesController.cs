using CircularReference.Api.DTOS;
using CircularReference.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularReference.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IDtoFactory _dtoFactory;        

        public ValuesController(ICustomerRepository customerRepository, IDtoFactory dtoFactory)
        {
            _customerRepository = customerRepository;
            _dtoFactory = dtoFactory;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> Get()
        {
            //var result = await _customerRepository.GetAllCustomers();
            //return result.Select(c => _dtoFactory.Create(c));
            return (await _customerRepository.GetAllCustomers()).Select(c => _dtoFactory.Create(c));
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<CustomerDto>> GetById(int id)
        {
            return (await _customerRepository.GetAllCustomers(id)).Select(c => _dtoFactory.Create(c));
        }
    }
}