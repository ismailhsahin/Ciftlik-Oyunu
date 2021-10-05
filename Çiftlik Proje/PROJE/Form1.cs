/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:PROJE
**				ÖĞRENCİ ADI............:İSMAİL HAKKI ŞAHİN
**				ÖĞRENCİ NUMARASI.......:G181210099
**              DERSİN ALINDIĞI GRUP...:2-A
****************************************************************************/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PROJE
{
    


    public partial class Form1 : Form
    {
        
        Tavuk t = new Tavuk();
        Ordek o = new Ordek();
        Inek i = new Inek();
        Keci k = new Keci();
        SoundPlayer tses = new SoundPlayer("tavuk.wav");
        SoundPlayer oses = new SoundPlayer("ordek.wav");
        SoundPlayer ises = new SoundPlayer("inek.wav");
        SoundPlayer kses = new SoundPlayer("keci.wav");
        int kasapara = 0;
        int saniye;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
           
            saniye++;
            label2.Text = Convert.ToString(saniye);
            //tavuk
            t.SaniyeAl = Convert.ToInt32(label2.Text);
            t.Cani = Tavukenerji.Value;
            Tavukenerji.Value = t.Oldur();
            tavukürün.Text = Convert.ToString(t.UrunAdet());
            if (Tavukenerji.Value < 1)
            {
                textBox9.Text = "ÖLÜ";
                if (t.Canlilik)
                {
                    tses.Play();
                    t.Canlilik = false;
                }
            }
            //ördek
            o.SaniyeAl = Convert.ToInt32(label2.Text);
            o.Cani = ördekenerji.Value;
            ördekenerji.Value = o.Oldur();
            ördekürün.Text = Convert.ToString(o.UrunAdet());
            if (ördekenerji.Value < 1)
            {
                textBox10.Text = "ÖLÜ";
                if (o.Canlilik)
                {
                    oses.Play();
                    o.Canlilik = false;
                }
            }
            //inek
            i.SaniyeAl = Convert.ToInt32(label2.Text);
            i.Cani = inekenerji.Value;
            inekenerji.Value = i.Oldur();
            inekürün.Text = Convert.ToString(i.UrunAdet());
            if (inekenerji.Value < 1)
            {
                textBox12.Text = "Ölü";
                if (i.Canlilik)
                {
                    ises.Play();
                    i.Canlilik = false;
                }
            }
            //keçi
            k.SaniyeAl = Convert.ToInt32(label2.Text);
            k.Cani = keçienerji.Value;
            keçienerji.Value = k.Oldur();
            keçiürün.Text = Convert.ToString(k.UrunAdet());
            if (keçienerji.Value < 1)
            {
                textBox13.Text = "Ölü";
                if (k.Canlilik)
                {
                    kses.Play();
                    k.Canlilik = false;
                }
            }
        }

        private void tavukyem_Click(object sender, EventArgs e)
        {
            if (Tavukenerji.Value > 0)
                Tavukenerji.Value = Tavukenerji.Maximum;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (inekenerji.Value > 0)
                inekenerji.Value = inekenerji.Maximum;
        }

        private void ördekyem_Click(object sender, EventArgs e)
        {
            if (ördekenerji.Value > 0)
                ördekenerji.Value = ördekenerji.Maximum;
        }

        private void keçiyem_Click(object sender, EventArgs e)
        {
            if (keçienerji.Value > 0)
                keçienerji.Value = keçienerji.Maximum;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            kasapara = Convert.ToInt32(label1.Text) + t.Kasa();
            label1.Text = Convert.ToString(kasapara);
            tavukürün.Text = t.YumurtaAdet.ToString();
            
        }

        private void ördekyumurtasat_Click(object sender, EventArgs e)
        {
            kasapara = Convert.ToInt32(label1.Text) + o.Kasa();
            label1.Text = Convert.ToString(kasapara);
            ördekürün.Text = o.OYumurtaAdet.ToString();
        }

        private void ineksütsat_Click(object sender, EventArgs e)
        {
            kasapara = Convert.ToInt32(label1.Text) + i.Kasa();
            label1.Text = Convert.ToString(kasapara);
            inekürün.Text = i.SutKg.ToString();
        }

        private void keçisütsat_Click(object sender, EventArgs e)
        {
            kasapara = Convert.ToInt32(label1.Text) + k.Kasa();
            label1.Text = Convert.ToString(kasapara);
            keçiürün.Text = i.SutKg.ToString();
        }

       
    }
   
    
}
