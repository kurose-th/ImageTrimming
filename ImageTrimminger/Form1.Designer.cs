namespace ImageTrimminger
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.OkButton = new System.Windows.Forms.Button();
            this.destFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.destTextbox = new System.Windows.Forms.TextBox();
            this.srcTextbox = new System.Windows.Forms.TextBox();
            this.srcFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_y2 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.textBox_y1 = new System.Windows.Forms.TextBox();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(95, 296);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(86, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "実行";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // destFolderButton
            // 
            this.destFolderButton.Location = new System.Drawing.Point(195, 160);
            this.destFolderButton.Name = "destFolderButton";
            this.destFolderButton.Size = new System.Drawing.Size(86, 23);
            this.destFolderButton.TabIndex = 1;
            this.destFolderButton.Text = "変更後フォルダ";
            this.destFolderButton.UseVisualStyleBackColor = true;
            this.destFolderButton.Click += new System.EventHandler(this.ToFolderButton_Click);
            // 
            // destTextbox
            // 
            this.destTextbox.Enabled = false;
            this.destTextbox.Location = new System.Drawing.Point(12, 135);
            this.destTextbox.Name = "destTextbox";
            this.destTextbox.Size = new System.Drawing.Size(260, 19);
            this.destTextbox.TabIndex = 2;
            // 
            // srcTextbox
            // 
            this.srcTextbox.Enabled = false;
            this.srcTextbox.Location = new System.Drawing.Point(12, 68);
            this.srcTextbox.Name = "srcTextbox";
            this.srcTextbox.Size = new System.Drawing.Size(260, 19);
            this.srcTextbox.TabIndex = 3;
            // 
            // srcFolderButton
            // 
            this.srcFolderButton.Location = new System.Drawing.Point(195, 93);
            this.srcFolderButton.Name = "srcFolderButton";
            this.srcFolderButton.Size = new System.Drawing.Size(86, 23);
            this.srcFolderButton.TabIndex = 4;
            this.srcFolderButton.Text = "変更元フォルダ";
            this.srcFolderButton.UseVisualStyleBackColor = true;
            this.srcFolderButton.Click += new System.EventHandler(this.FromFolderButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "bmp形式",
            "jpg形式",
            "gif形式",
            "png形式"});
            this.comboBox1.Location = new System.Drawing.Point(70, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_y2);
            this.panel1.Controls.Add(this.textBox_x2);
            this.panel1.Controls.Add(this.textBox_y1);
            this.panel1.Controls.Add(this.textBox_x1);
            this.panel1.Controls.Add(this.srcTextbox);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.srcFolderButton);
            this.panel1.Controls.Add(this.destTextbox);
            this.panel1.Controls.Add(this.destFolderButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 331);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "きりとるはんい";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(123, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "～";
            // 
            // textBox_y2
            // 
            this.textBox_y2.Location = new System.Drawing.Point(211, 233);
            this.textBox_y2.Name = "textBox_y2";
            this.textBox_y2.Size = new System.Drawing.Size(44, 19);
            this.textBox_y2.TabIndex = 9;
            this.textBox_y2.Text = "0";
            this.textBox_y2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(161, 233);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.Size = new System.Drawing.Size(44, 19);
            this.textBox_x2.TabIndex = 8;
            this.textBox_x2.Text = "0";
            this.textBox_x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_y1
            // 
            this.textBox_y1.Location = new System.Drawing.Point(62, 233);
            this.textBox_y1.Name = "textBox_y1";
            this.textBox_y1.Size = new System.Drawing.Size(44, 19);
            this.textBox_y1.TabIndex = 7;
            this.textBox_y1.Text = "0";
            this.textBox_y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_x1
            // 
            this.textBox_x1.Location = new System.Drawing.Point(12, 233);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.Size = new System.Drawing.Size(44, 19);
            this.textBox_x1.TabIndex = 6;
            this.textBox_x1.Text = "0";
            this.textBox_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(284, 331);
            this.Name = "MainForm";
            this.Text = "ガゾーキリトール";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button destFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox destTextbox;
        private System.Windows.Forms.TextBox srcTextbox;
        private System.Windows.Forms.Button srcFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_y2;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.TextBox textBox_y1;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.Label label2;

    }
}

