using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT_01_Assighment
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("1.Teacher\n2.Student\n3.Plumber\n4.Housekeeper");
            Console.WriteLine("Nhap so");
            n = Int32.Parse(Console.ReadLine());
            while (n <= 0 || n > 4)
            {
                Console.WriteLine("Nhap lai");
                n = Int32.Parse(Console.ReadLine());
            }

           
                

                if (n == 1)
                {

                    Teacher a = new Teacher();
                   
                    a.nhap();
                    a.PrintInfo();

                }
                else if (n == 2)
                {
                    Student a = new Student();
                    a.nhap();
                    a.PrintInfo();
                }
                else if (n == 3)
                {
                    Plumber a = new Plumber();
                    a.nhap();
                    a.PrintInfo();
                }
                else
                {
                    Housekeeper a = new Housekeeper();
                    a.nhap();
                    a.PrintInfo();
                }

                
            
            Console.ReadLine();

        }
    }
}
