using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtelOtomasyonApp.Entity
{
   public class PersonelBilgi
    {
        public int personelId { get; set; }
        public string personelTcNo { get; set; }
        public string personelAd { get; set; }
        public string personelSoyad { get; set; }
        public string personelTelefon { get; set; }
        public string personelAdres { get; set; }
        public string personelEposta { get; set; }
        public string personelDepartmant { get; set; }
        public string personelPozisyon { get; set; }
        public int personelPuan { get; set; }
        public string personelOtel { get; set; }
        public LinkedList<PersonelBilgi> LinkedList;


    }
}
