using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrolka.Text = kontrolka.Text + "1";
            wynik.Text = wynik.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrolka.Text = kontrolka.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kontrolka.Text = kontrolka.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kontrolka.Text = kontrolka.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kontrolka.Text = kontrolka.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kontrolka.Text = kontrolka.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kontrolka.Text = kontrolka.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kontrolka.Text = kontrolka.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kontrolka.Text = kontrolka.Text + "9";
        }
        int pamieckalulatora = 0;
        private void buttonSum_Click(object sender, EventArgs e)
        {
            int wpraowWarto = int.Parse(kontrolka.Text);
            pamieckalulatora += wpraowWarto;
            wynik.Text = pamieckalulatora.ToString() + "+";
            kontrolka.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int wpraowWarto = int.Parse(kontrolka.Text);
            pamieckalulatora -= wpraowWarto;
            wynik.Text = pamieckalulatora.ToString();
            kontrolka.Text = "";
        }

        private void buttonMnoz_Click(object sender, EventArgs e)
        {
            int wpraowWarto = int.Parse(kontrolka.Text);
            pamieckalulatora *= wpraowWarto;
            wynik.Text = pamieckalulatora.ToString();
            kontrolka.Text = "";
        }

        private void buttonDevid_Click(object sender, EventArgs e)
        {
            int wpraowWarto = int.Parse(kontrolka.Text);
            pamieckalulatora /= wpraowWarto;
            wynik.Text = pamieckalulatora.ToString();
            kontrolka.Text = "";
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            wynik.Text = pamieckalulatora.ToString();
        }
    }
}
