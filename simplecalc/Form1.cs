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
        string curNumStr = "";
        int firstNum = 0;

        bool isAdd = false;
        bool isSub = false;
        bool isDiv = false;
        bool isMul = false;



        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        //Button 0
        private void button23_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 0;
                mainNumber.Text = currentNumber.ToString();
            }
            else if (curNumStr.Length < 9)
            {
                curNumStr = curNumStr + "0";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button 1
        private void button20_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 1;
                curNumStr = curNumStr + "1";
                mainNumber.Text = currentNumber.ToString();
            }
            else if(curNumStr.Length < 9) {
                curNumStr = curNumStr + "1";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button 2
        private void button19_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 2;
                curNumStr = curNumStr + "2";
                mainNumber.Text = currentNumber.ToString();
            }
            else if (curNumStr.Length < 9)
            {
                curNumStr = curNumStr + "2";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button 3
        private void button18_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 3;
                curNumStr = curNumStr + "3";
                mainNumber.Text = currentNumber.ToString();
            }
            else if (curNumStr.Length < 9)
            {
                curNumStr = curNumStr + "3";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button 4
        private void button16_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 4;
                curNumStr = curNumStr + "4";
                mainNumber.Text = currentNumber.ToString();
            }
            else if (curNumStr.Length < 9)
            {
                curNumStr = curNumStr + "4";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button 5
        private void button15_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 5;
                curNumStr = curNumStr + "5";
                mainNumber.Text = currentNumber.ToString();
            }
            else if (curNumStr.Length < 9)
            {
                curNumStr = curNumStr + "5";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button 6
        private void button14_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 6;
                curNumStr = curNumStr + "6";
                mainNumber.Text = currentNumber.ToString();
            }
            else if (curNumStr.Length < 9)
            {
                curNumStr = curNumStr + "6";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button 7
        private void button12_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 7;
                curNumStr = curNumStr + "7";
                mainNumber.Text = currentNumber.ToString();
            }
            else if (curNumStr.Length < 9)
            {
                curNumStr = curNumStr + "7";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button 8
        private void button11_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 8;
                curNumStr = curNumStr + "8";
                mainNumber.Text = currentNumber.ToString();
            }
            else if (curNumStr.Length < 9)
            {
                curNumStr = curNumStr + "8";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button 9
        private void button10_Click(object sender, EventArgs e)
        {
            if (currentNumber == 0)
            {
                currentNumber = 9;
                curNumStr = curNumStr + "9";
                mainNumber.Text = currentNumber.ToString();
            }
            else if (curNumStr.Length < 9)
            {
                curNumStr = curNumStr + "9";
                currentNumber = Int64.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button +
        private void button17_Click(object sender, EventArgs e)
        {
            firstNum = Int32.Parse(curNumStr);
            label1.Text = firstNum.ToString() + " + ";
            curNumStr = "";
            currentNumber = 0;
            mainNumber.Text = "0";
            isAdd = true;

        }

        //Button -
        private void button13_Click(object sender, EventArgs e)
        {
            firstNum = Int32.Parse(curNumStr);
            label1.Text = firstNum.ToString() + " - ";
            curNumStr = "";
            currentNumber = 0;
            mainNumber.Text = "0";
            isSub = true;
        }

        //Button *
        private void button9_Click(object sender, EventArgs e)
        {
            firstNum = Int32.Parse(curNumStr);
            label1.Text = firstNum.ToString() + " * ";
            curNumStr = "";
            currentNumber = 0;
            mainNumber.Text = "0";
            isMul = true;
        }

        //Button /
        private void button5_Click(object sender, EventArgs e)
        {
            firstNum = Int32.Parse(curNumStr);
            label1.Text = firstNum.ToString() + " / ";
            curNumStr = "";
            currentNumber = 0;
            mainNumber.Text = "0";
            isDiv = true;
        }

        //Button =
        private void button21_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                label1.Text = firstNum.ToString() + " + " + curNumStr + " =";
                mainNumber.Text = (firstNum + Int32.Parse(curNumStr)).ToString();
            }
            else if (isSub) {
                label1.Text = firstNum.ToString() + " - " + curNumStr + " =";
                mainNumber.Text = (firstNum - Int32.Parse(curNumStr)).ToString();
            }
            else if (isDiv) {
                label1.Text = firstNum.ToString() + " / " + curNumStr + " =";
                mainNumber.Text = (firstNum / Int32.Parse(curNumStr)).ToString();
            }
            else if (isMul) {
                label1.Text = firstNum.ToString() + " * " + curNumStr + " =";
                mainNumber.Text = (firstNum * Int32.Parse(curNumStr)).ToString();
            }


            
        }

        //Clear Entry
        private void button2_Click(object sender, EventArgs e)
        {
            mainNumber.Text = "0";
            curNumStr = "";
            currentNumber = 0;
        }

        //Clear
        private void button3_Click(object sender, EventArgs e)
        {
            mainNumber.Text = "0";
            curNumStr = "";
            currentNumber = 0;
            firstNum = 0;
            label1.Text = "";
            isAdd = false;
            isDiv = false;
            isSub = false;
            isMul = false;
        }

        //Button +/-
        private void button24_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(curNumStr) > 0 || Int32.Parse(curNumStr) < 0)
            {
                curNumStr = (Int32.Parse(curNumStr) * -1).ToString();
                mainNumber.Text = curNumStr;
            }
        }

        //Delete Last
        private void button4_Click(object sender, EventArgs e)
        {
            curNumStr = curNumStr.Remove(curNumStr.Length - 1);
            mainNumber.Text = curNumStr;
        }
    }
}
