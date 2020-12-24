/*
Editors : D. A. Dineth De Silva / Senith Galakumbura
*/
//Main Susen program

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        private static string[] Documantation = File.ReadAllLines("Documantation.txt");
        private static int Document = 0;
        private static int User_C_C = 0;
        private static int We_C_C = 0;
        private static string We_Com;
        private static string User_Com;
        private static Label label_U;
        private static Label label_W;
        private static int timer;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Log.log"))
            {
                this.Close();
            }
            //File.Delete("Log.log");
            label10.Text = "";
            label_W = new Label();
            label_W.Name = "We" + We_C_C;
            label_W.MaximumSize = new Size(125, 0);
            label_W.AutoSize = true;
            label_W.Font = new Font("Comic Sans MS", 10);
            label_W.BackColor = Color.LightGray;
            label_W.Location = new Point(0, 0);
            try
            {
                string[] Lines = File.ReadAllLines("info.txt");
                label_W.Text = "Hello " + Lines[0] + "\n";
            }
            catch (FileNotFoundException)
            {
                StreamWriter Ask = new StreamWriter("Module_Commander.txt");
                Ask.WriteLine("Please enter your name,So that I can help you better ?");
                Ask.WriteLine("A");
                Ask.Close();
                Module Ask_Name = new Module();
                Ask_Name.TopMost = true;
                Ask_Name.Show();
                label_W.Text = "Hello\n";
            }
            if (DateTime.Now.ToString("tt") == "AM")
            {
                label_W.Text += "Good morning !";
            }
            else if (DateTime.Now.ToString("tt") == "PM")
            {
                label_W.Text += "Good evening !";
            }
            ChatArea.Controls.Add(label_W);
            We_Com = label_W.Name;
            We_C_C++;
            Doc.Start();
        }
        private void Send_Click(object sender, EventArgs e)
        {
            if (User_I.Text != "")
            {
                label_U = new Label();
                label_U.Name = "User" + User_C_C;
                label_U.MaximumSize = new Size(125, 0);
                label_U.AutoSize = true;
                label_U.Text = User_I.Text;
                label_U.Font = new Font("Comic Sans MS", 10);
                label_U.BackColor = Color.DeepSkyBlue;
                if (We_Com != null)
                {
                    label_U.Location = new Point(140, label_W.Location.Y + label_W.Height + 2);
                }
                else
                {
                    label_U.Location = new Point(140, 0);
                }
                ChatArea.Controls.Add(label_U);
                User_Com = label_U.Name;
                Brain(User_I.Text);
                User_C_C++;
                User_I.Text = "";
            }
        }
        private void Brain(string User_I)
        {
            //Susen main system
            label_W = new Label();
            label_W.Name = "We" + We_C_C;
            label_W.MaximumSize = new Size(125, 0);
            label_W.AutoSize = true;
            label_W.Font = new Font("Comic Sans MS", 10);
            label_W.BackColor = Color.LightGray;
            if (User_Com != "")
            {
                label_W.Location = new Point(0, label_U.Location.Y + label_U.Height + 2);
            }
            else
            {
                label_W.Location = new Point(0, 0);
            }
            if (User_I == "Exit")
            {
                label_W.Text = "Bye!";
                Exit.Start();
            }
            else if (User_I.Contains("Convert"))
            {
                //Converter engine
                //Use Susen uC.dll library and ESODS UnitConverter.dll library
                //Filtering requared parameters
                double Unit_V;
                string Unit;
                string to_Unit;
                try
                {
                    int position = 7;
                    while (Char.IsWhiteSpace(User_I[position]))
                    {
                        position++;
                    }
                    bool Over = false;
                    bool Nrange;
                    double Value;
                    int range = 0;
                    while (!Over)
                    {
                        range++;
                        string Value_S = User_I.Substring(position, range);
                        Nrange = double.TryParse(Value_S, out Value);
                        if (Nrange == false)
                        {
                            Over = true;
                        }
                    }
                    Unit_V = Convert.ToDouble(User_I.Substring(position, range - 1));
                    int position2 = (position - 1) + Convert.ToString(Unit_V).Length + 1;
                    while (Char.IsWhiteSpace(User_I[position2]))
                    {
                        position2++;
                    }
                    bool Over2 = false;
                    int index2 = position2;
                    Unit = "";
                    while (!Over2)
                    {
                        if (Char.IsWhiteSpace(User_I[index2]))
                        {
                            Over2 = true;
                        }
                        else
                        {
                            Unit += User_I[index2];
                        }
                        index2++;
                    }
                    int index3 = User_I.Length - 1;
                    bool Over3 = false;
                    to_Unit = "";
                    while (!Over3)
                    {
                        if (char.IsWhiteSpace(User_I[index3]))
                        {
                            Over3 = true;
                        }
                        else
                        {
                            to_Unit += User_I[index3];
                        }
                        index3--;
                    }
                    int Index = to_Unit.Length - 1;
                    string GenS = "";
                    while (Index >= 0)
                    {
                        GenS += to_Unit[Index];
                        Index--;
                    }
                    to_Unit = GenS;
                }
                catch (Exception)
                {
                    Unit_V = 0;
                    Unit = null;
                    to_Unit = null;
                    Error();
                }
                /*End filtering parameters as,
                double Unit_V,
                string Unit,
                string to_Unit
                */
                if(Unit != null && to_Unit != null)
                {
                    switch (uC.uC.Unitditerminer(Unit))
                    {
                        case "Masstomass":
                            switch (uC.uC.Unitditerminer(to_Unit))
                            {
                                case "Masstomass":
                                    label_W.Text = Convert.ToString(UnitConverter.Unittounit.Masstomass(Unit_V, Unit, to_Unit, "printvhlwh")) + " " + to_Unit;
                                    break;
                                default:
                                    Error();
                                    break;
                            }
                            break;
                        case "Lengthtolength":
                            switch (uC.uC.Unitditerminer(to_Unit))
                            {
                                case "Lengthtolength":
                                    label_W.Text = Convert.ToString(UnitConverter.Unittounit.Lengthtolength(Unit_V, Unit, to_Unit, "printvhlwh")) + " " + to_Unit;
                                    break;
                                default:
                                    Error();
                                    break;
                            }
                            break;
                        case "Temptotemp":
                            switch (uC.uC.Unitditerminer(to_Unit))
                            {
                                case "Temptotemp":
                                    label_W.Text = Convert.ToString(UnitConverter.Unittounit.Temptotemp(Unit_V, Unit, to_Unit, "printvhlwh")) + " " + to_Unit;
                                    break;
                                default:
                                    Error();
                                    break;
                            }
                            break;
                        case null:
                            Error();
                            break;
                    }
                }
                
            }
            else if(User_I == "What is today's date?" || User_I == "What's today's date?")
            {
                DateTime now = DateTime.Now;
                label_W.Text = Convert.ToString(now);
            }
            else
            {
                Error();
            }
            ChatArea.Controls.Add(label_W);
            We_Com = label_W.Name;
            We_C_C++;  
        }
        private void Error()
        {
            label_W.Text = "Sorry I didn't get that!";
        }
        //Timers
        private void Exit_Tick(object sender, EventArgs e)
        {
            if (timer > 3)
            {
                this.Close();
            }
            timer++;
        }
        private void Doc_Tick(object sender, EventArgs e)
        {
            if (Document == Documantation.Length)
            {
                Document = 0;
            }
            label10.Text = Documantation[Document];
            Document++;
        }
    }
}
