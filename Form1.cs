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

        private void finalButton_Click(object sender, EventArgs e)
        {
            thisYear = Convert.ToDouble(thisYearTxt.Text);
            lastYear = Convert.ToDouble(lastYearTxt.Text);
            totalrev = thisYear * 25; 
            totalrev1.Text=("Total revenue "+ totalrev.ToString("C"));
           
            expectedRevenueLabel.Visible = true;
            greaterLabel.Visible = true;

        }
    }
}
