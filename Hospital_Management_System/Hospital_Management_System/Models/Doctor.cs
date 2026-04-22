using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Hospital_Management_System.Models
{
    

    internal class Doctor:Person
    {
        public string Speacalization { get; private set; }
        public decimal ConsultationFee { get; private set; }

        public Doctor(int id, string name,int age, string email, string phone,string speacalization,decimal consultationfee):base(id,name,age,email,phone)
        {

            Speacalization = speacalization;
            ConsultationFee = consultationfee;

        }

        public void ShowDoctorInfo()
        {
            base.ShowBasicInfo();
            Console.WriteLine($"Gender: {Speacalization} \n BloodGroup: {ConsultationFee} ");
        }



    }
}
