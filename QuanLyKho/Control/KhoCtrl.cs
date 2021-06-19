using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models;
using System.Data;
using QuanLyKho.Object;

namespace QuanLyKho.Control
{
    class KhoCtrl
    {
        KhoMod nvMod = new KhoMod();
        public DataTable GetData()
        {
            return nvMod.Getdata();
        }
        public DataTable GetData(string dieukien)
        {
            return nvMod.GetData(dieukien);
        }
        public bool AddData(KhoObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool UpdData(KhoObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }

        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
        public DataTable Finddata(string ma)
        {
            return nvMod.finddata(ma);
        }
        public bool UpdSL(DataTable dt)
        {
            DataTable dthh = new DataTable();
            dthh = nvMod.Getdata();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dthh.Rows.Count; j++)
                {
                    if (dt.Rows[i][0].ToString() == dthh.Rows[j][0].ToString())
                    {
                        int SLcu = int.Parse(dthh.Rows[j][3].ToString());
                        int SLmoi = int.Parse(dthh.Rows[j][3].ToString()) + int.Parse(dt.Rows[i][3].ToString());
                        if (!nvMod.UpdSL(dthh.Rows[j][0].ToString(), SLmoi))
                            return false;
                        break;
                    }
                }
            }
            return true;
        }
        public bool DeldSL(DataTable dt)
        {
            DataTable dthh = new DataTable();
            dthh = nvMod.Getdata();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dthh.Rows.Count; j++)
                {
                    if (dt.Rows[i][0].ToString() == dthh.Rows[j][0].ToString())
                    {
                        int SLcu = int.Parse(dthh.Rows[j][3].ToString());
                        int SLmoi = int.Parse(dthh.Rows[j][3].ToString()) - int.Parse(dt.Rows[i][3].ToString());
                        if (!nvMod.UpdSL(dthh.Rows[j][0].ToString(), SLmoi))
                            return false;
                        break;
                    }
                }
            }
            return true;
        }
    }
}
