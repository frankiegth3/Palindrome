using BllPalindrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPalindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOFD = new OpenFileDialog();
            DialogResult result = myOFD.ShowDialog();
            if(result == DialogResult.OK)
            {
                PalindromeManagment myBLL = new PalindromeManagment();
                List<string> myList = myBLL.GetPalindromeFromFile(myOFD.FileName);

                LstAll.DataSource = myList;

            }
        }
    }
}
