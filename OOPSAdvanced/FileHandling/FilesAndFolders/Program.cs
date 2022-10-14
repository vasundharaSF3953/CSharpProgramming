using System;
using System.IO;
namespace FilesAndFolder;
class Program
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\VasundharaGnanasekar\OneDrive - Syncfusion\Desktop\MyFolder";

        string folderPath=path+"/Vasu";
        string filePath=path+"/newFile.txt";

        //Check whether the folder is present or not
        if(!Directory.Exists(folderPath))
        {
            Console.WriteLine("Folder not found. So creating folder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            Console.WriteLine("Directory Found");
        }

        //check whether the file is exist or not
        if(!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Creating File");
            File.Create(filePath);
        }
        else
        {
            Console.WriteLine("File Already exist");
        }

        Console.WriteLine("Select option 1.Create Folder 2.Create File 3.Delete Folder 4.Delete file");
         int option=int.Parse(Console.ReadLine());
         
        switch(option)
        {

            case 1:
            {
                Console.WriteLine("Enter the folder name you want to create:");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                if(!Directory.Exists(newPath))
                {
                    Console.WriteLine(newPath);
                }
                else
                {
                    Console.WriteLine("Directory name already exist");
                }
                break;
            }
            case 2:
            {

                Console.WriteLine("Enter file name you want to create");
                string fileName=Console.ReadLine();
                Console.WriteLine("Enter the file extension you want to create");
                string Extension=Console.ReadLine();
                string newPath=path+"\\"+fileName+"."+Extension;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else
                {
                    Console.WriteLine("File name already Exists");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path))
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Select the folder you want to delete");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)    //Check the folder name with the given folder name
                    {
                        try               //Handle the exception
                        {
                        Directory.Delete(newPath);
                        Console.WriteLine("Folder Deleted");
                        
                        }
                        catch(DirectoryNotFoundException e)     //If try block having any error catch block will be executed
                        {
                           Console.WriteLine("Directory not found",e.Message);
                        }
                    }
                }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))     //Get all the 
                {

                    Console.WriteLine(name);
                }
                Console.WriteLine("Select the file you want to delete");
                string name1=Console.ReadLine();
                Console.WriteLine("Enter the file extension you want to delete");
                string name2=Console.ReadLine();
                string newPath=path+"\\"+name1+"."+name2;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name==newPath)
                    {
                        File.Delete(newPath);
                        Console.WriteLine("File Deleted");
                    }
                }
                break;
            }
            
        }
    }
}