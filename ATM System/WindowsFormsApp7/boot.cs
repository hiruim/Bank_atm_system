using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class boot : Form
    {
        public boot()
        {
            InitializeComponent();
        }

        private void boot_Load(object sender, EventArgs e)
        {

        }

        private void LoadTime_Tick(object sender, EventArgs e)
        {
            LoadPanel.Width += 3;

            if(LoadPanel.Width >= 599)
            {
                LoadTime.Stop();
                login lgn = new login();
                lgn.Show();
                this.Hide();
            }
        }

        private void LoadPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
