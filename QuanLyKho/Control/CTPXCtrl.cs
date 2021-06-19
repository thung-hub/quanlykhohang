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
    class CTPXCtrl
    {
        CTPXMod Mod = new CTPXMod();
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
