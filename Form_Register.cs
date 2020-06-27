using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversData_PC
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void autenthicateWithGoogleButton_Click(object sender, EventArgs e)
        {
            //todo this later
        }

        private void autenthicateWithCodingShadowsAccountButton_Click(object sender, EventArgs e)
        {
            Form autenthicateForm = new Form_Autenthicate();
            autenthicateForm.Show();
            this.Close();
        }

        private void registerWithACodingShadowsAccountButton_Click(object sender, EventArgs e)
        {
            Form registerWithCodingShadowsAccountForm = new Form_RegisterCodingShadowsAccount();
            registerWithCodingShadowsAccountForm.Show();
            this.Close();
        }
    }
}
