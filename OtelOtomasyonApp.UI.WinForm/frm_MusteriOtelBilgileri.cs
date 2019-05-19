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
using OtelOtomasyonAppBLL;



namespace OtelOtomasyonApp.UI.WinForm
{
    public partial class frm_MusteriOtelBilgileri : Form
    {
        public frm_MusteriOtelBilgileri()
        {
            InitializeComponent();
        }
        List<PersonelBilgi> listPersonelBilgi = new List<PersonelBilgi>();
        PersonelDAL pdal = new PersonelDAL();
        private void frm_MusteriOtelBilgileri_Load(object sender, EventArgs e)
        {
            listPersonelBilgi = pdal.GetPersonelDepartmantListele();
            for (int i = 0; i < listPersonelBilgi.Count; i++)
            {
                if (cmb_musteriOtelSecim.Items.Contains(listPersonelBilgi[i].personelOtel))
                {
                    continue;
                }
                else
                {
                    cmb_musteriOtelSecim.Items.Add(listPersonelBilgi[i].personelOtel);
                }
            }
        }
        MusteriBilgi mBilgi = new MusteriBilgi();
        MusteriDAL mDal = new MusteriDAL();
        private void btn_musteriBilgiGonder_Click(object sender, EventArgs e)
        {
            LinkedMusteri linkedm = new LinkedMusteri();
            mBilgi.musteriAd = txt_müsteriAd.Text;
            mBilgi.musteriSoyad = txt_musteriSoyad.Text;
            mBilgi.musteriEposta = txt_musteriEposta.Text;
            mBilgi.musteriYorum = txt_musteriYorum.Text;
            mBilgi.musteriVerilenPuan =int.Parse( txt_musteriPuan.Text);
            mBilgi.musteriOtelAdı = cmb_musteriOtelSecim.Text;
            mDal.GetAddMusteri(mBilgi);
            linkedm.MusteriOtelBilgiEkle();
        }
    }
}
