using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkSMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonSingleSMS_Click(object sender, EventArgs e)
        {
            SingleSms singleSms=new SingleSms();
            singleSms.ShowDialog();
        }

        private void buttonBulkSMS_Click(object sender, EventArgs e)
        {
            MultiNumber multiNumber=new MultiNumber();
            multiNumber.ShowDialog();
        }
    }
}
