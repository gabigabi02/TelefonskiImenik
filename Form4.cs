using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TelefonskiImenik
{
    public partial class Form4 : Form
    {
        string path = "registracija.txt";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Nisu uneseni svi potrebni podatci!");
            }
            else
            {
                StreamReader sr = new StreamReader(path);
                string linija = sr.ReadLine();
                while (linija != null)
                {
                    string[] lin = linija.Split('|');
                    if (textBox1.Text == lin[0] && textBox2.Text == lin[1])
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        Form6 Form6 = new Form6();
                        Form6.ShowDialog();
                        this.Close();
                        break;
                    }
                    linija = sr.ReadLine();
                }

                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    MessageBox.Show("Vaši upisani podatci nisu pronađeni.\nDošlo je do pogreške pri upisu ili ako niste, trebate prvo izvršiti registraciju.");
                }
                sr.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
