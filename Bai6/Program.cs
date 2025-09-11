using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhập lương cơ bản (áp dụng cho tất cả): ");
            Employee.BasicSalary = double.Parse(Console.ReadLine());

            Employee[] arrEmp = new Employee[n];

            // Nhập danh sách nhân viên
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n--- Nhập thông tin nhân viên thứ {0} ---", i + 1);
                arrEmp[i] = new Employee();
                arrEmp[i].nhap();
            }

            // Xuất danh sách nhân viên
            Console.WriteLine("\n===== DANH SÁCH NHÂN VIÊN =====");
            Console.WriteLine("{0,-10}{1,-20}{2,-12}{3,-15}{4,-15}{5,-15}",
                "ID", "Họ tên", "Năm sinh", "Bậc lương", "Lương cơ bản", "Thu nhập");

            for (int i = 0; i < n; i++)
            {
                arrEmp[i].xuat();
            }

            Console.ReadLine();
        }
    }
}
