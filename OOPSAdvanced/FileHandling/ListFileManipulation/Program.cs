using System;
using System.Collections.Generic;
using System.IO;

namespace ListFileManipulation;

class Program
{
    public static void Main(string[] args)
    {
        List<StudentDetails> vlist=new List<StudentDetails>();
        vlist.Add(new StudentDetails(){Name="Vasu",FatherName="Ganam",Gender=Gender.Female,DOB=new DateTime(2001,02,11)});
        vlist.Add(new StudentDetails(){Name="Vino",FatherName="Sekaran",Gender=Gender.Female,DOB=new DateTime(2001,07,1)});
        vlist.Add(new StudentDetails(){Name="Indhu",FatherName="Mari",Gender=Gender.Female,DOB=new DateTime(2001,12,10)});
        Insert(vlist);
        Display();
    }

    static void Insert(List<StudentDetails> vlist)
    {
        StreamWriter write=null;
        if(!File.Exists("Data.csv"))
        {
            Console.WriteLine("File dosen't exit. Creating a new CSV file");
            File.Create("Data.csv");
        }
        else
        {
            Console.WriteLine("File Found");
        }
        write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(var data in vlist)
        {
            write.WriteLine(data.Name+","+data.FatherName+","+data.Gender+","+data.DOB.ToString("dd/MM/yyyy"));
        }
        write.Close();
    }

    static void Display()
    {
        StreamReader reader=null;
        List<StudentDetails> listA=new List<StudentDetails>();
        if(File.Exists("Data.csv"))
        {
            reader=new StreamReader(File.OpenRead("Data.csv"));
            while(!reader.EndOfStream)
            {
                var line=reader.ReadLine();
                var values=line.Split(',');
                if(values[0]!="")
                {
                    listA.Add(new StudentDetails(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                }
            }
        }
        else
        {
           Console.WriteLine("File dosen't exist");
        }
        reader.Close();
        foreach(var column1 in listA)
        {
            Console.WriteLine("Your Name:"+column1.Name+"\t Father Name:"+column1.FatherName+"\t Gender is:"+column1.Gender+"\t DateOfBirth:"+column1.DOB.ToString("dd/MM/yyyy"));
        }

        
        
    }
}