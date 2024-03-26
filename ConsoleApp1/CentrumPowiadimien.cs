using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsoleApp1
{
    public partial class CentrumPowiadimien : Form
    {
        public CentrumPowiadimien()
        {
            InitializeComponent();
        }
        delegate void naszDelegata(string wiadomosc);
        naszDelegata naszaZmienna;

        private void send(object sender, EventArgs e)
        {
            if (naszaZmienna != null)
            {
                naszaZmienna(textBox1.Text);
            }
        }

        void DodanieInforamcjiDoOkienkaPolicji(String dane)
        {
            MojePoleTextoweDlaPolicji.Text += dane + "\r\n";
        }
        void DodanieInforamcjiDoOkienkaPogotowia(String dane)
        {
            MojePoleTextoweDlaPogotowia.Text += dane + "\r\n";
        }
        void DodanieInforamcjiDoOkienkaStrazy(String dane)
        {
            MojePoleTextoweDlaStrazy.Text += dane + "\r\n";
        }

        private void add_pol(object sender, EventArgs e)
        {
            naszaZmienna += DodanieInforamcjiDoOkienkaPolicji;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_pol(object sender, EventArgs e)
        {
            naszaZmienna -= DodanieInforamcjiDoOkienkaPolicji;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_pog(object sender, EventArgs e)
        {
            naszaZmienna += DodanieInforamcjiDoOkienkaPogotowia;
        }

        private void del_pog(object sender, EventArgs e)
        {
            naszaZmienna -= DodanieInforamcjiDoOkienkaPogotowia;
        }

        private void add_str(object sender, EventArgs e)
        {
            naszaZmienna += DodanieInforamcjiDoOkienkaStrazy;
        }

        private void del_str(object sender, EventArgs e)
        {
            naszaZmienna -= DodanieInforamcjiDoOkienkaStrazy;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void usun(object sender, EventArgs e)
        {
            MojePoleTextoweDlaPolicji.Clear();
            MojePoleTextoweDlaPogotowia.Clear();
            MojePoleTextoweDlaStrazy.Clear();
        }
    }
}
