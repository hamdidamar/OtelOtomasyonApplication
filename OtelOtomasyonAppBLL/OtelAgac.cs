using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelOtomasyonApp.Entity;


namespace OtelOtomasyonAppBLL
{
   public class OtelAgac
    {
        public OtelBilgi otelBilgi;
        public OtelAgac sol;
        public OtelAgac sag;
        public OtelAgac()
        {

        }
        public OtelAgac(OtelBilgi otelBilgi)
        {

            this.otelBilgi = otelBilgi;
            sol = null;
            sag = null;
        }
    }
}
