using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if( tbPassword.Text == "pbo123"){
                MainMenu mm = new MainMenu();
                mm.ShowDialog();
                //this.Close();
            }
            else{
                MessageBox.Show("Password anda tidak valid!");
            }
        }
    }
}
