﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT_01_Assighment
{
    class Student: Person
    {
        public string StudentID;
        public string SchoolName;

        override
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Date Of Birth:" + dateOfBirth);
            Console.WriteLine("ID:" + StudentID);
            Console.WriteLine("Address:" + Address);
            Console.WriteLine("SchoolName:" + SchoolName);
        }

        override
        public void nhap()
        {

            int d, m, y;
            Console.WriteLine("nhap Name Student");
            name = Console.ReadLine();
            Console.WriteLine("nhap ngay/thang/nam sinh");
            d = Int32.Parse(Console.ReadLine());

            m = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            dateOfBirth = new DateTime(y, m, d);
            Console.WriteLine("Nhap StudentID");
            StudentID = Console.ReadLine();
            Console.WriteLine("Nhap Address");
            Address = Console.ReadLine();

            Console.WriteLine("nhap SchoolName");
            SchoolName = Console.ReadLine();
        }
    }
}
