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
        private int pcnt;
        private string infile;
        private float dpi;

        //コンストラクタ
        public PDFUtil(string infile, float dpi)
        {
            this.infile = infile;
            this.dpi = dpi;
            if (infile == "") return;
            try
            {
                pdoc = PdfDocument.Load(infile);
                pcnt = pdoc.PageCount;
            } catch (Exception ex) {
                pdoc.Dispose();
                return;
            }

        }

        //ゲッター
        public int page_cnt
        {
            get{ return pcnt; }
        }

        //JPEG保存
        public void save_to_jpeg(int page_index, string outdir)
        {
            try
            {
                if (page_index < 0)
                {
                    int cnt = 1;
                    for (int i = 0; i < pcnt; i++)
                    {
                        Image img = pdoc.Render(i, dpi, dpi, false);
                        img.Save(outdir + get_filename_body() + "-p" + cnt + ".jpg", ImageFormat.Jpeg);
                        cnt++;
                    }
                }
                else
                {
                    Image img = pdoc.Render((page_index - 1), dpi, dpi, false);
                    img.Save(outdir + get_filename_body() + "-p" + page_index + ".jpg", ImageFormat.Jpeg);
                }
            }
            catch(Exception ex)
            {
                pdoc.Dispose();
                return;
            }
            finally
            {
                MessageBox.Show("保存が完了しました。");
            }

        }

        //PNG保存
        public void save_to_png(int page_index, string outdir)
        {
            try
            {
                if (page_index < 0)
                {
                    int cnt = 1;
                    for (int i = 0; i < pcnt; i++)
                    {
                        Image img = pdoc.Render(i, dpi, dpi, false);
                        img.Save(outdir + get_filename_body() + "-p" + cnt + ".png", ImageFormat.Png);
                        cnt++;
                    }
                }
                else
                {
                    Image img = pdoc.Render((page_index - 1), dpi, dpi, false);
                    img.Save(outdir + get_filename_body() + "-p" + page_index + ".png", ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                pdoc.Dispose();
                return;
            }
            finally
            {
                MessageBox.Show("保存が完了しました。");
            }

        }

        //BITMAP保存
        public void save_to_bmp(int page_index, string outdir)
        {
            try
            {
                if (page_index < 0)
                {
                    int cnt = 1;
                    for (int i = 0; i < pcnt; i++)
                    {
                        Image img = pdoc.Render(i, dpi, dpi, false);
                        img.Save(outdir + get_filename_body() + "-p" + cnt + ".bmp", ImageFormat.Bmp);
                        cnt++;
                    }
                }
                else
                {
                    Image img = pdoc.Render((page_index - 1), dpi, dpi, false);
                    img.Save(outdir + get_filename_body() + "-p" + page_index + ".bmp", ImageFormat.Bmp);
                }
            }
            catch (Exception ex)
            {
                pdoc.Dispose();
                return;
            }
            finally
            {
                MessageBox.Show("保存が完了しました。");
            }

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
