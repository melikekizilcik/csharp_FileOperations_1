using System.IO;

namespace FileOperations_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKonumSec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnOpenFileDialog_Clik(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            label1.Text = openFileDialog.FileName;


        }

        private void btnSaveFileDialog_Clik(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

        }


        string BelgeYolu, BelgeAdi;
        private void btnKonum_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                BelgeYolu = folderBrowserDialog1.SelectedPath;
                textYol.Text = BelgeYolu;
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            BelgeAdi = textAd.Text;
            StreamWriter streamWriter = File.CreateText(BelgeYolu + "\\" + BelgeAdi + ".txt");
            MessageBox.Show("Belgeniz baþarýyla oluþturuldu.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                string satir = reader.ReadLine();
                while (satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = reader.ReadLine();
                }

            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "Metin Belgesi | *.txt"; 
            StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
            writer.WriteLine(richTextBox1.Text);
            writer.Close();
            MessageBox.Show("Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
