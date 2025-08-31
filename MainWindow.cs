using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SMBW_SaveGame_Editor.SaveFile;

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
        W1Label6, W1Label7, W1Label8, W1Label9, W1Label10
            };

            W1ClearCheckBoxes = new CheckBox[]
{
          W1ClearCheckBox1, W1ClearCheckBox2, W1ClearCheckBox3, W1ClearCheckBox4, W1ClearCheckBox5,
          W1ClearCheckBox6, W1ClearCheckBox7, W1ClearCheckBox8, W1ClearCheckBox9, W1ClearCheckBox10
};
            W1EndGoalSeeds = new CheckBox[]
            {
                W1EndGoalSeed1,  W1EndGoalSeed2,  W1EndGoalSeed3,  W1EndGoalSeed4,  W1EndGoalSeed5,  W1EndGoalSeed6,  W1EndGoalSeed7,  W1EndGoalSeed8,  W1EndGoalSeed9,  W1EndGoalSeed10
            };


            int i = 1;
            int location = 46;
            string controlName = "";
            int xloc = 250;
            foreach (var course in Data.GameData.AllCourses.Values)
            {
                foreach (var level in course)
                {

                    String levelName = level.Name;
                    controlName = "W1Label" + i;
                    Label label = W1Labels[i - 1];
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(44, location);
                    label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    label.Name = controlName;
                    label.Size = new System.Drawing.Size(25, 16);
                    label.TabIndex = 50;
                    label.Text = levelName;
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    //for (i = 0; i < 2; i++)
                    //{
                        controlName = "W1ClearCheckBox" + i;
                        CheckBox checkbox = W1ClearCheckBoxes[i - 1];
                        checkbox.AutoSize = true;
                        checkbox.Location = new System.Drawing.Point(250, location);
                        checkbox.Margin = new System.Windows.Forms.Padding(4);
                        checkbox.Name = controlName;
                        checkbox.Size = new System.Drawing.Size(18, 17);
                        checkbox.TabIndex = 50;
                        checkbox.UseVisualStyleBackColor = true;
                    //checkbox.CheckedChanged += new System.EventHandler(this.Wmap_CheckedChanged);
                    //checkbox.Tag = controlName;

                    controlName = "W1EndGoalSeed" + i;
                    CheckBox checkbox2 = W1EndGoalSeeds[i - 1];
                    checkbox2.AutoSize = true;
                    checkbox2.Location = new System.Drawing.Point(350, location);
                    checkbox2.Margin = new System.Windows.Forms.Padding(4);
                    checkbox2.Name = controlName;
                    checkbox2.Size = new System.Drawing.Size(18, 17);
                    checkbox2.TabIndex = 50;
                    checkbox2.UseVisualStyleBackColor = true;
                    i++;
                        location += 24;


                    }

                }
            }
        //}



        

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
            foreach (int course in _SaveFile.Courses)
            {
               CheckBox Checkbox = W1ClearCheckBoxes[i];
               Checkbox.Checked = _SaveFile.ReadBool(_SaveFile.Courses[i]);
                i++;
            }
            i = 0;
            foreach (int seed in _SaveFile.EndSeed)
            {
                CheckBox Checkbox = W1EndGoalSeeds[i];
                Checkbox.Checked = _SaveFile.ReadBool(_SaveFile.EndSeed[i]);
                i++;
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
            foreach (int course in _SaveFile.Courses)
            {
                CheckBox ClearCheckbox = W1ClearCheckBoxes[i];
                _SaveFile.WriteBool(_SaveFile.Courses[i], ClearCheckbox.Checked);
                i++;
            }
            i = 0;
            foreach (int course in _SaveFile.Courses)
            {
                CheckBox ClearCheckbox = W1EndGoalSeeds[i];
                _SaveFile.WriteBool(_SaveFile.EndSeed[i], ClearCheckbox.Checked);
                i++;
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
    }
}
