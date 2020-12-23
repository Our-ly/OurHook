using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;
using System.Diagnostics;
using System.Drawing.Text;
using System.Timers;
using Timer = System.Windows.Forms.Timer;
using WeAreDevs_API;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;

namespace OurHook_v1._0
{
    public partial class Form1 : Form
    {
        readonly EasyExploits.Module module = new EasyExploits.Module(); bool darkMode = false;
        readonly ExploitAPI api = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
       
        }
        private void FlatComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }


        private void FormSkin2_Click(object sender, EventArgs e)
        {

        }
        private void TabPage1_Click_4(object sender, EventArgs e)
        {

        }
        private void FlatButton1_Click_1(object sender, EventArgs e)
        {
            if (flatComboBox1.Text == "EasyExploits")
            {
                module.ExecuteScript(script.Text);
            }
            else if (flatComboBox1.Text == "WeAreDevs")
            {
                api.SendLuaCScript(script.Text);
            }
            else if (flatComboBox1.Text == "none")
            {
                MessageBox.Show("Choose an API!\n Settings -> API", "retard alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            script.Text = "";
            Execute.TextColor = System.Drawing.Color.Green;
            Execute.Text = "Executed!";
            Refresh();
            executed.Start();
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void FlatButton3_Click(object sender, EventArgs e)
        {
            if (flatComboBox1.Text == "EasyExploits")
            {
                module.LaunchExploit();
            }
            else if (flatComboBox1.Text == "WeAreDevs")
            {
                api.LaunchExploit();
            }
            else if (flatComboBox1.Text == "none")
            {
                MessageBox.Show("Choose an API!\n Settings -> API", "retard alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FastColoredTextBox1_Load_1(object sender, EventArgs e)
        {

        }

        private void FlatButton2_Click(object sender, EventArgs e)
        {
            script.Text = "";
        }

        private void FlatButton1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog
            {
                Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                script.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.script.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                _ = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FlatButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MaskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            script.Text = "";
            script.Text = "loadstring(game:HttpGet(('https://raw.githubusercontent.com/Sjorbiia/X-Scripts/master/PrisonXV3.5%20-%20Experimental.lua'),true))()";
            module.ExecuteScript(script.Text);
            script.Text = "";

        }

        private void MaskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void XuiSwitch2_Click(object sender, EventArgs e)
        {
            if (TopMost == false)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            script.Text = "";
            script.Text = "loadstring(game:HttpGetAsync('http://bruh.ws/unc0vered',true))()";
            module.ExecuteScript(script.Text);
            script.Text = "";
        }

        private void FlatButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void XuiSwitch3_Click(object sender, EventArgs e)
        {
            if (darkMode == false)
            {
                darkMode = true;
                OurHook.HeaderColor = System.Drawing.Color.DimGray;
                OurHook.BaseColor = System.Drawing.Color.Gray;
                OurHook.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                Settings.ActiveColor = System.Drawing.Color.Black;
                Settings.BaseColor = System.Drawing.Color.DimGray;
                script.BackColor = System.Drawing.Color.Gray;
                background1.BackColor = System.Drawing.Color.Gray;
                background2.BackColor = System.Drawing.Color.Gray;
                text2.BackColor = System.Drawing.Color.Gray;
                text3.BackColor = System.Drawing.Color.Gray;
                text4.BackColor = System.Drawing.Color.Gray;
                xuiSwitch2.BackColor = System.Drawing.Color.Gray;
                xuiSwitch3.BackColor = System.Drawing.Color.Gray;
                script.IndentBackColor = System.Drawing.Color.Gray;
                script.LineNumberColor = System.Drawing.Color.Black;
                OurHook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                flatLabel1.BackColor = System.Drawing.Color.Gray;
                flatLabel2.BackColor = System.Drawing.Color.Gray;
                flatLabel2.BackColor = System.Drawing.Color.Gray;
                tabPage2.BackColor = System.Drawing.Color.Gray;
                maskedTextBox1.BackColor = System.Drawing.Color.Gray;
                flatComboBox1.HoverColor = System.Drawing.Color.Gray;
                flatLabel3.BackColor = System.Drawing.Color.Gray;
                this.Refresh();
            }
            else
            {
                darkMode = false;
                OurHook.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                OurHook.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                OurHook.FlatColor = System.Drawing.Color.HotPink;
                Settings.ActiveColor = System.Drawing.Color.HotPink;
                Settings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                script.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                background1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                background2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                text3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                text4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                xuiSwitch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                xuiSwitch3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                script.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                script.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                OurHook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                flatLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                flatLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                flatLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
                maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                flatComboBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                flatLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                flatLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                this.Refresh();
            }
        }


        private void Executed_Tick(object sender, EventArgs e)
        {
            executed.Stop();
            Execute.Text = "Execute";
            Execute.TextColor = System.Drawing.Color.White;
            Refresh();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            script.Text = "";
            script.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/bockatta/Shitter/main/Loader'))();";
            module.ExecuteScript(script.Text);
            script.Text = "";
        }

        private void FlatLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.roblox.com/games/155615604/Prison-Life-Cars-fixed");
        }

        private void FlatLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.roblox.com/games/286090429/Arsenal");
        }

        private void FlatLabel3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.roblox.com/games/379614936/Assassin");
        }

        private void MaskedTextBox1_MaskInputRejected_2(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
