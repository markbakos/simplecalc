using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplecalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float currentNumber = 0;
        string curNumStr;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Button 0
        private void button23_Click(object sender, EventArgs e)
        {
        
        }

        //Button 1
        private void button20_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 1;
                mainNumber.Text = currentNumber.ToString();
            }
            else {
                curNumStr = curNumStr + "1";
                currentNumber = Int32.Parse(curNumStr);
                mainNumber.Text = currentNumber.ToString();
            }
        }

        //Button 2
        private void button19_Click(object sender, EventArgs e)
        {

        }

        //Button 3
        private void button18_Click(object sender, EventArgs e)
        {

        }

        //Button 4
        private void button16_Click(object sender, EventArgs e)
        {

        }

        //Button 5
        private void button15_Click(object sender, EventArgs e)
        {

        }

        //Button 6
        private void button14_Click(object sender, EventArgs e)
        {

        }

        //Button 7
        private void button12_Click(object sender, EventArgs e)
        {

        }

        //Button 8
        private void button11_Click(object sender, EventArgs e)
        {

        }

        //Button 9
        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
