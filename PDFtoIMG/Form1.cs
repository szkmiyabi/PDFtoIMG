using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PdfiumViewer;
using System.Drawing.Imaging;

namespace PDFtoIMG
{
    public partial class Form1 : Form
    {
        private string filename = "";
        private string dirname = "";

        public Form1()
        {
            InitializeComponent();
            dirname = getUserHomePath() + @"\Desktop\";
            saveDirPath.Text = getUserHomePath() + @"\Desktop\";
        }

        private void browsePdfButton_Click(object sender, EventArgs e)
        {
            filename = getOpenFileName();
            if (filename == "")
            {
                MessageBox.Show("PDFファイルが選択されていません");
                return;
            }
            pdfFilePath.Text = filename;
        }

        private void browseSaveDirButton_Click(object sender, EventArgs e)
        {
            dirname = getSaveFolderName();
            saveDirPath.Text = dirname;
        }

        private void doWriteImageButton_Click(object sender, EventArgs e)
        {
            PDFUtil pfu = new PDFUtil(filename, dirname, 300);
            pfu.save_to_jpeg(0);
        }
    }
}
