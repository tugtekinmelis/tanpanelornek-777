﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tab_panel_ornek_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 2)
            {
                //2 -> Hesap Sekmesi // Elle + koymadım ENTER tuşuna bastım.
                decimal hesap = 0;
                String mesaj = $"Ad Soyad: {txtAdSoyad.Text}\r\n" +
                    $"Telefon: {txtTel.Text}\r\n" +
                    $"Adres: {txtAdres.Text}\r\n\r\n";

                if(nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 60;
                    mesaj += $"Çorba= {nCorba.Value * 60}\r\n";
                }

                if(nSalata.Value > 0)
                {
                    hesap +=nSalata.Value * 30;
                    mesaj += $"Salata= {nSalata.Value * 30}\r\n";
                }

                if(nAnaYemek.Value > 0)
                {
                    hesap += nAnaYemek.Value * 100;
                    mesaj += $"Ana Yemek= {nAnaYemek.Value * 100}\r\n";
                }

                if (nTatli.Value > 0)
                {
                    hesap += nTatli.Value * 50;
                    mesaj += $"Tatlı= {nTatli.Value * 50}\r\n";
                }

                mesaj += $"**************************\r\n";
                mesaj += $"Ödenecek Tutar:{hesap}";

                txtBilgi.Text = mesaj;
            }
        }
    }
}
