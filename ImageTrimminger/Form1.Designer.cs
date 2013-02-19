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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.destFolderButton = new System.Windows.Forms.Button();
            this.destTextbox = new System.Windows.Forms.TextBox();
            this.srcFolderButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.srcTextbox = new System.Windows.Forms.TextBox();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.textBox_y1 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.textBox_y2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Edge_Checkbox = new System.Windows.Forms.CheckBox();
            this.textBox_Edge = new System.Windows.Forms.TextBox();
            this.BasePanel = new System.Windows.Forms.Panel();
            this.DragListview = new System.Windows.Forms.ListView();
            this.BasePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // destFolderButton
            // 
            this.destFolderButton.Location = new System.Drawing.Point(236, 237);
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
            this.destTextbox.Location = new System.Drawing.Point(33, 212);
            this.destTextbox.Name = "destTextbox";
            this.destTextbox.Size = new System.Drawing.Size(260, 19);
            this.destTextbox.TabIndex = 2;
            // 
            // srcFolderButton
            // 
            this.srcFolderButton.Location = new System.Drawing.Point(236, 172);
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
            this.comboBox1.Location = new System.Drawing.Point(99, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(126, 377);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(86, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "実行";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // srcTextbox
            // 
            this.srcTextbox.Enabled = false;
            this.srcTextbox.Location = new System.Drawing.Point(33, 147);
            this.srcTextbox.Name = "srcTextbox";
            this.srcTextbox.Size = new System.Drawing.Size(260, 19);
            this.srcTextbox.TabIndex = 3;
            // 
            // textBox_x1
            // 
            this.textBox_x1.Location = new System.Drawing.Point(33, 282);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.Size = new System.Drawing.Size(44, 19);
            this.textBox_x1.TabIndex = 6;
            this.textBox_x1.Text = "0";
            this.textBox_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_y1
            // 
            this.textBox_y1.Location = new System.Drawing.Point(83, 282);
            this.textBox_y1.Name = "textBox_y1";
            this.textBox_y1.Size = new System.Drawing.Size(44, 19);
            this.textBox_y1.TabIndex = 7;
            this.textBox_y1.Text = "0";
            this.textBox_y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(190, 284);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.Size = new System.Drawing.Size(44, 19);
            this.textBox_x2.TabIndex = 8;
            this.textBox_x2.Text = "0";
            this.textBox_x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_y2
            // 
            this.textBox_y2.Location = new System.Drawing.Point(240, 284);
            this.textBox_y2.Name = "textBox_y2";
            this.textBox_y2.Size = new System.Drawing.Size(44, 19);
            this.textBox_y2.TabIndex = 9;
            this.textBox_y2.Text = "0";
            this.textBox_y2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(152, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "～";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(31, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 11);
            this.label2.TabIndex = 11;
            this.label2.Text = "切り取る範囲";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "枠線内に画像をドラッグすると問答無用で切り取りますよ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(31, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 11);
            this.label4.TabIndex = 14;
            this.label4.Text = "切り取った画像の送り先（設定しない場合、元のディレクトリ内）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(31, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 11);
            this.label5.TabIndex = 15;
            this.label5.Text = "フォルダ内画像を一括で切り取る場合";
            // 
            // Edge_Checkbox
            // 
            this.Edge_Checkbox.AutoSize = true;
            this.Edge_Checkbox.Location = new System.Drawing.Point(190, 318);
            this.Edge_Checkbox.Name = "Edge_Checkbox";
            this.Edge_Checkbox.Size = new System.Drawing.Size(92, 16);
            this.Edge_Checkbox.TabIndex = 16;
            this.Edge_Checkbox.Text = "縁を切り取る：";
            this.Edge_Checkbox.UseVisualStyleBackColor = true;
            // 
            // textBox_Edge
            // 
            this.textBox_Edge.Location = new System.Drawing.Point(278, 316);
            this.textBox_Edge.Name = "textBox_Edge";
            this.textBox_Edge.Size = new System.Drawing.Size(44, 19);
            this.textBox_Edge.TabIndex = 17;
            this.textBox_Edge.Text = "0";
            this.textBox_Edge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BasePanel
            // 
            this.BasePanel.AllowDrop = true;
            this.BasePanel.Controls.Add(this.DragListview);
            this.BasePanel.Controls.Add(this.textBox_Edge);
            this.BasePanel.Controls.Add(this.Edge_Checkbox);
            this.BasePanel.Controls.Add(this.label5);
            this.BasePanel.Controls.Add(this.label4);
            this.BasePanel.Controls.Add(this.label3);
            this.BasePanel.Controls.Add(this.label2);
            this.BasePanel.Controls.Add(this.label1);
            this.BasePanel.Controls.Add(this.textBox_y2);
            this.BasePanel.Controls.Add(this.textBox_x2);
            this.BasePanel.Controls.Add(this.textBox_y1);
            this.BasePanel.Controls.Add(this.textBox_x1);
            this.BasePanel.Controls.Add(this.srcTextbox);
            this.BasePanel.Controls.Add(this.OkButton);
            this.BasePanel.Controls.Add(this.comboBox1);
            this.BasePanel.Controls.Add(this.srcFolderButton);
            this.BasePanel.Controls.Add(this.destTextbox);
            this.BasePanel.Controls.Add(this.destFolderButton);
            this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePanel.Location = new System.Drawing.Point(0, 0);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(334, 412);
            this.BasePanel.TabIndex = 6;
            // 
            // DragListview
            // 
            this.DragListview.AllowDrop = true;
            this.DragListview.Location = new System.Drawing.Point(39, 24);
            this.DragListview.Name = "DragListview";
            this.DragListview.Size = new System.Drawing.Size(243, 97);
            this.DragListview.TabIndex = 18;
            this.DragListview.UseCompatibleStateImageBehavior = false;
            this.DragListview.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragListview_DragDrop);
            this.DragListview.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragListview_DragEnter);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 412);
            this.Controls.Add(this.BasePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(284, 331);
            this.Name = "MainForm";
            this.Text = "ガゾーキリトール";
            this.BasePanel.ResumeLayout(false);
            this.BasePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button destFolderButton;
        private System.Windows.Forms.TextBox destTextbox;
        private System.Windows.Forms.Button srcFolderButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox srcTextbox;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.TextBox textBox_y1;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.TextBox textBox_y2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Edge_Checkbox;
        private System.Windows.Forms.TextBox textBox_Edge;
        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.ListView DragListview;

    }
}

