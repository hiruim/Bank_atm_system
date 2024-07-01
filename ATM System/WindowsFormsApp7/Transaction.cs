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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_PINC_Click(object sender, EventArgs e)
        {
            Pin_Change pin = new Pin_Change();
            pin.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_DIPOSIT_Click(object sender, EventArgs e)
        {
            Diposit diposit = new Diposit();
            diposit.Show();
            this.Hide();
        }

        private void BTN_FASTCASH_Click(object sender, EventArgs e)
        {
            FASH_CASH fast = new FASH_CASH();
            fast.Show();
            this.Hide();
        }

        private void BTN_CASHWITH_Click(object sender, EventArgs e)
        {
            Withdrawal wthdrw = new Withdrawal();
            wthdrw.Show();
            this.Hide();
        }

        private void BTN_STAT_Click(object sender, EventArgs e)
        {
            statement statement = new statement();
            statement.Show();
            this.Hide();
        }
    }
}
