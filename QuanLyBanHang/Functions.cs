using QuanLyBanHang.Classes;
using System.Data;

namespace QuanLyBanHang
{
    public class Functions
    {
        ProcessDatabase dataBase = new ProcessDatabase();
        public string SinhMaTuDong(string TenBang, string MaBatDau, string TruongMa)
        {
            int id = 0;
            bool dung = false;
            string ma = "";
            DataTable dm = new DataTable();
            while (dung == false)
            {
                dm = dataBase.DocBang("Select * from " + TenBang + " where " + TruongMa + "='" + MaBatDau +
                    id.ToString() + "'");
                if (dm.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {
                    id++;
                    dung = false;
                }
            }
            ma = MaBatDau + id.ToString();
            return ma;
        }
    }
}
