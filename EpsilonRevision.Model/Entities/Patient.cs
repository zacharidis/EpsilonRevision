using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpsilonRevision.Model.Entities
{
    public class Patient
    {

        public int Id { get; set; }// patients primary key
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<HospitalAdmission> hospitalAdmissions { get; set; } //List<HospitalAdmission>

        public  List<Consultation>  consultations { get; set; }



         public Patient(int id, string name, string surname, string address, string phoneNumber, string email)
        {
            
            Name = name;
            Surname = surname;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;

            List<HospitalAdmission> = new  List<HospitalAdmission>();
            List<Consultation> = new List<Consultation>();


        }
  

            
 
       

    }
}
