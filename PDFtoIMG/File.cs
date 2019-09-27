using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFtoIMG
{
    partial class Form1
    {
        //PDFパスを取得
        private string getOpenFileName()
        {
            string filename = "";
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "PDFファイル(*.pdf)|*.pdf";
            if (f.ShowDialog() == DialogResult.OK)
            {
                filename = f.FileName;
            }
            return filename;
        }

        //出力フォルダパスを選択
        private string getSaveFolderName()
        {
            string dirname = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "保存先のフォルダを選択";
            fbd.SelectedPath = getUserHomePath() + @"\Desktop";
            fbd.ShowNewFolderButton = true;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                dirname = fbd.SelectedPath + @"\";
            }
            return dirname;
        }

        //ユーザのホームフォルダパス取得
        private string getUserHomePath()
        {
            return System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

    }
}
