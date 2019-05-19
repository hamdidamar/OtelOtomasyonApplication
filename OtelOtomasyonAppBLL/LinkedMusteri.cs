using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelOtomasyonApp.Entity;
using System.Data.SqlClient;
using OtelOtomasyonApp.DAL;

namespace OtelOtomasyonAppBLL
{
    public class LinkedMusteri
    {
        public MusteriNode Head;
        public int Size = 0;
        public void InsertFirst(MusteriBilgi musteri)
        {
            MusteriNode tmpHead = new MusteriNode
            {
                musteriBilgi = musteri
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }
        public void InsertLast(MusteriBilgi musteri)
        {
            //Eski sonuncu PersonelNode, Head'den başlanarak set ediliyor
            MusteriNode oldLast = Head;
            if (Head == null)
                //Hiç kayıt eklenmediği için InsertFirst çağrılabilir
                InsertFirst(musteri);
            else
            {
                //Yeni sonuncu PersonelNode yaratılıyor
                MusteriNode newLast = new MusteriNode
                {
                    musteriBilgi = musteri
                };
                //Eski sonuncu PersonelNode bulunuyor
                //Tail olsaydı sonuncuyu bulmaya gerek yoktu.
                while (oldLast.Next != null)
                {
                    oldLast = oldLast.Next;
                }
                //Eski sonuncu PersonelNode referansı artık yeni sonuncu PersonelNode'u gösteriyor
                oldLast.Next = newLast;
                //Bağlı listedeki eleman sayısı bir arttı
                Size++;
            }
        }

        List<MusteriBilgi> listMusteriBilgi = new List<MusteriBilgi>();
        MusteriDAL mdal = new MusteriDAL();
        MusteriBilgi musteri = new MusteriBilgi();
        public void MusteriOtelBilgiEkle()
        {
            listMusteriBilgi = mdal.GetAllMusteri(musteri);
            for (int i = 0; i < listMusteriBilgi.Count; i++)
            {
                InsertLast(listMusteriBilgi[i]);
            }
        }
    }
}
