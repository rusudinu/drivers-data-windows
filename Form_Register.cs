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

        private void autenthicateWithGoogleButton_MouseMove(object sender, MouseEventArgs e)
        {
            autenthicateWithGoogleButton.BackColor = Color.FromArgb(0, 0, 64);
            autenthicateWithGoogleButton.ForeColor = Color.White;
        }

        private void autenthicateWithGoogleButton_MouseLeave(object sender, EventArgs e)
        {
            autenthicateWithGoogleButton.BackColor = Color.White;
            autenthicateWithGoogleButton.ForeColor = Color.FromArgb(0, 0, 64);
        }

        private void autenthicateWithCodingShadowsAccountButton_MouseMove(object sender, MouseEventArgs e)
        {
            autenthicateWithCodingShadowsAccountButton.BackColor = Color.FromArgb(0, 0, 64);
            autenthicateWithCodingShadowsAccountButton.ForeColor = Color.White;
        }

        private void autenthicateWithCodingShadowsAccountButton_MouseLeave(object sender, EventArgs e)
        {
            autenthicateWithCodingShadowsAccountButton.BackColor = Color.White;
            autenthicateWithCodingShadowsAccountButton.ForeColor = Color.FromArgb(0, 0, 64);
        }

        private void registerWithACodingShadowsAccountButton_MouseMove(object sender, MouseEventArgs e)
        {
            registerWithACodingShadowsAccountButton.BackColor = Color.FromArgb(0, 0, 64);
            registerWithACodingShadowsAccountButton.ForeColor = Color.White;
        }

        private void registerWithACodingShadowsAccountButton_MouseLeave(object sender, EventArgs e)
        {
            registerWithACodingShadowsAccountButton.BackColor = Color.White;
            registerWithACodingShadowsAccountButton.ForeColor = Color.FromArgb(0, 0, 64);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeLabel_MouseMove(object sender, MouseEventArgs e)
        {
            closeLabel.ForeColor = Color.FromArgb(0, 0, 64);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }
    }
}
