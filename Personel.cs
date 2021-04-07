using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIoWinForm
{
   public  class Personel
    {
        public int id { get; set; }

        public string isim { get; set; }

        public string soyisim { get; set; }

        public string emailAdres { get; set; }

        public string firmaAdi { get; set; }

        public string ulke { get; set; }

        public override string ToString()
        {
            return isim + "" + soyisim;
        }

        public string personelBilgiGetir()
        {
            return string.Format("isim:{0} soyisim:{1} email:{2} firmaadi:{3} ulke:{4} ", isim, soyisim, emailAdres, firmaAdi, ulke);
        }

    }
}
