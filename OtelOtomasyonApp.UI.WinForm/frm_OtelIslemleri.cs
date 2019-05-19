using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyonApp.DAL;
using OtelOtomasyonApp.Entity;
namespace OtelOtomasyonApp.UI.WinForm
{
    public partial class frm_OtelIslemleri : Form
    {
        public frm_OtelIslemleri()
        {
            InitializeComponent();
        }
        OtelBilgi oBilgi = new OtelBilgi();
        OtelDAL dal = new OtelDAL();
        private void btn_OtelEkle_Click(object sender, EventArgs e)
        {
            oBilgi.otelAd = txt_otelAdE.Text;
            oBilgi.otelBulunduguIl = txt_otelBulunduguIlE.Text;
            oBilgi.otelBulunduguIlce = txt_otelBulunduguIlceE.Text;
            oBilgi.otelAdres = txt_otelAdresE.Text;
            oBilgi.otelTelefon = txt_otelTelefonE.Text;
            oBilgi.otelEposta = txt_otelEpostaE.Text;
            oBilgi.otelYildizSayisi =int.Parse( txt_otelYildizSayisiE.Text);
            oBilgi.otelOdaSayisi =int.Parse(txt_otelOdaSayisiE.Text);
            oBilgi.otelOdaTipi = txt_otelOdaTipiE.Text;
            oBilgi.otelPuan =int.Parse(txt_otelPuanE.Text);
            dal.GetAddOtel(oBilgi);
        }

        private void btn_OtelGuncelle_Click(object sender, EventArgs e)
        {
            oBilgi.otelId = int.Parse(txt_otelIdG.Text);
            oBilgi.otelAd = txt_otelAdG.Text;
            oBilgi.otelBulunduguIl = txt_otelBulunduguIlG.Text;
            oBilgi.otelBulunduguIlce = txt_otelBulunduguIlceG.Text;
            oBilgi.otelAdres = txt_otelAdresG.Text;
            oBilgi.otelTelefon = txt_otelTelefonG.Text;
            oBilgi.otelEposta = txt_otelEpostaG.Text;
            oBilgi.otelYildizSayisi = int.Parse(txt_otelYildizSayisiG.Text);
            oBilgi.otelOdaSayisi = int.Parse(txt_otelOdaSayisiG.Text);
            oBilgi.otelOdaTipi = txt_otelOdaTipiG.Text;
            oBilgi.otelPuan = int.Parse(txt_otelPuanG.Text);
            dal.GetUpdateOtel(oBilgi);

        }

        private void btn_otelSil_Click(object sender, EventArgs e)
        {
            oBilgi.otelId =int.Parse( txt_otelIdS.Text);
            dal.GetDeleteOtel(oBilgi);
        }
    }
}
