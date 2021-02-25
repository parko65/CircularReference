using CircularReference.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularReference.Api.DTOS
{
    public interface IDtoFactory
    {
        public CustomerDto Create(Customer customer);
        public HardwareDto Create(Hardware hardware);
        public SoftwareDto Create(Software software);
    }
}
