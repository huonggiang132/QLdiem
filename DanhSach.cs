using System;
using System.Collections.Generic;
using System.Text;

namespace chuong3_bt6
{
    class DanhSach
    {
        private int n; //so lg sinh vien
        private SinhVien[] DS; //Mảng chứa danh sach Sinh viên

        public void Nhap()
        {
            Console.WriteLine("Hay nhap so sinh viên trong danh sách :");
            n = Convert.ToInt32(Console.ReadLine());

            DS = new SinhVien[n];

            for ( int i=0;i<n;i++)
            {
                Console.WriteLine(" Hay nhap thông tin cho sinh viên thứ:" + i);
                DS[i] = new SinhVien();
                DS[i].Nhap();
            }
        }

        public void Xuat()
        {
            if(DS!= null && n>0)
            {
                for ( int i= 0; i<n;i++)
                {
                    DS[i].InThongTin();
                }
            }    
        }

        public void SapXep() // Sắp xếp theo ma sinh viên tăng dần
        
        {
            for ( int i=0;i<n-1;i++)
                for ( int j=i+1;j<n;j++)
                {
                    if(string.Compare(DS[i].MaSinhVien, DS[j].MaSinhVien,true)>0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;

                    }
                }
        }
    }      
}
