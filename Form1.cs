using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace simplecalc
{
    public partial class Form1 : Form
    {
        private MySqlConnection kapcsolat;
        string connStr = "server=46.40.3.35; user=33bakos; database = 33bakos_szamologep";
        public Form1()
        {
            InitializeComponent();
            loadHistory();
        }
        
        private void loadHistory()
        {
            recentList.Items.Clear();
            
            kapcsolat = new MySqlConnection(connStr);
            try
            {
                kapcsolat.Open();
                string query = "SELECT fullOperation FROM history";
                MySqlCommand parancs = new MySqlCommand(query, kapcsolat);
                MySqlDataAdapter adapter = new MySqlDataAdapter(parancs);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                foreach (DataRow sor in dt.Rows)
                {
                    recentList.Items.Add(sor["fullOperation"].ToString());
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Hiba: " + a.Message);
            }
            finally {
                kapcsolat.Close();
            }
        }

        float currentNumber = 0;
        string curNumStr = "";
        float firstNum = 0;

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
                currentNumber = float.Parse(curNumStr);
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
            else if (curNumStr.Length < 9) {
                curNumStr = curNumStr + "1";
                currentNumber = float.Parse(curNumStr);
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
                currentNumber = float.Parse(curNumStr);
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
                currentNumber = float.Parse(curNumStr);
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
                currentNumber = float.Parse(curNumStr);
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
                currentNumber = float.Parse(curNumStr);
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
                currentNumber = float.Parse(curNumStr);
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
                currentNumber = float.Parse(curNumStr);
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
                currentNumber = float.Parse(curNumStr);
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
                currentNumber = float.Parse(curNumStr);
                mainNumber.Text = curNumStr;
            }
        }

        //Button +
        private void button17_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isDiv = false;
            isSub = false;
            isMul = false;

            firstNum = float.Parse(curNumStr);
            label1.Text = firstNum.ToString() + " + ";
            curNumStr = "";
            currentNumber = 0;
            mainNumber.Text = "0";


        }

        //Button -
        private void button13_Click(object sender, EventArgs e)
        {
            isSub = true;
            isAdd = false;
            isDiv = false;
            isMul = false;

            firstNum = float.Parse(curNumStr);
            label1.Text = firstNum.ToString() + " - ";
            curNumStr = "";
            currentNumber = 0;
            mainNumber.Text = "0";

        }

        //Button *
        private void button9_Click(object sender, EventArgs e)
        {
            isMul = true;
            isAdd = false;
            isDiv = false;
            isSub = false;

            firstNum = float.Parse(curNumStr);
            label1.Text = firstNum.ToString() + " * ";
            curNumStr = "";
            currentNumber = 0;
            mainNumber.Text = "0";

        }

        //Button /
        private void button5_Click(object sender, EventArgs e)
        {
            isDiv = true;
            isAdd = false;
            isSub = false;
            isMul = false;

            firstNum = float.Parse(curNumStr);
            label1.Text = firstNum.ToString() + " / ";
            curNumStr = "";
            currentNumber = 0;
            mainNumber.Text = "0";
        }

        //Button Equals
        private void button21_Click(object sender, EventArgs e)
        {
            string currOperator = "";
            
            if (isAdd)
            {
                label1.Text = firstNum.ToString() + " + " + curNumStr + " =";
                mainNumber.Text = (firstNum + float.Parse(curNumStr)).ToString();
                currOperator = "+";
            }
            else if (isSub) {
                label1.Text = firstNum.ToString() + " - " + curNumStr + " =";
                mainNumber.Text = (firstNum - float.Parse(curNumStr)).ToString();
                currOperator = "-";
            }
            else if (isDiv) {
                label1.Text = firstNum.ToString() + " / " + curNumStr + " =";
                mainNumber.Text = (firstNum / float.Parse(curNumStr)).ToString();
                currOperator = "/";
            }
            else if (isMul) {
                label1.Text = firstNum.ToString() + " * " + curNumStr + " =";
                mainNumber.Text = (firstNum * float.Parse(curNumStr)).ToString();
                currOperator = "*";
            }

            recentList.Items.Add(label1.Text + " " + mainNumber.Text);
            string operation = label1.Text + mainNumber.Text;
            
            kapcsolat = new MySqlConnection(connStr);
            try
            {
                kapcsolat.Open();
                
                string query = "INSERT INTO history (fullOperation, firstNum, secondNum, operator) VALUES (@operation, @firstNum, @secondNum, @operator)";
                MySqlCommand parancs = new MySqlCommand(query, kapcsolat);
                parancs.Parameters.AddWithValue("@operation", operation);
                parancs.Parameters.AddWithValue("@firstNum", firstNum);
                parancs.Parameters.AddWithValue("@secondNum", currentNumber);
                parancs.Parameters.AddWithValue("@operator", currOperator);

                parancs.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show("Hiba: " + a.Message);
            }
            finally {
                kapcsolat.Close();
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
            if (float.Parse(curNumStr) > 0 || float.Parse(curNumStr) < 0)
            {
                curNumStr = (float.Parse(curNumStr) * -1).ToString();
                mainNumber.Text = curNumStr;
            }
        }

        //Delete Last
        private void button4_Click(object sender, EventArgs e)
        {
            if (curNumStr.Length > 0) {
                curNumStr = curNumStr.Remove(curNumStr.Length - 1);
                mainNumber.Text = curNumStr;
            }

        }

        //Decimal
        private void button22_Click(object sender, EventArgs e)
        {
            curNumStr = curNumStr + ".";
            mainNumber.Text = curNumStr;
        }

        //1/x
        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "1 / (" + curNumStr + ") =";
            curNumStr = (1/(float.Parse(curNumStr))).ToString();
            mainNumber.Text = curNumStr;
        }

        //Square
        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "sqr( " + curNumStr + " ) =";
            curNumStr = ( (float.Parse(curNumStr))*(float.Parse(curNumStr)) ).ToString();
            mainNumber.Text = curNumStr;
        }

        //Square Root
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "sqrt( " + curNumStr + " ) =";
            if (float.Parse(curNumStr) > 0 || !(curNumStr == ""))
            {
                curNumStr = (Math.Sqrt(float.Parse(curNumStr))).ToString();
                mainNumber.Text = curNumStr;
            }

            //gotta fix this, crash when 0
            else if (curNumStr == "") {
                mainNumber.Text = "0";
            }
            else
            {
                mainNumber.Text = "Invalid Input";
            }
            
            
        }

        //Percentage
        private void button1_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                mainNumber.Text = "0";
                label1.Text = "0";
            }
            else
            {
                if (isDiv)
                {
                    curNumStr = ((float.Parse(curNumStr)) / 100).ToString();
                    mainNumber.Text = curNumStr;
                }
                else if (isMul)
                {
                    curNumStr = ((float.Parse(curNumStr)) / 100).ToString();
                    mainNumber.Text = curNumStr;
                }

                //no clue what formula needed
                else if (isAdd) 
                {
                    curNumStr = (float.Parse(curNumStr) / 100*firstNum).ToString();
                }
                else if (isSub)
                {

                }
            }
        }

        private void recentList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            kapcsolat = new MySqlConnection(connStr);
            try
            {
                kapcsolat.Open();
                
                string query = "DELETE FROM history WHERE fullOperation=@fullOperation";
                MySqlCommand parancs = new MySqlCommand(query, kapcsolat);
                parancs.Parameters.AddWithValue("@fullOperation", recentList.SelectedItem.ToString());

                parancs.ExecuteNonQuery();
                
                loadHistory();
                
                
            }
            catch (Exception a)
            {
                MessageBox.Show("Hiba: " + a.Message);
            }
            finally {
                kapcsolat.Close();
                
            }
        }
    }
}
