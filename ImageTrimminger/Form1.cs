using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                string dest = destTextbox.Text;
                int x1 = int.Parse(textBox_x1.Text.ToString());
                int y1 = int.Parse(textBox_y1.Text.ToString());
                int x2 = int.Parse(textBox_x2.Text.ToString());
                int y2 = int.Parse(textBox_y2.Text.ToString());

                if (x2 < 1 || y2 < 1 || x2 - x1<1 || y2 - y1<1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                trimming.Run(src, dest, comboBox1.SelectedIndex, x1, y1, x2, y2);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                mes.Error("切り取る範囲の縦横がそれぞれ0よりも大きくなるようにしてください");
            }
            catch (System.ArgumentNullException)
            {
                mes.Error("受け取り元フォルダか送り先フォルダが指定されてません");
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



        // メッセージボックス出すためだけのクラス
        class OriginalMessageBox
        {
            public void OK(string text)
            {
                MessageBox.Show(text, "", MessageBoxButtons.OK);
            }

            // Error
            public void Error(string text)
            {
                MessageBox.Show(text,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }
    }
}
