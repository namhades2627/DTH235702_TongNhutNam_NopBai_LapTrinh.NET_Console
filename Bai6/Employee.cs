using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private int _yearOfBirth;
        private double _salaryLevel;
        private static double _basicSalary;

        public Employee()
        {
            _id = 0;
            _name = "";
            _yearOfBirth = 0;
            _salaryLevel = 1.0;
        }

        // ===== Properties =====
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set { _yearOfBirth = value; }
        }

        public double SalaryLevel
        {
            get { return _salaryLevel; }
            set { _salaryLevel = value; }
        }

        public static double BasicSalary
        {
            get { return _basicSalary; }
            set { _basicSalary = value; }
        }

        public double Income
        {
            get { return Math.Round(SalaryLevel * BasicSalary, 2); }
        }

        // ===== Phương thức nhập / xuất =====
        public void nhap()
        {
            Console.Write("\t- Nhập ID: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("\t- Nhập họ tên: ");
            Name = Console.ReadLine();

            Console.Write("\t- Nhập năm sinh: ");
            YearOfBirth = int.Parse(Console.ReadLine());

            Console.Write("\t- Nhập bậc lương: ");
            SalaryLevel = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-12}{3,-15}{4,-15}{5,-15}",
                Id, Name, YearOfBirth, SalaryLevel, BasicSalary, Income);
        }
    }
}
