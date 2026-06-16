using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Address
    {
        public required string Area { get; set; }
        public required string City { get; set; }
        public required string PostalCode { get; set; }
        public string? ZipCode { get; set; }
    }
}
