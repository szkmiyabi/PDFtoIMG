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
        private PDFUtil pfu;
        private int pcnt = 0;

        //コンストラクタ
        public Form1()
        {
            InitializeComponent();
            dirname = getUserHomePath() + @"\Desktop\";
            saveDirPath.Text = getUserHomePath() + @"\Desktop\";
            init_file_type_combo();
        }

        //画像形式コンボの設定
        private void init_file_type_combo()
        {
            fileTypeCombo.Items.Add("JPG");
            fileTypeCombo.Items.Add("PNG");
            fileTypeCombo.Items.Add("BMP");
            fileTypeCombo.SelectedIndex = 0;
        }

        //頁選択コンボの設定
        private void init_page_combo()
        {
            if (pageCountCombo.Items.Count > 0) pageCountCombo.Items.Clear();

            for(int i=0; i<pcnt; i++)
            {
                pageCountCombo.Items.Add((i + 1).ToString());
            }
            pageCountCombo.Items.Add("全ページ");
            pageCountCombo.SelectedIndex = 0;
        }

        //PDFファイル参照ボタンクリック
        private void browsePdfButton_Click(object sender, EventArgs e)
        {
            if (pfu != null) pfu = null;
            filename = getOpenFileName();
            if (filename == "")
            {
                MessageBox.Show("PDFファイルが選択されていません");
                return;
            }
            pdfFilePath.Text = filename;
            pfu = new PDFUtil(filename, 300);
            pcnt = pfu.page_cnt;
            init_page_combo();
        }

        //出力先フォルダ参照ボタンクリック
        private void browseSaveDirButton_Click(object sender, EventArgs e)
        {
            dirname = getSaveFolderName();
            saveDirPath.Text = dirname;
        }

        //画像に変換ボタンクリック
        private void doWriteImageButton_Click(object sender, EventArgs e)
        {
            string src = pageCountCombo.Text;
            string tp = fileTypeCombo.Text;
            int idx = 0;
            if(src.Equals("全ページ"))
            {
                idx = -1;
            }
            else
            {
                idx = Int32.Parse(pageCountCombo.Text);
            }
            switch(tp)
            {
                case "JPG":
                    pfu.save_to_jpeg(idx, dirname);
                    break;
                case "PNG":
                    pfu.save_to_png(idx, dirname);
                    break;
                case "BMP":
                    pfu.save_to_bmp(idx, dirname);
                    break;
            }
        }
    }
}
