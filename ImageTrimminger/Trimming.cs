using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageTrimminger
{
    public class Trimming
    {
        public void Run(string srcPath, string destPath, int format, int x1, int y1, int x2, int y2)
        {
            // 画像を読み込む
            string baseDirectoryPath = srcPath;
            string saveDirectoryPath = destPath + @"\";

            DirectoryInfo di = new DirectoryInfo(baseDirectoryPath);
            List<FileInfo> files = new List<FileInfo>();
            // 効率のいい検索方法ください
            files.AddRange(di.GetFiles("*.jpg"));
            files.AddRange(di.GetFiles("*.jpe"));
            files.AddRange(di.GetFiles("*.jpeg"));
            files.AddRange(di.GetFiles("*.bmp"));
            files.AddRange(di.GetFiles("*.gif"));
            files.AddRange(di.GetFiles("*.png"));
            files.AddRange(di.GetFiles("*.tif"));
            files.AddRange(di.GetFiles("*.tiff"));
            //string[] files = Directory.GetFiles(baseDirectoryPath, "*", SearchOption.AllDirectories);

            int i = 0;
            for (i=0; i < files.Count; i++)
            {
                // 画像を読み込む
                string baseFilePath = baseDirectoryPath + @"\\" + files[i].Name;
                var bmpBase = new Bitmap(baseFilePath);

                // 画像を切り抜く
                var rect = new Rectangle(x1, y1, System.Math.Min(x2 - x1, bmpBase.Width), System.Math.Min(y2 - y1, bmpBase.Height));
                var bmpNew = bmpBase.Clone(rect, bmpBase.PixelFormat);

                // 画像を保存
                string newFilePath = saveDirectoryPath + Path.GetFileNameWithoutExtension(files[i].ToString());
                switch(format){
                    case(0):
                        newFilePath += ".bmp";
                        bmpNew.Save(newFilePath, ImageFormat.Bmp);
                        break;
                    case(1):
                        newFilePath += ".jpg";
                        bmpNew.Save(newFilePath, ImageFormat.Jpeg);
                        break;
                    case (2):
                        newFilePath += ".gif";
                        bmpNew.Save(newFilePath, ImageFormat.Gif);
                        break;
                    case (3):
                        newFilePath += ".png";
                        bmpNew.Save(newFilePath, ImageFormat.Png);
                        break;
                }

                // 画像リソースを解放
                bmpBase.Dispose();
                bmpNew.Dispose();

            }
            MessageBox.Show(i + "件の画像の処理完了");
        }
    }
}

