using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renamer {
    public partial class Renamer : Form {

        #region Vars
        private Rename rename = new Rename();
        private char[] invalidFileChars = Path.GetInvalidFileNameChars();
        private bool loading = false;
        #endregion

        #region Init
        public Renamer() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // Disable control => checkbox false
            InitControls();
        }

        /// <summary>
        /// Init checkbox and groupbox
        /// </summary>
        private void InitControls() {
            ModifyGroupControls(CBReplace, GBReplace);
            ModifyGroupControls(CBRemove, GBRemove);
            ModifyGroupControls(CBAdd, GBAdd);
            ModifyGroupControls(CBName, GBName);
            ModifyGroupControls(CBExt, GBExt);
        }

        #endregion

        #region Controls

        /// <summary>
        /// Rename files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTRename_Click(object sender, EventArgs e) {
   
            // Rename if files
            if (LVFiles.Items.Count > 0) {
                DialogResult dialogResult = MessageBox.Show($"{LVFiles.Items.Count} files are about to be renamed. Do you want to continue ?", "Rename files", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes) {

                    // Start (processing files) thread
                    loading = true;
                    new Thread(Loading).Start();
                    BW.RunWorkerAsync();
                    BTClear.Enabled = false;
                    BTRename.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Add new files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMIAdd_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK) {
                LVFiles.Items.AddRange(rename.AddNewFiles(ofd.FileNames));
                ProcessNewNameAndExt();
                CheckOptionEnable();
                BTClear.Enabled = true;
            }
        }

        private void BTClear_Click(object sender, EventArgs e) {
            CBNameAction.SelectedIndex = -1;
            CBExtAction.SelectedIndex = -1;
            TBNameRename.Text = String.Empty;
            TBReplaceName.Text = String.Empty;
            TBReplaceWith.Text = String.Empty;
            TBAddPrefix.Text = String.Empty;
            TBAddSufix.Text = String.Empty;
            TBAddInsert.Text = String.Empty;
            TBExtRename.Text = String.Empty;
            NUDRemoveFirst.Value = 0;
            NUDRemoveLast.Value = 0;
            NUDRemoveFrom.Value = 0;
            NUDRemoveTo.Value = 0;
            NUDAddAt.Value = 0;
            LVFiles.Items.Clear();
            BTClear.Enabled = false;
        }

        #region Even drag drop listview

        /// <summary>
        /// Get and process droped files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LVFiles_DragDrop(object sender, DragEventArgs e) {

            // Check if the data dropped is one or more files
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {

                // Get the file pathes from the data object
                string[] files = (e.Data.GetData(DataFormats.FileDrop) as string[]);
                LVFiles.Items.AddRange(rename.AddNewFiles(files));
                ProcessNewNameAndExt();
                BTClear.Enabled = true;
                CheckOptionEnable();
            }
        }

        /// <summary>
        /// Validate that's file that the user want to drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LVFiles_DragEnter(object sender, DragEventArgs e) {

            // Check if the data dropped is one or more files
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        #endregion

        #region Even key listview

        /// <summary>
        ///  Select all listview items with the comb. key (Ctrl + A)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LVFiles_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.A && e.Control) {
                LVFiles.MultiSelect = true;
                foreach (ListViewItem item in LVFiles.Items) {
                    item.Selected = true;
                }
            }

            // Remove items selected
            foreach (ListViewItem lvItem in LVFiles.SelectedItems) {
                LVFiles.Items.Remove(lvItem);
            }
        }
        #endregion

        #region Even text or value change

        private void TBReplaceName_TextChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void TBReplaceWith_TextChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void NUDRemoveFirst_ValueChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void NUDRemoveLast_ValueChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void NUDRemoveFrom_ValueChanged(object sender, EventArgs e) {
            if (NUDRemoveFrom.Value > NUDRemoveTo.Value) {
                NUDRemoveTo.Value = NUDRemoveFrom.Value;
            }
            ProcessNewNameAndExt();
        }

        private void NUDRemoveTo_ValueChanged(object sender, EventArgs e) {

            if (NUDRemoveTo.Value < NUDRemoveFrom.Value) {
                NUDRemoveFrom.Value = NUDRemoveTo.Value;
            }
            ProcessNewNameAndExt();
        }

        private void TBAddPrefix_TextChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void TBAddSufix_TextChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void TBAddInsert_TextChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void NUDAddAt_ValueChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void CBNameAction_SelectedIndexChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void TBNameRename_TextChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void CBExtAction_SelectedIndexChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        private void TBExtRename_TextChanged(object sender, EventArgs e) {
            ProcessNewNameAndExt();
        }

        #endregion

        #region Even keypress escape file invalid char

        private void TBReplaceName_KeyPress(object sender, KeyPressEventArgs e) {
            if (invalidFileChars.Contains(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void TBReplaceWith_KeyPress(object sender, KeyPressEventArgs e) {
            if (invalidFileChars.Contains(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void TBAddPrefix_KeyPress(object sender, KeyPressEventArgs e) {
            if (invalidFileChars.Contains(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void TBAddSufix_KeyPress(object sender, KeyPressEventArgs e) {
            if (invalidFileChars.Contains(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void TBAddInsert_KeyPress(object sender, KeyPressEventArgs e) {
            if (invalidFileChars.Contains(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void TBNameRename_KeyPress(object sender, KeyPressEventArgs e) {
            if (invalidFileChars.Contains(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void TBExtRename_KeyPress(object sender, KeyPressEventArgs e) {
            if (invalidFileChars.Contains(e.KeyChar)) {
                e.Handled = true;
            }
        }
        #endregion

        #region Even onchange checkbox controls

        private void CBReplace_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBReplace, GBReplace);
            ProcessNewNameAndExt();
            CheckOptionEnable();
        }

        private void CBRemove_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBRemove, GBRemove);
            ProcessNewNameAndExt();
            CheckOptionEnable();
        }

        private void CBAdd_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBAdd, GBAdd);
            ProcessNewNameAndExt();
            CheckOptionEnable();
        }

        private void CBName_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBName, GBName);
            ProcessNewNameAndExt();
            CheckOptionEnable();
        }

        private void CBExt_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBExt, GBExt);
            ProcessNewNameAndExt();
            CheckOptionEnable();
        }

        /// <summary>
        /// Enable or diable all the controls in the groups
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="gb"></param>
        private void ModifyGroupControls(CheckBox cb, GroupBox gb) {

            // Make sure the CheckBox isn't in the GroupBox. This will only happen the first time.
            if (cb.Parent == gb) {

                // Reparent the CheckBox so it's not in the GroupBox.
                gb.Parent.Controls.Add(cb);

                // Adjust the CheckBox's location.
                cb.Location = new Point(cb.Left + gb.Left, cb.Top + gb.Top);

                // Move the CheckBox to the top of the stacking order.
                cb.BringToFront();
            }

            // Enable or disable the GroupBox.
            gb.Enabled = cb.Checked;
        }

        /// <summary>
        /// Check if checkbox option selected
        /// </summary>
        private void CheckOptionEnable() {

            bool controlChecked = false;

            foreach (Control c in this.Controls) {
                if (c is CheckBox) {
                    if (((CheckBox)c).Checked) {
                        controlChecked = true;
                    }
                }
            }
            if (controlChecked && LVFiles.Items.Count > 0) {
                BTRename.Enabled = true;
            } else {
                BTRename.Enabled = false;
            }
        }

        /// <summary>
        /// Quit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSMIQuit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion

        #endregion


        /// <summary>
        /// Generate new name every time the option change
        /// </summary>
        private void ProcessNewNameAndExt() {
            if (LVFiles.Items.Count > 0) {
                for (int c = 0; c < LVFiles.Items.Count; c++) {
                    string name = LVFiles.Items[c].SubItems[1].Text;
                    string extension = LVFiles.Items[c].SubItems[2].Text;

                    if (CBName.Checked) {
                        name = rename.GetName(name, CBNameAction.Text, TBNameRename.Text);
                    }

                    if (CBReplace.Checked) {
                        name = rename.GetReplace(name, TBReplaceName.Text, TBReplaceWith.Text);
                    }
                    if (CBRemove.Checked) {
                        name = rename.GetRemove(name, (int)NUDRemoveFirst.Value, (int)NUDRemoveLast.Value, (int)NUDRemoveFrom.Value, (int)NUDRemoveTo.Value);
                    }
                    if (CBAdd.Checked) {
                        name = rename.GetAdd(name, TBAddPrefix.Text, TBAddSufix.Text, TBAddInsert.Text, (int)NUDAddAt.Value);
                    }

                    if (CBExt.Checked) {
                        extension = rename.GetExt(extension, CBExtAction.Text, TBExtRename.Text);
                    }
                    LVFiles.Items[c].SubItems[3].Text = name.ToString();
                    LVFiles.Items[c].SubItems[4].Text = extension.ToString();
                }
            }
        }

        #region Processing files thread

        /// <summary>
        /// Update tooltips message while loading
        /// </summary>
        /// <param name="text"></param>
        private void UpdateControls(string text) {
            if (InvokeRequired) {
                this.Invoke((MethodInvoker)delegate () { UpdateControls(text); });
                return;
            }
            TSSLMessage.Text = text;
        }

        /// <summary>
        /// Executed on a seperate thread and doesn't block the UI while sleeping
        /// </summary>
        private void Loading() {
            StringBuilder sb = new StringBuilder("Processing files");
            while (loading) {
                if(sb.Length >= 16 && sb.Length <= 21) {
                    sb.Append(".");
                } else {
                    sb.Clear().Append("Processing files");
                }
                UpdateControls(sb.ToString());
                Thread.Sleep(500);
            }
        }
        #endregion

        #region Rename file worker

        private void BW_DoWork(object sender, DoWorkEventArgs e) {
            //rename.RenameFiles(LVFiles.Items);
            rename.RenameFiles(LVFiles);
        }

        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            loading = false;
            BTClear.Enabled = true;
            BTRename.Enabled = true;
            TSSLMessage.Text = "Done";
            LVFiles.Items.Clear();
        }
        #endregion

        /// <summary>
        /// Prevent error access UI controls by thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Renamer_FormClosing(object sender, FormClosingEventArgs e) {
            loading = false;
        }
    }
}
