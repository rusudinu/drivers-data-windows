using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversData_PC
{
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void Form_Splash_Shown(object sender, EventArgs e)
        {
            //check for updates with the version number on the server

            if (Class_HandleAppUpdates.checkForUpdate())
            {

            }
            else
            {
                //Begin loading
                //Log the user in if it is possible
                this.Hide();
                Form formMainForm = new Form_MainForm();
                formMainForm.ShowDialog();
            }
        }
    }
}
