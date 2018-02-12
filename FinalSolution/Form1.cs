using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSolution
{
    public partial class frmMain : Form
    {
        public bool filesOpened;
        public string[] column_a, column_b;
        public int colALines, colBLines;
        public string fileLoc1, fileLoc2;

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
            Random rand1 = new Random();
            string temp;
            colALines = File.ReadAllLines(fileLoc1).Length;
            colBLines = File.ReadAllLines(fileLoc2).Length;
            column_a = new string[colALines];
            column_b = new string[colBLines];


            StreamReader inputFile1 = new StreamReader(fileLoc1);

            try
            {
                int counter_a;

                counter_a = 0;
                do
                {
                    column_a[counter_a] = inputFile1.ReadLine();

                    counter_a++;
                } while (inputFile1.Peek() != 1);

            }
            catch
            {

            }
            finally
            {
                inputFile1.Close();
            }

            StreamReader inputFile2 = new StreamReader(fileLoc2);
            try
            {
                int counter_b;

                counter_b = 0;

                do
                {
                    column_b[counter_b] = inputFile2.ReadLine();
                    counter_b++;
                } while (inputFile2.Peek() != 1);
            }
            catch
            {

            }
            finally
            {
                inputFile2.Close();
            }

            temp = column_a[rand1.Next(0, colALines)] + " " + column_b[rand1.Next(0, colBLines)];
            return temp;
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
                fileLoc1 = openFileDialog1.FileName;
                fileLoc2 = openFileDialog2.FileName;
                DisplayName(RollName());
            }
        }

        private void openFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog2.ShowDialog();
            filesOpened = true;
        }
    }
}
