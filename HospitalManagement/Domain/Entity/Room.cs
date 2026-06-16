using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Domain.Entity
{
    public class Room:BaseEntity
    {
        public string RoomName { get; set; } = null!;
        public int RoomNumber { get; set; }
        public Patient? Patient { get; set; }
    }
}
