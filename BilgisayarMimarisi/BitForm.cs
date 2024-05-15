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

namespace BilgisayarMimarisi
{
    public partial class BitForm : Form
    {
        private MainForm mainForm;
        public BitForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            bitBox.SelectedIndex = 0;
        }

        private void selectButton_Click(object sender, EventArgs e) // Sec tusuna basinca form'u kapatiyor(Farkli bir taktik icin)
        {
            this.Close();
        }

        private void BitForm_FormClosing(object sender, FormClosingEventArgs e) // Eger form kapanirken kutudaki degerlerden biri secilmediyse kapatmayi engelliyor
        {
            if(bitBox.SelectedIndex == -1)
            {
                e.Cancel = true;
            }
        }

        private void BitForm_FormClosed(object sender, FormClosedEventArgs e) // Eger kutudaki deger de seciliyse MainForm'daki degerlerini atiyor
        {
            switch (Int32.Parse(bitBox.Text))
            {
                case 16:
                    mainForm.dataLength = 16;
                    mainForm.maxLength = 21;
                    mainForm.maxX = 690;
                    break;
                case 8:
                    mainForm.dataLength = 8;
                    mainForm.maxLength = 12;
                    mainForm.maxX = 560;
                    break;
                default:
                    mainForm.dataLength = 4;
                    mainForm.maxLength = 7;
                    mainForm.maxX = 480;
                    break;
            }
            mainForm.applyData(); // En sonunda degerler uygulansin diye MainForm'daki fonksiyon cagiriliyor
        }
    }
}
