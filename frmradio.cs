using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1743145_first_app
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void frmradio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rdoRed.ForeColor = Color.FromName("red");
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            rdoGreen.ForeColor = Color.FromName("green");
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            rdoBlue.ForeColor = Color.FromName("blue");
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            rdoYellow.ForeColor = Color.FromName("yellow");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoRed.ForeColor = Color.FromName("black");
            rdoGreen.ForeColor = Color.FromName("black");
            rdoBlue.ForeColor = Color.FromName("black");
            rdoYellow.ForeColor = Color.FromName("black");
        }
    }
}
