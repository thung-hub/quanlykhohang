using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Object
{
    class PhieuXuatObj
    {
        string mapx, tenkh, tennv, ngaylap;
        int tong;
        public string Mapx { get => mapx; set => mapx = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public int Tong { get => tong; set => tong = value; }
        public PhieuXuatObj() { }
        public PhieuXuatObj(string ma, string ten, string tennv, string gia, int tong)
        {
            this.mapx = ma;
            this.tenkh = ten;
            this.tennv = tennv;
            this.ngaylap = gia;
            this.tong = tong;
        }
    }
}
