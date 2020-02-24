using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT_01_Assighment
{
    class Plumber: Person
    {
        public string EmployeeId;
        public string CompanyName;

        override
       public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Date Of Birth:" + dateOfBirth);
            Console.WriteLine("ID:" + EmployeeId);
            Console.WriteLine("Address:" + Address);
            Console.WriteLine("CompanyName:" + CompanyName);
        }

        override
        public void nhap()
        {

            int d, m, y;
            Console.WriteLine("nhap Name Employee");
            name = Console.ReadLine();
            Console.WriteLine("nhap ngay/thang/nam");
            d = Int32.Parse(Console.ReadLine());

            m = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            dateOfBirth = new DateTime(y, m, d);
            Console.WriteLine("Nhap EmployeeId");
            EmployeeId = Console.ReadLine();
            Console.WriteLine("Nhap Address");
            Address = Console.ReadLine();

            Console.WriteLine("nhap CompanyName");
            CompanyName = Console.ReadLine();
        }
    }
}
