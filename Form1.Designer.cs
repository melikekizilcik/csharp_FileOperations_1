
namespace FileOperations_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKonumSec = new Button();
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnOpenFileDialog = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnSaveFileDialog = new Button();
            textAd = new TextBox();
            label2 = new Label();
            btnKonum = new Button();
            btnOlustur = new Button();
            label3 = new Label();
            label4 = new Label();
            textYol = new TextBox();
            btnOku = new Button();
            listBox1 = new ListBox();
            btnYazdir = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnKonumSec
            // 
            btnKonumSec.Location = new Point(673, 31);
            btnKonumSec.Name = "btnKonumSec";
            btnKonumSec.Size = new Size(210, 53);
            btnKonumSec.TabIndex = 0;
            btnKonumSec.Text = "Folder Browser Dialog";
            btnKonumSec.UseVisualStyleBackColor = true;
            btnKonumSec.Click += btnKonumSec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 486);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Dialog Label";
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(673, 103);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(210, 53);
            btnOpenFileDialog.TabIndex = 2;
            btnOpenFileDialog.Text = "Open File Dialog";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Clik;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSaveFileDialog
            // 
            btnSaveFileDialog.Location = new Point(673, 175);
            btnSaveFileDialog.Name = "btnSaveFileDialog";
            btnSaveFileDialog.Size = new Size(210, 53);
            btnSaveFileDialog.TabIndex = 3;
            btnSaveFileDialog.Text = "Save File Dialog";
            btnSaveFileDialog.UseVisualStyleBackColor = true;
            btnSaveFileDialog.Click += btnSaveFileDialog_Clik;
            // 
            // textAd
            // 
            textAd.Location = new Point(153, 64);
            textAd.Name = "textAd";
            textAd.Size = new Size(299, 27);
            textAd.TabIndex = 4;
            textAd.TextChanged += textAd_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 8;
            // 
            // btnKonum
            // 
            btnKonum.Location = new Point(673, 248);
            btnKonum.Name = "btnKonum";
            btnKonum.Size = new Size(210, 53);
            btnKonum.TabIndex = 6;
            btnKonum.Text = "Konum Seç";
            btnKonum.UseVisualStyleBackColor = true;
            btnKonum.Click += btnKonum_Click;
            // 
            // btnOlustur
            // 
            btnOlustur.Location = new Point(673, 321);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(210, 53);
            btnOlustur.TabIndex = 7;
            btnOlustur.Text = "Oluştur";
            btnOlustur.UseVisualStyleBackColor = true;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 67);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 9;
            label3.Text = "Belge Adı:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 119);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 11;
            label4.Text = "Belge Yolu:";
            label4.Click += label4_Click;
            // 
            // textYol
            // 
            textYol.Location = new Point(153, 116);
            textYol.Name = "textYol";
            textYol.Size = new Size(299, 27);
            textYol.TabIndex = 10;
            textYol.TextChanged += textBox2_TextChanged;
            // 
            // btnOku
            // 
            btnOku.Location = new Point(673, 394);
            btnOku.Name = "btnOku";
            btnOku.Size = new Size(210, 53);
            btnOku.TabIndex = 12;
            btnOku.Text = "Oku";
            btnOku.UseVisualStyleBackColor = true;
            btnOku.Click += btnOku_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(69, 175);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(383, 84);
            listBox1.TabIndex = 13;
            // 
            // btnYazdir
            // 
            btnYazdir.Location = new Point(673, 470);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(210, 53);
            btnYazdir.TabIndex = 14;
            btnYazdir.Text = "Yazdır";
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(69, 265);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(383, 182);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(richTextBox1);
            Controls.Add(btnYazdir);
            Controls.Add(listBox1);
            Controls.Add(btnOku);
            Controls.Add(label4);
            Controls.Add(textYol);
            Controls.Add(label3);
            Controls.Add(btnOlustur);
            Controls.Add(btnKonum);
            Controls.Add(label2);
            Controls.Add(textAd);
            Controls.Add(btnSaveFileDialog);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(label1);
            Controls.Add(btnKonumSec);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnKonumSec;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnOpenFileDialog;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnSaveFileDialog;
        private TextBox textAd;
        private Label label2;
        private Button btnKonum;
        private Button btnOlustur;
        private Label label3;
        private Label label4;
        private TextBox textYol;
        private Button btnOku;
        private ListBox listBox1;
        private Button btnYazdir;
        private RichTextBox richTextBox1;
    }
}
