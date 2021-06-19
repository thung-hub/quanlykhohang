using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models;
using QuanLyKho.Object;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKho.Control
{
    class PhieuNhapCtrl
    {
        PhieuNhapMod nvMod = new PhieuNhapMod();
        public DataTable GetData()
        {
            return nvMod.Getdata();
        }
        public bool AddData(PhieuNhapObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
    }
}
