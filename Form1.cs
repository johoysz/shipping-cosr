using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingCost
{
    public partial class Form1 : Form
    {
        const int mmRate = 350, ccRate = 300, bRate = 295, sRate = 230, dcRate = 200;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void resetBtn_MouseEnter(object sender, EventArgs e)
        {
            resetBtn.BackColor= Color.Red;
        }
        private void resetButton_MouseHover(object sender, EventArgs e)
        {
            resetBtn.BackColor = Color.Red;
        }
        private void resetButton_MouseLeave(object sender, EventArgs e)
        {
            resetBtn.BackColor= Color.Linen;
        }
        private void resetButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxUserInput.Text = string.Empty;
            comboBoxCity.Text = string.Empty;
            kilogramLabel.Text = string.Empty;
            cityLabel.Text = string.Empty;
            totalCostLabel.Text = string.Empty;
        }
        private void textBoxUserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != (char)Keys.Back) { //allow digit, decimal point, and backspace
                
                e.Handled = true;
            }
        }
        private void buttonCal_MouseEnter(object sender, EventArgs e)
        {
            buttonDel.BackColor = Color.DarkSeaGreen;
        }
        private void deliverButton_MouseHover(object sender, EventArgs e)
        {
            buttonDel.BackColor = Color.DarkSeaGreen;
        }
        private void deliverButton_MouseLeave(object sender, EventArgs e)
        {
            buttonDel.BackColor = Color.Linen;
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string comboxCity = comboBoxCity.Text;
            double kg = Convert.ToDouble(textBoxUserInput.Text);
            if (comboxCity.Equals("Metro Manila"))
            {
                total = kg * mmRate;
                kilogramLabel.Text = kg.ToString();
                cityLabel.Text = comboxCity;
                totalCostLabel.Text = total.ToString("PHP 0.00");
            }
            else if (comboxCity.Equals("Cebu City"))
            {
                total = kg * ccRate;
                kilogramLabel.Text = kg.ToString();
                cityLabel.Text = comboxCity;
                totalCostLabel.Text = total.ToString("PHP 0.00");
            }
            else if (comboxCity.Equals("Bacolod"))
            {
                total = kg * bRate;
                kilogramLabel.Text = kg.ToString();
                cityLabel.Text = comboxCity;
                totalCostLabel.Text = total.ToString("PHP 0.00");
            }
            else if (comboxCity.Equals("Siargao"))
            {
                total = kg * sRate;
                kilogramLabel.Text = kg.ToString();
                cityLabel.Text = comboxCity;
                totalCostLabel.Text = total.ToString("PHP 0.00");
            }
            else {
                total = kg * dcRate;
                kilogramLabel.Text = kg.ToString();
                cityLabel.Text = comboxCity;
                totalCostLabel.Text = total.ToString("PHP 0.00");
            }
         }

    }
}