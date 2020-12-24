/*
Editors : D. A. Dineth De Silva / Senith Galakumbura
*/
//Module for Susen version 1

using System;
using System.IO;
using System.Windows.Forms;

namespace App
{
    public partial class Module : Form
    {
        private static string[] Details = File.ReadAllLines("Module_Commander.txt");
        public Module()
        {
            InitializeComponent();
        }

        private void Module_Load(object sender, EventArgs e)
        {
            label1.Text = Details[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Details[1] == "A")
                {
                    StreamWriter Name_File = new StreamWriter("info.txt");
                    Name_File.Write(textBox1.Text);
                    Name_File.Close();
                }
                File.Delete("Module_Commander.txt");
                this.Close();
            }
        }
    }
}
