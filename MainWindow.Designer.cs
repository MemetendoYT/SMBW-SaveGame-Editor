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
            this.lblW1WonderSeed = new System.Windows.Forms.Label();
            this.LblW1ClapperGate = new System.Windows.Forms.Label();
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
            this.W1Label11 = new System.Windows.Forms.Label();
            this.W1Label12 = new System.Windows.Forms.Label();
            this.W1Label13 = new System.Windows.Forms.Label();
            this.W1Label14 = new System.Windows.Forms.Label();
            this.W1Label15 = new System.Windows.Forms.Label();
            this.W1Label16 = new System.Windows.Forms.Label();
            this.W1Label17 = new System.Windows.Forms.Label();
            this.W1Label18 = new System.Windows.Forms.Label();
            this.W1Label19 = new System.Windows.Forms.Label();
            this.W1Label20 = new System.Windows.Forms.Label();
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
            this.W1ClearCheckBox11 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox12 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox13 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox14 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox15 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox16 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox17 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox18 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox19 = new System.Windows.Forms.CheckBox();
            this.W1ClearCheckBox20 = new System.Windows.Forms.CheckBox();
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
            this.W1EndGoalSeed11 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed12 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed13 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed14 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed15 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed16 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed17 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed18 = new System.Windows.Forms.CheckBox();
            this.W1EndGoalSeed19 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin1 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin2 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin3 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin4 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin5 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin6 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin7 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin8 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin9 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin10 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin11 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin12 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin13 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin14 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin15 = new System.Windows.Forms.CheckBox();
            this.W1FirstBigCoin16 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin1 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin2 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin3 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin4 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin5 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin6 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin7 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin8 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin9 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin10 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin11 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin12 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin13 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin14 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin15 = new System.Windows.Forms.CheckBox();
            this.W1SecondBigCoin16 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin1 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin2 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin3 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin4 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin5 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin6 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin7 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin8 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin9 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin10 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin11 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin12 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin13 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin14 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin15 = new System.Windows.Forms.CheckBox();
            this.W1ThirdBigCoin16 = new System.Windows.Forms.CheckBox();
            this.W1ClapperGate1 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed1 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed2 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed3 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed4 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed5 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed6 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed7 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed8 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed9 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed10 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed11 = new System.Windows.Forms.CheckBox();
            this.W1WonderSeed12 = new System.Windows.Forms.CheckBox();
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
            this.lblW1PurpleCoin1 = new System.Windows.Forms.Label();
            this.lblW1PurpleCoin2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.BtnOpenSaveFile.Location = new System.Drawing.Point(8, 10);
            this.BtnOpenSaveFile.Name = "BtnOpenSaveFile";
            this.BtnOpenSaveFile.Size = new System.Drawing.Size(90, 30);
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
            this.BtnPatchSaveFile.Location = new System.Drawing.Point(112, 390);
            this.BtnPatchSaveFile.Name = "BtnPatchSaveFile";
            this.BtnPatchSaveFile.Size = new System.Drawing.Size(98, 30);
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
            this.LblPath.Location = new System.Drawing.Point(-1, 6);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(89, 13);
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
            this.PanelPath.Location = new System.Drawing.Point(104, 12);
            this.PanelPath.Name = "PanelPath";
            this.PanelPath.Size = new System.Drawing.Size(804, 26);
            this.PanelPath.TabIndex = 6;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.Enabled = false;
            this.BtnReset.Location = new System.Drawing.Point(8, 390);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(98, 30);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Unload Savefile";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.CloseSaveFile);
            // 
            // World_1
            // 
            this.World_1.Controls.Add(this.label1);
            this.World_1.Controls.Add(this.lblW1PurpleCoin2);
            this.World_1.Controls.Add(this.lblW1PurpleCoin1);
            this.World_1.Controls.Add(this.lblW1WonderSeed);
            this.World_1.Controls.Add(this.LblW1ClapperGate);
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
            this.World_1.Controls.Add(this.W1Label11);
            this.World_1.Controls.Add(this.W1Label12);
            this.World_1.Controls.Add(this.W1Label13);
            this.World_1.Controls.Add(this.W1Label14);
            this.World_1.Controls.Add(this.W1Label15);
            this.World_1.Controls.Add(this.W1Label16);
            this.World_1.Controls.Add(this.W1Label17);
            this.World_1.Controls.Add(this.W1Label18);
            this.World_1.Controls.Add(this.W1Label19);
            this.World_1.Controls.Add(this.W1Label20);
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
            this.World_1.Controls.Add(this.W1ClearCheckBox11);
            this.World_1.Controls.Add(this.W1ClearCheckBox12);
            this.World_1.Controls.Add(this.W1ClearCheckBox13);
            this.World_1.Controls.Add(this.W1ClearCheckBox14);
            this.World_1.Controls.Add(this.W1ClearCheckBox15);
            this.World_1.Controls.Add(this.W1ClearCheckBox16);
            this.World_1.Controls.Add(this.W1ClearCheckBox17);
            this.World_1.Controls.Add(this.W1ClearCheckBox18);
            this.World_1.Controls.Add(this.W1ClearCheckBox19);
            this.World_1.Controls.Add(this.W1ClearCheckBox20);
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
            this.World_1.Controls.Add(this.W1EndGoalSeed11);
            this.World_1.Controls.Add(this.W1EndGoalSeed12);
            this.World_1.Controls.Add(this.W1EndGoalSeed13);
            this.World_1.Controls.Add(this.W1EndGoalSeed14);
            this.World_1.Controls.Add(this.W1EndGoalSeed15);
            this.World_1.Controls.Add(this.W1EndGoalSeed16);
            this.World_1.Controls.Add(this.W1EndGoalSeed17);
            this.World_1.Controls.Add(this.W1EndGoalSeed18);
            this.World_1.Controls.Add(this.W1EndGoalSeed19);
            this.World_1.Controls.Add(this.W1FirstBigCoin1);
            this.World_1.Controls.Add(this.W1FirstBigCoin2);
            this.World_1.Controls.Add(this.W1FirstBigCoin3);
            this.World_1.Controls.Add(this.W1FirstBigCoin4);
            this.World_1.Controls.Add(this.W1FirstBigCoin5);
            this.World_1.Controls.Add(this.W1FirstBigCoin6);
            this.World_1.Controls.Add(this.W1FirstBigCoin7);
            this.World_1.Controls.Add(this.W1FirstBigCoin8);
            this.World_1.Controls.Add(this.W1FirstBigCoin9);
            this.World_1.Controls.Add(this.W1FirstBigCoin10);
            this.World_1.Controls.Add(this.W1FirstBigCoin11);
            this.World_1.Controls.Add(this.W1FirstBigCoin12);
            this.World_1.Controls.Add(this.W1FirstBigCoin13);
            this.World_1.Controls.Add(this.W1FirstBigCoin14);
            this.World_1.Controls.Add(this.W1FirstBigCoin15);
            this.World_1.Controls.Add(this.W1FirstBigCoin16);
            this.World_1.Controls.Add(this.W1SecondBigCoin1);
            this.World_1.Controls.Add(this.W1SecondBigCoin2);
            this.World_1.Controls.Add(this.W1SecondBigCoin3);
            this.World_1.Controls.Add(this.W1SecondBigCoin4);
            this.World_1.Controls.Add(this.W1SecondBigCoin5);
            this.World_1.Controls.Add(this.W1SecondBigCoin6);
            this.World_1.Controls.Add(this.W1SecondBigCoin7);
            this.World_1.Controls.Add(this.W1SecondBigCoin8);
            this.World_1.Controls.Add(this.W1SecondBigCoin9);
            this.World_1.Controls.Add(this.W1SecondBigCoin10);
            this.World_1.Controls.Add(this.W1SecondBigCoin11);
            this.World_1.Controls.Add(this.W1SecondBigCoin12);
            this.World_1.Controls.Add(this.W1SecondBigCoin13);
            this.World_1.Controls.Add(this.W1SecondBigCoin14);
            this.World_1.Controls.Add(this.W1SecondBigCoin15);
            this.World_1.Controls.Add(this.W1SecondBigCoin16);
            this.World_1.Controls.Add(this.W1ThirdBigCoin1);
            this.World_1.Controls.Add(this.W1ThirdBigCoin2);
            this.World_1.Controls.Add(this.W1ThirdBigCoin3);
            this.World_1.Controls.Add(this.W1ThirdBigCoin4);
            this.World_1.Controls.Add(this.W1ThirdBigCoin5);
            this.World_1.Controls.Add(this.W1ThirdBigCoin6);
            this.World_1.Controls.Add(this.W1ThirdBigCoin7);
            this.World_1.Controls.Add(this.W1ThirdBigCoin8);
            this.World_1.Controls.Add(this.W1ThirdBigCoin9);
            this.World_1.Controls.Add(this.W1ThirdBigCoin10);
            this.World_1.Controls.Add(this.W1ThirdBigCoin11);
            this.World_1.Controls.Add(this.W1ThirdBigCoin12);
            this.World_1.Controls.Add(this.W1ThirdBigCoin13);
            this.World_1.Controls.Add(this.W1ThirdBigCoin14);
            this.World_1.Controls.Add(this.W1ThirdBigCoin15);
            this.World_1.Controls.Add(this.W1ThirdBigCoin16);
            this.World_1.Controls.Add(this.W1ClapperGate1);
            this.World_1.Controls.Add(this.W1WonderSeed1);
            this.World_1.Controls.Add(this.W1WonderSeed2);
            this.World_1.Controls.Add(this.W1WonderSeed3);
            this.World_1.Controls.Add(this.W1WonderSeed4);
            this.World_1.Controls.Add(this.W1WonderSeed5);
            this.World_1.Controls.Add(this.W1WonderSeed6);
            this.World_1.Controls.Add(this.W1WonderSeed7);
            this.World_1.Controls.Add(this.W1WonderSeed8);
            this.World_1.Controls.Add(this.W1WonderSeed9);
            this.World_1.Controls.Add(this.W1WonderSeed10);
            this.World_1.Controls.Add(this.W1WonderSeed11);
            this.World_1.Controls.Add(this.W1WonderSeed12);
            this.World_1.Location = new System.Drawing.Point(4, 22);
            this.World_1.Name = "World_1";
            this.World_1.Size = new System.Drawing.Size(892, 319);
            this.World_1.TabIndex = 7;
            this.World_1.Text = "World1 Levels";
            this.World_1.UseVisualStyleBackColor = true;
            // 
            // lblW1WonderSeed
            // 
            this.lblW1WonderSeed.AutoSize = true;
            this.lblW1WonderSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW1WonderSeed.Location = new System.Drawing.Point(416, 31);
            this.lblW1WonderSeed.Name = "lblW1WonderSeed";
            this.lblW1WonderSeed.Size = new System.Drawing.Size(84, 13);
            this.lblW1WonderSeed.TabIndex = 146;
            this.lblW1WonderSeed.Text = "Wonder Seed";
            this.lblW1WonderSeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblW1WonderSeed.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // LblW1ClapperGate
            // 
            this.LblW1ClapperGate.AutoSize = true;
            this.LblW1ClapperGate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblW1ClapperGate.Location = new System.Drawing.Point(516, 31);
            this.LblW1ClapperGate.Name = "LblW1ClapperGate";
            this.LblW1ClapperGate.Size = new System.Drawing.Size(81, 13);
            this.LblW1ClapperGate.TabIndex = 132;
            this.LblW1ClapperGate.Text = "Piranha Gate";
            this.LblW1ClapperGate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblW1ClapperGate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblW1Cleared
            // 
            this.LblW1Cleared.AutoSize = true;
            this.LblW1Cleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblW1Cleared.Location = new System.Drawing.Point(206, 31);
            this.LblW1Cleared.Name = "LblW1Cleared";
            this.LblW1Cleared.Size = new System.Drawing.Size(93, 13);
            this.LblW1Cleared.TabIndex = 103;
            this.LblW1Cleared.Text = "Course Cleared";
            this.LblW1Cleared.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblW1GoalSeed
            // 
            this.LblW1GoalSeed.AutoSize = true;
            this.LblW1GoalSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblW1GoalSeed.Location = new System.Drawing.Point(334, 31);
            this.LblW1GoalSeed.Name = "LblW1GoalSeed";
            this.LblW1GoalSeed.Size = new System.Drawing.Size(66, 13);
            this.LblW1GoalSeed.TabIndex = 102;
            this.LblW1GoalSeed.Text = "Goal Seed";
            this.LblW1GoalSeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblW1Level
            // 
            this.LblW1Level.AutoSize = true;
            this.LblW1Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblW1Level.Location = new System.Drawing.Point(43, 31);
            this.LblW1Level.Name = "LblW1Level";
            this.LblW1Level.Size = new System.Drawing.Size(38, 13);
            this.LblW1Level.TabIndex = 101;
            this.LblW1Level.Text = "Level";
            this.LblW1Level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblW1Level.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "Uncheck All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 69;
            this.button2.Text = "Check All";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // W1Label2
            // 
            this.W1Label2.Location = new System.Drawing.Point(0, 0);
            this.W1Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label2.Name = "W1Label2";
            this.W1Label2.Size = new System.Drawing.Size(75, 19);
            this.W1Label2.TabIndex = 71;
            // 
            // W1Label3
            // 
            this.W1Label3.Location = new System.Drawing.Point(0, 0);
            this.W1Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label3.Name = "W1Label3";
            this.W1Label3.Size = new System.Drawing.Size(75, 19);
            this.W1Label3.TabIndex = 72;
            // 
            // W1Label4
            // 
            this.W1Label4.Location = new System.Drawing.Point(0, 0);
            this.W1Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label4.Name = "W1Label4";
            this.W1Label4.Size = new System.Drawing.Size(75, 19);
            this.W1Label4.TabIndex = 73;
            // 
            // W1Label5
            // 
            this.W1Label5.Location = new System.Drawing.Point(0, 0);
            this.W1Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label5.Name = "W1Label5";
            this.W1Label5.Size = new System.Drawing.Size(75, 19);
            this.W1Label5.TabIndex = 74;
            // 
            // W1Label6
            // 
            this.W1Label6.Location = new System.Drawing.Point(0, 0);
            this.W1Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label6.Name = "W1Label6";
            this.W1Label6.Size = new System.Drawing.Size(75, 19);
            this.W1Label6.TabIndex = 75;
            // 
            // W1Label7
            // 
            this.W1Label7.Location = new System.Drawing.Point(0, 0);
            this.W1Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label7.Name = "W1Label7";
            this.W1Label7.Size = new System.Drawing.Size(75, 19);
            this.W1Label7.TabIndex = 76;
            // 
            // W1Label8
            // 
            this.W1Label8.Location = new System.Drawing.Point(0, 0);
            this.W1Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label8.Name = "W1Label8";
            this.W1Label8.Size = new System.Drawing.Size(75, 19);
            this.W1Label8.TabIndex = 77;
            // 
            // W1Label9
            // 
            this.W1Label9.Location = new System.Drawing.Point(0, 0);
            this.W1Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label9.Name = "W1Label9";
            this.W1Label9.Size = new System.Drawing.Size(75, 19);
            this.W1Label9.TabIndex = 78;
            // 
            // W1Label10
            // 
            this.W1Label10.Location = new System.Drawing.Point(0, 0);
            this.W1Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label10.Name = "W1Label10";
            this.W1Label10.Size = new System.Drawing.Size(75, 19);
            this.W1Label10.TabIndex = 79;
            // 
            // W1Label11
            // 
            this.W1Label11.Location = new System.Drawing.Point(0, 0);
            this.W1Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label11.Name = "W1Label11";
            this.W1Label11.Size = new System.Drawing.Size(75, 19);
            this.W1Label11.TabIndex = 104;
            // 
            // W1Label12
            // 
            this.W1Label12.Location = new System.Drawing.Point(0, 0);
            this.W1Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label12.Name = "W1Label12";
            this.W1Label12.Size = new System.Drawing.Size(75, 19);
            this.W1Label12.TabIndex = 105;
            // 
            // W1Label13
            // 
            this.W1Label13.Location = new System.Drawing.Point(0, 0);
            this.W1Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label13.Name = "W1Label13";
            this.W1Label13.Size = new System.Drawing.Size(75, 19);
            this.W1Label13.TabIndex = 106;
            // 
            // W1Label14
            // 
            this.W1Label14.Location = new System.Drawing.Point(0, 0);
            this.W1Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label14.Name = "W1Label14";
            this.W1Label14.Size = new System.Drawing.Size(75, 19);
            this.W1Label14.TabIndex = 107;
            // 
            // W1Label15
            // 
            this.W1Label15.Location = new System.Drawing.Point(0, 0);
            this.W1Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label15.Name = "W1Label15";
            this.W1Label15.Size = new System.Drawing.Size(75, 19);
            this.W1Label15.TabIndex = 108;
            // 
            // W1Label16
            // 
            this.W1Label16.Location = new System.Drawing.Point(0, 0);
            this.W1Label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label16.Name = "W1Label16";
            this.W1Label16.Size = new System.Drawing.Size(75, 19);
            this.W1Label16.TabIndex = 109;
            // 
            // W1Label17
            // 
            this.W1Label17.Location = new System.Drawing.Point(0, 0);
            this.W1Label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label17.Name = "W1Label17";
            this.W1Label17.Size = new System.Drawing.Size(75, 19);
            this.W1Label17.TabIndex = 110;
            // 
            // W1Label18
            // 
            this.W1Label18.Location = new System.Drawing.Point(0, 0);
            this.W1Label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label18.Name = "W1Label18";
            this.W1Label18.Size = new System.Drawing.Size(75, 19);
            this.W1Label18.TabIndex = 111;
            // 
            // W1Label19
            // 
            this.W1Label19.Location = new System.Drawing.Point(0, 0);
            this.W1Label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label19.Name = "W1Label19";
            this.W1Label19.Size = new System.Drawing.Size(75, 19);
            this.W1Label19.TabIndex = 112;
            // 
            // W1Label20
            // 
            this.W1Label20.Location = new System.Drawing.Point(0, 0);
            this.W1Label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label20.Name = "W1Label20";
            this.W1Label20.Size = new System.Drawing.Size(75, 19);
            this.W1Label20.TabIndex = 147;
            // 
            // W1Label1
            // 
            this.W1Label1.Location = new System.Drawing.Point(0, 0);
            this.W1Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.W1Label1.Name = "W1Label1";
            this.W1Label1.Size = new System.Drawing.Size(75, 19);
            this.W1Label1.TabIndex = 80;
            // 
            // W1ClearCheckBox1
            // 
            this.W1ClearCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox1.Name = "W1ClearCheckBox1";
            this.W1ClearCheckBox1.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox1.TabIndex = 81;
            // 
            // W1ClearCheckBox2
            // 
            this.W1ClearCheckBox2.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox2.Name = "W1ClearCheckBox2";
            this.W1ClearCheckBox2.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox2.TabIndex = 82;
            // 
            // W1ClearCheckBox3
            // 
            this.W1ClearCheckBox3.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox3.Name = "W1ClearCheckBox3";
            this.W1ClearCheckBox3.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox3.TabIndex = 83;
            // 
            // W1ClearCheckBox4
            // 
            this.W1ClearCheckBox4.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox4.Name = "W1ClearCheckBox4";
            this.W1ClearCheckBox4.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox4.TabIndex = 84;
            // 
            // W1ClearCheckBox5
            // 
            this.W1ClearCheckBox5.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox5.Name = "W1ClearCheckBox5";
            this.W1ClearCheckBox5.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox5.TabIndex = 85;
            // 
            // W1ClearCheckBox6
            // 
            this.W1ClearCheckBox6.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox6.Name = "W1ClearCheckBox6";
            this.W1ClearCheckBox6.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox6.TabIndex = 86;
            // 
            // W1ClearCheckBox7
            // 
            this.W1ClearCheckBox7.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox7.Name = "W1ClearCheckBox7";
            this.W1ClearCheckBox7.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox7.TabIndex = 87;
            // 
            // W1ClearCheckBox8
            // 
            this.W1ClearCheckBox8.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox8.Name = "W1ClearCheckBox8";
            this.W1ClearCheckBox8.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox8.TabIndex = 88;
            // 
            // W1ClearCheckBox9
            // 
            this.W1ClearCheckBox9.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox9.Name = "W1ClearCheckBox9";
            this.W1ClearCheckBox9.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox9.TabIndex = 89;
            // 
            // W1ClearCheckBox10
            // 
            this.W1ClearCheckBox10.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox10.Name = "W1ClearCheckBox10";
            this.W1ClearCheckBox10.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox10.TabIndex = 90;
            // 
            // W1ClearCheckBox11
            // 
            this.W1ClearCheckBox11.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox11.Name = "W1ClearCheckBox11";
            this.W1ClearCheckBox11.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox11.TabIndex = 113;
            // 
            // W1ClearCheckBox12
            // 
            this.W1ClearCheckBox12.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox12.Name = "W1ClearCheckBox12";
            this.W1ClearCheckBox12.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox12.TabIndex = 114;
            // 
            // W1ClearCheckBox13
            // 
            this.W1ClearCheckBox13.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox13.Name = "W1ClearCheckBox13";
            this.W1ClearCheckBox13.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox13.TabIndex = 115;
            // 
            // W1ClearCheckBox14
            // 
            this.W1ClearCheckBox14.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox14.Name = "W1ClearCheckBox14";
            this.W1ClearCheckBox14.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox14.TabIndex = 116;
            // 
            // W1ClearCheckBox15
            // 
            this.W1ClearCheckBox15.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox15.Name = "W1ClearCheckBox15";
            this.W1ClearCheckBox15.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox15.TabIndex = 117;
            // 
            // W1ClearCheckBox16
            // 
            this.W1ClearCheckBox16.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox16.Name = "W1ClearCheckBox16";
            this.W1ClearCheckBox16.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox16.TabIndex = 118;
            // 
            // W1ClearCheckBox17
            // 
            this.W1ClearCheckBox17.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox17.Name = "W1ClearCheckBox17";
            this.W1ClearCheckBox17.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox17.TabIndex = 119;
            // 
            // W1ClearCheckBox18
            // 
            this.W1ClearCheckBox18.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox18.Name = "W1ClearCheckBox18";
            this.W1ClearCheckBox18.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox18.TabIndex = 120;
            // 
            // W1ClearCheckBox19
            // 
            this.W1ClearCheckBox19.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox19.Name = "W1ClearCheckBox19";
            this.W1ClearCheckBox19.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox19.TabIndex = 121;
            // 
            // W1ClearCheckBox20
            // 
            this.W1ClearCheckBox20.Location = new System.Drawing.Point(0, 0);
            this.W1ClearCheckBox20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClearCheckBox20.Name = "W1ClearCheckBox20";
            this.W1ClearCheckBox20.Size = new System.Drawing.Size(78, 20);
            this.W1ClearCheckBox20.TabIndex = 148;
            // 
            // W1EndGoalSeed1
            // 
            this.W1EndGoalSeed1.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed1.Name = "W1EndGoalSeed1";
            this.W1EndGoalSeed1.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed1.TabIndex = 91;
            // 
            // W1EndGoalSeed2
            // 
            this.W1EndGoalSeed2.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed2.Name = "W1EndGoalSeed2";
            this.W1EndGoalSeed2.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed2.TabIndex = 92;
            // 
            // W1EndGoalSeed3
            // 
            this.W1EndGoalSeed3.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed3.Name = "W1EndGoalSeed3";
            this.W1EndGoalSeed3.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed3.TabIndex = 93;
            // 
            // W1EndGoalSeed4
            // 
            this.W1EndGoalSeed4.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed4.Name = "W1EndGoalSeed4";
            this.W1EndGoalSeed4.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed4.TabIndex = 94;
            // 
            // W1EndGoalSeed5
            // 
            this.W1EndGoalSeed5.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed5.Name = "W1EndGoalSeed5";
            this.W1EndGoalSeed5.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed5.TabIndex = 95;
            // 
            // W1EndGoalSeed6
            // 
            this.W1EndGoalSeed6.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed6.Name = "W1EndGoalSeed6";
            this.W1EndGoalSeed6.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed6.TabIndex = 96;
            // 
            // W1EndGoalSeed7
            // 
            this.W1EndGoalSeed7.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed7.Name = "W1EndGoalSeed7";
            this.W1EndGoalSeed7.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed7.TabIndex = 97;
            // 
            // W1EndGoalSeed8
            // 
            this.W1EndGoalSeed8.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed8.Name = "W1EndGoalSeed8";
            this.W1EndGoalSeed8.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed8.TabIndex = 98;
            // 
            // W1EndGoalSeed9
            // 
            this.W1EndGoalSeed9.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed9.Name = "W1EndGoalSeed9";
            this.W1EndGoalSeed9.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed9.TabIndex = 99;
            // 
            // W1EndGoalSeed10
            // 
            this.W1EndGoalSeed10.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed10.Name = "W1EndGoalSeed10";
            this.W1EndGoalSeed10.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed10.TabIndex = 100;
            // 
            // W1EndGoalSeed11
            // 
            this.W1EndGoalSeed11.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed11.Name = "W1EndGoalSeed11";
            this.W1EndGoalSeed11.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed11.TabIndex = 122;
            // 
            // W1EndGoalSeed12
            // 
            this.W1EndGoalSeed12.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed12.Name = "W1EndGoalSeed12";
            this.W1EndGoalSeed12.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed12.TabIndex = 123;
            // 
            // W1EndGoalSeed13
            // 
            this.W1EndGoalSeed13.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed13.Name = "W1EndGoalSeed13";
            this.W1EndGoalSeed13.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed13.TabIndex = 124;
            // 
            // W1EndGoalSeed14
            // 
            this.W1EndGoalSeed14.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed14.Name = "W1EndGoalSeed14";
            this.W1EndGoalSeed14.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed14.TabIndex = 125;
            // 
            // W1EndGoalSeed15
            // 
            this.W1EndGoalSeed15.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed15.Name = "W1EndGoalSeed15";
            this.W1EndGoalSeed15.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed15.TabIndex = 126;
            // 
            // W1EndGoalSeed16
            // 
            this.W1EndGoalSeed16.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed16.Name = "W1EndGoalSeed16";
            this.W1EndGoalSeed16.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed16.TabIndex = 127;
            // 
            // W1EndGoalSeed17
            // 
            this.W1EndGoalSeed17.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed17.Name = "W1EndGoalSeed17";
            this.W1EndGoalSeed17.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed17.TabIndex = 128;
            // 
            // W1EndGoalSeed18
            // 
            this.W1EndGoalSeed18.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed18.Name = "W1EndGoalSeed18";
            this.W1EndGoalSeed18.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed18.TabIndex = 129;
            // 
            // W1EndGoalSeed19
            // 
            this.W1EndGoalSeed19.Location = new System.Drawing.Point(0, 0);
            this.W1EndGoalSeed19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1EndGoalSeed19.Name = "W1EndGoalSeed19";
            this.W1EndGoalSeed19.Size = new System.Drawing.Size(78, 20);
            this.W1EndGoalSeed19.TabIndex = 130;
            // 
            // W1FirstBigCoin1
            // 
            this.W1FirstBigCoin1.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin1.Name = "W1FirstBigCoin1";
            this.W1FirstBigCoin1.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin1.TabIndex = 149;
            // 
            // W1FirstBigCoin2
            // 
            this.W1FirstBigCoin2.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin2.Name = "W1FirstBigCoin2";
            this.W1FirstBigCoin2.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin2.TabIndex = 150;
            // 
            // W1FirstBigCoin3
            // 
            this.W1FirstBigCoin3.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin3.Name = "W1FirstBigCoin3";
            this.W1FirstBigCoin3.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin3.TabIndex = 151;
            // 
            // W1FirstBigCoin4
            // 
            this.W1FirstBigCoin4.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin4.Name = "W1FirstBigCoin4";
            this.W1FirstBigCoin4.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin4.TabIndex = 152;
            // 
            // W1FirstBigCoin5
            // 
            this.W1FirstBigCoin5.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin5.Name = "W1FirstBigCoin5";
            this.W1FirstBigCoin5.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin5.TabIndex = 153;
            // 
            // W1FirstBigCoin6
            // 
            this.W1FirstBigCoin6.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin6.Name = "W1FirstBigCoin6";
            this.W1FirstBigCoin6.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin6.TabIndex = 154;
            // 
            // W1FirstBigCoin7
            // 
            this.W1FirstBigCoin7.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin7.Name = "W1FirstBigCoin7";
            this.W1FirstBigCoin7.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin7.TabIndex = 155;
            // 
            // W1FirstBigCoin8
            // 
            this.W1FirstBigCoin8.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin8.Name = "W1FirstBigCoin8";
            this.W1FirstBigCoin8.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin8.TabIndex = 156;
            // 
            // W1FirstBigCoin9
            // 
            this.W1FirstBigCoin9.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin9.Name = "W1FirstBigCoin9";
            this.W1FirstBigCoin9.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin9.TabIndex = 157;
            // 
            // W1FirstBigCoin10
            // 
            this.W1FirstBigCoin10.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin10.Name = "W1FirstBigCoin10";
            this.W1FirstBigCoin10.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin10.TabIndex = 158;
            // 
            // W1FirstBigCoin11
            // 
            this.W1FirstBigCoin11.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin11.Name = "W1FirstBigCoin11";
            this.W1FirstBigCoin11.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin11.TabIndex = 159;
            // 
            // W1FirstBigCoin12
            // 
            this.W1FirstBigCoin12.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin12.Name = "W1FirstBigCoin12";
            this.W1FirstBigCoin12.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin12.TabIndex = 160;
            // 
            // W1FirstBigCoin13
            // 
            this.W1FirstBigCoin13.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin13.Name = "W1FirstBigCoin13";
            this.W1FirstBigCoin13.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin13.TabIndex = 161;
            // 
            // W1FirstBigCoin14
            // 
            this.W1FirstBigCoin14.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin14.Name = "W1FirstBigCoin14";
            this.W1FirstBigCoin14.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin14.TabIndex = 162;
            // 
            // W1FirstBigCoin15
            // 
            this.W1FirstBigCoin15.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin15.Name = "W1FirstBigCoin15";
            this.W1FirstBigCoin15.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin15.TabIndex = 163;
            // 
            // W1FirstBigCoin16
            // 
            this.W1FirstBigCoin16.Location = new System.Drawing.Point(0, 0);
            this.W1FirstBigCoin16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1FirstBigCoin16.Name = "W1FirstBigCoin16";
            this.W1FirstBigCoin16.Size = new System.Drawing.Size(78, 20);
            this.W1FirstBigCoin16.TabIndex = 164;
            // 
            // W1SecondBigCoin1
            // 
            this.W1SecondBigCoin1.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin1.Name = "W1SecondBigCoin1";
            this.W1SecondBigCoin1.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin1.TabIndex = 168;
            // 
            // W1SecondBigCoin2
            // 
            this.W1SecondBigCoin2.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin2.Name = "W1SecondBigCoin2";
            this.W1SecondBigCoin2.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin2.TabIndex = 169;
            // 
            // W1SecondBigCoin3
            // 
            this.W1SecondBigCoin3.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin3.Name = "W1SecondBigCoin3";
            this.W1SecondBigCoin3.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin3.TabIndex = 170;
            // 
            // W1SecondBigCoin4
            // 
            this.W1SecondBigCoin4.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin4.Name = "W1SecondBigCoin4";
            this.W1SecondBigCoin4.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin4.TabIndex = 171;
            // 
            // W1SecondBigCoin5
            // 
            this.W1SecondBigCoin5.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin5.Name = "W1SecondBigCoin5";
            this.W1SecondBigCoin5.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin5.TabIndex = 172;
            // 
            // W1SecondBigCoin6
            // 
            this.W1SecondBigCoin6.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin6.Name = "W1SecondBigCoin6";
            this.W1SecondBigCoin6.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin6.TabIndex = 173;
            // 
            // W1SecondBigCoin7
            // 
            this.W1SecondBigCoin7.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin7.Name = "W1SecondBigCoin7";
            this.W1SecondBigCoin7.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin7.TabIndex = 174;
            // 
            // W1SecondBigCoin8
            // 
            this.W1SecondBigCoin8.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin8.Name = "W1SecondBigCoin8";
            this.W1SecondBigCoin8.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin8.TabIndex = 175;
            // 
            // W1SecondBigCoin9
            // 
            this.W1SecondBigCoin9.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin9.Name = "W1SecondBigCoin9";
            this.W1SecondBigCoin9.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin9.TabIndex = 176;
            // 
            // W1SecondBigCoin10
            // 
            this.W1SecondBigCoin10.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin10.Name = "W1SecondBigCoin10";
            this.W1SecondBigCoin10.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin10.TabIndex = 177;
            // 
            // W1SecondBigCoin11
            // 
            this.W1SecondBigCoin11.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin11.Name = "W1SecondBigCoin11";
            this.W1SecondBigCoin11.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin11.TabIndex = 178;
            // 
            // W1SecondBigCoin12
            // 
            this.W1SecondBigCoin12.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin12.Name = "W1SecondBigCoin12";
            this.W1SecondBigCoin12.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin12.TabIndex = 179;
            // 
            // W1SecondBigCoin13
            // 
            this.W1SecondBigCoin13.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin13.Name = "W1SecondBigCoin13";
            this.W1SecondBigCoin13.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin13.TabIndex = 180;
            // 
            // W1SecondBigCoin14
            // 
            this.W1SecondBigCoin14.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin14.Name = "W1SecondBigCoin14";
            this.W1SecondBigCoin14.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin14.TabIndex = 181;
            // 
            // W1SecondBigCoin15
            // 
            this.W1SecondBigCoin15.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin15.Name = "W1SecondBigCoin15";
            this.W1SecondBigCoin15.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin15.TabIndex = 182;
            // 
            // W1SecondBigCoin16
            // 
            this.W1SecondBigCoin16.Location = new System.Drawing.Point(0, 0);
            this.W1SecondBigCoin16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1SecondBigCoin16.Name = "W1SecondBigCoin16";
            this.W1SecondBigCoin16.Size = new System.Drawing.Size(78, 20);
            this.W1SecondBigCoin16.TabIndex = 183;
            // 
            // W1ThirdBigCoin1
            // 
            this.W1ThirdBigCoin1.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin1.Name = "W1ThirdBigCoin1";
            this.W1ThirdBigCoin1.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin1.TabIndex = 187;
            // 
            // W1ThirdBigCoin2
            // 
            this.W1ThirdBigCoin2.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin2.Name = "W1ThirdBigCoin2";
            this.W1ThirdBigCoin2.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin2.TabIndex = 188;
            // 
            // W1ThirdBigCoin3
            // 
            this.W1ThirdBigCoin3.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin3.Name = "W1ThirdBigCoin3";
            this.W1ThirdBigCoin3.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin3.TabIndex = 189;
            // 
            // W1ThirdBigCoin4
            // 
            this.W1ThirdBigCoin4.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin4.Name = "W1ThirdBigCoin4";
            this.W1ThirdBigCoin4.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin4.TabIndex = 190;
            // 
            // W1ThirdBigCoin5
            // 
            this.W1ThirdBigCoin5.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin5.Name = "W1ThirdBigCoin5";
            this.W1ThirdBigCoin5.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin5.TabIndex = 191;
            // 
            // W1ThirdBigCoin6
            // 
            this.W1ThirdBigCoin6.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin6.Name = "W1ThirdBigCoin6";
            this.W1ThirdBigCoin6.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin6.TabIndex = 192;
            // 
            // W1ThirdBigCoin7
            // 
            this.W1ThirdBigCoin7.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin7.Name = "W1ThirdBigCoin7";
            this.W1ThirdBigCoin7.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin7.TabIndex = 193;
            // 
            // W1ThirdBigCoin8
            // 
            this.W1ThirdBigCoin8.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin8.Name = "W1ThirdBigCoin8";
            this.W1ThirdBigCoin8.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin8.TabIndex = 194;
            // 
            // W1ThirdBigCoin9
            // 
            this.W1ThirdBigCoin9.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin9.Name = "W1ThirdBigCoin9";
            this.W1ThirdBigCoin9.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin9.TabIndex = 195;
            // 
            // W1ThirdBigCoin10
            // 
            this.W1ThirdBigCoin10.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin10.Name = "W1ThirdBigCoin10";
            this.W1ThirdBigCoin10.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin10.TabIndex = 196;
            // 
            // W1ThirdBigCoin11
            // 
            this.W1ThirdBigCoin11.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin11.Name = "W1ThirdBigCoin11";
            this.W1ThirdBigCoin11.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin11.TabIndex = 197;
            // 
            // W1ThirdBigCoin12
            // 
            this.W1ThirdBigCoin12.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin12.Name = "W1ThirdBigCoin12";
            this.W1ThirdBigCoin12.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin12.TabIndex = 198;
            // 
            // W1ThirdBigCoin13
            // 
            this.W1ThirdBigCoin13.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin13.Name = "W1ThirdBigCoin13";
            this.W1ThirdBigCoin13.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin13.TabIndex = 199;
            // 
            // W1ThirdBigCoin14
            // 
            this.W1ThirdBigCoin14.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin14.Name = "W1ThirdBigCoin14";
            this.W1ThirdBigCoin14.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin14.TabIndex = 200;
            // 
            // W1ThirdBigCoin15
            // 
            this.W1ThirdBigCoin15.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin15.Name = "W1ThirdBigCoin15";
            this.W1ThirdBigCoin15.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin15.TabIndex = 201;
            // 
            // W1ThirdBigCoin16
            // 
            this.W1ThirdBigCoin16.Location = new System.Drawing.Point(0, 0);
            this.W1ThirdBigCoin16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ThirdBigCoin16.Name = "W1ThirdBigCoin16";
            this.W1ThirdBigCoin16.Size = new System.Drawing.Size(78, 20);
            this.W1ThirdBigCoin16.TabIndex = 202;
            // 
            // W1ClapperGate1
            // 
            this.W1ClapperGate1.Location = new System.Drawing.Point(0, 0);
            this.W1ClapperGate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1ClapperGate1.Name = "W1ClapperGate1";
            this.W1ClapperGate1.Size = new System.Drawing.Size(78, 20);
            this.W1ClapperGate1.TabIndex = 131;
            // 
            // W1WonderSeed1
            // 
            this.W1WonderSeed1.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed1.Name = "W1WonderSeed1";
            this.W1WonderSeed1.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed1.TabIndex = 133;
            // 
            // W1WonderSeed2
            // 
            this.W1WonderSeed2.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed2.Name = "W1WonderSeed2";
            this.W1WonderSeed2.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed2.TabIndex = 134;
            // 
            // W1WonderSeed3
            // 
            this.W1WonderSeed3.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed3.Name = "W1WonderSeed3";
            this.W1WonderSeed3.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed3.TabIndex = 135;
            // 
            // W1WonderSeed4
            // 
            this.W1WonderSeed4.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed4.Name = "W1WonderSeed4";
            this.W1WonderSeed4.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed4.TabIndex = 136;
            // 
            // W1WonderSeed5
            // 
            this.W1WonderSeed5.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed5.Name = "W1WonderSeed5";
            this.W1WonderSeed5.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed5.TabIndex = 137;
            // 
            // W1WonderSeed6
            // 
            this.W1WonderSeed6.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed6.Name = "W1WonderSeed6";
            this.W1WonderSeed6.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed6.TabIndex = 138;
            // 
            // W1WonderSeed7
            // 
            this.W1WonderSeed7.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed7.Name = "W1WonderSeed7";
            this.W1WonderSeed7.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed7.TabIndex = 139;
            // 
            // W1WonderSeed8
            // 
            this.W1WonderSeed8.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed8.Name = "W1WonderSeed8";
            this.W1WonderSeed8.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed8.TabIndex = 140;
            // 
            // W1WonderSeed9
            // 
            this.W1WonderSeed9.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed9.Name = "W1WonderSeed9";
            this.W1WonderSeed9.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed9.TabIndex = 141;
            // 
            // W1WonderSeed10
            // 
            this.W1WonderSeed10.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed10.Name = "W1WonderSeed10";
            this.W1WonderSeed10.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed10.TabIndex = 142;
            // 
            // W1WonderSeed11
            // 
            this.W1WonderSeed11.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed11.Name = "W1WonderSeed11";
            this.W1WonderSeed11.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed11.TabIndex = 143;
            // 
            // W1WonderSeed12
            // 
            this.W1WonderSeed12.Location = new System.Drawing.Point(0, 0);
            this.W1WonderSeed12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.W1WonderSeed12.Name = "W1WonderSeed12";
            this.W1WonderSeed12.Size = new System.Drawing.Size(78, 20);
            this.W1WonderSeed12.TabIndex = 144;
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
            this.GameProgression.Location = new System.Drawing.Point(4, 22);
            this.GameProgression.Name = "GameProgression";
            this.GameProgression.Size = new System.Drawing.Size(892, 319);
            this.GameProgression.TabIndex = 5;
            this.GameProgression.Text = "Game Progress";
            this.GameProgression.UseVisualStyleBackColor = true;
            // 
            // BtnUncheckAll
            // 
            this.BtnUncheckAll.Location = new System.Drawing.Point(161, 349);
            this.BtnUncheckAll.Name = "BtnUncheckAll";
            this.BtnUncheckAll.Size = new System.Drawing.Size(75, 23);
            this.BtnUncheckAll.TabIndex = 70;
            this.BtnUncheckAll.Text = "Uncheck All";
            this.BtnUncheckAll.UseVisualStyleBackColor = true;
            this.BtnUncheckAll.Click += new System.EventHandler(this.SetAllCheckboxes);
            // 
            // BtnCheckAll
            // 
            this.BtnCheckAll.Location = new System.Drawing.Point(80, 349);
            this.BtnCheckAll.Name = "BtnCheckAll";
            this.BtnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckAll.TabIndex = 69;
            this.BtnCheckAll.Text = "Check All";
            this.BtnCheckAll.UseVisualStyleBackColor = true;
            this.BtnCheckAll.Click += new System.EventHandler(this.SetAllCheckboxes);
            // 
            // LblToggle
            // 
            this.LblToggle.AutoSize = true;
            this.LblToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToggle.Location = new System.Drawing.Point(138, 14);
            this.LblToggle.Name = "LblToggle";
            this.LblToggle.Size = new System.Drawing.Size(46, 13);
            this.LblToggle.TabIndex = 66;
            this.LblToggle.Text = "Toggle";
            this.LblToggle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblGameProgress
            // 
            this.LblGameProgress.AutoSize = true;
            this.LblGameProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGameProgress.Location = new System.Drawing.Point(33, 14);
            this.LblGameProgress.Name = "LblGameProgress";
            this.LblGameProgress.Size = new System.Drawing.Size(92, 13);
            this.LblGameProgress.TabIndex = 65;
            this.LblGameProgress.Text = "Game Progress";
            this.LblGameProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed6
            // 
            this.GrSeed6.AutoSize = true;
            this.GrSeed6.Location = new System.Drawing.Point(33, 157);
            this.GrSeed6.Name = "GrSeed6";
            this.GrSeed6.Size = new System.Drawing.Size(104, 13);
            this.GrSeed6.TabIndex = 56;
            this.GrSeed6.Text = "World 6 Grand Seed";
            this.GrSeed6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed5
            // 
            this.GrSeed5.AutoSize = true;
            this.GrSeed5.Location = new System.Drawing.Point(33, 137);
            this.GrSeed5.Name = "GrSeed5";
            this.GrSeed5.Size = new System.Drawing.Size(104, 13);
            this.GrSeed5.TabIndex = 55;
            this.GrSeed5.Text = "World 5 Grand Seed";
            this.GrSeed5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed4
            // 
            this.GrSeed4.AutoSize = true;
            this.GrSeed4.Location = new System.Drawing.Point(33, 117);
            this.GrSeed4.Name = "GrSeed4";
            this.GrSeed4.Size = new System.Drawing.Size(104, 13);
            this.GrSeed4.TabIndex = 54;
            this.GrSeed4.Text = "World 4 Grand Seed";
            this.GrSeed4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed3
            // 
            this.GrSeed3.AutoSize = true;
            this.GrSeed3.Location = new System.Drawing.Point(33, 97);
            this.GrSeed3.Name = "GrSeed3";
            this.GrSeed3.Size = new System.Drawing.Size(104, 13);
            this.GrSeed3.TabIndex = 53;
            this.GrSeed3.Text = "World 3 Grand Seed";
            this.GrSeed3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed2
            // 
            this.GrSeed2.AutoSize = true;
            this.GrSeed2.Location = new System.Drawing.Point(33, 77);
            this.GrSeed2.Name = "GrSeed2";
            this.GrSeed2.Size = new System.Drawing.Size(104, 13);
            this.GrSeed2.TabIndex = 52;
            this.GrSeed2.Text = "World 2 Grand Seed";
            this.GrSeed2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrSeed1
            // 
            this.GrSeed1.AutoSize = true;
            this.GrSeed1.Location = new System.Drawing.Point(33, 57);
            this.GrSeed1.Name = "GrSeed1";
            this.GrSeed1.Size = new System.Drawing.Size(104, 13);
            this.GrSeed1.TabIndex = 51;
            this.GrSeed1.Text = "World 1 Grand Seed";
            this.GrSeed1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameComplete
            // 
            this.GameComplete.AutoSize = true;
            this.GameComplete.Location = new System.Drawing.Point(33, 37);
            this.GameComplete.Name = "GameComplete";
            this.GameComplete.Size = new System.Drawing.Size(82, 13);
            this.GameComplete.TabIndex = 50;
            this.GameComplete.Text = "Complete Game";
            this.GameComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GameComplete.Click += new System.EventHandler(this.label1_Click);
            // 
            // GrSeed6Btn
            // 
            this.GrSeed6Btn.AutoSize = true;
            this.GrSeed6Btn.Location = new System.Drawing.Point(141, 156);
            this.GrSeed6Btn.Name = "GrSeed6Btn";
            this.GrSeed6Btn.Size = new System.Drawing.Size(15, 14);
            this.GrSeed6Btn.TabIndex = 11;
            this.GrSeed6Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed5Btn
            // 
            this.GrSeed5Btn.AutoSize = true;
            this.GrSeed5Btn.Location = new System.Drawing.Point(141, 136);
            this.GrSeed5Btn.Name = "GrSeed5Btn";
            this.GrSeed5Btn.Size = new System.Drawing.Size(15, 14);
            this.GrSeed5Btn.TabIndex = 10;
            this.GrSeed5Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed4Btn
            // 
            this.GrSeed4Btn.AutoSize = true;
            this.GrSeed4Btn.Location = new System.Drawing.Point(141, 116);
            this.GrSeed4Btn.Name = "GrSeed4Btn";
            this.GrSeed4Btn.Size = new System.Drawing.Size(15, 14);
            this.GrSeed4Btn.TabIndex = 9;
            this.GrSeed4Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed3Btn
            // 
            this.GrSeed3Btn.AutoSize = true;
            this.GrSeed3Btn.Location = new System.Drawing.Point(141, 96);
            this.GrSeed3Btn.Name = "GrSeed3Btn";
            this.GrSeed3Btn.Size = new System.Drawing.Size(15, 14);
            this.GrSeed3Btn.TabIndex = 8;
            this.GrSeed3Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed2Btn
            // 
            this.GrSeed2Btn.AutoSize = true;
            this.GrSeed2Btn.Location = new System.Drawing.Point(141, 76);
            this.GrSeed2Btn.Name = "GrSeed2Btn";
            this.GrSeed2Btn.Size = new System.Drawing.Size(15, 14);
            this.GrSeed2Btn.TabIndex = 7;
            this.GrSeed2Btn.UseVisualStyleBackColor = true;
            // 
            // GrSeed1Btn
            // 
            this.GrSeed1Btn.AutoSize = true;
            this.GrSeed1Btn.Location = new System.Drawing.Point(141, 56);
            this.GrSeed1Btn.Name = "GrSeed1Btn";
            this.GrSeed1Btn.Size = new System.Drawing.Size(15, 14);
            this.GrSeed1Btn.TabIndex = 6;
            this.GrSeed1Btn.UseVisualStyleBackColor = true;
            // 
            // CompleteGameBtn
            // 
            this.CompleteGameBtn.AutoSize = true;
            this.CompleteGameBtn.Location = new System.Drawing.Point(141, 36);
            this.CompleteGameBtn.Name = "CompleteGameBtn";
            this.CompleteGameBtn.Size = new System.Drawing.Size(15, 14);
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
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.GeneralTab.Size = new System.Drawing.Size(892, 319);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Location = new System.Drawing.Point(9, 80);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(32, 13);
            this.LblLives.TabIndex = 7;
            this.LblLives.Text = "Lives";
            this.LblLives.Click += new System.EventHandler(this.label28_Click);
            // 
            // InputLives
            // 
            this.InputLives.Location = new System.Drawing.Point(119, 80);
            this.InputLives.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.InputLives.Name = "InputLives";
            this.InputLives.Size = new System.Drawing.Size(131, 20);
            this.InputLives.TabIndex = 6;
            this.InputLives.ValueChanged += new System.EventHandler(this.InputLives_ValueChanged);
            // 
            // LblPCoin
            // 
            this.LblPCoin.AutoSize = true;
            this.LblPCoin.Location = new System.Drawing.Point(9, 48);
            this.LblPCoin.Name = "LblPCoin";
            this.LblPCoin.Size = new System.Drawing.Size(92, 13);
            this.LblPCoin.TabIndex = 5;
            this.LblPCoin.Text = "Purple Coin Count";
            // 
            // InputPCoins
            // 
            this.InputPCoins.Location = new System.Drawing.Point(119, 48);
            this.InputPCoins.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.InputPCoins.Name = "InputPCoins";
            this.InputPCoins.Size = new System.Drawing.Size(131, 20);
            this.InputPCoins.TabIndex = 4;
            this.InputPCoins.ValueChanged += new System.EventHandler(this.InputPCoins_ValueChanged);
            // 
            // InputCoins
            // 
            this.InputCoins.Location = new System.Drawing.Point(119, 15);
            this.InputCoins.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.InputCoins.Name = "InputCoins";
            this.InputCoins.Size = new System.Drawing.Size(131, 20);
            this.InputCoins.TabIndex = 3;
            this.InputCoins.ValueChanged += new System.EventHandler(this.InputCoins_ValueChanged);
            // 
            // LblCoin
            // 
            this.LblCoin.AutoSize = true;
            this.LblCoin.Location = new System.Drawing.Point(9, 16);
            this.LblCoin.Name = "LblCoin";
            this.LblCoin.Size = new System.Drawing.Size(59, 13);
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
            this.TabControlValues.Location = new System.Drawing.Point(8, 46);
            this.TabControlValues.Name = "TabControlValues";
            this.TabControlValues.SelectedIndex = 0;
            this.TabControlValues.Size = new System.Drawing.Size(900, 345);
            this.TabControlValues.TabIndex = 2;
            this.TabControlValues.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // lblW1PurpleCoin1
            // 
            this.lblW1PurpleCoin1.AutoSize = true;
            this.lblW1PurpleCoin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW1PurpleCoin1.Location = new System.Drawing.Point(618, 31);
            this.lblW1PurpleCoin1.Name = "lblW1PurpleCoin1";
            this.lblW1PurpleCoin1.Size = new System.Drawing.Size(75, 13);
            this.lblW1PurpleCoin1.TabIndex = 206;
            this.lblW1PurpleCoin1.Text = "PurpleCoin1";
            this.lblW1PurpleCoin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblW1PurpleCoin1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // lblW1PurpleCoin2
            // 
            this.lblW1PurpleCoin2.AutoSize = true;
            this.lblW1PurpleCoin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW1PurpleCoin2.Location = new System.Drawing.Point(727, 31);
            this.lblW1PurpleCoin2.Name = "lblW1PurpleCoin2";
            this.lblW1PurpleCoin2.Size = new System.Drawing.Size(75, 13);
            this.lblW1PurpleCoin2.TabIndex = 207;
            this.lblW1PurpleCoin2.Text = "PurpleCoin2";
            this.lblW1PurpleCoin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(821, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 208;
            this.label1.Text = "PurpleCoin3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 432);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.PanelPath);
            this.Controls.Add(this.BtnPatchSaveFile);
            this.Controls.Add(this.TabControlValues);
            this.Controls.Add(this.BtnOpenSaveFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label W1Label11;
        private System.Windows.Forms.Label W1Label12;
        private System.Windows.Forms.Label W1Label13;
        private System.Windows.Forms.Label W1Label14;
        private System.Windows.Forms.Label W1Label15;
        private System.Windows.Forms.Label W1Label16;
        private System.Windows.Forms.Label W1Label17;
        private System.Windows.Forms.Label W1Label18;
        private System.Windows.Forms.Label W1Label19;
        private System.Windows.Forms.Label W1Label20;
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
        private System.Windows.Forms.CheckBox W1ClearCheckBox11;
        private System.Windows.Forms.CheckBox W1ClearCheckBox12;
        private System.Windows.Forms.CheckBox W1ClearCheckBox13;
        private System.Windows.Forms.CheckBox W1ClearCheckBox14;
        private System.Windows.Forms.CheckBox W1ClearCheckBox15;
        private System.Windows.Forms.CheckBox W1ClearCheckBox16;
        private System.Windows.Forms.CheckBox W1ClearCheckBox17;
        private System.Windows.Forms.CheckBox W1ClearCheckBox18;
        private System.Windows.Forms.CheckBox W1ClearCheckBox19;
        private System.Windows.Forms.CheckBox W1ClearCheckBox20;
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
        private System.Windows.Forms.CheckBox W1EndGoalSeed11;
        private System.Windows.Forms.CheckBox W1EndGoalSeed12;
        private System.Windows.Forms.CheckBox W1EndGoalSeed13;
        private System.Windows.Forms.CheckBox W1EndGoalSeed14;
        private System.Windows.Forms.CheckBox W1EndGoalSeed15;
        private System.Windows.Forms.CheckBox W1EndGoalSeed16;
        private System.Windows.Forms.CheckBox W1EndGoalSeed17;
        private System.Windows.Forms.CheckBox W1EndGoalSeed18;
        private System.Windows.Forms.CheckBox W1EndGoalSeed19;
        //private System.Windows.Forms.CheckBox W1EndGoalSeed20;
        private System.Windows.Forms.CheckBox W1WonderSeed1;
        private System.Windows.Forms.CheckBox W1WonderSeed2;
        private System.Windows.Forms.CheckBox W1WonderSeed3;
        private System.Windows.Forms.CheckBox W1WonderSeed4;
        private System.Windows.Forms.CheckBox W1WonderSeed5;
        private System.Windows.Forms.CheckBox W1WonderSeed6;
        private System.Windows.Forms.CheckBox W1WonderSeed7;
        private System.Windows.Forms.CheckBox W1WonderSeed8;
        private System.Windows.Forms.CheckBox W1WonderSeed9;
        private System.Windows.Forms.CheckBox W1WonderSeed10;
        private System.Windows.Forms.CheckBox W1WonderSeed11;
        private System.Windows.Forms.CheckBox W1WonderSeed12;
        private System.Windows.Forms.CheckBox W1ClapperGate1;
        private System.Windows.Forms.CheckBox W1FirstBigCoin1;
        private System.Windows.Forms.CheckBox W1FirstBigCoin2;
        private System.Windows.Forms.CheckBox W1FirstBigCoin3;
        private System.Windows.Forms.CheckBox W1FirstBigCoin4;
        private System.Windows.Forms.CheckBox W1FirstBigCoin5;
        private System.Windows.Forms.CheckBox W1FirstBigCoin6;
        private System.Windows.Forms.CheckBox W1FirstBigCoin7;
        private System.Windows.Forms.CheckBox W1FirstBigCoin8;
        private System.Windows.Forms.CheckBox W1FirstBigCoin9;
        private System.Windows.Forms.CheckBox W1FirstBigCoin10;
        private System.Windows.Forms.CheckBox W1FirstBigCoin11;
        private System.Windows.Forms.CheckBox W1FirstBigCoin12;
        private System.Windows.Forms.CheckBox W1FirstBigCoin13;
        private System.Windows.Forms.CheckBox W1FirstBigCoin14;
        private System.Windows.Forms.CheckBox W1FirstBigCoin15;
        private System.Windows.Forms.CheckBox W1FirstBigCoin16;
        private System.Windows.Forms.CheckBox W1SecondBigCoin1;
        private System.Windows.Forms.CheckBox W1SecondBigCoin2;
        private System.Windows.Forms.CheckBox W1SecondBigCoin3;
        private System.Windows.Forms.CheckBox W1SecondBigCoin4;
        private System.Windows.Forms.CheckBox W1SecondBigCoin5;
        private System.Windows.Forms.CheckBox W1SecondBigCoin6;
        private System.Windows.Forms.CheckBox W1SecondBigCoin7;
        private System.Windows.Forms.CheckBox W1SecondBigCoin8;
        private System.Windows.Forms.CheckBox W1SecondBigCoin9;
        private System.Windows.Forms.CheckBox W1SecondBigCoin10;
        private System.Windows.Forms.CheckBox W1SecondBigCoin11;
        private System.Windows.Forms.CheckBox W1SecondBigCoin12;
        private System.Windows.Forms.CheckBox W1SecondBigCoin13;
        private System.Windows.Forms.CheckBox W1SecondBigCoin14;
        private System.Windows.Forms.CheckBox W1SecondBigCoin15;
        private System.Windows.Forms.CheckBox W1SecondBigCoin16;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin1;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin2;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin3;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin4;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin5;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin6;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin7;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin8;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin9;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin10;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin11;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin12;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin13;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin14;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin15;
        private System.Windows.Forms.CheckBox W1ThirdBigCoin16;
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
        CheckBox[] W1ClapperGates;
        CheckBox[] W1EndGoalSeeds;
        CheckBox[] W1FirstBigCoins;
        CheckBox[] W1SecondBigCoins;
        CheckBox[] W1ThirdBigCoins;
        CheckBox[] W1WonderSeeds;
        String[] Course_Labels;
        private Label LblW1Level;
        private Label LblW1Cleared;
        private Label LblW1GoalSeed;
        private Label LblW1ClapperGate;
        private Label lblW1WonderSeed;
        private Label lblW1PurpleCoin1;
        private Label label1;
        private Label lblW1PurpleCoin2;
    }
}

