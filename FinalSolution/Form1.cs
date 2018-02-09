using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSolution
{
    public partial class frmMain : Form
    {
        public bool filesOpened;


        public frmMain()
        {
            InitializeComponent();
            filesOpened = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private string RollName()
        {
            return "";
        }

        private void DisplayName(string strInput)
        {
            txtDisplay.Text = strInput;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            if (filesOpened == false)
            {
                return;

            }
            else
            {
                DisplayName(RollName());
            }
        }

        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog2.ShowDialog();
        }
    }
}
