using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Object;
using QuanLyKho.Models;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKho.Control
{
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable GetData()
        {
            return nvMod.Getdata();
        }
        public bool AddData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool UpdData(NhanVienObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }

        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);

        }
    }
}
