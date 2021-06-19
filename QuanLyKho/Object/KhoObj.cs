using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Object
{
    class KhoObj
    {
        string mahang, tenhang, donvi, nhacc;
        int solg, dongia;
        public string Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public int Solg { get => solg; set => solg = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public string Nhacc { get => nhacc; set => nhacc = value; }
        public KhoObj() { }
        public KhoObj(string ma, string ten, int solg, int gia, string donvi, string nhacc)
        {
            this.mahang = ma;
            this.tenhang = ten;
            this.solg = solg;
            this.dongia = gia;
            this.donvi = donvi;
            this.nhacc = nhacc;
        }
    }
}
