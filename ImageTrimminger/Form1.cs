using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageTrimminger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        #region Button
        private void FromFolderButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            srcTextbox.Text = folderBrowserDialog1.SelectedPath;

        }


        private void ToFolderButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog2.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            destTextbox.Text = folderBrowserDialog2.SelectedPath;

        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            var mes = new OriginalMessageBox();

            try
            {
                var trimming = new Trimming();
                string src = srcTextbox.Text;
                string dest = srcTextbox.Text;

                // destディレクトリが指定されてないならsrcディレクトリと同じ
                if (destTextbox.Text != "")
                {
                    dest = destTextbox.Text;
                }

                int x1 = int.Parse(textBox_x1.Text.ToString());
                int y1 = int.Parse(textBox_y1.Text.ToString());
                int x2 = int.Parse(textBox_x2.Text.ToString());
                int y2 = int.Parse(textBox_y2.Text.ToString());
                int edge = 0;
                
                // 縁取りオプション時
                if (Edge_Checkbox.Checked)
                {
                    edge = int.Parse(textBox_Edge.Text.ToString());
                    // 縁が0より小さい
                    if (edge < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    trimming.Run(src, dest, comboBox1.SelectedIndex, x1, y1, x2, y2, edge);
                }
                else
                {
                    if (x2 < 1 || y2 < 1 || x2 - x1 < 1 || y2 - y1 < 1)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    trimming.Run(src, dest, comboBox1.SelectedIndex, x1, y1, x2, y2);
                }

                
            }
            catch (System.ArgumentOutOfRangeException)
            {
                mes.Error("切り取る範囲の縦横、または縁のサイズがそれぞれ0よりも大きくなるようにしてください");
            }
            catch (System.ArgumentNullException)
            {
                mes.Error("変更元フォルダが指定されていません");
            }
            // 不測の事態
            catch (Exception err)
            {
                mes.Error(err.ToString());
            }
            finally
            {
            }
        }

        #endregion


        #region drag

        /// <summary>
        /// ListViewにDragした時の関数
        /// </summary>
        private void DragListview_DragEnter(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            bool exist_pic = false;
            List<FileInfo> files = new List<FileInfo>();

            var property = new Property();
            var getFileExtension = property.SearchExtension;
            // 計算量がi*jなのでアレ
            for (int i = 0; i < paths.Length; i++)
            {
                for (int j = 0; j < getFileExtension.Length; j++)
                {
                    if (paths[i].Contains(getFileExtension[j]))
                    {
                        exist_pic = true;
                        break;
                    }
                }
            }

            if (!exist_pic)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// ListViewにDropした時の関数
        /// </summary>
        private void DragListview_DragDrop(object sender, DragEventArgs e)
        {
            var mes = new OriginalMessageBox();
            try
            {
                var trimming = new Trimming();

                int x1 = int.Parse(textBox_x1.Text.ToString());
                int y1 = int.Parse(textBox_y1.Text.ToString());
                int x2 = int.Parse(textBox_x2.Text.ToString());
                int y2 = int.Parse(textBox_y2.Text.ToString());
                int edge = 0;

                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                List<FileInfo> files = new List<FileInfo>();

                var property = new Property();
                var getFileExtension = property.SearchExtension;
                // 計算量がi*jなのでアレ
                int i = 0;
                for (i = 0; i < paths.Length; i++)
                {
                    for (int j = 0; j < getFileExtension.Length; j++)
                    {
                        if (paths[i].Contains(getFileExtension[j]))
                        {

                            string baseDirectoryPath = Path.GetDirectoryName(paths[i]);
                            string saveDirectoryPath = baseDirectoryPath + @"\";

                            // destディレクトリが指定されてないならsrcディレクトリと同じ
                            if (destTextbox.Text != "")
                            {
                                saveDirectoryPath = destTextbox.Text + @"\";
                            }

                            // 縁取りオプション時
                            if (Edge_Checkbox.Checked)
                            {
                                edge = int.Parse(textBox_Edge.Text.ToString());
                                // 縁が0より小さい
                                if (edge < 0)
                                {
                                    throw new ArgumentOutOfRangeException();
                                }
                                trimming.Cut(Path.GetFileName(paths[i]), baseDirectoryPath, saveDirectoryPath, comboBox1.SelectedIndex, x1, y1, x2, y2, edge);
                            }
                            else
                            {
                                if (x2 < 1 || y2 < 1 || x2 - x1 < 1 || y2 - y1 < 1)
                                {
                                    throw new ArgumentOutOfRangeException();
                                }
                                trimming.Cut(Path.GetFileName(paths[i]), baseDirectoryPath, saveDirectoryPath, comboBox1.SelectedIndex, x1, y1, x2, y2);
                            }
                        }
                    }
                }
                MessageBox.Show(i + "件の画像の処理完了");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                mes.Error("切り取る範囲の縦横、または縁のサイズがそれぞれ0よりも大きくなるようにしてください");
            }
            // 不測の事態
            catch (Exception err)
            {
                mes.Error(err.ToString());
            }
            finally
            {
            }
        }

        #endregion


        #region Utility

        /// <summary>
        /// オリジナルなメッセージボックスを出すだけのクラス．
        /// </summary>
        class OriginalMessageBox
        {
            /// <summary>
            /// OKな時のメッセージボックスを出す為の関数．
            /// </summary>
            public void OK(string text)
            {
                MessageBox.Show(text, "", MessageBoxButtons.OK);
            }

            /// <summary>
            /// エラー時のメッセージボックスを出す為の関数．
            /// </summary>
            public void Error(string text)
            {
                MessageBox.Show(text,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }


        #endregion

    }
}
