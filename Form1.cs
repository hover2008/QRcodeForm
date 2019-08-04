using System;
using System.Drawing;
using System.Windows.Forms;
namespace QRcodeForm
{
    public partial class Form1 : Form
    {
        private int num = 0;
        public Form1()
        {
            InitializeComponent();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            if (url.Length == 0)
            {
                MessageBox.Show("请输入URL！再生码！");
                this.lbl_AllNumber.Text = "共:0行";
                this.lbl_Current.Text = "当前:0行";
                return;
            }
            if (txtIds.Lines.Length > 0)
            {
                num = 0;
                qrCodeGraphicControl1.Text = url + txtIds.Lines[0].ToString();
                this.txt_Msg.Text = txtIds.Lines[0].ToString();
                this.lbl_AllNumber.Text = "共:" + txtIds.Lines.Length + "行";
                this.lbl_Current.Text = "当前:" + (num + 1) + "行";
            }
            else
            {
                MessageBox.Show("请输入数据源！再生码！");
                this.lbl_AllNumber.Text = "共:0行";
                this.lbl_Current.Text = "当前:0行";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            if (url.Length == 0)
            {
                MessageBox.Show("请输入URL！再生码！");
                this.lbl_AllNumber.Text = "共:0行";
                this.lbl_Current.Text = "当前:0行";
                return;
            }
            if (num >=1 )
            {
                num--;
                qrCodeGraphicControl1.Text = url + txtIds.Lines[num].ToString();
                this.txt_Msg.Text = txtIds.Lines[num].ToString();
                this.lbl_AllNumber.Text = "共:" + txtIds.Lines.Length + "行";
                this.lbl_Current.Text = "当前:" + (num + 1) + "行";
            }
            else
            {
                MessageBox.Show("已是第一条数据！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            if (url.Length == 0)
            {
                MessageBox.Show("请输入URL！再生码！");
                this.lbl_AllNumber.Text = "共:0行";
                this.lbl_Current.Text = "当前:0行";
                return;
            }
            if (num + 1 < txtIds.Lines.Length)
            {
                num++;
                qrCodeGraphicControl1.Text = url + txtIds.Lines[num].ToString();
                this.txt_Msg.Text = txtIds.Lines[num].ToString();
                this.lbl_AllNumber.Text = "共:" + txtIds.Lines.Length + "行";
                this.lbl_Current.Text = "当前:" + (num + 1) + "行";
            }
            else
            {
                MessageBox.Show("已是最后一条数据！");
            }
        }


        private void txtIds_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            if (url.Length == 0)
            {
                MessageBox.Show("请输入URL！再生码！");
                this.lbl_AllNumber.Text = "共:0行";
                this.lbl_Current.Text = "当前:0行";
                return;
            }
            if (txtIds.Lines.Length > 0)
            {
                int index = txtIds.GetFirstCharIndexOfCurrentLine();//得到当前行第一个字符的索引
                int line = txtIds.GetLineFromCharIndex(index);//得到当前行的行号,从0开始
                num = line;
                qrCodeGraphicControl1.Text = url + txtIds.Lines[num].ToString();
                this.txt_Msg.Text = txtIds.Lines[num].ToString();
                this.lbl_AllNumber.Text = "共:" + txtIds.Lines.Length + "行";
                this.lbl_Current.Text = "当前:" + (num+1)+ "行";
            }
            else
            {
                this.lbl_AllNumber.Text = "共:0行";
                this.lbl_Current.Text = "当前:0行";
            }
        }

        /// <summary>
        /// 重写键盘响应事件
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        { 
            switch (keyData)
            {
                case Keys.Up:
                    //焦点定位到控件
                    button2.Focus();
                    //执行按钮点击操作
                    button2.PerformClick();
                    return true;
                case Keys.Down:
                    button3.Focus();
                    button3.PerformClick();
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonQr_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            if (url.Length == 0)
            {
                MessageBox.Show("请输入URL！再打印！"); 
                return;
            }
            if (txtURL.Text == string.Empty)
            {
                MessageBox.Show("输入URL不能为空！");
                return;
            }
            if (txtIds.Text == string.Empty)
            {
                MessageBox.Show("输入数据源不能为空！");
                return;
            }
            //清空
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < txtIds.Lines.Length; i++)
            {
                string txt = txtIds.Lines[i].ToString();
                if (!string.IsNullOrEmpty(txt))
                { 
                    UserControl1 ucpic = new UserControl1();
                    //窗体类加子控件添加该picBox控件
                    flowLayoutPanel1.Controls.Add(ucpic);
                    //加载图片放入自定义控件
                    ucpic.setpic(url + txt, txt); 
                }
            }
            //打印
            this.printDocument1.Print();
        }
        private Bitmap DrawMeToBitmap(Control Obj)
        {
            int w = 0, h = 0;
            foreach (Control var in Obj.Controls)
            {
                if (var.Right > w)
                    w = var.Right;
                if (var.Bottom > h)
                    h = var.Bottom;
            }
            w++;
            h++;
            Bitmap bmp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bmp);
            using (Brush backColorBrush = new SolidBrush(Obj.BackColor))
            {
                g.FillRectangle(backColorBrush, new Rectangle(0, 0, bmp.Width, bmp.Height));
                foreach (Control var in Obj.Controls)
                {
                    using (Bitmap b = new Bitmap(var.Width, var.Height))
                    {
                        var.DrawToBitmap(b, var.ClientRectangle);
                        g.DrawImage(b, var.Location);
                    }
                }
            }
            return bmp;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //打印内容为flowLayoutPanel1内容
            Bitmap bitmap = new Bitmap(flowLayoutPanel1.Width, flowLayoutPanel1.Height);
            flowLayoutPanel1.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            bitmap = DrawMeToBitmap(flowLayoutPanel1);
            bitmap.Save(@"D:\qrcode.png");
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
        }

    }
}
