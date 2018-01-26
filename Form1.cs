using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class GreenvilleRevenueGUI : Form
    {
        public GreenvilleRevenueGUI()
        {
            InitializeComponent();
        }

        private void FinalButton_Click(object sender, EventArgs e) // uppercase first letter on method
        {
            double thisYear = Convert.ToDouble(thisYearTxt.Text); // declaration of variable types
            double lastYear = Convert.ToDouble(lastYearTxt.Text);
            double totalRev = thisYear * 25; // camel casing on variable
            totalRev1.Text=("Total revenue " + totalRev.ToString("C"));
           
            expectedRevenueLabel.Visible = true;
            greaterLabel.Visible = true;

        }
    }
}
// double may not be neccesary since result will always be a multiple of 25, thus an int
