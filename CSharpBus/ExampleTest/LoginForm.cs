using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReflectionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                danteBus.CallbackBus.GetFunc("OnLogin").DynamicInvoke("?user=dante&psw=123123").ToString()
                );


            bool value = 
                danteBus.CallbackBus.GetBoolCallbackFuncWithStr("OnLogin")("user&psw");

            MessageBox.Show("return value is " + value);
        }
    }
}
