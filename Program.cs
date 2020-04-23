using System;

namespace chuong3_bt6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quan ly thông tin sinh viên ");
            DanhSach k21httta = new DanhSach();
            k21httta.Nhap();
            k21httta.Xuat();
            k21httta.SapXep();
            k21httta.Xuat();
            Console.ReadLine();

        }
    }
}
