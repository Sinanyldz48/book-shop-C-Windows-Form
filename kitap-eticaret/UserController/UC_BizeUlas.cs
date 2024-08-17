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

namespace kitap_eticaret.UserController
{
    public partial class UC_BizeUlas : UserControl
    {
        public UC_BizeUlas()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydet";
            saveFileDialog1.Filter = ("Metin Belgesi| *.txt | Zengin Metin Belgesi| *.rtf");
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "*";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Aç";
            openFileDialog1.Filter = ("Metin Belgesi|*.txt|Zengin Metin Belgesi|*.rtf");
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "*";
            openFileDialog1.ShowDialog();
            richTextBox2.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox2.Cut();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox2.Copy();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox2.Paste();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = true;
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowHelp = true;
            fontDialog1.ShowDialog();
            richTextBox2.SelectionFont = fontDialog1.Font;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowHelp = true;
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            richTextBox2.SelectionColor = colorDialog1.Color;
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.ResetText();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Aç";
            openFileDialog1.Filter = ("Metin Belgesi|*.txt|Zengin Metin Belgesi|*.rtf");
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "*";
            openFileDialog1.ShowDialog();
            richTextBox2.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydet";
            saveFileDialog1.Filter = ("Metin Belgesi| *.txt | Zengin Metin Belgesi| *.rtf");
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "*";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.ShowDialog();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydet";
            saveFileDialog1.Filter = ("Metin Belgesi| *.txt | Zengin Metin Belgesi| *.rtf");
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "*";
            saveFileDialog1.OverwritePrompt = false;
            saveFileDialog1.ShowDialog();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Undo();
        }

        private void yineleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Redo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Paste();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectAll();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KitapAL Yayıncılık ve İletişim A.Ş.\r\n\r\nE-Posta: editor@KitapAL.com\r\n\r\nAdres:\r\nYenibosna Merkez Mahallesi Cemal Ulusoy Caddesi No:43 Bahçelievler/İstanbul\r\n\r\nMersis Numarası: 0564055769600014\r\n\r\nKayıtlı Olunan Meslek Odası: İstanbul Ticaret Odası (www.ito.org.tr)\r\n\r\nKayıtlı Elektronik Posta Adresi: KitapAL@hs03.kep.tr\r\n\r\nTelefon: 0212 519 87 20\r\n\r\nFaks: 0212 519 15 84");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Gönderildi");

        }
    }
}
