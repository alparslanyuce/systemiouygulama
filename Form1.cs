using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIoWinForm
{
    public partial class Form1 : Form
    {
        dataislemleri dataislemleri;
        List<Personel> personelListe;
       


        public Form1()
        {
            InitializeComponent();
            dataislemleri = new dataislemleri();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnpersonelgetir_Click(object sender, EventArgs e)
        {

         personelListe = dataislemleri.personelgetir(150);
            lstPersonel.DataSource = personelListe;







        }

        private void lstPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel secilenpersonel = (Personel)lstPersonel.SelectedItem;
            txtisim.Text = secilenpersonel.isim;
            txtsoyisim.Text = secilenpersonel.soyisim;
            txtemail.Text = secilenpersonel.emailAdres;
            txtfirma.Text = secilenpersonel.firmaAdi;
            txtulke.Text = secilenpersonel.ulke;




        }

        private void btnpersonelkaydet_Click(object sender, EventArgs e)
        {
            dataislemleri.personelkaydet("c:\\tasimaislemi", personelListe);
        }
    }
}
