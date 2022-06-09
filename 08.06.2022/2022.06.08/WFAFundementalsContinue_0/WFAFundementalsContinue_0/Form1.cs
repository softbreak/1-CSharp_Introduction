using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAFundementalsContinue_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // txtGiris.Text = "Hello World";

            // MessageBox.Show(txtGiris.Text);

            // string veri = txtGiris.Text;

            //Kullanıcıdan gelen string bir tipi siz farklı bir tipte almak isteyebilirsiniz

            // int16 short , int32 => int , int64 long

            int sayi = Convert.ToInt32(txtGiris.Text);

            int sonuc = sayi + sayi;

            MessageBox.Show(sonuc.ToString());

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {

            try
            {

                


                int sayi1 = Convert.ToInt32(txtGiris.Text);
                int sayi2 = Convert.ToInt32(txtGiris2.Text);

                int sonuc = sayi1 + sayi2;
                //int sonuc2 = sayi1 - sayi2;
                //int sonuc3 = sayi1 * sayi2;
                //int sonuc4 = sayi1 / sayi2;


                //double doubleSayi = 1.5;

                //double ondalikliSayi = Convert.ToDouble(txtGiris.Text);

                //byte byteSayi = Convert.ToByte(txtGiris.Text);

                //float floatSayi = Convert.ToSingle(txtGiris.Text);

                MessageBox.Show(sonuc.ToString());


            }
            catch
            {
                MessageBox.Show("Arkadasım düzgün formatta yaz lütfen...");
            }




        }
    }
}
