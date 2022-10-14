using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public class Vaccination
    {
        private static int s_vaccinateId=1000;  //Field Creation

        public string VaccinationId { get; set; }   //Property Creation

        public string  RegistrationNumber{ get; set; }

        public string VaccineId { get; set; }

        public int DoseNumber { get; set; }

        public DateTime VaccinateDate { get; set; }
        

        //Parameterized Constructor creation
        public Vaccination(string registrationNumber, string vaccineId, int doseNumber, DateTime vaccinatedDate)
        {
            s_vaccinateId++;
            VaccinationId="VID"+s_vaccinateId;
            RegistrationNumber=registrationNumber;
            VaccineId=vaccineId;
            VaccinateDate=vaccinatedDate;
        }
        
        
        
        
        
        
        
        
    }
}