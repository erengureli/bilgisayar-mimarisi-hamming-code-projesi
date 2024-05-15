namespace BilgisayarMimarisi
{
    public partial class MainForm : Form
    {
        public int dataLength = 0;
        public int maxLength = 0;
        public int maxX = 0;

        private TextBox[] bits;

        public MainForm()
        {
            InitializeComponent();

            // 4-8-16'lik secim formunu gosteriyor
            BitForm bitForm = new BitForm(this);
            bitForm.TopMost = true;
            bitForm.Show();
        }

        public void applyData() // 4-8-16'dan birini secince TextBox'lari olusturan fonksiyon
        {
            TextBox textBox;
            bits = new TextBox[this.maxLength];
            writeTextBox.MaxLength = this.dataLength;

            int i = 1, p = 1, d = 1;
            while (i <= this.maxLength)
            {
                textBox = new TextBox();
                textBox.MaxLength = 1;
                textBox.TextAlign = HorizontalAlignment.Center;
                textBox.Text = "0";
                textBox.Size = new Size(27, 27);
                textBox.TabIndex = this.maxLength - i;
                textBox.Location = new Point(this.maxX - i * 30, 26);

                if (isP(i))
                {
                    textBox.ForeColor = Color.Blue;
                    textBox.Name = "p" + p;
                    p++;
                }
                else
                {
                    textBox.Name = "d" + d;
                    d++;
                }

                textBox.TextChanged += new System.EventHandler(dataChanged);
                bits[i - 1] = textBox;
                ramBox.Controls.Add(textBox);

                i++;
            }

        }

        private bool isP(int i) // Girilen sayinin 2^n olup olmadigini hesapliyor ona gore true donduruyor
        {
            bool ret = true;

            while (i != 1)
            {
                if (i % 2 != 0)
                {
                    ret = false;
                    break;
                }
                i = i / 2;
            }

            return ret;
        }

        private void dataChanged(object sender, EventArgs e) // RAM kismindeki TextBox'lardaki degerler degisince kontrol ediyor
        {
            TextBox textBox = (TextBox)sender;
            if (textBox != null)
            {
                // TextBox'in icindeki deger 0,1 den farkliysa 0 yapiyor
                if (textBox.Text != "0" && textBox.Text != "1")
                {
                    textBox.Text = "0";
                }
            }
        }

        private void writeButton_Click(object sender, EventArgs e) // Write buttonuna tiklandigi zaman RAM kismina verileri ekliyor
        {

            // Girdileri kontrol ediyor
            if (writeTextBox.Text.Length != dataLength) return;
            for (int i = 0; i < this.dataLength; i++) if (writeTextBox.Text[i] != '0' && writeTextBox.Text[i] != '1') return;
            

            // Hamming kod'u hesapliyor
            int hammingCode = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i].Name.Contains('d'))
                {
                    bits[i].Text = writeTextBox.Text[writeTextBox.Text.Length - Int32.Parse(bits[i].Name.Substring(1, bits[i].Name.Length - 1).PadLeft(bits[i].Name.Length + 1, '0'))].ToString();

                    if (bits[i].Text == "1")
                    {
                        hammingCode ^= (i + 1);
                    }
                }
            }

            // Hamming kod'u string'e ceviriyor ve TextBox'lara atiyor
            string hammingCodeStr = Convert.ToString(hammingCode, 2).PadLeft(this.maxLength - this.dataLength, '0');
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i].Name.Contains("p"))
                {
                    bits[i].Text = hammingCodeStr[hammingCodeStr.Length - Int32.Parse(bits[i].Name.Substring(1, bits[i].Name.Length - 1).PadLeft(bits[i].Name.Length + 1, '0'))].ToString();
                }
            }

            // TextBox'u sifirliyor
            writeTextBox.Text = "";

        }

        private void readButton_Click(object sender, EventArgs e) // 
        {

            // Kayitli hamming code'u aliyor
            string oldHammingCode = "";
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i].Name.Contains("p"))
                {
                    oldHammingCode = oldHammingCode.PadLeft(oldHammingCode.Length + 1, bits[i].Text[0]);
                }
            }

            // Syndrome kod'u hesapliyor
            int syndromeCode = Convert.ToInt32(oldHammingCode, 2);
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i].Name.Contains('d') && bits[i].Text == "1")
                {
                    syndromeCode ^= (i + 1);
                }
            }

            // Syndrome kod'u form'a ekliyor
            syndromeLabel.Text = "Syndrome : " + Convert.ToString(syndromeCode, 2).PadLeft(maxLength-dataLength, '0') + " -> " + syndromeCode.ToString();


            // Syndrome kod'una bakarak hatali biti degistiriyor
            if(syndromeCode != 0) bits[syndromeCode - 1].Text = (bits[syndromeCode - 1].Text == "1") ? "0" : "1";

            // Data ve Hamming kismini yazdirir
            dataLabel.Text = "Data : ";
            hammingLabel.Text = "Hamming : ";
            for(int i = maxLength-1;  i >= 0; i--)
            {
                if (bits[i].Name.Contains('d'))
                {
                    dataLabel.Text += bits[i].Text;
                }
                else
                {
                    hammingLabel.Text += bits[i].Text;
                }
            }

        }
    }
}
