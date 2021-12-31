using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.IO;
namespace ExceptionHandlingApp
{
    class DoctorFile
    {
        public void Doctordetails()
        {
            FileStream usingfilestreamobj = new FileStream("c:\\capgemini\\myfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(filestreamobj);
            sw.WriteLine("doctor details");
            Console.Write("Enter doctorname");
            String doctorname = Console.ReadLine();
            Console.Write("Enter doctor address");
            String address = Console.ReadLine();
            Console.Write("Enter doctor phone");
            int phone = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine("doctorname:" + doctorname);
            sw.WriteLine("doctorname:" + address);
            sw.WriteLine("doctorname:" + phone);
            sw.Close();
            filestreamobj.Close();
        }
        class program
        {
            public static void Main(String[] args)
            {
                DoctorFile doctorfileobj = new DoctorFile();
                doctorfileobj.Doctordetails();
                Console.ReadKey();
            }


        }
    }
}


  

