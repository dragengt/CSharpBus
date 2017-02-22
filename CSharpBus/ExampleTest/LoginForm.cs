using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CSharpBus;

namespace CSharpBusTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        /// <summary>
        /// Action of login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = tb_User.Text;
            string userPsw = tb_psw.Text;
            string funcName = "OnLogin";

            //Use if you know the func's type:
            BoolCallbackWithStrs method = CallbackBus.GetBoolCallbackWithStrs(funcName);
            bool checkResult = method(new string[] { userName, userPsw });
            MessageBox.Show("Call method "+ funcName  +" : " + checkResult);
            if (checkResult == true)
            {
                MessageBox.Show("Yes you can login");
            }


            //Use if you don't know the func's type:
            Delegate delegateMethod = CallbackBus.GetFunc(funcName);
            //--create param with string array:
            Object paramObj = new string[] { userName, userPsw };
            checkResult = (bool)delegateMethod.DynamicInvoke( paramObj );
            MessageBox.Show("Call invoke:" + checkResult);

            if (checkResult == true)
            {
                MessageBox.Show("Yes you can login");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string funcName = "LoginHandler-Welcom";
            StringCallback otherFunc = (StringCallback) CallbackBus.GetFunc(funcName);
            MessageBox.Show(otherFunc());
        }
    }
}
