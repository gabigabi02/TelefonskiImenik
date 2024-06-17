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
    public partial class Form5 : Form
    {
        string path = "registracija.txt";
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text != textBoxPotvrdiLozinku.Text)
            {
                MessageBox.Show("Lozinka i potvrda lozinke se ne podudaraju!");
            }
            if (textBoxKorisnickoIme.Text == "" || textBoxLozinka.Text == "" || textBoxPotvrdiLozinku.Text == "")
            {

                MessageBox.Show("Nisu upisani svi traženi podatci!");
            }
            else
            {
                StreamReader sr = new StreamReader(path);
                string linija1 = sr.ReadLine();
                while (linija1 != null)
                {
                    string[] lin = linija1.Split('|');
                    if (textBoxKorisnickoIme.Text == lin[0])
                    {
                        textBoxKorisnickoIme.Text = "";
                        MessageBox.Show("Upisano korisničko ime već je iskorišteno i upotrebljeno.\nMolimo vas da smislite neko drugo korisničmo ime!");
                    }
                    linija1 = sr.ReadLine();
                }
                sr.Close();
                if (textBoxKorisnickoIme.Text != "")
                {
                    string linija2 = textBoxKorisnickoIme.Text + "|" + textBoxLozinka.Text;
                    StreamWriter sw = new StreamWriter(path, true);
                    sw.WriteLine(linija2);
                    //textBoxKorisnickoIme.Text = "";
                    //textBoxLozinka.Text = "";
                    //textBoxPotvrdiLozinku.Text = "";
                    MessageBox.Show("Podatci su spremljeni!");
                    sw.Close();
                    Form4 Form4 = new Form4();
                    Form4.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.ShowDialog();
            this.Close();
        }
    }
}
