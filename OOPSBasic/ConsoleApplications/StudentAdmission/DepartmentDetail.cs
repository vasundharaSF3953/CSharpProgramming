

namespace StudentAdmission
{
    public class DepartmentDetail
    {

       private static int s_departmentId=100;     //Field Creation

       public string DepartmentId { get; set; }   //Property Creation
       
        
       public string DepartmentName { get; set; }

       public int NumberOfSeats { get; set; }
       
       public DepartmentDetail(string departmentName,int numberOfSeats)
       {
          s_departmentId++;
          DepartmentId="DID"+s_departmentId;
          DepartmentName=departmentName;
          NumberOfSeats=numberOfSeats;
       }

       public DepartmentDetail(string data)
       {
          string[] values=data.Split(',');
          s_departmentId=int.Parse(values[0].Remove(0,3));
          DepartmentId=values[0];
          DepartmentName=values[1];
          NumberOfSeats=int.Parse(values[2]);

       }
       
        
    }
}