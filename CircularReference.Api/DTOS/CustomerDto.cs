using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularReference.Api.DTOS
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<HardwareDto> Hardware { get; set; }
        public IEnumerable<SoftwareDto> Software { get; set; }
    }
}
