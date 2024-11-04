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
        string username = "33bakos";
        private MySqlConnection kapcsolat;
        private string connStr;
        public Form1()
        { 
            connStr = $"server=46.40.3.35; user={username}; database = {username}_szamologep";
            InitializeComponent();
            loadHistory();
            loadMemory();
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
        
        private void loadMemory()
        {
            memoryList.Items.Clear();
            
            kapcsolat = new MySqlConnection(connStr);
            try
            {
                kapcsolat.Open();
                string query = "SELECT memory FROM memory";
                MySqlCommand parancs = new MySqlCommand(query, kapcsolat);
                MySqlDataAdapter adapter = new MySqlDataAdapter(parancs);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                foreach (DataRow sor in dt.Rows)
                {
                    memoryList.Items.Add(sor["memory"].ToString());
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

        double currentNumber = 0;
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
            if (curNumStr.Length > 0)
            {
                if (isAdd)
                {
                    firstNum += float.Parse(curNumStr);
                }
                else if (isSub)
                {
                    firstNum -= float.Parse(curNumStr);
                }
                else if (isMul)
                {
                    firstNum *= float.Parse(curNumStr);
                }
                else if (isDiv)
                {
                    firstNum /= float.Parse(curNumStr);
                }
                else
                {
                    firstNum = float.Parse(curNumStr);
                }

                isAdd = true;
                isDiv = false;
                isSub = false;
                isMul = false;
                label1.Text = firstNum.ToString() + " + ";
                curNumStr = "";
                currentNumber = 0;
                mainNumber.Text = firstNum.ToString();
            }
        }

        //Button -
        private void button13_Click(object sender, EventArgs e)
        {
            if (curNumStr.Length > 0)
            {
                if (isAdd)
                {
                    firstNum += float.Parse(curNumStr);
                }
                else if (isSub)
                {
                    firstNum -= float.Parse(curNumStr);
                }
                else if (isMul)
                {
                    firstNum *= float.Parse(curNumStr);
                }
                else if (isDiv)
                {
                    firstNum /= float.Parse(curNumStr);
                }
                else
                {
                    firstNum = float.Parse(curNumStr);
                }

                isAdd = false;
                isDiv = false;
                isSub = true;
                isMul = false;
                label1.Text = firstNum.ToString() + " - ";
                curNumStr = "";
                currentNumber = 0;
                mainNumber.Text = firstNum.ToString();
            }

        }

        //Button *
        private void button9_Click(object sender, EventArgs e)
        {
            if (curNumStr.Length > 0)
            {
                if (isAdd)
                {
                    firstNum += float.Parse(curNumStr);
                }
                else if (isSub)
                {
                    firstNum -= float.Parse(curNumStr);
                }
                else if (isMul)
                {
                    firstNum *= float.Parse(curNumStr);
                }
                else if (isDiv)
                {
                    firstNum /= float.Parse(curNumStr);
                }
                else
                {
                    firstNum = float.Parse(curNumStr);
                }

                isAdd = false;
                isDiv = false;
                isSub = false;
                isMul = true;
                label1.Text = firstNum.ToString() + " * ";
                curNumStr = "";
                currentNumber = 0;
                mainNumber.Text = firstNum.ToString();
            }
        }

        //Button /
        private void button5_Click(object sender, EventArgs e)
        {
            if (curNumStr.Length > 0)
            {
                if (isAdd)
                {
                    firstNum += float.Parse(curNumStr);
                }
                else if (isSub)
                {
                    firstNum -= float.Parse(curNumStr);
                }
                else if (isMul)
                {
                    firstNum *= float.Parse(curNumStr);
                }
                else if (isDiv)
                {
                    firstNum /= float.Parse(curNumStr);
                }
                else
                {
                    firstNum = float.Parse(curNumStr);
                }

                isAdd = false;
                isDiv = true;
                isSub = false;
                isMul = false;
                label1.Text = firstNum.ToString() + " / ";
                curNumStr = "";
                currentNumber = 0;
                mainNumber.Text = firstNum.ToString();
            }
        }

        //Button Equals
        private void button21_Click(object sender, EventArgs e)
        {
            if (curNumStr.Length > 0)
            {
                string currOperator = "";

                if (isAdd)
                {
                    label1.Text = firstNum.ToString() + " + " + curNumStr + " =";
                    mainNumber.Text = (firstNum + float.Parse(curNumStr)).ToString();
                    currOperator = "+";
                }
                else if (isSub)
                {
                    label1.Text = firstNum.ToString() + " - " + curNumStr + " =";
                    mainNumber.Text = (firstNum - float.Parse(curNumStr)).ToString();
                    currOperator = "-";
                }
                else if (isDiv)
                {
                    label1.Text = firstNum.ToString() + " / " + curNumStr + " =";
                    mainNumber.Text = (firstNum / float.Parse(curNumStr)).ToString();
                    currOperator = "/";
                }
                else if (isMul)
                {
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

                    string query =
                        "INSERT INTO history (fullOperation, firstNum, secondNum, operator) VALUES (@operation, @firstNum, @secondNum, @operator)";
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
                finally
                {
                    kapcsolat.Close();
                }
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
            if (!string.IsNullOrEmpty(curNumStr))
            {
                float currentValue = float.Parse(curNumStr);
                currentValue = -currentValue;
                curNumStr = currentValue.ToString();
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
            if (!curNumStr.Contains("."))
            {
                curNumStr += ".";
                mainNumber.Text = curNumStr;
            }
        }

        //1/x
        private void button8_Click(object sender, EventArgs e)
        {
            if (curNumStr.Length > 0)
            {
                label1.Text = "1 / (" + curNumStr + ") =";
                curNumStr = (1 / (float.Parse(curNumStr))).ToString();
                mainNumber.Text = curNumStr;
            }
        }

        //Square
        private void button7_Click(object sender, EventArgs e)
        {
            if (curNumStr.Length > 0)
            {
                label1.Text = "sqr( " + curNumStr + " ) =";
                curNumStr = ((float.Parse(curNumStr)) * (float.Parse(curNumStr))).ToString();
                mainNumber.Text = curNumStr;
            }
        }

        //Square Root
        private void button6_Click(object sender, EventArgs e)
        {
            if (curNumStr.Length > 0)
            {
                label1.Text = "sqrt( " + curNumStr + " ) =";
                if (float.Parse(curNumStr) > 0 || !(curNumStr == ""))
                {
                    curNumStr = (Math.Sqrt(float.Parse(curNumStr))).ToString();
                    mainNumber.Text = curNumStr;
                }
                else
                {
                    mainNumber.Text = "Invalid Input";
                }
            }

        }

        //Percentage
        private void button1_Click(object sender, EventArgs e)
        {
            if (curNumStr.Length > 0)
            {
                if (firstNum == 0)
                {
                    mainNumber.Text = "0";
                    label1.Text = "0";
                }
                else
                {
                    float percentage = float.Parse(curNumStr) / 100;
                    if (isAdd)
                    {
                        curNumStr = (firstNum + (firstNum * percentage)).ToString();
                    }
                    else if (isSub)
                    {
                        curNumStr = (firstNum - (firstNum * percentage)).ToString();
                    }
                    else if (isMul || isDiv)
                    {
                        curNumStr = percentage.ToString();
                    }

                    mainNumber.Text = curNumStr;
                }
            }
        }

        private void recentList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            kapcsolat = new MySqlConnection(connStr);
            try
            {
                kapcsolat.Open();
                
                string query = "DELETE FROM history WHERE fullOperation=@fullOperation LIMIT 1";
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

        private double memory = 0;
        private void MemorySave_Click(object sender, EventArgs e)
        {
            memory = currentNumber; 
            memoryList.Items.Add(currentNumber);
            
            kapcsolat = new MySqlConnection(connStr);
            try
            {
                kapcsolat.Open();
                
                string query = "INSERT INTO memory (memory) VALUES (@memory)";
                MySqlCommand parancs = new MySqlCommand(query, kapcsolat);
                parancs.Parameters.AddWithValue("@memory", memory);

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
        
        private void MemoryClear_Click(object sender, EventArgs e)
        {
            if (memoryList.SelectedItems.Count == 1)
            {
                kapcsolat = new MySqlConnection(connStr);
                try
                {
                    kapcsolat.Open();
                
                    string query = "DELETE FROM memory WHERE memory=@memory LIMIT 1";
                    MySqlCommand parancs = new MySqlCommand(query, kapcsolat);
                    parancs.Parameters.AddWithValue("@memory", memoryList.SelectedItem.ToString());

                    parancs.ExecuteNonQuery();
                
                    loadMemory();
                
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

        private void MemorySub_Click(object sender, EventArgs e)
        {
            if (memoryList.SelectedItems.Count == 1)
            {
                memory -= currentNumber;
                memoryList.Items[memoryList.SelectedIndex] = memory;
            }
        }
        
        private void MemoryAdd_Click(object sender, EventArgs e)
        {
            if (memoryList.SelectedItems.Count == 1)
            {
                memory += currentNumber;
                memoryList.Items[memoryList.SelectedIndex] = memory;
            }

            
        }

        private void MemoryRecall_Click(object sender, EventArgs e)
        {
                if (memoryList.SelectedItem != null)
                {
                    string memoryValue = memoryList.SelectedItem.ToString();
                    curNumStr = memoryValue;
                    mainNumber.Text = memoryValue;
                }
        }


        private void memoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memoryList.SelectedItems.Count == 1)
            {
                memory = double.Parse(memoryList.SelectedItem.ToString());
                currentNumber = memory;
                mainNumber.Text = currentNumber.ToString();
                curNumStr = mainNumber.Text;
            }
        }
    }
}
