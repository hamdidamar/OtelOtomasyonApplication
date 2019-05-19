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
    public partial class frm_PersonelListele : Form
    {
        PersonelBilgi personel = new PersonelBilgi();
        List<PersonelBilgi> listDepartmant = new List<PersonelBilgi>();
        LinkedPersonel perlis = new LinkedPersonel();
        public frm_PersonelListele()
        {
            InitializeComponent();
        }
        List<PersonelBilgi> listPersonelBilgi = new List<PersonelBilgi>();
        PersonelDAL pdal = new PersonelDAL();
        PersonelBilgi pBilgi = new PersonelBilgi();
        private void frm_PersonelListele_Load(object sender, EventArgs e)
        {
            listPersonelBilgi = pdal.GetPersonelDepartmantListele();
            for (int i = 0; i < listPersonelBilgi.Count; i++)
            {
                if (cmbbx_OtelDepartman.Items.Contains(listPersonelBilgi[i].personelOtel))
                {
                    continue;
                }
                else
                {
                    cmbbx_OtelDepartman.Items.Add(listPersonelBilgi[i].personelOtel);
                }
                if (cmbbx_departmantListele.Items.Contains(listPersonelBilgi[i].personelDepartmant))
                {
                    continue;
                }
                else
                {
                    cmbbx_departmantListele.Items.Add(listPersonelBilgi[i].personelDepartmant);
                }
            }
            listPersonelBilgi = pdal.GetPersonelDepartmantListele();
            for (int i = 0; i < listPersonelBilgi.Count; i++)
            {
                if (cmbbx_OtelPuan.Items.Contains(listPersonelBilgi[i].personelOtel))
                {
                    continue;
                }
                else
                {
                    cmbbx_OtelPuan.Items.Add(listPersonelBilgi[i].personelOtel);
                }
                
            }
            perlis.PersonelEkle();
        }
        private void btn_DepartmantListele_Click(object sender, EventArgs e)
        {
            Lstbx_DepartmantaGoreListele.Items.Clear();
            personel.personelDepartmant = cmbbx_departmantListele.Text;
            personel.personelOtel = cmbbx_OtelDepartman.Text;
            listDepartmant= perlis.FindNode(personel.personelDepartmant, personel.personelOtel);
            for (int i = 0; i < listDepartmant.Count; i++)
            {
                Lstbx_DepartmantaGoreListele.Items.Add(listDepartmant[i].personelAd + "\t" + listDepartmant[i].personelSoyad + "\t" + listDepartmant[i].personelOtel + "\t" + listDepartmant[i].personelDepartmant);
            }
        }
        
        List<PersonelBilgi> listPuan = new List<PersonelBilgi>();
        private void btn_PuanListele_Click(object sender, EventArgs e)
        {
            PersonelBilgi per = new PersonelBilgi();
            lstbx_PuanaGoreListele.Items.Clear();
            per = perlis.EnYüksekPuan(cmbbx_OtelPuan.Text);
            lstbx_PuanaGoreListele.Items.Add(per.personelAd + "\t" + per.personelSoyad + "\t" + per.personelOtel + "\t" + per.personelPuan);
        }
    }
}
