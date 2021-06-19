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
    class CTPNCtrl
    {
        CTPNMod Mod = new CTPNMod();
        public DataTable GetData(string mahd)
        {
            return Mod.Getdata(mahd);
        }
        public bool AddData(string ma, DataTable dt)
        {
            return Mod.AddData(ma, dt);
        }
    }
}
