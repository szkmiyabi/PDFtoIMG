namespace PDFtoIMG
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pdfFilePath = new System.Windows.Forms.TextBox();
            this.browsePdfButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.saveDirPath = new System.Windows.Forms.TextBox();
            this.browseSaveDirButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.doWriteImageButton = new System.Windows.Forms.Button();
            this.pageCountCombo = new System.Windows.Forms.ComboBox();
            this.outputPdfPageCombo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileTypeCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 107);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.pdfFilePath);
            this.flowLayoutPanel1.Controls.Add(this.browsePdfButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pdfFilePath
            // 
            this.pdfFilePath.Location = new System.Drawing.Point(73, 3);
            this.pdfFilePath.Name = "pdfFilePath";
            this.pdfFilePath.Size = new System.Drawing.Size(217, 19);
            this.pdfFilePath.TabIndex = 0;
            // 
            // browsePdfButton
            // 
            this.browsePdfButton.Location = new System.Drawing.Point(296, 3);
            this.browsePdfButton.Name = "browsePdfButton";
            this.browsePdfButton.Size = new System.Drawing.Size(56, 23);
            this.browsePdfButton.TabIndex = 1;
            this.browsePdfButton.Text = "参照";
            this.browsePdfButton.UseVisualStyleBackColor = true;
            this.browsePdfButton.Click += new System.EventHandler(this.browsePdfButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "PDFファイル";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.saveDirPath);
            this.flowLayoutPanel2.Controls.Add(this.browseSaveDirButton);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(366, 30);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "出力フォルダ";
            // 
            // saveDirPath
            // 
            this.saveDirPath.Location = new System.Drawing.Point(73, 3);
            this.saveDirPath.Name = "saveDirPath";
            this.saveDirPath.Size = new System.Drawing.Size(217, 19);
            this.saveDirPath.TabIndex = 1;
            // 
            // browseSaveDirButton
            // 
            this.browseSaveDirButton.Location = new System.Drawing.Point(296, 3);
            this.browseSaveDirButton.Name = "browseSaveDirButton";
            this.browseSaveDirButton.Size = new System.Drawing.Size(56, 23);
            this.browseSaveDirButton.TabIndex = 2;
            this.browseSaveDirButton.Text = "参照";
            this.browseSaveDirButton.UseVisualStyleBackColor = true;
            this.browseSaveDirButton.Click += new System.EventHandler(this.browseSaveDirButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.outputPdfPageCombo);
            this.flowLayoutPanel3.Controls.Add(this.pageCountCombo);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.fileTypeCombo);
            this.flowLayoutPanel3.Controls.Add(this.doWriteImageButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 75);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(366, 29);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // doWriteImageButton
            // 
            this.doWriteImageButton.Location = new System.Drawing.Point(280, 3);
            this.doWriteImageButton.Name = "doWriteImageButton";
            this.doWriteImageButton.Size = new System.Drawing.Size(75, 23);
            this.doWriteImageButton.TabIndex = 0;
            this.doWriteImageButton.Text = "画像に変換";
            this.doWriteImageButton.UseVisualStyleBackColor = true;
            this.doWriteImageButton.Click += new System.EventHandler(this.doWriteImageButton_Click);
            // 
            // pageCountCombo
            // 
            this.pageCountCombo.FormattingEnabled = true;
            this.pageCountCombo.Location = new System.Drawing.Point(68, 3);
            this.pageCountCombo.Name = "pageCountCombo";
            this.pageCountCombo.Size = new System.Drawing.Size(64, 20);
            this.pageCountCombo.TabIndex = 1;
            // 
            // outputPdfPageCombo
            // 
            this.outputPdfPageCombo.AutoSize = true;
            this.outputPdfPageCombo.Location = new System.Drawing.Point(3, 6);
            this.outputPdfPageCombo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.outputPdfPageCombo.Name = "outputPdfPageCombo";
            this.outputPdfPageCombo.Size = new System.Drawing.Size(59, 12);
            this.outputPdfPageCombo.TabIndex = 2;
            this.outputPdfPageCombo.Text = "出力ページ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "画像形式";
            // 
            // fileTypeCombo
            // 
            this.fileTypeCombo.FormattingEnabled = true;
            this.fileTypeCombo.Location = new System.Drawing.Point(197, 3);
            this.fileTypeCombo.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.fileTypeCombo.Name = "fileTypeCombo";
            this.fileTypeCombo.Size = new System.Drawing.Size(65, 20);
            this.fileTypeCombo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 107);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PDFtoIMG";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pdfFilePath;
        private System.Windows.Forms.Button browsePdfButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saveDirPath;
        private System.Windows.Forms.Button browseSaveDirButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button doWriteImageButton;
        private System.Windows.Forms.Label outputPdfPageCombo;
        private System.Windows.Forms.ComboBox pageCountCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fileTypeCombo;
    }
}

