using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Object
{
    class NhacungcapObj
    {
        int mancc;
        string tencc, diachi, sdt, ghichu;

        public NhacungcapObj()
        {
        }

        public NhacungcapObj(int mancc, string tencc, string diachi, string sdt, string ghichu)
        {
            this.Mancc = mancc;
            this.Tencc = tencc;
            this.Diachi = diachi;
            this.sdt = sdt;
            this.Ghichu = ghichu;
        }

        public int Mancc { get => mancc; set => mancc = value; }
        public string Tencc { get => tencc; set => tencc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
