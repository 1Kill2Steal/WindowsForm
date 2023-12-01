using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtCnfPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtCnfPassword.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "Успешна регистрация! Здравейте Изпит Практика!",
                "Успешна регистрация!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
