using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using OtelOtomasyonApp.Entity;

namespace OtelOtomasyonApp.DAL
{
   public class OtelDAL
    {
        private DBHelper dbHelper;
        public OtelDAL()
        {
            dbHelper = new DBHelper();

        }

        public List<OtelBilgi> GetOtelAllBilgi()
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM OtelOtomasyonApp.dbo.TBL_OtelBilgiler";
            cmd.ExecuteNonQuery();
            List<OtelBilgi> listOtelBilgi = new List<OtelBilgi>();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                OtelBilgi oBilgi = new OtelBilgi();
                oBilgi.otelAd = rdr["otelAd"].ToString();
                oBilgi.otelBulunduguIl = rdr["otelBulunduguIl"].ToString();
                listOtelBilgi.Add(oBilgi);
            }
            return listOtelBilgi;
        }
        public void GetAddOtel(OtelBilgi oBilgi)
        {
            Console.WriteLine(oBilgi.otelAd);
            string cmdText = string.Format("INSERT INTO OtelOtomasyonApp.dbo.TBL_OtelBilgiler ( [otelAd],[otelBulunduguIl],[otelBulunduguIlce],[otelAdres],[otelTelefon],[otelEposta],[otelYıldızSayisi],[otelOdaSayisi],[otelOdaTipi],[otelPuan]) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')"
                , oBilgi.otelAd,oBilgi.otelBulunduguIl,oBilgi.otelBulunduguIlce,oBilgi.otelAdres,oBilgi.otelTelefon
                ,oBilgi.otelEposta,oBilgi.otelYildizSayisi,oBilgi.otelOdaSayisi,oBilgi.otelOdaTipi,oBilgi.otelPuan);
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }
        public void GetDeleteOtel(OtelBilgi oBilgi)
        {
             
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = string.Format("Delete From OtelOtomasyonApp.dbo.TBL_OtelBilgiler Where otelId=@otelId");
            cmd.Parameters.AddWithValue("@otelId", oBilgi.otelId);
            cmd.ExecuteNonQuery();

        }
        public void GetUpdateOtel(OtelBilgi oBilgi)
        {
            Console.WriteLine(oBilgi.otelAd);
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = string.Format("UPDATE OtelOtomasyonApp.dbo.TBL_OtelBilgiler SET otelAd=@otelAd,otelBulunduguIl=@otelBulunduguIl,otelBulunduguIlce=@otelBulunduguIlce,otelAdres=@otelAdres,otelTelefon=@otelTelefon,otelEposta=@otelEposta,otelYıldızSayisi=@otelYildizSayisi,otelOdaSayisi=@otelOdaSayisi,otelOdaTipi=@otelOdaTipi,otelPuan=@otelPuan WHERE otelId =@otelId"
                , oBilgi.otelAd,oBilgi.otelBulunduguIl,oBilgi.otelBulunduguIlce
                ,oBilgi.otelAdres,oBilgi.otelTelefon,oBilgi.otelEposta
                ,oBilgi.otelYildizSayisi,oBilgi.otelOdaSayisi,oBilgi.otelOdaTipi,oBilgi.otelPuan);
            cmd.Parameters.AddWithValue("@otelAd", oBilgi.otelAd);
            cmd.Parameters.AddWithValue("@otelBulunduguIl", oBilgi.otelBulunduguIl);
            cmd.Parameters.AddWithValue("@otelBulunduguIlce", oBilgi.otelBulunduguIlce);
            cmd.Parameters.AddWithValue("@otelAdres", oBilgi.otelAdres);
            cmd.Parameters.AddWithValue("@otelTelefon", oBilgi.otelTelefon);
            cmd.Parameters.AddWithValue("@otelEposta", oBilgi.otelEposta);
            cmd.Parameters.AddWithValue("@otelYildizSayisi", oBilgi.otelYildizSayisi);
            cmd.Parameters.AddWithValue("@otelOdaSayisi", oBilgi.otelOdaSayisi);
            cmd.Parameters.AddWithValue("@otelOdaTipi", oBilgi.otelOdaTipi);
            cmd.Parameters.AddWithValue("@otelPuan", oBilgi.otelPuan);
            cmd.Parameters.AddWithValue("@otelId", oBilgi.otelId);
            cmd.ExecuteNonQuery();

        }
        

    }
}
