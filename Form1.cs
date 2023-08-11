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

        public string Status
        {
            get { return statusLabel.Text; }
            set { statusLabel.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();          
            InitChoiceTest_cb();
        }

        private void InitChoiceTest_cb()
        {
            choiceTest_cb.Items.AddRange(new string[] { "Тест №1", "Тест №2", "Тест №3" });
            choiceTest_cb.SelectedIndex = 0;
        }

        private async void choiceTest_btn_Click(object sender, EventArgs e)
        {
            choiceTest_btn.Enabled = false;

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

            await myTest.Run();

            choiceTest_btn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTest.Cancel();
        }

        
    }
}
