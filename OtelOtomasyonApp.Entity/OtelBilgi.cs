using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonApp.Entity
{
   public class OtelBilgi
    {
        public int otelId { get; set; }
        public string otelAd { get; set; } 
        public string otelBulunduguIl { get; set; }
        public string otelBulunduguIlce { get; set; }
        public string otelAdres { get; set; }
        public string otelTelefon { get; set; }
        public string otelEposta { get; set; }
        public int otelYildizSayisi { get; set; }
        public int otelOdaSayisi { get; set; }
        public string otelOdaTipi { get; set; }
        public int otelPuan { get; set; }

    }
}
