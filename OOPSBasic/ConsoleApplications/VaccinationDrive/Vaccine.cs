using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public enum VaccineName{Covishekd, Covaccine}
    public class Vaccine
    {
       private static int s_vaccineId=100;  //Field Creation

       public string VaccineId { get; set; }  //Property Creation

       public VaccineName VaccineName { get; set; }

       public int NoOfDoseAvailable { get; set; }


      //Paratemeterized constructor creation
       public Vaccine(VaccineName vaccineName,int noOfDoseAvailable)
       {
        s_vaccineId++;
        VaccineId="CID"+s_vaccineId;
        VaccineName=vaccineName;
        NoOfDoseAvailable=noOfDoseAvailable;
       }
       
       
       
       
       
       

    }
}