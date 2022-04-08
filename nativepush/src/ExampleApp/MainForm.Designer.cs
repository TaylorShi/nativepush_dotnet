namespace ExampleApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtb_PushXml = new System.Windows.Forms.RichTextBox();
            this.btn_PostPush = new System.Windows.Forms.Button();
            this.btn_ClearPush = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PrevPush = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_PushXml
            // 
            this.rtb_PushXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_PushXml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_PushXml.Font = new System.Drawing.Font("宋体", 10F);
            this.rtb_PushXml.Location = new System.Drawing.Point(4, 24);
            this.rtb_PushXml.Name = "rtb_PushXml";
            this.rtb_PushXml.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_PushXml.Size = new System.Drawing.Size(560, 483);
            this.rtb_PushXml.TabIndex = 0;
            this.rtb_PushXml.Text = "";
            // 
            // btn_PostPush
            // 
            this.btn_PostPush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PostPush.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_PostPush.Location = new System.Drawing.Point(575, 24);
            this.btn_PostPush.Name = "btn_PostPush";
            this.btn_PostPush.Size = new System.Drawing.Size(81, 85);
            this.btn_PostPush.TabIndex = 1;
            this.btn_PostPush.Text = "发送";
            this.btn_PostPush.UseVisualStyleBackColor = true;
            this.btn_PostPush.Click += new System.EventHandler(this.btn_PostPush_Click);
            // 
            // btn_ClearPush
            // 
            this.btn_ClearPush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearPush.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_ClearPush.Location = new System.Drawing.Point(575, 230);
            this.btn_ClearPush.Name = "btn_ClearPush";
            this.btn_ClearPush.Size = new System.Drawing.Size(81, 82);
            this.btn_ClearPush.TabIndex = 1;
            this.btn_ClearPush.Text = "清除";
            this.btn_ClearPush.UseVisualStyleBackColor = true;
            this.btn_ClearPush.Click += new System.EventHandler(this.btn_ClearPush_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "推送消息内容(XML)";
            // 
            // btn_PrevPush
            // 
            this.btn_PrevPush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PrevPush.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_PrevPush.Location = new System.Drawing.Point(575, 129);
            this.btn_PrevPush.Name = "btn_PrevPush";
            this.btn_PrevPush.Size = new System.Drawing.Size(81, 85);
            this.btn_PrevPush.TabIndex = 1;
            this.btn_PrevPush.Text = "预设";
            this.btn_PrevPush.UseVisualStyleBackColor = true;
            this.btn_PrevPush.Click += new System.EventHandler(this.btn_PrevPush_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ClearPush);
            this.Controls.Add(this.btn_PrevPush);
            this.Controls.Add(this.btn_PostPush);
            this.Controls.Add(this.rtb_PushXml);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows原生推送示例程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_PushXml;
        private System.Windows.Forms.Button btn_PostPush;
        private System.Windows.Forms.Button btn_ClearPush;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrevPush;
    }
}

