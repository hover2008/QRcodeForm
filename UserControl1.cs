using System.Windows.Forms;

namespace QRcodeForm
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void setpic(string qrc, string s)
        {
            this.qrcgc1.Text = qrc;
            this.label1.Text = s;
        }
    }
}
