using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Object;
using QuanLyKho.Models;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKho.Models
{
    class NhacungcapCtrl
    {
        NhaCungCapMod nvMod = new NhaCungCapMod();
        public DataTable GetData()
        {
            return nvMod.Getdata();
        }
        public bool AddData(NhacungcapObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool UpdData(NhacungcapObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }

        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
