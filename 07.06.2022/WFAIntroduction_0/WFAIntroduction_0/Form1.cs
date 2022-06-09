using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAIntroduction_0
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }




        private void btnGiris_Click(object sender, EventArgs e)
        {

            //Sayısal tip, mantıksal tip , metinsel tip,


            #region SayisalTiplerimiz

            //TamSayi
            //byte,sbyte,short,ushort,int, uint,long, ulong
            // 8   8      16       16   32   32   64   64
            //Ondalıklı Sayı
            //float,double,decimal 

            //32     64     128
            #endregion
            #region MetinselTipler

            //Metinsel tiplerimiz

            // string yazi = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //
            // string bilgi = "a";

            // char harf = 'a'; 
            #endregion

            #region MantiksalTip
            //Mantıksal Tip
            // bool 
            #endregion


            //int
            //double
            //string
            //bool




            #region Degiskenler
            string veri = "Hello World";


            int sayi = 3;

            double ondalikliSayi = 3.1;

            bool ehliyetVarmi = true;
            #endregion

            string gelenVeri = txtGiris.Text;

            MessageBox.Show("Hosgeldin " + gelenVeri);

           
        }

        private void txtGiris_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
