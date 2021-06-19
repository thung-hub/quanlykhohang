using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKho.Models;
using QuanLyKho.Object;
namespace QuanLyKho.Control
{
    class PhieuXuatCtrl
    {
        PhieuXuatMod nvMod = new PhieuXuatMod();
        public DataTable GetData()
        {
            return nvMod.Getdata();
        }
        public bool AddData(PhieuXuatObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
    }
}
