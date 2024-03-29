﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            decimal corbaFiyat = 75;
            decimal salataFiyat = 100;
            decimal anaYemekFiyat =200;
            decimal tatliFiyat =120;

            decimal toplamtutar = 0;

            if (tabControl1.SelectedIndex == 2)
            {
                string ad = txtAdSoyad.Text;
                string telefon = txtTelefon.Text;
                decimal corbaToplam = 0;
                decimal salataToplam = 0;
                decimal anaYemekToplam = 0;
                decimal tatliToplam = 0;

                if (nCorba.Value > 0)
                {
                    corbaToplam = nCorba.Value * corbaFiyat;
                    toplamtutar += corbaToplam;
                }
                if (nSalata.Value > 0)
                {
                    salataToplam = nSalata.Value * salataFiyat;
                    toplamtutar += salataToplam;
                }
                if (nYemek.Value > 0)
                {
                    anaYemekToplam = nYemek.Value * anaYemekFiyat;
                    toplamtutar += anaYemekToplam;
                }
                if (nTatlı.Value > 0)
                {
                    tatliToplam = nTatlı.Value * tatliFiyat;
                    toplamtutar += tatliToplam;
                }

                lblHesap.Text = String.Format("Ad: {0}\nTelefon: {1}\n\n" +
                     "================================\n" +
                    "{2} x Çorba = {3}\n" +
                     "{4} x Salata = {5}\n" +
                     "{6} x Ana Yemek = {7}\n" +
                    "{8} x Tatlı = {9}\n" +
                     "=================================\n" +
                    "Toplam Fiyat: {10}\n" +
                   "=================================\n" +
                    "Afiyet olsun. Teşekkür Ederiz.",
                     ad,
                     telefon,
                     nCorba.Value,
                     corbaToplam,
                     nSalata.Value,
                     salataToplam,
                     nYemek.Value,
                     anaYemekToplam,
                     nTatlı.Value,
                     tatliToplam,
                     toplamtutar);



            }

        }
    }
}  
        

    
