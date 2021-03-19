using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {

        private string userID = "IU42453";
        private string password = "iqra@123";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (ValidateChildren(ValidationConstraints.Enabled))
            //{
            //    MessageBox.Show(txtUserID.Text, "Log In Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            errorProvider1.Clear();
            if (txtUserID.Text.Equals(""))
            {
                errorProvider1.SetError(txtUserID, "Please Enter User ID");
            } else if (txtUserPass.Text.Equals(""))
            {
                errorProvider1.SetError(txtUserPass, "Please Enter Password");
            } else
            {
                if (txtUserID.Text.Equals(userID) && txtUserPass.Text.Equals(password))
                {
                    MessageBox.Show(userID, "Log In Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show(userID, "Wrong ID or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUserID_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtUserID.Text))
            //{
            //    e.Cancel = true;
            //    txtUserID.Focus();
            //    errorProvider1.SetError(txtUserID, "Please Enter User ID");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtUserID, null);
            //}
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = txtUserPass.Text = "";
        }
    }
}
