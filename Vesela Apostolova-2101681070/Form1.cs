using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vesela_Apostolova_2101681070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double ketchup = 0.20;
        double mayo = 0.30;
        double mstr = 0.40;
        double chickenBurger = 3.80;
        double mcBeef = 4.80;
        double cola = 2.80;
        double appleJ = 3.00;
        double cherryJ = 2.00;
        double sum = 0;
        double cheesebur = 4.30;
        private void cbKetchup_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKetchup.CheckState==CheckState.Checked)
            {
                pictureBox1.Image = Properties.Resources.ketchup;
                sum += ketchup;
            }
        }

        private void cbMayo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMayo.CheckState == CheckState.Checked)
            {
                pictureBox2.Image = Properties.Resources.mayo;
                sum += mayo;
            }
        }

        private void cbMustard_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMustard.CheckState == CheckState.Checked)
            {
                pictureBox3.Image = Properties.Resources.copycat_mcdonalds_hot_mustard_sauce_;
                sum += mstr;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Juice-Apple")
            {
                sum += appleJ;
            }
            else if (comboBox1.Text=="Juice-Cherry")
            {
                sum += cherryJ;
            }
            else if (comboBox1.Text=="Cola")
            {
                sum += cola;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show($"You have to pay {Math.Round(sum,2)}lv.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to delete your order?","Delete oreder",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            cbKetchup.CheckState = CheckState.Unchecked;
            cbMayo.CheckState = CheckState.Unchecked;
            cbMustard.CheckState = CheckState.Unchecked;
            comboBox1.Text = string.Empty;


        }
        
        private void cbChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChicken.CheckState == CheckState.Checked)
                sum += chickenBurger;
        }

        private void cbBeef_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBeef.CheckState == CheckState.Checked)
                sum += mcBeef;
        }

        private void cbCheeese_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheeese.CheckState == CheckState.Checked)
                sum += cheesebur;
        }
    }
}
