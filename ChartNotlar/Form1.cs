using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartNotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("Dersin Final Sonucu");
            this.chart1.Series["Not"].Points.AddXY("AA",textBox1.Text); //aa
            this.chart1.Series["Not"].Points.AddXY("BA",textBox2.Text); //ba
            this.chart1.Series["Not"].Points.AddXY("BB", textBox3.Text); //bb
            this.chart1.Series["Not"].Points.AddXY("CB", textBox4.Text); //cb
            this.chart1.Series["Not"].Points.AddXY("CC", textBox5.Text); //cc
            this.chart1.Series["Not"].Points.AddXY("DC", textBox6.Text); //dc
            this.chart1.Series["Not"].Points.AddXY("DD", textBox7.Text); //dd
            this.chart1.Series["Not"].Points.AddXY("FD", textBox8.Text); //fd
            this.chart1.Series["Not"].Points.AddXY("FF", textBox9.Text); //ff


            int a1, a2, a3, a4, a5, a6, a7, a8, a9,toplam;
            a1 = Convert.ToInt32(textBox1.Text);
            a2 = Convert.ToInt32(textBox2.Text);
            a3 = Convert.ToInt32(textBox3.Text);
            a4 = Convert.ToInt32(textBox4.Text);
            a5 = Convert.ToInt32(textBox5.Text);
            a6 = Convert.ToInt32(textBox6.Text);
            a7 = Convert.ToInt32(textBox7.Text);
            a8 = Convert.ToInt32(textBox8.Text);
            a9 = Convert.ToInt32(textBox9.Text);

            toplam = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9;
            label11.Text = toplam.ToString();
        }
    }
}
