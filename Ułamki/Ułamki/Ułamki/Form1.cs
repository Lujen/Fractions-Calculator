using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ułamki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox3.Text=="")
            {
                MessageBox.Show("Podaj licznik!");
                return;
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            if(textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            if(textBox2.Text=="0" || textBox2.Text=="" || textBox4.Text=="0" || textBox4.Text=="")
            {
                MessageBox.Show("Błędny mianownik!");
                return;
            }
                int licznik = int.Parse(textBox1.Text);
                int mianownik = int.Parse(textBox2.Text);
                int licznik2 = int.Parse(textBox3.Text);
                int mianownik2 = int.Parse(textBox4.Text);
                int calosc = int.Parse(textBox8.Text);
                int calosc2 = int.Parse(textBox9.Text);
                int L_wynik = (((calosc * mianownik) + licznik) * mianownik2) + (mianownik * (licznik2 + (calosc2 * mianownik2)));
                int M_wynik = (mianownik * mianownik2);
                int C_wynik=0;
            if (L_wynik >= M_wynik)
            {
                C_wynik = L_wynik / M_wynik;
                L_wynik = L_wynik % M_wynik;

                int a = L_wynik;
                int b = M_wynik;
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                L_wynik = L_wynik / a;
                M_wynik = M_wynik / a;
            }

            textBox5.Text = L_wynik.ToString();
                textBox6.Text = M_wynik.ToString();
                textBox10.Text = C_wynik.ToString();
                textBox7.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Podaj licznik!");
                return;
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            if (textBox2.Text == "0" || textBox2.Text == "" || textBox4.Text == "0" || textBox4.Text == "")
            {
                MessageBox.Show("Błędny mianownik!");
                return;
            }
            int licznik = int.Parse(textBox1.Text);
            int mianownik = int.Parse(textBox2.Text);
            int licznik2 = int.Parse(textBox3.Text);
            int mianownik2 = int.Parse(textBox4.Text);
            int calosc = int.Parse(textBox8.Text);
            int calosc2 = int.Parse(textBox9.Text);
            int L_wynik = (((calosc*mianownik) + licznik) * mianownik2) - (mianownik * (licznik2+(calosc2*mianownik2)));
            int M_wynik = (mianownik * mianownik2);
            int C_wynik = 0;
            if (L_wynik >= M_wynik)
            {
                C_wynik = L_wynik / M_wynik;
                L_wynik = L_wynik % M_wynik;

                int a = L_wynik;
                int b = M_wynik;
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                L_wynik = L_wynik / a;
                M_wynik = M_wynik / a;
            }
                textBox5.Text = L_wynik.ToString();
            textBox6.Text = M_wynik.ToString();
            textBox10.Text = C_wynik.ToString();
            textBox7.Text = "-";
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Podaj licznik!");
                return;
            }
            if (textBox8.Text == "")
                {
                    textBox8.Text = "0";
                }
            if (textBox9.Text == "")
                {
                    textBox9.Text = "0";
                }
            if (textBox2.Text == "0" || textBox2.Text == "" || textBox4.Text == "0" || textBox4.Text == "")
                {
                    MessageBox.Show("Błędny mianownik!");
                    return;
                }
                int licznik = int.Parse(textBox1.Text);
                int mianownik = int.Parse(textBox2.Text);
                int licznik2 = int.Parse(textBox3.Text);
                int mianownik2 = int.Parse(textBox4.Text);
                int calosc = int.Parse(textBox8.Text);
                int calosc2 = int.Parse(textBox9.Text);
                int L_wynik = (((calosc*mianownik) + licznik) * (licznik2+(calosc2*mianownik2)));
                int M_wynik = (mianownik * mianownik2);
            int C_wynik = 0;
            if (L_wynik >= M_wynik)
            {
                C_wynik = L_wynik / M_wynik;
                L_wynik = L_wynik % M_wynik;

                int a = L_wynik;
                int b = M_wynik;
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                L_wynik = L_wynik / a;
                M_wynik = M_wynik / a;
            }
                textBox5.Text = L_wynik.ToString();
            textBox6.Text = M_wynik.ToString();
            textBox10.Text = C_wynik.ToString();
            textBox7.Text = "*";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Podaj licznik!");
                return;
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            if (textBox2.Text == "0" || textBox2.Text == "" || textBox4.Text == "0" || textBox4.Text == "")
            {
                MessageBox.Show("Błędny mianownik!");
                return;
            }
            int licznik = int.Parse(textBox1.Text);
            int mianownik = int.Parse(textBox2.Text);
            int licznik2 = int.Parse(textBox3.Text);
            int mianownik2 = int.Parse(textBox4.Text);
            int calosc = int.Parse(textBox8.Text);
            int calosc2 = int.Parse(textBox9.Text);
            int L_wynik = (((calosc * mianownik) + licznik) * mianownik2);
            int M_wynik = (mianownik * (licznik2 + (calosc2 * mianownik2)));
            int C_wynik = 0;
            if (L_wynik >= M_wynik)
            {
                C_wynik = L_wynik / M_wynik;
                L_wynik = L_wynik % M_wynik;

                int a = L_wynik;
                int b = M_wynik;
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                L_wynik = L_wynik / a;
                M_wynik = M_wynik / a;
            }
                textBox5.Text = L_wynik.ToString();
            textBox6.Text = M_wynik.ToString();
            textBox10.Text = C_wynik.ToString();
            textBox7.Text = "/";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
