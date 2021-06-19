using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Object
{
    class KhachHangObj
    {
        string ma, ten, gioitinh, diachi, namsinh;
        int sdt, diem;

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public int Diem { get => diem; set => diem = value; }
        public KhachHangObj() { }
        public KhachHangObj(string ma, string ten, string gioitinh, string diachi, int sdt, int diem)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.diem = diem;

        }
    }
}
