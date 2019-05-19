using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelOtomasyonApp.Entity;
using OtelOtomasyonApp.DAL;
using System.Data;
using System.Data.SqlClient;

namespace OtelOtomasyonApp.DAL
{
    public class MusteriDAL
    {
        private DBHelper dbHelper;
        public MusteriDAL()
        {
            dbHelper = new DBHelper();
        }
        public List<MusteriBilgi> GetAllMusteri(MusteriBilgi musteri)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = ("SELECT * FROM OtelOtomasyonApp.dbo.TBL_MusteriBilgiler ");
            cmd.ExecuteNonQuery();
            List<MusteriBilgi> listMusteriBilgi = new List<MusteriBilgi>();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                MusteriBilgi mBilgi = new MusteriBilgi();
                mBilgi.musteriAd = rdr["musteriAd"].ToString();
                mBilgi.musteriSoyad = rdr["musteriSoyad"].ToString();
                mBilgi.musteriEposta = rdr["musteriEposta"].ToString();
                mBilgi.musteriYorum = rdr["musteriYorum"].ToString();
                mBilgi.musteriVerilenPuan =int.Parse(rdr["musteriVerilenPuan"].ToString());
                mBilgi.musteriOtelAdı = rdr["musteriOtelAdı"].ToString();
                listMusteriBilgi.Add(mBilgi);
            }
            return listMusteriBilgi;
        }

        public void GetAddMusteri(MusteriBilgi mBilgi)
        {

            string cmdText = string.Format("INSERT INTO OtelOtomasyonApp.dbo.TBL_MusteriBilgiler"
                + "([musteriAd],[musteriSoyad],[musteriEposta],[musteriYorum],[musteriVerilenPuan],[musteriOtelAdı] )"
                + "values('{0}', '{1}', '{2}', '{3}', '{4}')"
                , mBilgi.musteriAd, mBilgi.musteriSoyad, mBilgi.musteriEposta, mBilgi.musteriYorum, mBilgi.musteriVerilenPuan
                , mBilgi.musteriOtelAdı);
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }

    }
}
