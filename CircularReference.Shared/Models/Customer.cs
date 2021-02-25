using System.Collections.Generic;

namespace CircularReference.Shared.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public Customer()
        //{
        //    this.Hardwares = new HashSet<Hardware>();
        //    this.Softwares = new HashSet<Software>();
        //}

        public virtual ICollection<Hardware> Hardwares { get; set; }
        public virtual ICollection<Software> Softwares { get; set; }
    }
}
