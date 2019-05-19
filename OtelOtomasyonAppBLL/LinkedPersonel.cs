using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelOtomasyonApp.Entity;
using OtelOtomasyonApp.DAL;
namespace OtelOtomasyonAppBLL
{
   public class LinkedPersonel
    {
        public PersonelNode Head;
        public int Size = 0;
        public  void InsertFirst(PersonelBilgi personel)
        {
            PersonelNode tmpHead = new PersonelNode
            {
                personelBilgi = personel
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
        public  void InsertLast(PersonelBilgi personel)
        {
            //Eski sonuncu PersonelNode, Head'den başlanarak set ediliyor
            PersonelNode oldLast = Head;
            if (Head == null)
                //Hiç kayıt eklenmediği için InsertFirst çağrılabilir
                InsertFirst(personel);
            else
            {
                //Yeni sonuncu PersonelNode yaratılıyor
                PersonelNode newLast = new PersonelNode
                {
                    personelBilgi = personel
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
        public  void DeleteFirst()
        {
            if (Head != null)
            {
                //Head'in next'i HeadNext'e atanıyor
                PersonelNode tempHeadNext = this.Head.Next;
                //HeadNext null ise zaten tek kayıt olan Head silinir.
                if (tempHeadNext == null)
                    Head = null;
                else
                    //HeadNext null değilse yeni Head, HeadNext olur.
                    Head = tempHeadNext;
                //Listedeki eleman sayısı bir azaltılıyor
                Size--;
            }
        }
        public  void DeleteLast()
        {
            //Last PersonelNode bulunup NULL yapılacak
            PersonelNode lastPersonelNode = Head;
            //Last PersonelNode'dan bir önceki PersonelNode'un Next'i null olacak
            PersonelNode lastPrevPersonelNode = null;
            while (lastPersonelNode.Next != null)
            {

                lastPrevPersonelNode = lastPersonelNode;
                lastPersonelNode = lastPersonelNode.Next;

            }
            //Listedeki eleman sayısı bir azaltılıyor
            Size--;
            //Last PersonelNode null oldu
            lastPersonelNode = null;

            //Last PersonelNode'dan önceki PersonelNode varsa onun next'i null olacak yoksa zaten tek kayıt vardır, 
            //o da Head'dir, o da null olacak
            if (lastPrevPersonelNode != null)
                lastPrevPersonelNode.Next = null;
            else
                Head = null;
        }
        public  PersonelNode GetElement(string departman,string otelAdi)
        {
            //Geri dönülecek eleman
            PersonelNode retPersonelNode = null;
            //Head'den başlanarak Next PersonelNode'a gidilecek
            PersonelNode tempPersonelNode = Head;
            int count = 0;
            while (tempPersonelNode != null)
            {
                if (personel.personelDepartmant==departman && personel.personelOtel== otelAdi)
                {
                    
                }
                //Next PersonelNode'a git
                tempPersonelNode = tempPersonelNode.Next;
                count++;
            }
            return retPersonelNode;
        }
        public List<PersonelBilgi> FindNode(string departman, string otelAdi)
        {
            PersonelNode tempPersonelNode = Head;
            List<PersonelBilgi> pOteldeCalısan = new List<PersonelBilgi>();
            while (tempPersonelNode != null)
            {
                
                if (tempPersonelNode.personelBilgi.personelDepartmant == departman && tempPersonelNode.personelBilgi.personelOtel == otelAdi)
                {
                    pOteldeCalısan.Add(tempPersonelNode.personelBilgi);
                }
                //Next PersonelNode'a git
                tempPersonelNode = tempPersonelNode.Next;
            }
            return pOteldeCalısan;
        }
        public PersonelBilgi EnYüksekPuan(string otelAdi)
        {
            PersonelNode tempPersonelNode = Head;
            PersonelBilgi maxPuanlıPersonel =null;
            int maxPuan = 0;
            while (tempPersonelNode != null)
            {

                if (maxPuan <tempPersonelNode.personelBilgi.personelPuan && tempPersonelNode.personelBilgi.personelOtel == otelAdi)
                {
                    maxPuan = tempPersonelNode.personelBilgi.personelPuan;
                    maxPuanlıPersonel = tempPersonelNode.personelBilgi;
                }
                //Next PersonelNode'a git
                tempPersonelNode = tempPersonelNode.Next;
            }
            return maxPuanlıPersonel;
        } 
        public  string DisplayElements()
        {
            string temp = "";
            PersonelNode item = Head;
            while (item != null)
            {
                temp += "-->" + item.personelBilgi;
                item = item.Next;
            }

            return temp;
        }
        List<PersonelBilgi> listPersonelBilgi = new List<PersonelBilgi>();
        PersonelDAL pdal = new PersonelDAL();
        PersonelBilgi personel = new PersonelBilgi();
        public void PersonelEkle()
        {
            listPersonelBilgi = pdal.GetAllPersonel(personel);
            for (int i = 0; i < listPersonelBilgi.Count; i++)
            {
                InsertLast(listPersonelBilgi[i]);
            }
        }

        
    }
}
