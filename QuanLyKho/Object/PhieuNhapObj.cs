using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Object
{
    class PhieuNhapObj
    {
        string mapn, tennv, ngaylap;

        int tong,ncc;
        public string Mapn { get => mapn; set => mapn = value; }
        public int Ncc { get => ncc; set => ncc = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public int Tong { get => tong; set => tong = value; }
        public PhieuNhapObj() { }
        public PhieuNhapObj(string ma, int ncc, string tennv, string gia, int tong)
        {
            this.mapn = ma;
            this.ncc = ncc;
            this.tennv = tennv;
            this.ngaylap = gia;
            this.tong = tong;
        }
    }
}
