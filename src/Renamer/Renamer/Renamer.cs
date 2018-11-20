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
        #endregion

        #region Init
        public Renamer() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // Disable control => checkbox false
            InitControls();
        }

        private void InitControls() {
            ModifyGroupControls(CBRename, GBRename);
            ModifyGroupControls(CBRemove, GBRemove);
            ModifyGroupControls(CBAdd, GBAdd);
            ModifyGroupControls(CBName, GBName);
            ModifyGroupControls(CBExt, GBExt);
        }

        #endregion

        #region Controls
        private void BTRename_Click(object sender, EventArgs e) {

            Random rnd = new Random();

            LVFiles.Items.Add(new ListViewItem(new[] {rnd.Next(100).ToString(), rnd.Next(100).ToString(), rnd.Next(100).ToString(), rnd.Next(100).ToString()}));
            LVFiles.Items.Add(new ListViewItem(new[] { rnd.Next(100).ToString(), rnd.Next(100).ToString(), rnd.Next(100).ToString(), rnd.Next(100).ToString() }));
            LVFiles.Items.Add(new ListViewItem(new[] { rnd.Next(100).ToString(), rnd.Next(100).ToString(), rnd.Next(100).ToString(), rnd.Next(100).ToString() }));

            Rename r = new Rename();

            foreach(ListViewItem x in LVFiles.Items) {

            }


           // r.GetFiles(LVFiles.Items);

            //LVFiles.Items.AddRange()
        }


        #region Even onchange checkbox controls
        private void CBRename_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBRename, GBRename);
        }

        private void CBRemove_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBRemove, GBRemove);
        }

        private void CBAdd_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBAdd, GBAdd);
        }

        private void CBName_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBName, GBName);
        }

        private void CBExt_CheckedChanged(object sender, EventArgs e) {
            ModifyGroupControls(CBExt, GBExt);
        }
        #endregion
        #endregion

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

        private void LVFiles_SelectedIndexChanged(object sender, EventArgs e) {
            GetAllItems();
        }

        private void GetAllSelectedItems() {
            if (LVFiles.SelectedItems.Count > 0) {
                for (int c = 0; c < LVFiles.SelectedItems.Count; c++) {
                    for (int i = 0; i < LVFiles.SelectedItems[c].SubItems.Count; i++) {
                        Console.WriteLine(LVFiles.SelectedItems[c].SubItems[i].Text);
                    }
                }
            }
        }

        private void GetAllItems() {
            if (LVFiles.Items.Count > 0) {
                for (int c = 0; c < LVFiles.Items.Count; c++) {
                    for (int i = 0; i < LVFiles.Items[c].SubItems.Count; i++) {
                        Console.WriteLine(LVFiles.Items[c].SubItems[i].Text);
                    }
                }
            }
        }

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

            foreach (ListViewItem lvItem in LVFiles.SelectedItems) {
                LVFiles.Items.Remove(lvItem);
            }
        }

        /// <summary>
        /// Get and process droped files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LVFiles_DragDrop(object sender, DragEventArgs e) {

            // Check if the data dropped is one or more files
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {

                // Get the file pathes from the data object
                string[] filePaths = (e.Data.GetData(DataFormats.FileDrop) as string[]);

                foreach(string f in filePaths) {
                    Console.WriteLine(f);
                }

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
    }
}
