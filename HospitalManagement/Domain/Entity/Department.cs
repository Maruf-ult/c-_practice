using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Department:BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        
        public ICollection<Doctor> Doctors { get; set; }  = new List<Doctor>();
    }
}
