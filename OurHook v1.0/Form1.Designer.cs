namespace OurHook_v1._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OurHook = new FlatUI.FormSkin();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.Execute = new FlatUI.FlatButton();
            this.Settings = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.script = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.xuiSwitch3 = new XanderUI.XUISwitch();
            this.flatButton5 = new FlatUI.FlatButton();
            this.text3 = new System.Windows.Forms.MaskedTextBox();
            this.xuiSwitch2 = new XanderUI.XUISwitch();
            this.text2 = new System.Windows.Forms.MaskedTextBox();
            this.flatButton4 = new FlatUI.FlatButton();
            this.background1 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.text4 = new System.Windows.Forms.MaskedTextBox();
            this.background2 = new System.Windows.Forms.ListView();
            this.executed = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OurHook.SuspendLayout();
            this.Settings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.script)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OurHook
            // 
            this.OurHook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OurHook.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OurHook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OurHook.Controls.Add(this.flatButton3);
            this.OurHook.Controls.Add(this.flatButton2);
            this.OurHook.Controls.Add(this.flatButton1);
            this.OurHook.Controls.Add(this.Execute);
            this.OurHook.Controls.Add(this.Settings);
            this.OurHook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OurHook.FlatColor = System.Drawing.Color.HotPink;
            this.OurHook.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OurHook.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OurHook.HeaderMaximize = false;
            this.OurHook.Location = new System.Drawing.Point(0, 0);
            this.OurHook.Name = "OurHook";
            this.OurHook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OurHook.Size = new System.Drawing.Size(800, 450);
            this.OurHook.TabIndex = 1;
            this.OurHook.Text = "OurHook";
            this.OurHook.Click += new System.EventHandler(this.FormSkin2_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.HotPink;
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton3.Location = new System.Drawing.Point(3, 401);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(112, 42);
            this.flatButton3.TabIndex = 4;
            this.flatButton3.Text = "Inject";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.UseCustomColor = false;
            this.flatButton3.Click += new System.EventHandler(this.FlatButton3_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.HotPink;
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton2.Location = new System.Drawing.Point(3, 158);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(112, 42);
            this.flatButton2.TabIndex = 3;
            this.flatButton2.Text = "Clear";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.UseCustomColor = false;
            this.flatButton2.Click += new System.EventHandler(this.FlatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.HotPink;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton1.Location = new System.Drawing.Point(3, 110);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(112, 42);
            this.flatButton1.TabIndex = 2;
            this.flatButton1.Text = "Open Lua";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.UseCustomColor = false;
            this.flatButton1.Click += new System.EventHandler(this.FlatButton1_Click_2);
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.Transparent;
            this.Execute.BaseColor = System.Drawing.Color.HotPink;
            this.Execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Execute.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.Location = new System.Drawing.Point(3, 61);
            this.Execute.Name = "Execute";
            this.Execute.Rounded = false;
            this.Execute.Size = new System.Drawing.Size(112, 42);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Execute";
            this.Execute.TextColor = System.Drawing.Color.White;
            this.Execute.UseCustomColor = false;
            this.Execute.Click += new System.EventHandler(this.FlatButton1_Click_1);
            // 
            // Settings
            // 
            this.Settings.ActiveColor = System.Drawing.Color.HotPink;
            this.Settings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Settings.Controls.Add(this.tabPage1);
            this.Settings.Controls.Add(this.tabPage2);
            this.Settings.Controls.Add(this.tabPage3);
            this.Settings.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ItemSize = new System.Drawing.Size(120, 46);
            this.Settings.Location = new System.Drawing.Point(117, 0);
            this.Settings.Multiline = true;
            this.Settings.Name = "Settings";
            this.Settings.SelectedIndex = 0;
            this.Settings.Size = new System.Drawing.Size(683, 450);
            this.Settings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Settings.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.script);
            this.tabPage1.Location = new System.Drawing.Point(4, 50);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lua C";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click_4);
            // 
            // script
            // 
            this.script.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.script.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.script.BackBrush = null;
            this.script.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.script.CharHeight = 14;
            this.script.CharWidth = 8;
            this.script.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.script.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.script.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.script.IsReplaceMode = false;
            this.script.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.script.Location = new System.Drawing.Point(0, 0);
            this.script.Name = "script";
            this.script.Paddings = new System.Windows.Forms.Padding(0);
            this.script.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.script.Size = new System.Drawing.Size(679, 397);
            this.script.TabIndex = 0;
            this.script.Zoom = 100;
            this.script.Load += new System.EventHandler(this.FastColoredTextBox1_Load_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.flatComboBox1);
            this.tabPage2.Controls.Add(this.maskedTextBox1);
            this.tabPage2.Controls.Add(this.xuiSwitch3);
            this.tabPage2.Controls.Add(this.flatButton5);
            this.tabPage2.Controls.Add(this.text3);
            this.tabPage2.Controls.Add(this.xuiSwitch2);
            this.tabPage2.Controls.Add(this.text2);
            this.tabPage2.Controls.Add(this.flatButton4);
            this.tabPage2.Controls.Add(this.background1);
            this.tabPage2.Location = new System.Drawing.Point(4, 50);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 396);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Settings";
            // 
            // flatComboBox1
            // 
            this.flatComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flatComboBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.flatComboBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox1.ForeColor = System.Drawing.Color.White;
            this.flatComboBox1.FormattingEnabled = true;
            this.flatComboBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flatComboBox1.ItemHeight = 16;
            this.flatComboBox1.Items.AddRange(new object[] {
            "EasyExploits",
            "WeAreDevs"});
            this.flatComboBox1.Location = new System.Drawing.Point(86, 134);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(180, 22);
            this.flatComboBox1.TabIndex = 17;
            this.flatComboBox1.SelectedIndexChanged += new System.EventHandler(this.FlatComboBox1_SelectedIndexChanged_1);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(21, 127);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(162, 34);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.Text = "API";
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected_2);
            // 
            // xuiSwitch3
            // 
            this.xuiSwitch3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.xuiSwitch3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.xuiSwitch3.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiSwitch3.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.xuiSwitch3.Location = new System.Drawing.Point(189, 62);
            this.xuiSwitch3.Name = "xuiSwitch3";
            this.xuiSwitch3.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.xuiSwitch3.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSwitch3.Size = new System.Drawing.Size(77, 44);
            this.xuiSwitch3.SwitchState = XanderUI.XUISwitch.State.Off;
            this.xuiSwitch3.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.xuiSwitch3.TabIndex = 13;
            this.xuiSwitch3.Text = "xuiSwitch3";
            this.xuiSwitch3.Click += new System.EventHandler(this.XuiSwitch3_Click);
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.Transparent;
            this.flatButton5.BaseColor = System.Drawing.Color.HotPink;
            this.flatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton5.ForeColor = System.Drawing.Color.White;
            this.flatButton5.Location = new System.Drawing.Point(3, 351);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Rounded = false;
            this.flatButton5.Size = new System.Drawing.Size(330, 42);
            this.flatButton5.TabIndex = 12;
            this.flatButton5.Text = "Close Cheat";
            this.flatButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton5.UseCustomColor = false;
            this.flatButton5.Click += new System.EventHandler(this.FlatButton5_Click);
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.text3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text3.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.ForeColor = System.Drawing.Color.White;
            this.text3.Location = new System.Drawing.Point(10, 68);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(173, 34);
            this.text3.TabIndex = 11;
            this.text3.Text = "Darkmode";
            this.text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xuiSwitch2
            // 
            this.xuiSwitch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.xuiSwitch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.xuiSwitch2.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiSwitch2.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.xuiSwitch2.Location = new System.Drawing.Point(189, 6);
            this.xuiSwitch2.Name = "xuiSwitch2";
            this.xuiSwitch2.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.xuiSwitch2.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSwitch2.Size = new System.Drawing.Size(77, 44);
            this.xuiSwitch2.SwitchState = XanderUI.XUISwitch.State.Off;
            this.xuiSwitch2.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.xuiSwitch2.TabIndex = 10;
            this.xuiSwitch2.Text = "xuiSwitch2";
            this.xuiSwitch2.Click += new System.EventHandler(this.XuiSwitch2_Click);
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.text2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text2.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.White;
            this.text2.Location = new System.Drawing.Point(10, 11);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(173, 34);
            this.text2.TabIndex = 9;
            this.text2.Text = "Topmost";
            this.text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox3_MaskInputRejected);
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.HotPink;
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton4.ForeColor = System.Drawing.Color.White;
            this.flatButton4.Location = new System.Drawing.Point(342, 351);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(330, 42);
            this.flatButton4.TabIndex = 5;
            this.flatButton4.Text = "Minimize Cheat";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.UseCustomColor = false;
            this.flatButton4.Click += new System.EventHandler(this.FlatButton4_Click);
            // 
            // background1
            // 
            this.background1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.background1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.background1.HideSelection = false;
            this.background1.Location = new System.Drawing.Point(-4, -10);
            this.background1.MultiSelect = false;
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(680, 408);
            this.background1.TabIndex = 0;
            this.background1.UseCompatibleStateImageBehavior = false;
            this.background1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.flatLabel3);
            this.tabPage3.Controls.Add(this.flatLabel2);
            this.tabPage3.Controls.Add(this.flatLabel1);
            this.tabPage3.Controls.Add(this.text4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.background2);
            this.tabPage3.Location = new System.Drawing.Point(4, 50);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(675, 396);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Scripts";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flatLabel3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(281, 81);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(72, 17);
            this.flatLabel3.TabIndex = 13;
            this.flatLabel3.Text = "Assassin!";
            this.flatLabel3.Click += new System.EventHandler(this.FlatLabel3_Click);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flatLabel2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(166, 81);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(63, 17);
            this.flatLabel2.TabIndex = 12;
            this.flatLabel2.Text = "Arsenal";
            this.flatLabel2.Click += new System.EventHandler(this.FlatLabel2_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flatLabel1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(32, 81);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(86, 17);
            this.flatLabel1.TabIndex = 11;
            this.flatLabel1.Text = "Prison Life";
            this.flatLabel1.Click += new System.EventHandler(this.FlatLabel1_Click);
            // 
            // text4
            // 
            this.text4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.text4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text4.Font = new System.Drawing.Font("Showcard Gothic", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text4.ForeColor = System.Drawing.Color.White;
            this.text4.Location = new System.Drawing.Point(0, 363);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(675, 32);
            this.text4.TabIndex = 8;
            this.text4.Text = "Script Automagically executes after clicking!";
            this.text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text4.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox2_MaskInputRejected);
            // 
            // background2
            // 
            this.background2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.background2.HideSelection = false;
            this.background2.Location = new System.Drawing.Point(-4, -2);
            this.background2.MultiSelect = false;
            this.background2.Name = "background2";
            this.background2.Size = new System.Drawing.Size(682, 398);
            this.background2.TabIndex = 1;
            this.background2.UseCompatibleStateImageBehavior = false;
            this.background2.SelectedIndexChanged += new System.EventHandler(this.ListView2_SelectedIndexChanged);
            // 
            // executed
            // 
            this.executed.Interval = 500;
            this.executed.Tick += new System.EventHandler(this.Executed_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(260, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 66);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(139, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 66);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(18, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 66);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OurHook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.OurHook.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.script)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin OurHook;
        private FlatUI.FlatButton Execute;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatButton flatButton4;
        private FlatUI.FlatTabControl Settings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView background1;
        private FastColoredTextBoxNS.FastColoredTextBox script;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView background2;
        private System.Windows.Forms.MaskedTextBox text4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox text2;
        private XanderUI.XUISwitch xuiSwitch2;
        private System.Windows.Forms.Button button2;
        private FlatUI.FlatButton flatButton5;
        private System.Windows.Forms.MaskedTextBox text3;
        private XanderUI.XUISwitch xuiSwitch3;
        private System.Windows.Forms.Timer executed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private FlatUI.FlatComboBox flatComboBox1;
    }
}

