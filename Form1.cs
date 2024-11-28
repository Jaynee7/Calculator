using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstNumber = double.Parse(tbFirstNumber.Text);
                double SecondNumber = double.Parse(tbSecondNumber.Text);
                double Answer = FirstNumber + SecondNumber;

                tbAnswer.Text = Answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstNumber = double.Parse(tbFirstNumber.Text);
                double SecondNumber = double.Parse(tbSecondNumber.Text);
                double Answer = FirstNumber - SecondNumber;

                tbAnswer.Text = Answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Subtraction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstNumber = double.Parse(tbFirstNumber.Text);
                double SecondNumber = double.Parse(tbSecondNumber.Text);
                double Answer = FirstNumber / SecondNumber;

                tbAnswer.Text = Answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Division Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstNumber = double.Parse(tbFirstNumber.Text);
                double SecondNumber = double.Parse(tbSecondNumber.Text);
                double Answer = FirstNumber * SecondNumber;

                tbAnswer.Text = Answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Multiplication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstNumber = double.Parse(tbFirstNumber.Text);
                double SecondNumber = double.Parse(tbSecondNumber.Text);
                double Answer = FirstNumber % SecondNumber;

                tbAnswer.Text = Answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modulus Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            tbAnswer.Text = "";
            tbFirstNumber.Text = "";
            tbSecondNumber.Text = "";
        }
    }
}
