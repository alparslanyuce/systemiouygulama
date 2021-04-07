using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIoWinForm
{
   public  class dataislemleri
    {

        public dataislemleri()
        {

        }

        public List<Personel> personelgetir(int adet)
        {
            List<Personel> personelListe = new List<Personel>();

            int sayac = 0;
            for(int i=0; i<=adet; i++)
            {
                Personel personel = new Personel();
                personel.id = sayac++;
                personel.isim = FakeData.NameData.GetFirstName();
                personel.soyisim = FakeData.NameData.GetSurname();
                personel.firmaAdi = FakeData.NetworkData.GetDomain();
                personel.emailAdres = personel.isim + "." + personel.soyisim + "@" + personel.firmaAdi;
                personel.ulke = FakeData.PlaceData.GetCountry();

                personelListe.Add(personel);



            }
            return personelListe;






        }

        public void personelkaydet(string path,List<Personel> personelListesi)
        {
            DirectoryInfo ulkebilgisi = null;
            for(int i=0; i < personelListesi.Count; i++)
            {
                if(Directory.Exists(path+"\\"+personelListesi[i].ulke))
                {
                    ulkebilgisi = new DirectoryInfo(path + "\\" + personelListesi[i].ulke);
                }

                else
                {
                   ulkebilgisi= Directory.CreateDirectory(path + "\\" + personelListesi[i].ulke);
                }


               FileStream fs= File.Create(ulkebilgisi.FullName +"\\"+ personelListesi[i].isim + "." + personelListesi[i].soyisim + ".txt");
                byte[] personelbilgi = new UTF8Encoding(true).GetBytes(personelListesi[i].personelBilgiGetir());
                fs.Write(personelbilgi,0,personelbilgi.Length);
                fs.Close();


            }
        }




    }
}
