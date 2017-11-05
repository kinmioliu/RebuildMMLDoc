namespace RebuildMMLDoc
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_choose_doc = new System.Windows.Forms.Button();
            this.bt_parse_mmldoc = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rtb_dumpinfo = new MMLRichTextBox();
            this.SuspendLayout();
            // 
            // bt_choose_doc
            // 
            this.bt_choose_doc.Location = new System.Drawing.Point(23, 23);
            this.bt_choose_doc.Name = "bt_choose_doc";
            this.bt_choose_doc.Size = new System.Drawing.Size(75, 23);
            this.bt_choose_doc.TabIndex = 0;
            this.bt_choose_doc.Text = "选择";
            this.bt_choose_doc.UseVisualStyleBackColor = true;
            this.bt_choose_doc.Click += new System.EventHandler(this.bt_choose_mmldoc);
            // 
            // bt_parse_mmldoc
            // 
            this.bt_parse_mmldoc.Location = new System.Drawing.Point(23, 75);
            this.bt_parse_mmldoc.Name = "bt_parse_mmldoc";
            this.bt_parse_mmldoc.Size = new System.Drawing.Size(75, 23);
            this.bt_parse_mmldoc.TabIndex = 1;
            this.bt_parse_mmldoc.Text = "解析";
            this.bt_parse_mmldoc.UseVisualStyleBackColor = true;
            this.bt_parse_mmldoc.Click += new System.EventHandler(this.bt_parse_mmldoc_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(119, 14);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // rtb_dumpinfo
            // 
            this.rtb_dumpinfo.Location = new System.Drawing.Point(121, 54);
            this.rtb_dumpinfo.Name = "rtb_dumpinfo";
            this.rtb_dumpinfo.Size = new System.Drawing.Size(362, 224);
            this.rtb_dumpinfo.TabIndex = 5;
            this.rtb_dumpinfo.Text = "";
            this.rtb_dumpinfo.TextChanged += new System.EventHandler(this.rtb_dumpinfo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(508, 311);
            this.Controls.Add(this.rtb_dumpinfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bt_parse_mmldoc);
            this.Controls.Add(this.bt_choose_doc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private string selected_doc;
        private System.Windows.Forms.Button bt_choose_doc;
        private System.Windows.Forms.Button bt_parse_mmldoc;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MMLRichTextBox rtb_dumpinfo;
    }
}

