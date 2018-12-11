using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class OdevForm : Form
    {
        public OdevForm()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }





        private void Form1_Load(object sender, EventArgs e)
        {
            Odev1();
            Odev3();
        }

        private void Odev3()
        {
            comBxYO.SelectedIndex = 0;
            comBxKutle.SelectedIndex = 0;
            comBxKutleHesSure.SelectedIndex = 0;
            comBxSureHesKutle.SelectedIndex = 0;

        }



        /*
         Ödev 1
         * Literatürde bilinen en büyük asal sayı nedir?
         */
        private void Odev1()
        {
            richTxBxOdev1Sonuc.SelectionAlignment = HorizontalAlignment.Center;
            richTxBxOdev1Sonuc.Text += @"The largest known prime number (as of November 2018) is " +
                                        Environment.NewLine + "2^77,232,917 - 1" +
                                        Environment.NewLine +
                                        "A number with 23,249,425 digits." + Environment.NewLine +
                                        "It was found by the Great Internet  Mersenne Prime Search (GIMPS) in 2017." + Environment.NewLine +
                                             "Kaynak : wikipedia";
        }
        //Ödev 1 Sonu


        /*
         Ödev 2 
         Modulo n için toplamsal ve çarpımsal tersleri gösteren tablo
         */
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int mod = 0;
            try
            {
                mod = Convert.ToInt32(txBxMod.Text);
            }
            catch
            {
                MessageBox.Show("Tablosu hesaplanacak modulus değerini giriniz", "HATA!");
            }
            TabloHesapla(mod);
        }
        private void TabloHesapla(int modulus)
        {
            int w;
            int minus_w;
            dGvResult.Rows.Clear();
            foreach (DataGridViewColumn col in dGvResult.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            for (int i = 0; i < modulus; i++)
            {
                int inverse_w = 0;
                w = i % modulus;
                minus_w = Math.Abs(i - modulus) % modulus;
                for (int j = 0; j < modulus; j++)
                {
                    if ((i * j) % modulus == 1)
                        inverse_w = j;
                }
                string inverse = "YOK";
                if (inverse_w > 0)
                    inverse = inverse_w.ToString();
                dGvResult.Rows.Add(w.ToString(), minus_w.ToString(), inverse);
            }
        }
        //Ödev 2 Sonu



        /*
         * Ödev 3
         */

        //kalan yüzde hesabı
        private void rdBtnSureBul_CheckedChanged(object sender, EventArgs e)
        {
            pnlKutleHesabi.Visible = false;
            pnlSureHesabi.Visible = false;


            if (rdBtnKalanKutleBul.Checked)
                pnlKutleHesabi.Visible = true;
            if (rdBtnSureBul.Checked)
                pnlSureHesabi.Visible = true;
        }
       
        private void rdBtnSure2_CheckedChanged(object sender, EventArgs e)
        {
            txBxSureHesKutle.Visible = false;
            comBxSureHesKutle.Visible = false;
            lblYuzde.Visible = false;
            txBxSureHesKutleYuzdesi.Visible = false;

            //gececek süre hesabı kütleden hareketle
            if (rdBtnSure1.Checked)
            {
                txBxSureHesKutle.Visible = true;
                comBxSureHesKutle.Visible = true;
            }

            //gececek süre hesabı yüzdeden hareketle
            if (rdBtnSure2.Checked)
            {
                txBxSureHesKutleYuzdesi.Visible = true;
                lblYuzde.Visible = true;
            }
        }

        private void btnYarilanmaOmruHesapla_Click(object sender, EventArgs e)
        {
            double yarilanmaOmru = 0;
            double kutle = 0;

            try
            {
                yarilanmaOmru = Convert.ToDouble(txBxYarilanmaOmru.Text.Replace('.', ','));
                kutle = Convert.ToDouble(txBxKutle.Text);
                if (comBxYO.SelectedIndex == 0)
                    yarilanmaOmru *= 365.25;
                if (comBxKutle.SelectedIndex == 0)
                    kutle *= 1000;

              
                YarilanmaOmurHesabi(yarilanmaOmru,kutle);
            }
            catch
            {
                MessageBox.Show("Lütfen yarilanma ömrü ve kütle bilgilerini kontrol ediniz");
            }
        }

        private void YarilanmaOmurHesabi(double yarOmru,double kutle)
        {
            if (rdBtnKalanKutleBul.Checked)
            {
                double gececekSure = Convert.ToDouble(txBxKutleHesSure.Text);
                if (comBxKutleHesSure.SelectedIndex == 0)
                    gececekSure *= 365.25;
                double kalanOran = Math.Pow(2,gececekSure/yarOmru*(-1));
                double kalanKutle = kutle * kalanOran;

                lblKutleHesSonuc.Text=("Sonuç :Süre sonunda kalan kütle:" + kalanKutle.ToString("0.00") + "g, yüzdesi %" + (kalanOran*100).ToString("0.00"));
            }
            if (rdBtnSureBul.Checked)
            {
                double yuzde = 1;
                if (rdBtnSure1.Checked)
                {
                    yuzde = kutle / Convert.ToDouble(txBxSureHesKutle.Text);
                    if (comBxSureHesKutle.SelectedIndex == 0)
                        yuzde /= 1000;
                   
                }
                if (rdBtnSure2.Checked)
                {
                    yuzde =100/ Convert.ToDouble(txBxSureHesKutleYuzdesi.Text);
                    
                }
                
                double zaman = yarOmru* Math.Log(yuzde,2);
                lblSureHesSonuc.Text="Sonuç : "+zaman.ToString("0.00")+" Gun veya "+(zaman/365.25).ToString("0.00")+" Yıl";
            }
        }
        //Ödev 2 Sonu
    }
}
