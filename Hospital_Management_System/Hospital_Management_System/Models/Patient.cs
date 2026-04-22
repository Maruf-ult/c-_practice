using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Models
{
    internal class Patient:Person
    {
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string MedicalHistoryNote { get; set; }

        public Patient(int id,string name, int age, string email,string phone,string gender,string bloodGroup,string medicalhistorynote) : base(id, name, age, email, phone)
        {
            Gender = gender;
            BloodGroup = bloodGroup;
            MedicalHistoryNote = medicalhistorynote;
        }

        public void ShowPatientInfo()
        {
            base.ShowBasicInfo();
            Console.WriteLine($"Gender: {Gender} \n BloodGroup: {BloodGroup} \n MedicalHistoryNote: {MedicalHistoryNote} ");
        }


    }
}
