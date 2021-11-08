using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyukUnluUyumuKontrol
{
    public partial class frm_kontrol : Form
    {
        public frm_kontrol()
        {
            InitializeComponent();
        }

        char[] kalinHarfler = new char[] { 'a', 'ı', 'u', 'o' };
        char[] inceHarfler = new char[] { 'e', 'i', 'ö', 'ü' };

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            string kelime = tbx_kelime.Text.ToString();
            Kontrol(kelime);
        }

        string kontrolMetin = "bos";

        private void Kontrol(string kelime)
        {
            lbox_ince.Items.Clear();
            lbox_kalin.Items.Clear();
            string[] cumle = kelime.Split(' ');
            foreach (var secilenKelime in cumle)
            {
                foreach (var item in secilenKelime)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (item == kalinHarfler[i])
                        {
                            if (kontrolMetin == "ince")
                            {
                                kontrolMetin = "uyumsuz";
                            }
                            else
                            {
                                kontrolMetin = "kalin";
                            }
                        }

                        if (item == inceHarfler[i])
                        {
                            if (kontrolMetin == "kalin")
                            {
                                kontrolMetin = "uyumsuz";
                            }
                            else
                            {
                                kontrolMetin = "ince";
                            }
                        }
                    }
                }

                if (kontrolMetin == "kalin")
                {
                    lbox_kalin.Items.Add(secilenKelime);
                }
                else if (kontrolMetin == "ince")
                {
                    lbox_ince.Items.Add(secilenKelime);
                }
            }

        }
    }
}
