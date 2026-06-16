using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Application.DTOs.Common
{
    public class AddressDto
    {
        public string Area { get; set; } = null!;

        public string City { get; set; } = null!;

        public string PostalCode { get; set; } = null!;
    }
}
