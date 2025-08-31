using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
namespace SMBW_SaveGame_Editor
{
    partial class MainWindow
    {
   
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BtnOpenSaveFile = new System.Windows.Forms.Button();
            this.BtnPatchSaveFile = new System.Windows.Forms.Button();
            this.LblPath = new System.Windows.Forms.Label();
            this.PanelPath = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.World_1 = new System.Windows.Forms.TabPage();
            this.LblW1Cleared = new System.Windows.Forms.Label();
            this.LblW1GoalSeed = new System.Windows.Forms.Label();
            this.LblW1Level = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.W1Label2 = new System.Windows.Forms.Label();
            this.W1Label3 = new System.Windows.Forms.Label();
            this.W1Label4 = new System.Windows.Forms.Label();
            this.W1Label5 = new System.Windows.Forms.Label();
            this.W1Label6 = new System.Windows.Forms.Label();
            this.W1Label7 = new System.Windows.Forms.Label();
            this.W1Label8 = new System.Windows.Forms.Label();
            this.W1Label9 = new System.Windows.Forms.Label();
            this.W1Label10 = new System.Windows.Forms.Label();
            this.W1Label1 = new System.Windows.Forms.Label();
            this.W1ClearCheckBox1 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox2 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox3 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox4 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox5 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox6 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox7 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox8 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox9 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox10 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed1 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed2 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed3 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed4 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed5 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed6 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed7 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed8 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed9 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed10 = new System.Windows.Forms.CheckBox();
            this.GameProgression = new System.Windows.Forms.TabPage();
            this.BtnUncheckAll = new System.Windows.Forms.Button();
            this.BtnCheckAll = new System.Windows.Forms.Button();
            this.LblToggle = new System.Windows.Forms.Label();
            this.LblGameProgress = new System.Windows.Forms.Label();
            this.GrSeed6 = new System.Windows.Forms.Label();
            this.GrSeed5 = new System.Windows.Forms.Label();
            this.GrSeed4 = new System.Windows.Forms.Label();
            this.GrSeed3 = new System.Windows.Forms.Label();
            this.GrSeed2 = new System.Windows.Forms.Label();
            this.GrSeed1 = new System.Windows.Forms.Label();
            this.GameComplete = new System.Windows.Forms.Label();
            this.GrSeed6Btn = new System.Windows.Forms.CheckBox();
            this.GrSeed5Btn = new System.Windows.Forms.CheckBox();
            this.GrSeed4Btn = new System.Windows.Forms.CheckBox();
            this.GrSeed3Btn = new System.Windows.Forms.CheckBox();
            this.GrSeed2Btn = new System.Windows.Forms.CheckBox();
            this.GrSeed1Btn = new System.Windows.Forms.CheckBox();
            this.CompleteGameBtn = new System.Windows.Forms.CheckBox();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.LblLives = new System.Windows.Forms.Label();
            this.InputLives = new System.Windows.Forms.NumericUpDown();
            this.LblPCoin = new System.Windows.Forms.Label();
            this.InputPCoins = new System.Windows.Forms.NumericUpDown();
            this.InputCoins = new System.Windows.Forms.NumericUpDown();
            this.LblCoin = new System.Windows.Forms.Label();
            this.TabControlValues = new System.Windows.Forms.TabControl();
            this.PanelPath.SuspendLayout();
            this.World_1.SuspendLayout();
            this.GameProgression.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputCoins)).BeginInit();
            this.TabControlValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOpenSaveFile
            // 
            this.BtnOpenSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpenSaveFile.Location = new System.Drawing.Point(11, 12);
            this.BtnOpenSaveFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOpenSaveFile.Name = "BtnOpenSaveFile";
            this.BtnOpenSaveFile.Size = new System.Drawing.Size(120, 37);
            this.BtnOpenSaveFile.TabIndex = 0;
            this.BtnOpenSaveFile.Text = "Open Savefile";
            this.BtnOpenSaveFile.UseVisualStyleBackColor = true;
            this.BtnOpenSaveFile.Click += new System.EventHandler(this.OpenSaveFile);
            // 
            // BtnPatchSaveFile
            // 
            this.BtnPatchSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPatchSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPatchSaveFile.Enabled = false;
            this.BtnPatchSaveFile.Location = new System.Drawing.Point(149, 339);
            this.BtnPatchSaveFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPatchSaveFile.Name = "BtnPatchSaveFile";
            this.BtnPatchSaveFile.Size = new System.Drawing.Size(131, 37);
            this.BtnPatchSaveFile.TabIndex = 3;
            this.BtnPatchSaveFile.Text = "Patch Savefile";
            this.BtnPatchSaveFile.UseVisualStyleBackColor = true;
            this.BtnPatchSaveFile.Click += new System.EventHandler(this.BtnPatchSaveFile_Click);
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblPath.Location = new System.Drawing.Point(-1, 7);
            this.LblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(107, 16);
            this.LblPath.TabIndex = 5;
            this.LblPath.Text = "game_data.sav";
            // 
            // PanelPath
            // 
            this.PanelPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPath.Controls.Add(this.LblPath);
            this.PanelPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelPath.Location = new System.Drawing.Point(139, 15);
            this.PanelPath.Margin = new System.Windows.Forms.Padding(4);
            this.PanelPath.Name = "PanelPath";
            this.PanelPath.Size = new System.Drawing.Size(441, 32);
            this.PanelPath.TabIndex = 6;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.Enabled = false;
            this.BtnReset.Location = new System.Drawing.Point(11, 339);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(131, 37);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Unload Savefile";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.CloseSaveFile);

            // 
            // World_1
            // 
            this.World_1.Controls.Add(this.LblW1Cleared);
            this.World_1.Controls.Add(this.LblW1GoalSeed);
            this.World_1.Controls.Add(this.LblW1Level);
            this.World_1.Controls.Add(this.button1);
            this.World_1.Controls.Add(this.button2);
            this.World_1.Controls.Add(this.W1Label2);
            this.World_1.Controls.Add(this.W1Label3);
            this.World_1.Controls.Add(this.W1Label4);
            this.World_1.Controls.Add(this.W1Label5);
            this.World_1.Controls.Add(this.W1Label6);
            this.World_1.Controls.Add(this.W1Label7);
            this.World_1.Controls.Add(this.W1Label8);
            this.World_1.Controls.Add(this.W1Label9);
            this.World_1.Controls.Add(this.W1Label10);
            this.World_1.Controls.Add(this.W1Label1);
            this.World_1.Controls.Add(this.W1ClearCheckBox1);
            this.World_1.Controls.Add(this.W1ClearCheckBox2);
            this.World_1.Controls.Add(this.W1ClearCheckBox3);
            this.World_1.Controls.Add(this.W1ClearCheckBox4);
            this.World_1.Controls.Add(this.W1ClearCheckBox5);
            this.World_1.Controls.Add(this.W1ClearCheckBox6);
            this.World_1.Controls.Add(this.W1ClearCheckBox7);
            this.World_1.Controls.Add(this.W1ClearCheckBox8);
            this.World_1.Controls.Add(this.W1ClearCheckBox9);
            this.World_1.Controls.Add(this.W1ClearCheckBox10);
            this.World_1.Controls.Add(this.W1EndGoalSeed1);
            this.World_1.Controls.Add(this.W1EndGoalSeed2);
            this.World_1.Controls.Add(this.W1EndGoalSeed3);
            this.World_1.Controls.Add(this.W1EndGoalSeed4);
            this.World_1.Controls.Add(this.W1EndGoalSeed5);
            this.World_1.Controls.Add(this.W1EndGoalSeed6);
            this.World_1.Controls.Add(this.W1EndGoalSeed7);
            this.World_1.Controls.Add(this.W1EndGoalSeed8);
            this.World_1.Controls.Add(this.W1EndGoalSeed9);
            this.World_1.Controls.Add(this.W1EndGoalSeed10);
            this.World_1.Location = new System.Drawing.Point(4, 25);
            this.World_1.Margin = new System.Windows.Forms.Padding(4);
            this.World_1.Name = "World_1";
            this.World_1.Size = new System.Drawing.Size(561, 255);
            this.World_1.TabIndex = 7;
            this.World_1.Text = "World1 Levels";
            this.World_1.UseVisualStyleBackColor = true;
            // 
            // LblW1Cleared
            // 
            this.LblW1Cleared.AutoSize = true;
            this.LblW1Cleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblW1Cleared.Location = new System.Drawing.Point(274, 38);
            this.LblW1Cleared.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblW1Cleared.Name = "LblW1Cleared";
            this.LblW1Cleared.Size = new System.Drawing.Size(120, 17);
            this.LblW1Cleared.TabIndex = 103;
            this.LblW1Cleared.Text = "Course Cleared";
            this.LblW1Cleared.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblW1GoalSeed
            // 
            this.LblW1GoalSeed.AutoSize = true;
            this.LblW1GoalSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblW1GoalSeed.Location = new System.Drawing.Point(445, 38);
            this.LblW1GoalSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblW1GoalSeed.Name = "LblW1GoalSeed";
            this.LblW1GoalSeed.Size = new System.Drawing.Size(84, 17);
            this.LblW1GoalSeed.TabIndex = 102;
            this.LblW1GoalSeed.Text = "Goal Seed";
            this.LblW1GoalSeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblW1Level
            // 
            this.LblW1Level.AutoSize = true;
            this.LblW1Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblW1Level.Location = new System.Drawing.Point(57, 38);
            this.LblW1Level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblW1Level.Name = "LblW1Level";
            this.LblW1Level.Size = new System.Drawing.Size(47, 17);
            this.LblW1Level.TabIndex = 101;
            this.LblW1Level.Text = "Level";
            this.LblW1Level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblW1Level.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 70;
            this.button1.Text = "Uncheck All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 430);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 69;
            this.button2.Text = "Check All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // W1Label2
            // 
            this.W1Label2.Location = new System.Drawing.Point(0, 0);
            this.W1Label2.Name = "W1Label2";
            this.W1Label2.Size = new System.Drawing.Size(100, 23);
            this.W1Label2.TabIndex = 71;
            // 
            // W1Label3
            // 
            this.W1Label3.Location = new System.Drawing.Point(0, 0);
            this.W1Label3.Name = "W1Label3";
            this.W1Label3.Size = new System.Drawing.Size(100, 23);
            this.W1Label3.TabIndex = 72;
            // 
            // W1Label4
            // 
            this.W1Label4.Location = new System.Drawing.Point(0, 0);
            this.W1Label4.Name = "W1Label4";
            this.W1Label4.Size = new System.Drawing.Size(100, 23);
            this.W1Label4.TabIndex = 73;
            // 
            // W1Label5
            // 
            this.W1Label5.Location = new System.Drawing.Point(0, 0);
            this.W1Label5.Name = "W1Label5";
            this.W1Label5.Size = new System.Drawing.Size(100, 23);
            this.W1Label5.TabIndex = 74;
            // 
            // W1Label6
            // 
            this.W1Label6.Location = new System.Drawing.Point(0, 0);
            this.W1Label6.Name = "W1Label6";
            this.W1Label6.Size = new System.Drawing.Size(100, 23);
            this.W1Label6.TabIndex = 75;
            // 
            // W1Label7
            // 
            this.W1Label7.Location = new System.Drawing.Point(0, 0);
            this.W1Label7.Name = "W1Label7";
            this.W1Label7.Size = new System.Drawing.Size(100, 23);
            this.W1Label7.TabIndex = 76;
            // 
            // W1Label8
            // 
            this.W1Label8.Location = new System.Drawing.Point(0, 0);
            this.W1Label8.Name = "W1Label8";
            this.W1Label8.Size = new System.Drawing.Size(100, 23);
            this.W1Label8.TabIndex = 77;
            // 
            // W1Label9
            // 
            this.W1Label9.Location = new System.Drawing.Point(0, 0);
            this.W1Label9.Name = "W1Label9";
            this.W1Label9.Size = new System.Drawing.Size(100, 23);
            this.W1Label9.TabIndex = 78;
            // 
            // W1Label10
            // 
            this.W1Label10.Location = new System.Drawing.Point(0, 0);
            this.W1Label10.Name = "W1Label10";
            this.W1Label10.Size = new System.Drawing.Size(100, 23);
            this.W1Label10.TabIndex = 79;
            // 
            // W1Label1
            // 
            this.W1Label1.Location = new System.Drawing.Point(0, 0);
            this.W1Label1.Name = "W1Label1";
            this.W1Label1.Size = new System.Drawing.Size(100, 23);
            this.W1Label1.TabIndex = 80;
            // 
            // W1ClearCheckBox1
            // 
            this.W1ClearCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox1.Name = "W1ClearCheckBox1";
            this.W1ClearCheckBox1.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox1.TabIndex = 81;
            // 
            // W1ClearCheckBox2
            // 
            this.W1ClearCheckBox2.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox2.Name = "W1ClearCheckBox2";
            this.W1ClearCheckBox2.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox2.TabIndex = 82;
            // 
            // W1ClearCheckBox3
            // 
            this.W1ClearCheckBox3.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox3.Name = "W1ClearCheckBox3";
            this.W1ClearCheckBox3.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox3.TabIndex = 83;
            // 
            // W1ClearCheckBox4
            // 
            this.W1ClearCheckBox4.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox4.Name = "W1ClearCheckBox4";
            this.W1ClearCheckBox4.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox4.TabIndex = 84;
            // 
            // W1ClearCheckBox5
            // 
            this.W1ClearCheckBox5.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox5.Name = "W1ClearCheckBox5";
            this.W1ClearCheckBox5.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox5.TabIndex = 85;
            // 
            // W1ClearCheckBox6
            // 
            this.W1ClearCheckBox6.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox6.Name = "W1ClearCheckBox6";
            this.W1ClearCheckBox6.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox6.TabIndex = 86;
            // 
            // W1ClearCheckBox7
            // 
            this.W1ClearCheckBox7.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox7.Name = "W1ClearCheckBox7";
            this.W1ClearCheckBox7.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox7.TabIndex = 87;
            // 
            // W1ClearCheckBox8
            // 
            this.W1ClearCheckBox8.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox8.Name = "W1ClearCheckBox8";
            this.W1ClearCheckBox8.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox8.TabIndex = 88;
            // 
            // W1ClearCheckBox9
            // 
            this.W1ClearCheckBox9.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox9.Name = "W1ClearCheckBox9";
            this.W1ClearCheckBox9.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox9.TabIndex = 89;
            // 
            // W1ClearCheckBox10
            // 
            this.W1ClearCheckBox10.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox10.Name = "W1ClearCheckBox10";
            this.W1ClearCheckBox10.Size = new System.Drawing.Size(104, 24);
            this.W1ClearCheckBox10.TabIndex = 90;
            // 
            // W1EndGoalSeed1
            // 
            this.W1EndGoalSeed1.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed1.Name = "W1EndGoalSeed1";
            this.W1EndGoalSeed1.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed1.TabIndex = 91;
            // 
            // W1EndGoalSeed2
            // 
            this.W1EndGoalSeed2.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed2.Name = "W1EndGoalSeed2";
            this.W1EndGoalSeed2.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed2.TabIndex = 92;
            // 
            // W1EndGoalSeed3
            // 
            this.W1EndGoalSeed3.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed3.Name = "W1EndGoalSeed3";
            this.W1EndGoalSeed3.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed3.TabIndex = 93;
            // 
            // W1EndGoalSeed4
            // 
            this.W1EndGoalSeed4.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed4.Name = "W1EndGoalSeed4";
            this.W1EndGoalSeed4.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed4.TabIndex = 94;
            // 
            // W1EndGoalSeed5
            // 
            this.W1EndGoalSeed5.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed5.Name = "W1EndGoalSeed5";
            this.W1EndGoalSeed5.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed5.TabIndex = 95;
            // 
            // W1EndGoalSeed6
            // 
            this.W1EndGoalSeed6.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed6.Name = "W1EndGoalSeed6";
            this.W1EndGoalSeed6.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed6.TabIndex = 96;
            // 
            // W1EndGoalSeed7
            // 
            this.W1EndGoalSeed7.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed7.Name = "W1EndGoalSeed7";
            this.W1EndGoalSeed7.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed7.TabIndex = 97;
            // 
            // W1EndGoalSeed8
            // 
            this.W1EndGoalSeed8.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed8.Name = "W1EndGoalSeed8";
            this.W1EndGoalSeed8.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed8.TabIndex = 98;
            // 
            // W1EndGoalSeed9
            // 
            this.W1EndGoalSeed9.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed9.Name = "W1EndGoalSeed9";
            this.W1EndGoalSeed9.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed9.TabIndex = 99;
            // 
            // W1EndGoalSeed10
            // 
            this.W1EndGoalSeed10.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed10.Name = "W1EndGoalSeed10";
            this.W1EndGoalSeed10.Size = new System.Drawing.Size(104, 24);
            this.W1EndGoalSeed10.TabIndex = 100;
            // 
            // GameProgression
            // 
            this.GameProgression.Controls.Add(this.BtnUncheckAll);
            this.GameProgression.Controls.Add(this.BtnCheckAll);
            this.GameProgression.Controls.Add(this.LblToggle);
            this.GameProgression.Controls.Add(this.LblGameProgress);
            this.GameProgression.Controls.Add(this.GrSeed6);
            this.GameProgression.Controls.Add(this.GrSeed5);
            this.GameProgression.Controls.Add(this.GrSeed4);
            this.GameProgression.Controls.Add(this.GrSeed3);
            this.GameProgression.Controls.Add(this.GrSeed2);
            this.GameProgression.Controls.Add(this.GrSeed1);
            this.GameProgression.Controls.Add(this.GameComplete);
            this.GameProgression.Controls.Add(this.GrSeed6Btn);
            this.GameProgression.Controls.Add(this.GrSeed5Btn);
            this.GameProgression.Controls.Add(this.GrSeed4Btn);
            this.GameProgression.Controls.Add(this.GrSeed3Btn);
            this.GameProgression.Controls.Add(this.GrSeed2Btn);
            this.GameProgression.Controls.Add(this.GrSeed1Btn);
            this.GameProgression.Controls.Add(this.CompleteGameBtn);
            this.GameProgression.Location = new System.Drawing.Point(4, 25);
            this.GameProgression.Margin = new System.Windows.Forms.Padding(4);
            this.GameProgression.Name = "GameProgression";
            this.GameProgression.Size = new System.Drawing.Size(561, 255);
            this.GameProgression.TabIndex = 5;
            this.GameProgression.Text = "Game Progress";
            this.GameProgression.UseVisualStyleBackColor = true;
            // 
            // BtnUncheckAll
            // 
            this.BtnUncheckAll.Location = new System.Drawing.Point(215, 430);
            this.BtnUncheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUncheckAll.Name = "BtnUncheckAll";
            this.BtnUncheckAll.Size = new System.Drawing.Size(100, 28);
            this.BtnUncheckAll.TabIndex = 70;
            this.BtnUncheckAll.Text = "Uncheck All";
            this.BtnUncheckAll.UseVisualStyleBackColor = true;
            this.BtnUncheckAll.Click += new System.EventHandler(this.SetAllCheckboxes);
            // 
            // BtnCheckAll
            // 
            this.BtnCheckAll.Location = new System.Drawing.Point(107, 430);
            this.BtnCheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCheckAll.Name = "BtnCheckAll";
            this.BtnCheckAll.Size = new System.Drawing.Size(100, 28);
            this.BtnCheckAll.TabIndex = 69;
            this.BtnCheckAll.Text = "Check All";
            this.BtnCheckAll.UseVisualStyleBackColor = true;
            this.BtnCheckAll.Click += new System.EventHandler(this.SetAllCheckboxes);
            // 
            // LblToggle
            // 
            this.LblToggle.AutoSize = true;
            this.LblToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToggle.Location = new System.Drawing.Point(184, 17);
            this.LblToggle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblToggle.Name = "LblToggle";
            this.LblToggle.Size = new System.Drawing.Size(58, 17);
            this.LblToggle.TabIndex = 66;
            this.LblToggle.Text = "Toggle";
            this.LblToggle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblGameProgress
            // 
            this.LblGameProgress.AutoSize = true;
            this.LblGameProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGameProgress.Location = new System.Drawing.Point(44, 17);
            this.LblGameProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGameProgress.Name = "LblGameProgress";
            this.LblGameProgress.Size = new System.Drawing.Size(120, 17);
            this.LblGameProgress.TabIndex = 65;
            this.LblGameProgress.Text = "Game Progress";
            this.LblGameProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed6
            // 
            this.GrSeed6.AutoSize = true;
            this.GrSeed6.Location = new System.Drawing.Point(44, 193);
            this.GrSeed6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrSeed6.Name = "GrSeed6";
            this.GrSeed6.Size = new System.Drawing.Size(129, 16);
            this.GrSeed6.TabIndex = 56;
            this.GrSeed6.Text = "World 6 Grand Seed";
            this.GrSeed6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed5
            // 
            this.GrSeed5.AutoSize = true;
            this.GrSeed5.Location = new System.Drawing.Point(44, 169);
            this.GrSeed5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrSeed5.Name = "GrSeed5";
            this.GrSeed5.Size = new System.Drawing.Size(129, 16);
            this.GrSeed5.TabIndex = 55;
            this.GrSeed5.Text = "World 5 Grand Seed";
            this.GrSeed5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed4
            // 
            this.GrSeed4.AutoSize = true;
            this.GrSeed4.Location = new System.Drawing.Point(44, 144);
            this.GrSeed4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrSeed4.Name = "GrSeed4";
            this.GrSeed4.Size = new System.Drawing.Size(129, 16);
            this.GrSeed4.TabIndex = 54;
            this.GrSeed4.Text = "World 4 Grand Seed";
            this.GrSeed4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed3
            // 
            this.GrSeed3.AutoSize = true;
            this.GrSeed3.Location = new System.Drawing.Point(44, 119);
            this.GrSeed3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrSeed3.Name = "GrSeed3";
            this.GrSeed3.Size = new System.Drawing.Size(129, 16);
            this.GrSeed3.TabIndex = 53;
            this.GrSeed3.Text = "World 3 Grand Seed";
            this.GrSeed3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed2
            // 
            this.GrSeed2.AutoSize = true;
            this.GrSeed2.Location = new System.Drawing.Point(44, 95);
            this.GrSeed2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrSeed2.Name = "GrSeed2";
            this.GrSeed2.Size = new System.Drawing.Size(129, 16);
            this.GrSeed2.TabIndex = 52;
            this.GrSeed2.Text = "World 2 Grand Seed";
            this.GrSeed2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed1
            // 
            this.GrSeed1.AutoSize = true;
            this.GrSeed1.Location = new System.Drawing.Point(44, 70);
            this.GrSeed1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrSeed1.Name = "GrSeed1";
            this.GrSeed1.Size = new System.Drawing.Size(129, 16);
            this.GrSeed1.TabIndex = 51;
            this.GrSeed1.Text = "World 1 Grand Seed";
            this.GrSeed1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameComplete
            // 
            this.GameComplete.AutoSize = true;
            this.GameComplete.Location = new System.Drawing.Point(44, 46);
            this.GameComplete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameComplete.Name = "GameComplete";
            this.GameComplete.Size = new System.Drawing.Size(105, 16);
            this.GameComplete.TabIndex = 50;
            this.GameComplete.Text = "Complete Game";
            this.GameComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GameComplete.Click += new System.EventHandler(this.label1_Click);
            // 
            // GrSeed6Btn
            // 
            this.GrSeed6Btn.AutoSize = true;
            this.GrSeed6Btn.Location = new System.Drawing.Point(188, 192);
            this.GrSeed6Btn.Margin = new System.Windows.Forms.Padding(4);
            this.GrSeed6Btn.Name = "GrSeed6Btn";
            this.GrSeed6Btn.Size = new System.Drawing.Size(18, 17);
            this.GrSeed6Btn.TabIndex = 11;
            this.GrSeed6Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed5Btn
            // 
            this.GrSeed5Btn.AutoSize = true;
            this.GrSeed5Btn.Location = new System.Drawing.Point(188, 167);
            this.GrSeed5Btn.Margin = new System.Windows.Forms.Padding(4);
            this.GrSeed5Btn.Name = "GrSeed5Btn";
            this.GrSeed5Btn.Size = new System.Drawing.Size(18, 17);
            this.GrSeed5Btn.TabIndex = 10;
            this.GrSeed5Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed4Btn
            // 
            this.GrSeed4Btn.AutoSize = true;
            this.GrSeed4Btn.Location = new System.Drawing.Point(188, 143);
            this.GrSeed4Btn.Margin = new System.Windows.Forms.Padding(4);
            this.GrSeed4Btn.Name = "GrSeed4Btn";
            this.GrSeed4Btn.Size = new System.Drawing.Size(18, 17);
            this.GrSeed4Btn.TabIndex = 9;
            this.GrSeed4Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed3Btn
            // 
            this.GrSeed3Btn.AutoSize = true;
            this.GrSeed3Btn.Location = new System.Drawing.Point(188, 118);
            this.GrSeed3Btn.Margin = new System.Windows.Forms.Padding(4);
            this.GrSeed3Btn.Name = "GrSeed3Btn";
            this.GrSeed3Btn.Size = new System.Drawing.Size(18, 17);
            this.GrSeed3Btn.TabIndex = 8;
            this.GrSeed3Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed2Btn
            // 
            this.GrSeed2Btn.AutoSize = true;
            this.GrSeed2Btn.Location = new System.Drawing.Point(188, 94);
            this.GrSeed2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.GrSeed2Btn.Name = "GrSeed2Btn";
            this.GrSeed2Btn.Size = new System.Drawing.Size(18, 17);
            this.GrSeed2Btn.TabIndex = 7;
            this.GrSeed2Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed1Btn
            // 
            this.GrSeed1Btn.AutoSize = true;
            this.GrSeed1Btn.Location = new System.Drawing.Point(188, 69);
            this.GrSeed1Btn.Margin = new System.Windows.Forms.Padding(4);
            this.GrSeed1Btn.Name = "GrSeed1Btn";
            this.GrSeed1Btn.Size = new System.Drawing.Size(18, 17);
            this.GrSeed1Btn.TabIndex = 6;
            this.GrSeed1Btn.UseVisualStyleBackColor = true;
            // 
            // CompleteGameBtn
            // 
            this.CompleteGameBtn.AutoSize = true;
            this.CompleteGameBtn.Location = new System.Drawing.Point(188, 44);
            this.CompleteGameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CompleteGameBtn.Name = "CompleteGameBtn";
            this.CompleteGameBtn.Size = new System.Drawing.Size(18, 17);
            this.CompleteGameBtn.TabIndex = 5;
            this.CompleteGameBtn.UseVisualStyleBackColor = true;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.LblLives);
            this.GeneralTab.Controls.Add(this.InputLives);
            this.GeneralTab.Controls.Add(this.LblPCoin);
            this.GeneralTab.Controls.Add(this.InputPCoins);
            this.GeneralTab.Controls.Add(this.InputCoins);
            this.GeneralTab.Controls.Add(this.LblCoin);
            this.GeneralTab.Location = new System.Drawing.Point(4, 25);
            this.GeneralTab.Margin = new System.Windows.Forms.Padding(4);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(4);
            this.GeneralTab.Size = new System.Drawing.Size(561, 255);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Location = new System.Drawing.Point(12, 99);
            this.LblLives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(39, 16);
            this.LblLives.TabIndex = 7;
            this.LblLives.Text = "Lives";
            this.LblLives.Click += new System.EventHandler(this.label28_Click);
            // 
            // InputLives
            // 
            this.InputLives.Location = new System.Drawing.Point(159, 99);
            this.InputLives.Margin = new System.Windows.Forms.Padding(4);
            this.InputLives.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.InputLives.Name = "InputLives";
            this.InputLives.Size = new System.Drawing.Size(175, 22);
            this.InputLives.TabIndex = 6;
            this.InputLives.ValueChanged += new System.EventHandler(this.InputLives_ValueChanged);
            // 
            // LblPCoin
            // 
            this.LblPCoin.AutoSize = true;
            this.LblPCoin.Location = new System.Drawing.Point(12, 59);
            this.LblPCoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPCoin.Name = "LblPCoin";
            this.LblPCoin.Size = new System.Drawing.Size(113, 16);
            this.LblPCoin.TabIndex = 5;
            this.LblPCoin.Text = "Purple Coin Count";
            // 
            // InputPCoins
            // 
            this.InputPCoins.Location = new System.Drawing.Point(159, 59);
            this.InputPCoins.Margin = new System.Windows.Forms.Padding(4);
            this.InputPCoins.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.InputPCoins.Name = "InputPCoins";
            this.InputPCoins.Size = new System.Drawing.Size(175, 22);
            this.InputPCoins.TabIndex = 4;
            this.InputPCoins.ValueChanged += new System.EventHandler(this.InputPCoins_ValueChanged);
            // 
            // InputCoins
            // 
            this.InputCoins.Location = new System.Drawing.Point(159, 18);
            this.InputCoins.Margin = new System.Windows.Forms.Padding(4);
            this.InputCoins.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.InputCoins.Name = "InputCoins";
            this.InputCoins.Size = new System.Drawing.Size(175, 22);
            this.InputCoins.TabIndex = 3;
            this.InputCoins.ValueChanged += new System.EventHandler(this.InputCoins_ValueChanged);
            // 
            // LblCoin
            // 
            this.LblCoin.AutoSize = true;
            this.LblCoin.Location = new System.Drawing.Point(12, 20);
            this.LblCoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCoin.Name = "LblCoin";
            this.LblCoin.Size = new System.Drawing.Size(71, 16);
            this.LblCoin.TabIndex = 0;
            this.LblCoin.Text = "Coin Count";
            this.LblCoin.Click += new System.EventHandler(this.LblRupees_Click);
            // 
            // TabControlValues
            // 
            this.TabControlValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlValues.Controls.Add(this.GeneralTab);
            this.TabControlValues.Controls.Add(this.GameProgression);
            this.TabControlValues.Controls.Add(this.World_1);
            this.TabControlValues.HotTrack = true;
            this.TabControlValues.Location = new System.Drawing.Point(11, 57);
            this.TabControlValues.Margin = new System.Windows.Forms.Padding(4);
            this.TabControlValues.Name = "TabControlValues";
            this.TabControlValues.SelectedIndex = 0;
            this.TabControlValues.Size = new System.Drawing.Size(569, 284);
            this.TabControlValues.TabIndex = 2;
            this.TabControlValues.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 391);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.PanelPath);
            this.Controls.Add(this.BtnPatchSaveFile);
            this.Controls.Add(this.TabControlValues);
            this.Controls.Add(this.BtnOpenSaveFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "SMBW | SaveGame Editor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.PanelPath.ResumeLayout(false);
            this.PanelPath.PerformLayout();
            this.World_1.ResumeLayout(false);
            this.World_1.PerformLayout();
            this.GameProgression.ResumeLayout(false);
            this.GameProgression.PerformLayout();
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputLives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputPCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputCoins)).EndInit();
            this.TabControlValues.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button BtnOpenSaveFile;
        private System.Windows.Forms.Button BtnPatchSaveFile;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.Panel PanelPath;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TabPage World_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label W1Label1;
        private System.Windows.Forms.Label W1Label2;
        private System.Windows.Forms.Label W1Label3;
        private System.Windows.Forms.Label W1Label4;
        private System.Windows.Forms.Label W1Label5;
        private System.Windows.Forms.Label W1Label6;
        private System.Windows.Forms.Label W1Label7;
        private System.Windows.Forms.Label W1Label8;
        private System.Windows.Forms.Label W1Label9;
        private System.Windows.Forms.Label W1Label10;
        private System.Windows.Forms.CheckBox W1ClearCheckBox1;
        private System.Windows.Forms.CheckBox W1ClearCheckBox2;
        private System.Windows.Forms.CheckBox W1ClearCheckBox3;
        private System.Windows.Forms.CheckBox W1ClearCheckBox4;
        private System.Windows.Forms.CheckBox W1ClearCheckBox5;
        private System.Windows.Forms.CheckBox W1ClearCheckBox6;
        private System.Windows.Forms.CheckBox W1ClearCheckBox7;
        private System.Windows.Forms.CheckBox W1ClearCheckBox8;
        private System.Windows.Forms.CheckBox W1ClearCheckBox9;
        private System.Windows.Forms.CheckBox W1ClearCheckBox10;
        private System.Windows.Forms.CheckBox W1EndGoalSeed1;
        private System.Windows.Forms.CheckBox W1EndGoalSeed2;
        private System.Windows.Forms.CheckBox W1EndGoalSeed3;
        private System.Windows.Forms.CheckBox W1EndGoalSeed4;
        private System.Windows.Forms.CheckBox W1EndGoalSeed5;
        private System.Windows.Forms.CheckBox W1EndGoalSeed6;
        private System.Windows.Forms.CheckBox W1EndGoalSeed7;
        private System.Windows.Forms.CheckBox W1EndGoalSeed8;
        private System.Windows.Forms.CheckBox W1EndGoalSeed9;
        private System.Windows.Forms.CheckBox W1EndGoalSeed10;
        private System.Windows.Forms.TabPage GameProgression;
        private System.Windows.Forms.Button BtnUncheckAll;
        private System.Windows.Forms.Button BtnCheckAll;
        private System.Windows.Forms.Label LblToggle;
        private System.Windows.Forms.Label LblGameProgress;
        private System.Windows.Forms.Label GrSeed6;
        private System.Windows.Forms.Label GrSeed5;
        private System.Windows.Forms.Label GrSeed4;
        private System.Windows.Forms.Label GrSeed3;
        private System.Windows.Forms.Label GrSeed2;
        private System.Windows.Forms.Label GrSeed1;
        private System.Windows.Forms.Label GameComplete;
        private System.Windows.Forms.CheckBox GrSeed6Btn;
        private System.Windows.Forms.CheckBox GrSeed5Btn;
        private System.Windows.Forms.CheckBox GrSeed4Btn;
        private System.Windows.Forms.CheckBox GrSeed3Btn;
        private System.Windows.Forms.CheckBox GrSeed2Btn;
        private System.Windows.Forms.CheckBox GrSeed1Btn;
        private System.Windows.Forms.CheckBox CompleteGameBtn;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.NumericUpDown InputLives;
        private System.Windows.Forms.Label LblPCoin;
        private System.Windows.Forms.NumericUpDown InputPCoins;
        private System.Windows.Forms.NumericUpDown InputCoins;
        private System.Windows.Forms.Label LblCoin;
        private System.Windows.Forms.TabControl TabControlValues;

        Label[] W1Labels;
        CheckBox[] W1ClearCheckBoxes;
        CheckBox[] W1EndGoalSeeds;
        String[] Course_Labels;
        private Label LblW1Level;
        private Label LblW1Cleared;
        private Label LblW1GoalSeed;
    }
}

