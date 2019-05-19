using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonAppBLL
{
  public  class OtelLinkedHashEntry
    {
        private int anahtar;
        private object deger;
        private OtelLinkedHashEntry next;
        public object Deger
        {
            get { return deger; }
            set { deger = value; }
        }
        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }
        public OtelLinkedHashEntry Next
        {
            get { return next; }
            set { next = value; }
        }
        public OtelLinkedHashEntry(int anahtar, object deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
            this.next = null;
        }
    }
}
