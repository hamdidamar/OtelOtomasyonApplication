using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyonApp.Entity;
using OtelOtomasyonApp.DAL;
using OtelOtomasyonAppBLL;


namespace OtelOtomasyonApp.UI.WinForm
{
    public partial class frm_PersonelIslemleri : Form
    {
        public frm_PersonelIslemleri()
        {
            InitializeComponent();
        }
        PersonelBilgi pBilgi = new PersonelBilgi();
        PersonelDAL dal = new PersonelDAL();
        private void btn_PersonelEkle_Click(object sender, EventArgs e)
        {
            LinkedPersonel linkedp = new LinkedPersonel();
            pBilgi.personelTcNo = txt_personelTCEkle.Text;
            pBilgi.personelAd = txt_personelAdEkle.Text;
            pBilgi.personelSoyad = txt_personelSoyadEkle.Text;
            pBilgi.personelTelefon = txt_personelTelefonEkle.Text;
            pBilgi.personelAdres = txt_personelAdresEkle.Text;
            pBilgi.personelEposta = txt_personelEpostaEkle.Text;
            pBilgi.personelDepartmant = txt_personelDepartmantEkle.Text;
            pBilgi.personelPozisyon = txt_personelPozisyonEkle.Text;
            pBilgi.personelPuan =int.Parse(txt_personelPuanEkle.Text);
            dal.GetAddPersonel(pBilgi);
            linkedp.PersonelEkle();
        }
        private void btn_otelSil_Click(object sender, EventArgs e)
        {
            pBilgi.personelId =int.Parse(txt_personeIdS.Text);
            dal.GetDeletePersonel(pBilgi);
        }

        private void btn_OtelGuncelle_Click(object sender, EventArgs e)
        {

            pBilgi.personelId =int.Parse(txt_personelIdG.Text);
            pBilgi.personelTcNo = txt_personelTCG.Text;
            pBilgi.personelAd = txt_personelAdG.Text;
            pBilgi.personelSoyad = txt_personelSoyadG.Text;
            pBilgi.personelTelefon = txt_personelTelefonG.Text;
            pBilgi.personelAdres = txt_personelAdresG.Text;
            pBilgi.personelEposta = txt_personelEpostaG.Text;
            pBilgi.personelDepartmant = txt_personelDepartmantG.Text;
            pBilgi.personelPozisyon = txt_personelPozisyonG.Text;
            pBilgi.personelPuan = int.Parse(txt_personelPuanG.Text);
            dal.GetUpdatePersonel(pBilgi);
        }
    }
}
