using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RekenamchineLogica;

namespace RekenmachineForm
{
    public partial class Form1 : Form
    {
        public void GetalInput(Button button)
        {
            textBox1.Text += button.Text;
            textBox2.Text += button.Text;
        }
        double eersteGetal = 0;
        string teken = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            GetalInput(button10);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            GetalInput(button9);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            GetalInput(button6);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            GetalInput(button8);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GetalInput(button4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            GetalInput(button5);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            GetalInput(button7);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GetalInput(button1);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            GetalInput(button2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            GetalInput(button3);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Convert.ToString(Class1.Berekenen(eersteGetal, double.Parse(textBox1.Text), teken));
                eersteGetal = 0;
                teken = "";
                textBox2.Text = textBox1.Text;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (teken == "")
                {
                    eersteGetal = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    teken = "+";
                    textBox2.Text += "+";
                }
                else
                {
                    eersteGetal = Class1.Berekenen(eersteGetal, double.Parse(textBox1.Text), teken);
                    textBox1.Clear();
                    teken = "+";
                    textBox2.Text = eersteGetal + "+";
                }
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            eersteGetal = 0;
            teken = "";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (teken == "")
                {
                    eersteGetal = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    teken = "*";
                    textBox2.Text += "*";
                }
                else
                {
                    eersteGetal = Class1.Berekenen(eersteGetal, double.Parse(textBox1.Text), teken);
                    textBox1.Clear();
                    teken = "*";
                    textBox2.Text = eersteGetal + "*";
                }
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (teken == "")
                {
                    eersteGetal = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    teken = "/";
                    textBox2.Text += "/";
                }
                else
                {
                    eersteGetal = Class1.Berekenen(eersteGetal, double.Parse(textBox1.Text), teken);
                    textBox1.Clear();
                    teken = "/";
                    textBox2.Text = eersteGetal + "/";
                }
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (teken == "")
                {
                    eersteGetal = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    teken = "-";
                    textBox2.Text += "-";
                }
                else
                {
                    eersteGetal = Class1.Berekenen(eersteGetal, double.Parse(textBox1.Text), teken);
                    textBox1.Clear();
                    teken = "-";
                    textBox2.Text = textBox2.Text + "-";
                }
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) * double.Parse(textBox1.Text));
                textBox2.Text += "²";
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(double.Parse(textBox1.Text)));
                textBox2.Text += "√";
            }
        }
    }
}
