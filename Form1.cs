using MetranTest.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetranTest
{
    public partial class Form1 : Form
    {
        ITest myTest;

        public Form1()
        {
            InitializeComponent();

            initChoiceTestCB();
        }
        private void initChoiceTestCB()
        {
            choiceTest_cb.Items.AddRange(new string[] { "Тест №1", "Тест №2", "Тест №3" });
            choiceTest_cb.SelectedIndex = 0;
        }

        private void choiceTest_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_tb.Text.Trim()))
            {
                MessageBox.Show("Введите идентификатор");
                return;
            }

            

            switch (choiceTest_cb.SelectedIndex)
            {                                                                 
                case 0: myTest = new Test1(id_tb.Text); break;                //Тест1               
                case 1: myTest = new Test2(id_tb.Text, nameof(Test1)); break; //Тест2, по результатам первого  
                case 2: myTest = new Test3(id_tb.Text); break;                //Тест3

                default: return;
            }

            myTest.Run();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTest.Cancel();
        }
    }
}
