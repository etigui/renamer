using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renamer {
    public partial class Renamer : Form {

        #region Vars
        private Rename rename = new Rename();
        private char[] invalidFileChars = Path.GetInvalidFileNameChars();
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
        private void BTRename_Click(object sender, EventArgs e) {
      
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
        }

        private void CBRemove_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBRemove, GBRemove);
            ProcessNewNameAndExt();
        }

        private void CBAdd_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBAdd, GBAdd);
            ProcessNewNameAndExt();
        }

        private void CBName_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBName, GBName);
            ProcessNewNameAndExt();
        }

        private void CBExt_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBExt, GBExt);
            ProcessNewNameAndExt();
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

        #endregion
        #endregion

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

        private void CBAttributes_CheckedChanged(object sender, EventArgs e) {
            if (CBAttributes.Checked) {
                Attributes attributes = new Attributes();
                attributes.ShowDialog();
            }
        }

        private void CBTimestamps_CheckedChanged(object sender, EventArgs e) {
            if (CBTimestamps.Checked) {
                Timestamps timestamps = new Timestamps();
                timestamps.ShowDialog();
            }
        }
    }
}
