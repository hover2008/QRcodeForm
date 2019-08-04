namespace QRcodeForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.qrCodeGraphicControl1 = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_AllNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Current = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonQr = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIds
            // 
            this.txtIds.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIds.Location = new System.Drawing.Point(12, 91);
            this.txtIds.Margin = new System.Windows.Forms.Padding(4);
            this.txtIds.Multiline = true;
            this.txtIds.Name = "txtIds";
            this.txtIds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIds.Size = new System.Drawing.Size(330, 395);
            this.txtIds.TabIndex = 0;
            this.txtIds.Click += new System.EventHandler(this.txtIds_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "生成的Id数据组:(以行为分界)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(366, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "生成第一个";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(366, 212);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "上一个[↑]";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(366, 321);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "下一个[↓]";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.qrCodeGraphicControl1);
            this.panel1.Controls.Add(this.txt_Msg);
            this.panel1.Location = new System.Drawing.Point(509, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 396);
            this.panel1.TabIndex = 3;
            // 
            // qrCodeGraphicControl1
            // 
            this.qrCodeGraphicControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrCodeGraphicControl1.Location = new System.Drawing.Point(21, 44);
            this.qrCodeGraphicControl1.Margin = new System.Windows.Forms.Padding(4);
            this.qrCodeGraphicControl1.Name = "qrCodeGraphicControl1";
            this.qrCodeGraphicControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrCodeGraphicControl1.Size = new System.Drawing.Size(267, 261);
            this.qrCodeGraphicControl1.TabIndex = 4;
            // 
            // txt_Msg
            // 
            this.txt_Msg.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_Msg.Location = new System.Drawing.Point(21, 312);
            this.txt_Msg.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ReadOnly = true;
            this.txt_Msg.Size = new System.Drawing.Size(265, 30);
            this.txt_Msg.TabIndex = 1;
            this.txt_Msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(510, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "二维码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(17, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(608, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "注：光标选中哪一行，也能自动生成哪一行。同时，按键盘上面的\"↑↓\"键也可更换数据。";
            // 
            // lbl_AllNumber
            // 
            this.lbl_AllNumber.AutoSize = true;
            this.lbl_AllNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_AllNumber.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_AllNumber.ForeColor = System.Drawing.Color.Red;
            this.lbl_AllNumber.Location = new System.Drawing.Point(366, 414);
            this.lbl_AllNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AllNumber.Name = "lbl_AllNumber";
            this.lbl_AllNumber.Size = new System.Drawing.Size(75, 22);
            this.lbl_AllNumber.TabIndex = 5;
            this.lbl_AllNumber.Text = "共:0行";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(6, 500);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 21);
            this.panel2.TabIndex = 6;
            // 
            // lbl_Current
            // 
            this.lbl_Current.AutoSize = true;
            this.lbl_Current.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Current.Font = new System.Drawing.Font("宋体", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_Current.ForeColor = System.Drawing.Color.Green;
            this.lbl_Current.Location = new System.Drawing.Point(366, 451);
            this.lbl_Current.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Current.Name = "lbl_Current";
            this.lbl_Current.Size = new System.Drawing.Size(84, 19);
            this.lbl_Current.TabIndex = 5;
            this.lbl_Current.Text = "当前:0行";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(67, 19);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(749, 25);
            this.txtURL.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "URL：";
            // 
            // buttonQr
            // 
            this.buttonQr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQr.Location = new System.Drawing.Point(916, 19);
            this.buttonQr.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQr.Name = "buttonQr";
            this.buttonQr.Size = new System.Drawing.Size(100, 29);
            this.buttonQr.TabIndex = 9;
            this.buttonQr.Text = "打印";
            this.buttonQr.UseVisualStyleBackColor = true;
            this.buttonQr.Click += new System.EventHandler(this.buttonQr_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(838, 63);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(336, 430);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 525);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonQr);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Current);
            this.Controls.Add(this.lbl_AllNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIds);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "二维码生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Msg;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl qrCodeGraphicControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_AllNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Current;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonQr;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

