using HospitalManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Nurse:BaseEntity
    {
        public required string Name { get; set; }
        public required Genders Gender { get; set; }
        public required int Age { get; set; }
        public required string Speacializaqtion { get; set; }
        public required int Experience { get; set; }

    }
}
