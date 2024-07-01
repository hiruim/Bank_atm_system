using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void BTN_SIGN_UP_Click(object sender, EventArgs e)
        {
            Signup sgnup = new Signup();
            sgnup.Show();
            this.Hide();
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            TXT_CARD_NO.Clear();
            TXT_PIN.Clear();
        }

        private void BTN_SIGN_IN_Click(object sender, EventArgs e)
        {
            Transaction trns = new Transaction();
            trns.Show();
            this.Hide();
        }
    }
}
