namespace CircularReference.Shared.Models
{
    public class Hardware
    {
        public int HardwareId { get; set; }
        public int CustomerId { get; set; }
        public string HardwareName { get; set; }

        public Customer Customer { get; set; }
    }
}