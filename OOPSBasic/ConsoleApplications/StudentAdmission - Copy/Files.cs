using System;

using System.IO;

namespace StudentAdmission
{
    public class Files
    {
        
        public static void Create()
        {
            if(!Directory.Exists("College"))     //Folder Creation
            {
                 System.Console.WriteLine("Creating Folder");
                 Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))   //File Creation for student details
            {
                Console.WriteLine("Cerating file");
                File.Create("College/StudentDetails.csv");
            }
             if(!File.Exists("College/AdmissionDetail.csv"))  //File creation for Admission details
            {
                Console.WriteLine("Cerating file");
                File.Create("College/AdmissionDetail.csv");
            }
              if(!File.Exists("College/DepartmentDetail.csv"))   //Files created for DepartmentDetails
            {
                Console.WriteLine("Cerating file");
                File.Create("College/DepartmentDetail.csv");
            }
            

        }


        public static void ReadFile()
        {
            string[] students=File.ReadAllLines("College/StudentDetails.csv");
            foreach(string data in students)
            {
                StudentDetails student=new StudentDetails(data);
                Operations.StudentDetailList.Add(student);
            }


             string[] department1=File.ReadAllLines("College/DepartmentDetail.csv");
             foreach(string data1 in department1)
             {
                DepartmentDetail department2=new DepartmentDetail(data1);
                Operations.DepartmentDetailList.Add(department2);
             }

             string[] admission1=File.ReadAllLines("College/AdmissionDetail.csv");
             foreach(string data2 in admission1)
             {
                AdmissionDetail admission2=new AdmissionDetail(data2);
                Operations.AdmissionDetailList.Add(admission2);
             }
           
        }

        public static void WriteToFiles()
        {
            string[] student=new string[Operations.StudentDetailList.Count];
            for(int i=0; i<Operations.StudentDetailList.Count;i++)
            {
                student[i]=Operations.StudentDetailList[i].StudentId+","+Operations.StudentDetailList[i].StudentName+","+Operations.StudentDetailList[i].FatherName+","+Operations.StudentDetailList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.StudentDetailList[i].Gender+","+Operations.StudentDetailList[i].Physics+","+Operations.StudentDetailList[i].Chemistry+","+Operations.StudentDetailList[i].Maths;
            }
            File.WriteAllLines("College/StudentDetails.csv",student);


            string[] admission1=new string[Operations.AdmissionDetailList.Count];
            for(int i=0; i<Operations.AdmissionDetailList.Count; i++)
            {
                admission1[i]=Operations.AdmissionDetailList[i].AdmissionId+","+Operations.AdmissionDetailList[i].StudentId+","+Operations.AdmissionDetailList[i].DepartmentId+","+Operations.AdmissionDetailList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operations.AdmissionDetailList[i].AdmissionStatus;
            }
            File.WriteAllLines("College/AdmissionDetail.csv",admission1);


            string[] department1=new string[Operations.DepartmentDetailList.Count];
            for(int i=0; i<Operations.DepartmentDetailList.Count; i++)
            {
                department1[i]=Operations.DepartmentDetailList[i].DepartmentId+","+Operations.DepartmentDetailList[i].DepartmentName+","+Operations.DepartmentDetailList[i].NumberOfSeats;
            }
            File.WriteAllLines("College/DepartmentDetail.csv",department1);
        }
    }
}