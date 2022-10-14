using System;


namespace StudentAdmission
{
    public enum AdmissionStatus{Admitted, Cancelled,Booked}
    public class AdmissionDetail
    {
        private static int s_admissionId=1000;  //Field Creation

      

        public string AdmissionId { get; set; }  //Property Creation
        
        public string StudentId { get; set; }

        public string DepartmentId { get; set; }

        public DateTime AdmissionDate { get; set; }
        
        public AdmissionStatus AdmissionStatus { get; set; }


        public AdmissionDetail(string studentId,string departmentId,DateTime admissionDate, AdmissionStatus admissionStatus)
        {
            s_admissionId++;
            AdmissionId="AID"+s_admissionId;
            StudentId=studentId;
            DepartmentId=departmentId;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;

        }
        

        public AdmissionDetail(string data)
        {
            string[] values=data.Split(',');
            s_admissionId=int.Parse(values[0].Remove(0,3));
            AdmissionId=values[0];
            StudentId=values[1];
            DepartmentId=values[2];
            AdmissionDate=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            AdmissionStatus=Enum.Parse<AdmissionStatus>(values[4]);
        }
       

        public void ShowAdmissionDetails()      
       {
           Console.WriteLine("Your Basic Details are:");
           Console.WriteLine($"Admission ID: {AdmissionId} \nStudent ID: {StudentId} \nDepartment ID: {DepartmentId} \nAdmission Date: {AdmissionDate.ToString("dd/MM/yyyy")} \nAdmission Status: {AdmissionStatus} ");
       }

       
        
        
        
    }
}