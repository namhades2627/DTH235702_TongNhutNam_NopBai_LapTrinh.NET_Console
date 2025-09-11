using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MangSoNguyen msn = new MangSoNguyen();
            int n;
            Console.Write("Nhập vào số phần tử mảng = ");
            n = msn.NhapSoDuong();
            int[] a = new int[n];
            msn.NhapMang(a);
            Console.WriteLine("Mảng vừa nhập ");
            msn.InMang(a);
            Console.WriteLine("\nSố lớn nhất trong mảng {0}", msn.TimMax(a));
            Console.WriteLine("\nSố nhỏ nhất trong mảng {0}", msn.TimMin(a));
            Console.WriteLine("\nTổng các phần tử trong mảng {0}", msn.TinhTong(a));
            Console.WriteLine("\nMang sau khi sắp tăng dần ");
            msn.SapXepTang(a);
            msn.InMang(a);
            Console.ReadLine();
        }
    }
}
