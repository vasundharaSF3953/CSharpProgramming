using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData
{
    public static class StudentInfo   //static Class
    {
        public static int RegisterNumber; //static Field
        public static string Name { get; set; }  //static Property

        static StudentInfo()    //static Constructor
        {
            RegisterNumber=3953;
            Name="Vasundhara";
        }

        public static void Display()  
        {
            Console.WriteLine("Register Number: "+RegisterNumber);
            Console.WriteLine("Name: "+Name);
        }
        
        
        
        
        
    }
}