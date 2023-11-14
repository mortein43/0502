using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace _0502
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int shwCmds);
        public double opacity { get; set; }

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (radioButton1.Checked)
            {
                Form2 form2 = new Form2();
                if (checkBoxPatriot.Checked)
                {
                    form2.patriot = true;
                }
                else form2.patriot = false;
                form2.Show(this);
                ShowWindow(this.Handle, 0);
                //form2.wordsForStop = "stop";
                Global.needExit = true;
            }
            else if (radioButton2.Checked)
            {
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show("Введіть хоча б одне слово для виходу з прихованого режиму", "Інфо");
                } else
                {
                    Form2 form2 = new Form2();
                    if (checkBoxPatriot.Checked)
                    {
                        form2.patriot = true;
                    }
                    else form2.patriot = false;
                    ShowWindow(this.Handle, 0);
                    form2.wordsForStop = textBox1.Text;
                    Global.needExit = true;
                }
                
            }






            //this.Opacity = opacity;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (radioButton1.Checked) textBox1.Enabled = false;
            else if (radioButton2.Checked) textBox1.Enabled = true;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}