using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Object
{
    class CTPXObj
    {
        string mapx,mahang, thanhtien, solg, tenhh, dongia;
        public string Mapx { get => mapx; set => mapx = value; }
        public string Mahang { get => mahang; set => mahang = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Solg { get => solg; set => solg = value; }
        public string Tenhh { get => tenhh; set => tenhh = value; }
        public string Dongia { get => dongia; set => dongia = value; }

        public CTPXObj() { }

        public CTPXObj(string mapx, string mahang, string thanhtien, string solg, string tenhh, string dongia)
        {
            this.mapx = mapx;
            this.mahang = mahang;
            this.thanhtien = thanhtien;
            this.solg = solg;
            this.tenhh = tenhh;
            this.dongia = dongia;
        }
    }
}
