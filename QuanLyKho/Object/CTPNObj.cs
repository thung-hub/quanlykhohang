using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Object
{
    class CTPNObj
    {

        string mahd, mahh, thanhtien, solg, tenhh, dongia;
        public string Mahd { get => mahd; set => mahd = value; }
        public string Mahh { get => mahh; set => mahh = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Solg { get => solg; set => solg = value; }
        public string Tenhh { get => tenhh; set => tenhh = value; }
        public string Dongia { get => dongia; set => dongia = value; }

        public CTPNObj() { }

        public CTPNObj(string mahd,string mahh, string thanhtien, string solg, string tenhh, string dongia)
        {
            this.mahd = mahd;
            this.mahh = mahh;
            this.thanhtien = thanhtien;
            this.solg = solg;
            this.tenhh = tenhh;
            this.dongia = dongia;
        }
    }
}
