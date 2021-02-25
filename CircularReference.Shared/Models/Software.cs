namespace CircularReference.Shared.Models
{
    public class Software
    {
        public int SoftwareId { get; set; }
        public int CustomerId { get; set; }
        public string SoftwareName { get; set; }

        public Customer Customer { get; set; }
    }
}