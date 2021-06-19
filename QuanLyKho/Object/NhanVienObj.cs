using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Object
{
    class NhanVienObj
    {
        string ma, ten, gioitinh, diachi, namsinh;
        string sdt;
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }
        public NhanVienObj() { }
        public NhanVienObj(string ma, string ten, string gioitinh, string diachi, string sdt, string matkhau, string namsinh)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.namsinh = namsinh;
        }
    }
}
