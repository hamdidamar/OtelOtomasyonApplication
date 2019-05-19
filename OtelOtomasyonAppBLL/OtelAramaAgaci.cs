using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelOtomasyonApp.Entity;
using OtelOtomasyonAppBLL;
using OtelOtomasyonApp.DAL;

namespace OtelOtomasyonAppBLL
{
    public class OtelAramaAgaci
    {
        private OtelAgac kok;
        private List<OtelBilgi> dugumler;
        public OtelAramaAgaci()
        {
        }
        public OtelAramaAgaci(OtelAgac kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(OtelAgac dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(OtelAgac dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        public List<OtelBilgi> DugumleriYazdir()
        {
            return dugumler;
        }
        public void EkleOtelAd(OtelBilgi otel)
        {
            //Yeni eklenecek düğümün parent'ı
            OtelAgac tempParent = new OtelAgac();
            //Kökten başla ve ilerle
            OtelAgac tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (otel.otelAd == tempSearch.otelBilgi.otelAd)
                    return;
                else if (string.Compare(otel.otelAd, tempSearch.otelBilgi.otelAd) == -1)
                {
                    tempSearch = tempSearch.sol;
                }

                else
                    tempSearch = tempSearch.sag;
            }
            OtelAgac eklenecek = new OtelAgac(otel);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (string.Compare(otel.otelAd, tempParent.otelBilgi.otelAd) == -1)
            {
                tempParent.sol = eklenecek;
            }
            else
                tempParent.sag = eklenecek;

        }
        public OtelAgac Ara(OtelBilgi otel)
        {
            return AraInt(kok, otel);
        }
        private OtelAgac AraInt(OtelAgac dugum, OtelBilgi otel)
        {
            if (dugum == null)
                return null;
            else if (dugum.otelBilgi.otelBulunduguIl == otel.otelBulunduguIl)
                return dugum;
            else if (string.Compare(dugum.otelBilgi.otelBulunduguIl,otel.otelBulunduguIl) == -1)
                return (AraInt(dugum.sol, otel));
            else
                return (AraInt(dugum.sag, otel));
        }
        private void Ziyaret(OtelAgac dugum)
        {
            dugumler.Add(dugum.otelBilgi);
        }
        public void InOrder()
        {
            dugumler = new List<OtelBilgi>();
            dugumler.Clear();

            InOrderInt(kok);
        }
        private void InOrderInt(OtelAgac dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
    }
}
