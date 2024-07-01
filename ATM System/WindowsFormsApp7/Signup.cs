using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BTN_CAN_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            this.Hide();
        }

        private void BTN_SUB_Click(object sender, EventArgs e)
        {
            string CS = "Data Source=THEHELLRAISER;Initial Catalog=LANKA_PAY_BANK;Integrated Security=True";
            SqlConnection SQLcon = new SqlConnection(CS);
            SQLcon.Open();

            SqlCommand insert1 = new SqlCommand("INSERT INTO Customer (Name, Mname, DoB, Email, Mstatus, Address, city, Pin, Status, AccType) VALUES('" + TXT_NAME.Text + "','" + TXT_MNAME.Text + "','" + DTTM_DOB.Text + "','" + GRP_GNDR.Text + "','" + TXT_EMAIL.Text + "','" + GRP_MRTL_STTS.Text + "','" + TXT_ADDRESS.Text + "','" + TXT_CITY.Text + "','" + TXT_PINC.Text + "','" + TXT_STATE.Text + "','" + GRP_ACCTYP.Text + "')", SQLcon);
            int I = insert1.ExecuteNonQuery();

            if (I != 0)
            {
                if (MessageBox.Show("You are now registered to our services. thank you for choosing Lanka Pay Bank!", "Sign-up Successful!", MessageBoxButtons.OK) == DialogResult.Yes)
                {
                    login lgn = new login();
                    lgn.Show();
                    this.Hide();
                }
            }
            SQLcon.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
