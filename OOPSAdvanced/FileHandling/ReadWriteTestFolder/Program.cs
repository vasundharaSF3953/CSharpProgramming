using System;
using System.IO;
namespace ReadWriteTestFile;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))    //Folder Creation
        {
            Directory.CreateDirectory("TestFolder");
            Console.WriteLine("Folder created");
        }
        else
        {
            Console.WriteLine("Folder Exists");
        }

        if(!File.Exists("TestFolder/Test.txt"))    //File Creation
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File Created");
        }
        else
        {
            System.Console.WriteLine("File Found");
        }

         Console.WriteLine("Select the option 1.Read File 2.Write File");
         int Option=int.Parse(Console.ReadLine());

         switch(Option)
         {
            case 1:
            {
                string line;
                StreamReader sr=null;
                try
                {
                    sr=new StreamReader("TestFolder/Test.txt");
                    line=sr.ReadLine();
                    while(line!=null)
                    {
                        Console.WriteLine(line);
                        line=sr.ReadLine();
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception:"+e.Message);
                }
                finally
                {
                    if(sr!=null)
                    {
                        Console.WriteLine("Executing finally block");
                        sr.Close();
                    }
                }
                break;
            }

            case 2:
            {
                StreamWriter sw=null;
                try
                {
                string[] old=File.ReadAllLines("TestFolder/Test.txt");
                sw =new StreamWriter("TestFolder/Test.txt");
                Console.WriteLine("Enter new content to be placed in file");
                string info=Console.ReadLine();
                string old1="";
                foreach(string text in old)
                {
                    old1=old1+"\n"+text;
                }
                
                old1=old1+"\n"+info;
                sw.WriteLine(old1);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception:"+e.Message);
                }
                finally
                {
                   if(sw!=null)
                   {
                    sw.Close();
                   }
                }

                break;
            }
         }
         
    }
}

