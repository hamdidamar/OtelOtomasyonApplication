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
   public class PersonelDAL
    {
        private DBHelper dbHelper;
        public PersonelDAL()
        {
            dbHelper = new DBHelper();
        }
  public List<PersonelBilgi> GetAllPersonel(PersonelBilgi personel)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            Console.WriteLine(personel.personelDepartmant);
            cmd.CommandText = ("SELECT * FROM OtelOtomasyonApp.dbo.TBL_PersonelBilgiler ");
            cmd.ExecuteNonQuery();
            List<PersonelBilgi> listPersonelBilgi = new List<PersonelBilgi>();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                PersonelBilgi pBilgi = new PersonelBilgi();
                pBilgi.personelTcNo = rdr["personelTcNo"].ToString();
                pBilgi.personelAd = rdr["personelAd"].ToString();
                pBilgi.personelSoyad = rdr["personelSoyad"].ToString();
                pBilgi.personelTelefon = rdr["personelTelefon"].ToString();
                pBilgi.personelAdres = rdr["personelAdres"].ToString();
                pBilgi.personelEposta = rdr["personelEposta"].ToString();
                pBilgi.personelDepartmant = rdr["personelDepartmant"].ToString();
                pBilgi.personelPozisyon = rdr["personelPozisyon"].ToString();
                pBilgi.personelPuan =int.Parse(rdr["personelPuan"].ToString());
                pBilgi.personelOtel = rdr["personelOtel"].ToString();
                listPersonelBilgi.Add(pBilgi);
            }
            return listPersonelBilgi;
        }
        public List<PersonelBilgi> GetPersonelLinkedList(PersonelBilgi personel)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            Console.WriteLine(personel.personelDepartmant);
            cmd.CommandText = ("SELECT * FROM OtelOtomasyonApp.dbo.TBL_PersonelBilgiler");
            cmd.ExecuteNonQuery();
            List<PersonelBilgi> listPersonelBilgi = new List<PersonelBilgi>();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                PersonelBilgi pBilgi = new PersonelBilgi();
                pBilgi.personelTcNo = rdr["personelTcNo"].ToString();
                pBilgi.personelAd = rdr["personelAd"].ToString();
                pBilgi.personelSoyad = rdr["personelSoyad"].ToString();
                pBilgi.personelTelefon = rdr["personelTelefon"].ToString();
                pBilgi.personelAdres = rdr["personelAdres"].ToString();
                pBilgi.personelEposta = rdr["personelEposta"].ToString();
                pBilgi.personelDepartmant = rdr["personelDepartmant"].ToString();
                pBilgi.personelPozisyon = rdr["personelPozisyon"].ToString();
                pBilgi.personelPuan =int.Parse(rdr["personelPuan"].ToString());
                listPersonelBilgi.Add(pBilgi);
            }
            return listPersonelBilgi;
        }
        public void GetAddPersonel(PersonelBilgi pBilgi)
        {
            
            string cmdText = string.Format("INSERT INTO OtelOtomasyonApp.dbo.TBL_PersonelBilgiler"
                + "( [personelTcNo],[personelAd],[personelSoyad],[personelTelefon],[personelAdres]"
                + ",[personelEposta],[personelDepartmant],[personelPozisyon],[personelPuan])"
                + "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')"
                , pBilgi.personelTcNo, pBilgi.personelAd, pBilgi.personelSoyad, pBilgi.personelTelefon, pBilgi.personelAdres
                , pBilgi.personelEposta, pBilgi.personelDepartmant, pBilgi.personelPozisyon, pBilgi.personelPuan);
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }
        public void GetDeletePersonel(PersonelBilgi pBilgi)
        {
            
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = string.Format("Delete From OtelOtomasyonApp.dbo.TBL_PersonelBilgiler Where personelId = @personelId");
            cmd.Parameters.AddWithValue("@personelId", pBilgi.personelId);
            cmd.ExecuteNonQuery();

        }
        public void GetUpdatePersonel(PersonelBilgi pBilgi)
        {
             
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = string.Format("UPDATE OtelOtomasyonApp.dbo.TBL_PersonelBilgiler SET personelTcNo=@personelTcNo,personelAd=@personelAd,personelSoyad=@personelSoyad,personelTelefon=@personelTelefon,personelAdres=@personelAdres,personelEposta=@personelEposta,personelDepartmant=@personelDepartmant,personelPozisyon=@personelPozisyon,personelPuan=@personelPuan WHERE personelId=@personelId"
                , pBilgi.personelTcNo, pBilgi.personelAd, pBilgi.personelSoyad, pBilgi.personelTelefon, pBilgi.personelAdres, pBilgi.personelEposta, pBilgi.personelDepartmant, pBilgi.personelPozisyon, pBilgi.personelPuan, pBilgi.personelId);
            cmd.Parameters.AddWithValue("@personelTcNo", pBilgi.personelTcNo);
            cmd.Parameters.AddWithValue("@personelAd", pBilgi.personelAd);
            cmd.Parameters.AddWithValue("@personelSoyad", pBilgi.personelSoyad);
            cmd.Parameters.AddWithValue("@personelTelefon", pBilgi.personelTelefon);
            cmd.Parameters.AddWithValue("@personelAdres", pBilgi.personelAdres);
            cmd.Parameters.AddWithValue("@personelEposta", pBilgi.personelEposta);
            cmd.Parameters.AddWithValue("@personelDepartmant", pBilgi.personelDepartmant);
            cmd.Parameters.AddWithValue("@personelPozisyon", pBilgi.personelPozisyon);
            cmd.Parameters.AddWithValue("@personelPuan", pBilgi.personelPuan);
            cmd.Parameters.AddWithValue("@personelId", pBilgi.personelId);
            cmd.ExecuteNonQuery();

        }
        public List<PersonelBilgi> GetPersonelDepartmantListele()
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT personelDepartmant,personelOtel FROM OtelOtomasyonApp.dbo.TBL_PersonelBilgiler";
            cmd.ExecuteNonQuery();
            List<PersonelBilgi> listPersonelBilgi = new List<PersonelBilgi>();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                PersonelBilgi pBilgi = new PersonelBilgi();
                pBilgi.personelDepartmant = rdr["personelDepartmant"].ToString();
                pBilgi.personelOtel = rdr["personelOtel"].ToString();
                listPersonelBilgi.Add(pBilgi);
            }
            return listPersonelBilgi;

        }
        public List<PersonelBilgi> DeparmantGorePersonelListele(PersonelBilgi personel)
        {
            Console.WriteLine(personel.personelDepartmant);
            Console.WriteLine(personel.personelOtel);
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText =string.Format( "SELECT personelAd,personelSoyad,personelOtel,personelDepartmant FROM OtelOtomasyonApp.dbo.TBL_PersonelBilgiler WHERE personelOtel =@personelOtel and personelDepartmant = @personelDepartmant", personel.personelOtel, personel.personelDepartmant);
            cmd.Parameters.AddWithValue("@personelOtel", personel.personelOtel);
            cmd.Parameters.AddWithValue("@personelDepartmant", personel.personelDepartmant);
            cmd.ExecuteNonQuery();
            List<PersonelBilgi> listPersonelBilgi = new List<PersonelBilgi>();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                PersonelBilgi pBilgi = new PersonelBilgi();
                pBilgi.personelAd = rdr["personelAd"].ToString();
                pBilgi.personelSoyad = rdr["personelSoyad"].ToString();
                pBilgi.personelDepartmant = rdr["personelDepartmant"].ToString();
                pBilgi.personelOtel = rdr["personelOtel"].ToString();
                listPersonelBilgi.Add(pBilgi);
            }
            return listPersonelBilgi;
        }

       
    }
}
