using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PdfiumViewer;
using System.Drawing.Imaging;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PDFtoIMG
{
    public class PDFUtil
    {
        private PdfDocument pdoc;
        private string infile;
        private string outdir;
        private float dpi;

        //コンストラクタ
        public PDFUtil(string infile, string outdir, float dpi)
        {
            this.infile = infile;
            this.outdir = outdir;
            this.dpi = dpi;
            if (infile == "") return;
            pdoc = PdfDocument.Load(infile);
        }

        //JPEGで保存
        public void save_to_jpeg(int page_index)
        {
            try
            {
                Image img = pdoc.Render(page_index, dpi, dpi, false);
                img.Save(outdir + get_filename_body() + ".jpg", ImageFormat.Jpeg);
            } catch(Exception ex)
            {
                MessageBox.Show("システムエラー：" + ex.Message);
                return;
            }
            MessageBox.Show("保存が完了しました。");

        }

        //ファイル名文字列を取得
        private string get_filename_body()
        {
            string ret = "";
            Regex pt = new Regex(@"(.+)(\\)(.+)(\.)(.+)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            if (!pt.IsMatch(infile)) return "";
            Match mt = pt.Match(infile);
            ret = mt.Groups[3].Value;
            return ret;
        }

    }
}
