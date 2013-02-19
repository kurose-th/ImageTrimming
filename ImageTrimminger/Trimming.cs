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
    /// <summary>
    /// 画像の切り取りに関するクラス．
    /// </summary>
    public class Trimming
    {
        /// <summary>
        /// 画像の切り取りを実際に行う関数．
        /// </summary>
        public void Run(string srcPath, string destPath, int format, int x1, int y1, int x2, int y2, int edge)
        {
            // 画像を読み込む
            string baseDirectoryPath = srcPath;
            string saveDirectoryPath = destPath + @"\";

            DirectoryInfo di = new DirectoryInfo(baseDirectoryPath);
            List<FileInfo> files = new List<FileInfo>();

            var property = new Property();
            var getFileExtension = property.SearchExtension;
            for (int j = 0; j < getFileExtension.Length; j++)
            {
                files.AddRange(di.GetFiles("*" + getFileExtension[j]));
            }
            //string[] files = Directory.GetFiles(baseDirectoryPath, "*", SearchOption.AllDirectories);

            int i = 0;
            for (i=0; i < files.Count; i++)
            {
                Cut(files[i].Name, baseDirectoryPath, saveDirectoryPath, format, x1, y1, x2, y2, edge);
            }
            MessageBox.Show(i + "件の画像の処理完了");
        }


        /// <summary>
        /// 画像の切り取りを実際に行う関数．（edgeのoptionがfalseの場合）
        /// </summary>
        public void Run(string srcPath, string destPath, int format, int x1, int y1, int x2, int y2)
        {
            Run(srcPath, destPath, format, x1, y1, x2, y2, 0);
        }

        
        /// <summary>
        /// 個々の画像を切り取る関数．
        /// </summary>
        public void Cut(string filename, string baseDirectoryPath, string saveDirectoryPath, int format, int x1, int y1, int x2, int y2, int edge)
        {

            // 画像を読み込む
            string baseFilePath = baseDirectoryPath + @"\\" + filename;
            var bmpBase = new Bitmap(baseFilePath);

            Rectangle rect;
            // 画像を切り抜く
            if (edge != 0)
            {
                rect = new Rectangle(edge, edge, bmpBase.Width - 2 * edge, bmpBase.Height - 2 * edge);
            }
            else
            {
                rect = new Rectangle(x1, y1, System.Math.Min(x2 - x1, bmpBase.Width), System.Math.Min(y2 - y1, bmpBase.Height));
            }
            var bmpNew = bmpBase.Clone(rect, bmpBase.PixelFormat);

            // 画像を保存
            string newFilePath = saveDirectoryPath + Path.GetFileNameWithoutExtension(filename);
            switch (format)
            {
                case (0):
                    newFilePath += ".bmp";
                    bmpNew.Save(newFilePath, ImageFormat.Bmp);
                    break;
                case (1):
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

        /// <summary>
        /// 個々の画像を切り取る関数．（edgeのoptionがfalseの場合）
        /// </summary>
        public void Cut(string filename, string baseDirectoryPath, string saveDirectoryPath, int format, int x1, int y1, int x2, int y2){
            Cut(filename, baseDirectoryPath, saveDirectoryPath, format, x1, y1, x2, y2, 0);
        }
    }
}

