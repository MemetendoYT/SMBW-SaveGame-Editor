using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using SMBW_SaveGame_Editor.SaveFile;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SMBW_SaveGame_Editor
{
    public partial class MainWindow : Form
    {
        private SMBW_SaveFile _SaveFile;

        public MainWindow()
        {
            InitializeComponent();


            Size = new Size(351, 260);
            TabControlValues.Enabled = false;

            W1Labels = new Label[]
            {
        W1Label1, W1Label2, W1Label3, W1Label4, W1Label5,
        W1Label6, W1Label7, W1Label8, W1Label9, W1Label10, W1Label11, W1Label12, W1Label13, W1Label14, W1Label15, W1Label16, W1Label17,W1Label18, W1Label19, W1Label20
            };

            W1ClearCheckBoxes = new CheckBox[]
{
          W1ClearCheckBox1, W1ClearCheckBox2, W1ClearCheckBox3, W1ClearCheckBox4, W1ClearCheckBox5, W1ClearCheckBox6, W1ClearCheckBox7, W1ClearCheckBox8, W1ClearCheckBox9, W1ClearCheckBox10, W1ClearCheckBox11, W1ClearCheckBox12, W1ClearCheckBox13,W1ClearCheckBox14, W1ClearCheckBox15, W1ClearCheckBox16,W1ClearCheckBox17, W1ClearCheckBox18, W1ClearCheckBox19, W1ClearCheckBox20
};
            W1EndGoalSeeds = new CheckBox[]
            {
                W1EndGoalSeed1,  W1EndGoalSeed2,  W1EndGoalSeed3,  W1EndGoalSeed4,  W1EndGoalSeed5, W1EndGoalSeed6,  W1EndGoalSeed7,  W1EndGoalSeed8,  W1EndGoalSeed9,  W1EndGoalSeed10,  W1EndGoalSeed11,  W1EndGoalSeed12,  W1EndGoalSeed13,  W1EndGoalSeed14,  W1EndGoalSeed15,  W1EndGoalSeed16,  W1EndGoalSeed17,  W1EndGoalSeed18, W1EndGoalSeed19
            };

            W1FirstBigCoins = new CheckBox[]
{
      W1FirstBigCoin1,  W1FirstBigCoin2,  W1FirstBigCoin3,  W1FirstBigCoin4,  W1FirstBigCoin5, W1FirstBigCoin6,  W1FirstBigCoin7,  W1FirstBigCoin8,  W1FirstBigCoin9,  W1FirstBigCoin10,  W1FirstBigCoin11,  W1FirstBigCoin12,  W1FirstBigCoin13,  W1FirstBigCoin14,  W1FirstBigCoin15,  W1FirstBigCoin16
};

            W1SecondBigCoins = new CheckBox[]
{
      W1SecondBigCoin1,  W1SecondBigCoin2,  W1SecondBigCoin3,  W1SecondBigCoin4,  W1SecondBigCoin5, W1SecondBigCoin6,  W1SecondBigCoin7,  W1SecondBigCoin8,  W1SecondBigCoin9,  W1SecondBigCoin10,  W1SecondBigCoin11,  W1SecondBigCoin12,  W1SecondBigCoin13,  W1SecondBigCoin14,  W1SecondBigCoin15,  W1SecondBigCoin16
};

       W1ThirdBigCoins = new CheckBox[]
{
      W1ThirdBigCoin1,  W1ThirdBigCoin2,  W1ThirdBigCoin3,  W1ThirdBigCoin4,  W1ThirdBigCoin5, W1ThirdBigCoin6,  W1ThirdBigCoin7,  W1ThirdBigCoin8,  W1ThirdBigCoin9,  W1ThirdBigCoin10,  W1ThirdBigCoin11,  W1ThirdBigCoin12,  W1ThirdBigCoin13,  W1ThirdBigCoin14,  W1ThirdBigCoin15,  W1ThirdBigCoin16
};

            W1ClapperGates = new CheckBox[]
         {
                W1ClapperGate1
         };

    W1WonderSeeds = new CheckBox[]
{
    W1WonderSeed1, W1WonderSeed2, W1WonderSeed3, W1WonderSeed4, W1WonderSeed5,
    W1WonderSeed6, W1WonderSeed7, W1WonderSeed8, W1WonderSeed9, W1WonderSeed10,
    W1WonderSeed11, W1WonderSeed12
};

            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int o = 0;
            int location = 46;
            string controlName = "";

            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {

                    LevelInfo info = entry.Value;
                    controlName = "W1Label" + (i + 1);
                    Label label = W1Labels[i];
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(44, location);
                    label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    label.Name = controlName;
                    label.Size = new System.Drawing.Size(25, 16);
                    label.TabIndex = 50;
                    label.Text = info.Name;
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    controlName = "W1ClearCheckBox" + (i + 1);
                    CheckBox checkbox = W1ClearCheckBoxes[i];
                    checkbox.AutoSize = true;
                    checkbox.Location = new System.Drawing.Point(250, location);
                    checkbox.Margin = new System.Windows.Forms.Padding(4);
                    checkbox.Name = controlName;
                    checkbox.Size = new System.Drawing.Size(18, 17);
                    checkbox.TabIndex = 50;
                    checkbox.UseVisualStyleBackColor = true;

                if (info.GoalWonderSeed != -1)
                {
                    controlName = "W1EndGoalSeed" + (l);
                    CheckBox checkbox2 = W1EndGoalSeeds[l];
                    checkbox2.AutoSize = true;
                    checkbox2.Location = new System.Drawing.Point(350, location);
                    checkbox2.Margin = new System.Windows.Forms.Padding(4);
                    checkbox2.Name = controlName;
                    checkbox2.Size = new System.Drawing.Size(18, 17);
                    checkbox2.TabIndex = 50;
                    checkbox2.UseVisualStyleBackColor = true;
                    l++;
                }
                if (info.ClapperGate != -1)
                {
                    controlName = "W1ClapperGate" + (j);
                    CheckBox checkbox3 = W1ClapperGates[j];
                    checkbox3.AutoSize = true;
                    checkbox3.Location = new System.Drawing.Point(550, location);
                    checkbox3.Margin = new System.Windows.Forms.Padding(4);
                    checkbox3.Name = controlName;
                    checkbox3.Size = new System.Drawing.Size(18, 17);
                    checkbox3.TabIndex = 50;
                    checkbox3.UseVisualStyleBackColor = true;
                    j++;
                }

                if (info.WonderSeed != -1)
                {
                    controlName = "W1WonderSeed" + (k);

                    CheckBox checkbox4 = W1WonderSeeds[k];
                    checkbox4.AutoSize = true;
                    checkbox4.Location = new System.Drawing.Point(450, location);
                    checkbox4.Margin = new System.Windows.Forms.Padding(4);
                    checkbox4.Name = controlName;
                    checkbox4.Size = new System.Drawing.Size(18, 17);
                    checkbox4.TabIndex = 50;
                    checkbox4.UseVisualStyleBackColor = true;
                    k++;
                }

                if (info.PurpleCoinOffset != -1)
                {
                    controlName = "W1FirstBigCoin" + (m);

                    CheckBox checkbox5 = W1FirstBigCoins[m];
                    checkbox5.AutoSize = true;
                    checkbox5.Location = new System.Drawing.Point(650, location);
                    checkbox5.Margin = new System.Windows.Forms.Padding(4);
                    checkbox5.Name = controlName;
                    checkbox5.Size = new System.Drawing.Size(18, 17);
                    checkbox5.TabIndex = 50;
                    checkbox5.UseVisualStyleBackColor = true;
                    m++;
                }

                if (info.PurpleCoinOffset != -1)
                {
                    controlName = "W1SecondBigCoin" + (n);

                    CheckBox checkbox6 = W1SecondBigCoins[n];
                    checkbox6.AutoSize = true;
                    checkbox6.Location = new System.Drawing.Point(750, location);
                    checkbox6.Margin = new System.Windows.Forms.Padding(4);
                    checkbox6.Name = controlName;
                    checkbox6.Size = new System.Drawing.Size(18, 17);
                    checkbox6.TabIndex = 50;
                    checkbox6.UseVisualStyleBackColor = true;
                    n++;
                }
                if (info.PurpleCoinOffset != -1)
                {
                    controlName = "W1ThirdBigCoin" + (o);

                    CheckBox checkbox7 = W1ThirdBigCoins[o];
                    checkbox7.AutoSize = true;
                    checkbox7.Location = new System.Drawing.Point(850, location);
                    checkbox7.Margin = new System.Windows.Forms.Padding(4);
                    checkbox7.Name = controlName;
                    checkbox7.Size = new System.Drawing.Size(18, 17);
                    checkbox7.TabIndex = 50;
                    checkbox7.UseVisualStyleBackColor = true;
                    o++;
                }


                i++;
                location += 24;
            }
          }
 


        

        private void OpenSaveFile(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog
            {
                Filter = "game_data (*.sav)|*.sav"
            };

            if (FileDialog.ShowDialog() != DialogResult.OK) return;
            if (!FileDialog.CheckFileExists) return;

            _SaveFile = new SMBW_SaveFile(FileDialog.FileName);

            if (!_SaveFile.IsLoaded)
            {
                MessageBox.Show("Invalid game_data.sav!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LblPath.Text = FileDialog.FileName;

            BtnOpenSaveFile.Enabled = false;
            BtnPatchSaveFile.Enabled = true;
            BtnReset.Enabled = true;

            TabControlValues.Enabled = true;

            SetValuesFromSavefile();
        }

        private void CloseSaveFile(object sender, EventArgs e)
        {
            LblPath.Text = "game_data.sav";
            _SaveFile = null;

            BtnOpenSaveFile.Enabled = true;
            BtnPatchSaveFile.Enabled = false;
            BtnReset.Enabled = false;

            TabControlValues.Enabled = false;
        }

        private void SetComboIndex(ComboBox comboBox, string value)
        {
            var index = comboBox.Items.IndexOf(value);
            if (index == -1) return;

            comboBox.SelectedIndex = index;
        }

        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    Size = new Size(351, 260);
                    break;
                case 1:
                    Size = new Size(458, 341);
                    break;
                case 2:
                    Size = new Size(458, 341);
                    break;
                case 3:
                    Size = new Size(458, 341);
                    break;
                case 4:
                    Size = new Size(458, 341);
                    break;
                case 5:
                    Size = new Size(351, 541);
                    break;
            }
        }


        private void SetValuesFromSavefile()
        {
            InputCoins.Value = _SaveFile.Coins;
            InputPCoins.Value = _SaveFile.P_Coins;
            InputLives.Value = _SaveFile.Lives; 
         
            CompleteGameBtn.Checked = _SaveFile.ReadBool(_SaveFile.COMPLETE_GAME);
            GrSeed1Btn.Checked = _SaveFile.ReadBool(_SaveFile.WORLD1_SEED);
            GrSeed2Btn.Checked = _SaveFile.ReadBool(_SaveFile.WORLD2_SEED);
            GrSeed3Btn.Checked = _SaveFile.ReadBool(_SaveFile.WORLD3_SEED);
            GrSeed4Btn.Checked = _SaveFile.ReadBool(_SaveFile.WORLD4_SEED);
            GrSeed5Btn.Checked = _SaveFile.ReadBool(_SaveFile.WORLD5_SEED);
            GrSeed6Btn.Checked = _SaveFile.ReadBool(_SaveFile.WORLD6_SEED);

            int i = 0;
            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                CheckBox Checkbox = W1ClearCheckBoxes[i];

               Checkbox.Checked = _SaveFile.ReadBool(info.CourseClearHex);
                i++;
            }
            i = 0;
            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                if (info.GoalWonderSeed != -1)
                {
                    CheckBox Checkbox = W1EndGoalSeeds[i];
                    Checkbox.Checked = _SaveFile.ReadBool(info.GoalWonderSeed);
                    i++;
                }
            }
            i = 0;
            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                if (info.ClapperGate != -1)
                {
                    CheckBox Checkbox = W1ClapperGates[i];
                    Checkbox.Checked = _SaveFile.ReadBool(info.ClapperGate);
                    i++;
                }
               
            }

            i = 0;
            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                if (info.WonderSeed != -1)
                {
                    CheckBox Checkbox = W1WonderSeeds[i];
                    Checkbox.Checked = _SaveFile.ReadBool(info.WonderSeed);
                    i++;
                }


            }

            i = 0;
            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                if (info.PurpleCoinOffset != -1)
                {
                    ReadBigCoin(info.PurpleCoinOffset, info);
                    CheckBox Checkbox = W1FirstBigCoins[i];
                    CheckBox Checkbox2 = W1SecondBigCoins[i];
                    CheckBox Checkbox3 = W1ThirdBigCoins[i];
                    Checkbox.Checked = Convert.ToBoolean(info.PurpleCoin1);
                    Checkbox2.Checked = Convert.ToBoolean(info.PurpleCoin2);
                    Checkbox3.Checked = Convert.ToBoolean(info.PurpleCoin3);
                    i++;
                }


            }
        }




        private void BtnPatchSaveFile_Click(object sender, EventArgs e)
        {
            if (_SaveFile == null || !_SaveFile.IsLoaded)
            {
                MessageBox.Show("Invalid Savefile!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
     _SaveFile.WriteBool(_SaveFile.COMPLETE_GAME,CompleteGameBtn.Checked);
           
            _SaveFile.WriteBool(_SaveFile.WORLD1_SEED, GrSeed1Btn.Checked);
            _SaveFile.WriteBool(_SaveFile.WORLD2_SEED, GrSeed2Btn.Checked);
            _SaveFile.WriteBool(_SaveFile.WORLD3_SEED, GrSeed3Btn.Checked);
            _SaveFile.WriteBool(_SaveFile.WORLD4_SEED, GrSeed4Btn.Checked);
            _SaveFile.WriteBool(_SaveFile.WORLD5_SEED, GrSeed5Btn.Checked);
            _SaveFile.WriteBool(_SaveFile.WORLD6_SEED, GrSeed6Btn.Checked);
            int i = 0;


            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                CheckBox ClearCheckbox = W1ClearCheckBoxes[i];
                _SaveFile.WriteBool(info.CourseClearHex, ClearCheckbox.Checked);
                i++;
            }
            i = 0;
            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                CheckBox ClearCheckbox = W1EndGoalSeeds[i];
                if (info.GoalWonderSeed != -1)
                {
                    _SaveFile.WriteBool(info.GoalWonderSeed, ClearCheckbox.Checked);
                    i++;
                }
            }
            i = 0;
            int valueToWrite = 0;
            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                if (info.ClapperGate != -1)
                {
                    CheckBox ClearCheckbox = W1ClapperGates[i];
                    if (ClearCheckbox.Checked)
                        valueToWrite = info.ClapperGateOrgVal;

                 
                    _SaveFile.WriteInt(info.ClapperGate, valueToWrite);
                    i++;
                }

            }

            i = 0;
            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                if (info.WonderSeed != -1)
                {
                    CheckBox ClearCheckbox = W1WonderSeeds[i];
                    _SaveFile.WriteBool(info.WonderSeed, ClearCheckbox.Checked);
                    i++;
                }
            }

            i = 0;
            foreach (KeyValuePair<string, LevelInfo> entry in CourseData.World1Courses)
            {
                LevelInfo info = entry.Value;
                if (info.PurpleCoinOffset != -1)
                {
                    int coin_1_checkbox = Convert.ToInt32(W1FirstBigCoins[i].Checked);
                    int coin_2_checkbox = Convert.ToInt32(W1SecondBigCoins[i].Checked);
                    int coin_3_checkbox = Convert.ToInt32(W1ThirdBigCoins[i].Checked);
                    int number_to_write = 1 * coin_1_checkbox + 2 * coin_2_checkbox + 4 * coin_3_checkbox;
                    _SaveFile.WriteInt(info.PurpleCoinOffset, number_to_write);
                    i++;
                }
            }

            _SaveFile.PatchSaveFile();

            MessageBox.Show("Successfully patched savefile!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetAllCheckboxes(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            bool value = btn.Name == "BtnCheckAll";

            foreach (CheckBox checkbox in GameProgression.Controls.OfType<CheckBox>())
            {
                checkbox.Checked = value;
            }
        }

        public void ReadBigCoin(int value, LevelInfo info)
        {
            byte newValue = 0;
            if (value != 0)
            {
               newValue = Convert.ToByte(_SaveFile.ReadInt(value));
            }
             
            
            info.PurpleCoin1 = newValue & 1;
            info.PurpleCoin2 = (newValue >> 1) & 1;
            info.PurpleCoin3 = (newValue >> 2) & 1;
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxSwords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblRupees_Click(object sender, EventArgs e)
        {

        }

        private void InputCoins_ValueChanged(object sender, EventArgs e)
        {
            _SaveFile.Coins = (int)InputCoins.Value;
        }

        private void InputPCoins_ValueChanged(object sender, EventArgs e)
        {
            _SaveFile.P_Coins = (int)InputPCoins.Value;
        }

        private void InputLives_ValueChanged(object sender, EventArgs e)
        {
            _SaveFile.Lives = (int)InputLives.Value;
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void Wmap_CheckedChanged(object sender, EventArgs e)
        {
            _SaveFile.WriteBool(_SaveFile.WORLD6_SEED, GrSeed6Btn.Checked);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
