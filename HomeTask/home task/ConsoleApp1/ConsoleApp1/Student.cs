using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student
    {
        public Student()
        {
            TotalCount++;

            No = TotalCount;


        }



        public string FullName;
        public string GroupNo;
        public int No;
        public static int TotalCount;

    }
}
