using CircularReference.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularReference.Api.DTOS
{
    public class DtoFactory : IDtoFactory
    {        
        public CustomerDto Create(Customer customer)
        {
            return new CustomerDto()
            {
                Id = customer.Id,
                Name = customer.Name,
                Hardware = customer.Hardwares.Select(h => Create(h)),
                Software = customer.Softwares.Select(s => Create(s))
            };
        }

        public HardwareDto Create(Hardware hardware)
        {
            return new HardwareDto()
            {
                HardwareId = hardware.HardwareId,
                HardwareName = hardware.HardwareName
            };
        }

        public SoftwareDto Create(Software software)
        {
            return new SoftwareDto()
            {
                SoftwareId = software.SoftwareId,
                SoftwareName = software.SoftwareName
            };
        }
    }
}
