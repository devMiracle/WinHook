using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hook;
using System.Threading;

namespace WinHook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 0x70 клавиша F1
            var _hook_F1 = new Hook.Hook(0x70);
            _hook_F1.KeyPressed += new KeyPressEventHandler(_hook_F1_KeyPressed);
            _hook_F1.SetHook();

        }
        void _hook_F1_KeyPressed(object sender, KeyPressEventArgs e) //Событие нажатия клавиш
        {
            label2.Text = "F1";
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
