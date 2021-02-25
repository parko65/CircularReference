using CircularReference.Api.DTOS;
using CircularReference.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
        public IEnumerable<CustomerDto> Get()
        {
            return _customerRepository.GetAllCustomers().ToList().Select(c => _dtoFactory.Create(c));
        }

        [HttpGet("{id:int}")]
        public IEnumerable<CustomerDto> GetById(int id)
        {
            return _customerRepository.GetAllCustomers(id).ToList().Select(c => _dtoFactory.Create(c));
        }
    }
}
