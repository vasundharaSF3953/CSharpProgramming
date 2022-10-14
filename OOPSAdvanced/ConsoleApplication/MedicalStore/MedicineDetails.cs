using System;


namespace MedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineId=100;

        public string MedicineId { get; set; }

        public string MedicineName { get; set; }
        
        public int AvailableCount{ get; set; }
        
        public int Price{ get; set; }
        
        public DateTime DateOfExpiry { get; set; }
        
        public MedicineDetails(string medicineId, string medicineName,int count, int price, DateTime dateOfExpiry)
        {
            s_medicineId++;
            MedicineId="MD"+s_medicineId;
            MedicineName=medicineName;
            AvailableCount=count;
            Price= price;
            DateOfExpiry=dateOfExpiry;
        }

        public MedicineDetails(string data)
        {
            string[] values=data.Split(',');
            s_medicineId=int.Parse(values[0].Remove(0,2));
            MedicineId=values[0];
            MedicineName=values[1];
            AvailableCount=int.Parse(values[2]);
            Price= int.Parse(values[0]);
            DateOfExpiry=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
        }

        public void ShowMedicineDetails()
        {
             Console.WriteLine("MedicineId: "+MedicineId+"\n"+"MedicineName: "+MedicineName+"\n"+"AvailableCount: "+AvailableCount+"\n"+"Price: "+Price+"\n"+"DateOfExpiry: "+DateOfExpiry);
        }


    }
}