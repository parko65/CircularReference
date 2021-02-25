using CircularReference.Shared.Models;

namespace CircularReference.Api.DTOS
{
    public interface IDtoFactory
    {
        public CustomerDto Create(Customer customer);
        public HardwareDto Create(Hardware hardware);
        public SoftwareDto Create(Software software);
    }
}
