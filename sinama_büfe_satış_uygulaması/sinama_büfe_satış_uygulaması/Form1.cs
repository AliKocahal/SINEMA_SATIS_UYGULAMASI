using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinama_büfe_satış_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, bilet, su, çay, toplam;
            mısır = Convert.ToInt16(TXTMISIR.Text);
            bilet = Convert.ToUInt16(TXTBİLET.Text);
            su = Convert.ToInt16(TXTSU.Text);
            çay = Convert.ToInt16(TXTÇAY.Text);

            toplam = mısır * 90 + su * 15 + çay * 20 + bilet * 130;
            label10.Text = toplam.ToString() + "  TL ";

            kasatutar = kasatutar + toplam;
            label12.Text = kasatutar.ToString() + "   TL";





        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXTBİLET.Text = "";
            TXTÇAY.Text = "";
            TXTMISIR.Text = "";
            TXTSU.Text = "";
            label10.Text = "00  TL";
            TXTMISIR.Focus();
        }
    }
}
