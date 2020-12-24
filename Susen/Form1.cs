/*
Editors : D. A. Dineth De Silva / Senith Galakumbura
*/
//Loading for Susen version 1

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Susen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Status.Text = "Checking product files...";
            string[] Files =
                {"Nothing",
                "yet !"};
            int Increment = 100 / Files.Length;
            int File_N = 0;
            bool Error = false;
            while (File_N < Files.Length && !Error)
            {
                if (!File.Exists(Files[File_N]))
                {
                    Error = true;
                }
                progressBar1.Value += Increment;
                File_N++;
            }
            if (Error)
            {
                Status.ForeColor = Color.Red;
                Status.Text = "An error occured while\nrunning this software";
            }
            else
            {
                progressBar1.Value = 100;
                Status.Text = "Opening Susen...";
                StreamWriter Log = new StreamWriter("Log.log");
                Log.Close();
                Exitting.Start();
            }
        }
        //Timers
        private void Exitting_Tick(object sender, EventArgs e)
        {
            Process App = new Process();
            App.StartInfo.FileName = "App.exe";
            App.Start();
            this.Close();
        }
    }
}
