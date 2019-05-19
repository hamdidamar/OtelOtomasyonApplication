using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelOtomasyonApp.Entity;
using OtelOtomasyonApp.DAL;

namespace OtelOtomasyonAppBLL
{
   public class OtelHashMapChain
    {
        int TABLE_SIZE = 10;

        OtelLinkedHashEntry[] table;
        public OtelHashMapChain()
        {
            table = new OtelLinkedHashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                table[i] = null;
        }
        public void AddOtel(int otelIl,string otelIlce )
        {
            int hash = (otelIl % TABLE_SIZE);
            if (table[hash] == null)
                table[hash] = new OtelLinkedHashEntry(otelIl, otelIlce);
            else
            {
               OtelLinkedHashEntry entry = table[hash];
                while (entry.Next != null && entry.Anahtar != otelIl)
                    entry = entry.Next;
                if (entry.Anahtar == otelIl)
                    entry.Deger = otelIlce;
                else
                    entry.Next = new OtelLinkedHashEntry(otelIl, otelIlce);
            }
        }
        public OtelBilgi GetOtel(int key)
        {
            int hash = (key % TABLE_SIZE);
            if (table[hash] == null)
                return null;
            else
            {
                OtelLinkedHashEntry entry = table[hash];
                while (entry != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry == null)
                    return null;
                else
                    return (OtelBilgi)entry.Deger;
            }
        }
    }
}
