using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Year_Born_Lab_Click(object sender, EventArgs e)
        {

        }

        private void Years_Old_Click(object sender, EventArgs e)
        {

        }

        private void BornIn_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            int year = (int)datetime.Year;
            int z;
            Int32.TryParse(BornInTextBox.Text, out z);
            var res = year - z;
            Year_Born_Lab.Text = res.ToString();
        }

        private void YearsOld_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            int year = (int)datetime.Year;
            int y;
            Int32.TryParse(YearsOldTextBox.Text, out y);
            var res = year - y;
            Years_Old.Text = res.ToString();
        }

        private void BornInTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YearsOldTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
