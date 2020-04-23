using System;
using System.Collections.Generic;
using System.Text;

namespace chuong3_bt6
{
    class SinhVien
    {
        public string MaSinhVien;
        private string HoTen;
        private int NamSinh;
        private double DiemLapTrinh;
        private double DiemCSDL;
        private double DiemTB;
        public SinhVien()
        {
            MaSinhVien = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLapTrinh = DiemCSDL = DiemTB = 0;
        }
        public SinhVien( string MaSinhVien, string HoTen,int NamSinh, double DiemLapTrinh, double DiemCSDL)
        {
            this.MaSinhVien = MaSinhVien;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLapTrinh = DiemLapTrinh;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (DiemLapTrinh + DiemCSDL) / 2;

        }
        public void Nhap()
        {
            Console.WriteLine(" Nhập mã sinh viên:");
            MaSinhVien = Console.ReadLine();
            Console.WriteLine(" Nhập họ tên sinh viên:");
            HoTen = Console.ReadLine();
            Console.WriteLine(" Nhập năm sinh sinh viên:");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Nhập điểm lập trình:");
            DiemLapTrinh =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Nhập điểm CSDL:");
            DiemCSDL =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Điểm Trung bình của sinh viên:" , + DiemTB);
        }

        public void InThongTin ()
        {
            Console.WriteLine("Thông tin của sinh viên là: \n Ma sinh vien:{0} \t Họ và tên:{1} \t Năm sinh: {2}", MaSinhVien, HoTen, NamSinh);
            Console.WriteLine("Điểm lập trình:{0} \t Điểm CSDL:{2} \t Điểm Trung bình:{3}", DiemLapTrinh, DiemCSDL, DiemTB);
        }
    }
}
