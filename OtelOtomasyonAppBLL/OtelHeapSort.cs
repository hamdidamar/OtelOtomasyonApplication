using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonAppBLL
{
   public class OtelHeapSort
    {
        private int[] dizi;
        public OtelHeapSort(int[] dizi)
        {
            this.dizi = dizi;
        }

        public int[] Sort()
        {
            OtelHeap h = new OtelHeap(dizi.Length);
            int[] sorted = new int[dizi.Length];
            //Heap Ağacı Oluştur
            foreach (var item in dizi)
                h.Insert(item);
            int i = 0;
            //Ağaçtaki maksimum elemanı al ve yeni diziye ekle
            while (!h.IsEmpty())
                sorted[i++] = h.RemoveMax().Deger;
            return sorted;
        }
    }
}
