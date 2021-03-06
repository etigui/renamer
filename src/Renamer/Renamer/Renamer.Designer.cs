﻿namespace Renamer {
    partial class Renamer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renamer));
            this.GBReplace = new System.Windows.Forms.GroupBox();
            this.TBReplaceWith = new System.Windows.Forms.TextBox();
            this.TBReplaceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBReplace = new System.Windows.Forms.CheckBox();
            this.GBRemove = new System.Windows.Forms.GroupBox();
            this.NUDRemoveTo = new System.Windows.Forms.NumericUpDown();
            this.NUDRemoveFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDRemoveLast = new System.Windows.Forms.NumericUpDown();
            this.NUDRemoveFirst = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBRemove = new System.Windows.Forms.CheckBox();
            this.GBAdd = new System.Windows.Forms.GroupBox();
            this.NUDAddAt = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.TBAddInsert = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBAddSufix = new System.Windows.Forms.TextBox();
            this.TBAddPrefix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBAdd = new System.Windows.Forms.CheckBox();
            this.GBName = new System.Windows.Forms.GroupBox();
            this.CBNameAction = new System.Windows.Forms.ComboBox();
            this.TBNameRename = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CBName = new System.Windows.Forms.CheckBox();
            this.GBExt = new System.Windows.Forms.GroupBox();
            this.CBExtAction = new System.Windows.Forms.ComboBox();
            this.TBExtRename = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CBExt = new System.Windows.Forms.CheckBox();
            this.SSMessage = new System.Windows.Forms.StatusStrip();
            this.TSSLMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.MSMenu = new System.Windows.Forms.MenuStrip();
            this.TSMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.LVFiles = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTRename = new System.Windows.Forms.Button();
            this.BTClear = new System.Windows.Forms.Button();
            this.BW = new System.ComponentModel.BackgroundWorker();
            this.GBReplace.SuspendLayout();
            this.GBRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemoveTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemoveFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemoveLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemoveFirst)).BeginInit();
            this.GBAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAddAt)).BeginInit();
            this.GBName.SuspendLayout();
            this.GBExt.SuspendLayout();
            this.SSMessage.SuspendLayout();
            this.MSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBReplace
            // 
            this.GBReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GBReplace.Controls.Add(this.TBReplaceWith);
            this.GBReplace.Controls.Add(this.TBReplaceName);
            this.GBReplace.Controls.Add(this.label2);
            this.GBReplace.Controls.Add(this.label1);
            this.GBReplace.Controls.Add(this.CBReplace);
            this.GBReplace.Location = new System.Drawing.Point(12, 726);
            this.GBReplace.Name = "GBReplace";
            this.GBReplace.Size = new System.Drawing.Size(181, 115);
            this.GBReplace.TabIndex = 0;
            this.GBReplace.TabStop = false;
            // 
            // TBReplaceWith
            // 
            this.TBReplaceWith.Location = new System.Drawing.Point(68, 69);
            this.TBReplaceWith.Name = "TBReplaceWith";
            this.TBReplaceWith.Size = new System.Drawing.Size(100, 20);
            this.TBReplaceWith.TabIndex = 4;
            this.TBReplaceWith.TextChanged += new System.EventHandler(this.TBReplaceWith_TextChanged);
            this.TBReplaceWith.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBReplaceWith_KeyPress);
            // 
            // TBReplaceName
            // 
            this.TBReplaceName.Location = new System.Drawing.Point(68, 39);
            this.TBReplaceName.Name = "TBReplaceName";
            this.TBReplaceName.Size = new System.Drawing.Size(100, 20);
            this.TBReplaceName.TabIndex = 3;
            this.TBReplaceName.TextChanged += new System.EventHandler(this.TBReplaceName_TextChanged);
            this.TBReplaceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBReplaceName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "With:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Replace:";
            // 
            // CBReplace
            // 
            this.CBReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBReplace.AutoSize = true;
            this.CBReplace.Location = new System.Drawing.Point(6, 0);
            this.CBReplace.Name = "CBReplace";
            this.CBReplace.Size = new System.Drawing.Size(101, 17);
            this.CBReplace.TabIndex = 1;
            this.CBReplace.Text = "Replace (name)";
            this.CBReplace.UseVisualStyleBackColor = true;
            this.CBReplace.CheckedChanged += new System.EventHandler(this.CBReplace_CheckedChanged);
            // 
            // GBRemove
            // 
            this.GBRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GBRemove.Controls.Add(this.NUDRemoveTo);
            this.GBRemove.Controls.Add(this.NUDRemoveFrom);
            this.GBRemove.Controls.Add(this.label5);
            this.GBRemove.Controls.Add(this.label6);
            this.GBRemove.Controls.Add(this.NUDRemoveLast);
            this.GBRemove.Controls.Add(this.NUDRemoveFirst);
            this.GBRemove.Controls.Add(this.label3);
            this.GBRemove.Controls.Add(this.label4);
            this.GBRemove.Controls.Add(this.CBRemove);
            this.GBRemove.Location = new System.Drawing.Point(199, 726);
            this.GBRemove.Name = "GBRemove";
            this.GBRemove.Size = new System.Drawing.Size(217, 115);
            this.GBRemove.TabIndex = 5;
            this.GBRemove.TabStop = false;
            // 
            // NUDRemoveTo
            // 
            this.NUDRemoveTo.Location = new System.Drawing.Point(168, 71);
            this.NUDRemoveTo.Name = "NUDRemoveTo";
            this.NUDRemoveTo.Size = new System.Drawing.Size(39, 20);
            this.NUDRemoveTo.TabIndex = 11;
            this.NUDRemoveTo.ValueChanged += new System.EventHandler(this.NUDRemoveTo_ValueChanged);
            // 
            // NUDRemoveFrom
            // 
            this.NUDRemoveFrom.Location = new System.Drawing.Point(65, 70);
            this.NUDRemoveFrom.Name = "NUDRemoveFrom";
            this.NUDRemoveFrom.Size = new System.Drawing.Size(39, 20);
            this.NUDRemoveFrom.TabIndex = 10;
            this.NUDRemoveFrom.ValueChanged += new System.EventHandler(this.NUDRemoveFrom_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "From:";
            // 
            // NUDRemoveLast
            // 
            this.NUDRemoveLast.Location = new System.Drawing.Point(168, 38);
            this.NUDRemoveLast.Name = "NUDRemoveLast";
            this.NUDRemoveLast.Size = new System.Drawing.Size(39, 20);
            this.NUDRemoveLast.TabIndex = 7;
            this.NUDRemoveLast.ValueChanged += new System.EventHandler(this.NUDRemoveLast_ValueChanged);
            // 
            // NUDRemoveFirst
            // 
            this.NUDRemoveFirst.Location = new System.Drawing.Point(65, 37);
            this.NUDRemoveFirst.Name = "NUDRemoveFirst";
            this.NUDRemoveFirst.Size = new System.Drawing.Size(39, 20);
            this.NUDRemoveFirst.TabIndex = 6;
            this.NUDRemoveFirst.ValueChanged += new System.EventHandler(this.NUDRemoveFirst_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "From last:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "From first:";
            // 
            // CBRemove
            // 
            this.CBRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBRemove.AutoSize = true;
            this.CBRemove.Location = new System.Drawing.Point(6, 0);
            this.CBRemove.Name = "CBRemove";
            this.CBRemove.Size = new System.Drawing.Size(101, 17);
            this.CBRemove.TabIndex = 1;
            this.CBRemove.Text = "Remove (name)";
            this.CBRemove.UseVisualStyleBackColor = true;
            this.CBRemove.CheckedChanged += new System.EventHandler(this.CBRemove_CheckedChanged);
            // 
            // GBAdd
            // 
            this.GBAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GBAdd.Controls.Add(this.NUDAddAt);
            this.GBAdd.Controls.Add(this.label12);
            this.GBAdd.Controls.Add(this.TBAddInsert);
            this.GBAdd.Controls.Add(this.label9);
            this.GBAdd.Controls.Add(this.TBAddSufix);
            this.GBAdd.Controls.Add(this.TBAddPrefix);
            this.GBAdd.Controls.Add(this.label7);
            this.GBAdd.Controls.Add(this.label8);
            this.GBAdd.Controls.Add(this.CBAdd);
            this.GBAdd.Location = new System.Drawing.Point(422, 726);
            this.GBAdd.Name = "GBAdd";
            this.GBAdd.Size = new System.Drawing.Size(233, 115);
            this.GBAdd.TabIndex = 12;
            this.GBAdd.TabStop = false;
            // 
            // NUDAddAt
            // 
            this.NUDAddAt.Location = new System.Drawing.Point(180, 77);
            this.NUDAddAt.Name = "NUDAddAt";
            this.NUDAddAt.Size = new System.Drawing.Size(39, 20);
            this.NUDAddAt.TabIndex = 13;
            this.NUDAddAt.ValueChanged += new System.EventHandler(this.NUDAddAt_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "At:";
            // 
            // TBAddInsert
            // 
            this.TBAddInsert.Location = new System.Drawing.Point(48, 77);
            this.TBAddInsert.Name = "TBAddInsert";
            this.TBAddInsert.Size = new System.Drawing.Size(100, 20);
            this.TBAddInsert.TabIndex = 10;
            this.TBAddInsert.TextChanged += new System.EventHandler(this.TBAddInsert_TextChanged);
            this.TBAddInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAddInsert_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Insert:";
            // 
            // TBAddSufix
            // 
            this.TBAddSufix.Location = new System.Drawing.Point(48, 51);
            this.TBAddSufix.Name = "TBAddSufix";
            this.TBAddSufix.Size = new System.Drawing.Size(100, 20);
            this.TBAddSufix.TabIndex = 8;
            this.TBAddSufix.TextChanged += new System.EventHandler(this.TBAddSufix_TextChanged);
            this.TBAddSufix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAddSufix_KeyPress);
            // 
            // TBAddPrefix
            // 
            this.TBAddPrefix.Location = new System.Drawing.Point(48, 25);
            this.TBAddPrefix.Name = "TBAddPrefix";
            this.TBAddPrefix.Size = new System.Drawing.Size(100, 20);
            this.TBAddPrefix.TabIndex = 7;
            this.TBAddPrefix.TextChanged += new System.EventHandler(this.TBAddPrefix_TextChanged);
            this.TBAddPrefix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAddPrefix_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sufix:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Prefix:";
            // 
            // CBAdd
            // 
            this.CBAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBAdd.AutoSize = true;
            this.CBAdd.Location = new System.Drawing.Point(6, 0);
            this.CBAdd.Name = "CBAdd";
            this.CBAdd.Size = new System.Drawing.Size(80, 17);
            this.CBAdd.TabIndex = 1;
            this.CBAdd.Text = "Add (name)";
            this.CBAdd.UseVisualStyleBackColor = true;
            this.CBAdd.CheckedChanged += new System.EventHandler(this.CBAdd_CheckedChanged);
            // 
            // GBName
            // 
            this.GBName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GBName.Controls.Add(this.CBNameAction);
            this.GBName.Controls.Add(this.TBNameRename);
            this.GBName.Controls.Add(this.label10);
            this.GBName.Controls.Add(this.CBName);
            this.GBName.Location = new System.Drawing.Point(661, 726);
            this.GBName.Name = "GBName";
            this.GBName.Size = new System.Drawing.Size(181, 115);
            this.GBName.TabIndex = 5;
            this.GBName.TabStop = false;
            this.GBName.Text = "z";
            // 
            // CBNameAction
            // 
            this.CBNameAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNameAction.FormattingEnabled = true;
            this.CBNameAction.Items.AddRange(new object[] {
            "Remove",
            "Rename",
            "Reverse",
            "First to upper",
            "First to lower",
            "To upper",
            "To lower"});
            this.CBNameAction.Location = new System.Drawing.Point(15, 40);
            this.CBNameAction.Name = "CBNameAction";
            this.CBNameAction.Size = new System.Drawing.Size(153, 21);
            this.CBNameAction.TabIndex = 13;
            this.CBNameAction.SelectedIndexChanged += new System.EventHandler(this.CBNameAction_SelectedIndexChanged);
            // 
            // TBNameRename
            // 
            this.TBNameRename.Location = new System.Drawing.Point(68, 67);
            this.TBNameRename.Name = "TBNameRename";
            this.TBNameRename.Size = new System.Drawing.Size(100, 20);
            this.TBNameRename.TabIndex = 4;
            this.TBNameRename.TextChanged += new System.EventHandler(this.TBNameRename_TextChanged);
            this.TBNameRename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNameRename_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Rename:";
            // 
            // CBName
            // 
            this.CBName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBName.AutoSize = true;
            this.CBName.Location = new System.Drawing.Point(6, 0);
            this.CBName.Name = "CBName";
            this.CBName.Size = new System.Drawing.Size(54, 17);
            this.CBName.TabIndex = 1;
            this.CBName.Text = "Name";
            this.CBName.UseVisualStyleBackColor = true;
            this.CBName.CheckedChanged += new System.EventHandler(this.CBName_CheckedChanged);
            // 
            // GBExt
            // 
            this.GBExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GBExt.Controls.Add(this.CBExtAction);
            this.GBExt.Controls.Add(this.TBExtRename);
            this.GBExt.Controls.Add(this.label11);
            this.GBExt.Controls.Add(this.CBExt);
            this.GBExt.Location = new System.Drawing.Point(848, 726);
            this.GBExt.Name = "GBExt";
            this.GBExt.Size = new System.Drawing.Size(181, 115);
            this.GBExt.TabIndex = 14;
            this.GBExt.TabStop = false;
            // 
            // CBExtAction
            // 
            this.CBExtAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBExtAction.FormattingEnabled = true;
            this.CBExtAction.Items.AddRange(new object[] {
            "Remove",
            "Rename",
            "To upper",
            "To lower"});
            this.CBExtAction.Location = new System.Drawing.Point(15, 40);
            this.CBExtAction.Name = "CBExtAction";
            this.CBExtAction.Size = new System.Drawing.Size(153, 21);
            this.CBExtAction.TabIndex = 13;
            this.CBExtAction.SelectedIndexChanged += new System.EventHandler(this.CBExtAction_SelectedIndexChanged);
            // 
            // TBExtRename
            // 
            this.TBExtRename.Location = new System.Drawing.Point(68, 67);
            this.TBExtRename.Name = "TBExtRename";
            this.TBExtRename.Size = new System.Drawing.Size(100, 20);
            this.TBExtRename.TabIndex = 4;
            this.TBExtRename.TextChanged += new System.EventHandler(this.TBExtRename_TextChanged);
            this.TBExtRename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBExtRename_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Rename:";
            // 
            // CBExt
            // 
            this.CBExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBExt.AutoSize = true;
            this.CBExt.Location = new System.Drawing.Point(6, 0);
            this.CBExt.Name = "CBExt";
            this.CBExt.Size = new System.Drawing.Size(72, 17);
            this.CBExt.TabIndex = 1;
            this.CBExt.Text = "Extension";
            this.CBExt.UseVisualStyleBackColor = true;
            this.CBExt.CheckedChanged += new System.EventHandler(this.CBExt_CheckedChanged);
            // 
            // SSMessage
            // 
            this.SSMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLMessage});
            this.SSMessage.Location = new System.Drawing.Point(0, 853);
            this.SSMessage.Name = "SSMessage";
            this.SSMessage.Size = new System.Drawing.Size(1118, 22);
            this.SSMessage.TabIndex = 15;
            this.SSMessage.Text = "statusStrip1";
            // 
            // TSSLMessage
            // 
            this.TSSLMessage.Name = "TSSLMessage";
            this.TSSLMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // MSMenu
            // 
            this.MSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIFile});
            this.MSMenu.Location = new System.Drawing.Point(0, 0);
            this.MSMenu.Name = "MSMenu";
            this.MSMenu.Size = new System.Drawing.Size(1118, 24);
            this.MSMenu.TabIndex = 16;
            this.MSMenu.Text = "menuStrip1";
            // 
            // TSMIFile
            // 
            this.TSMIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAdd,
            this.TSMIQuit});
            this.TSMIFile.Name = "TSMIFile";
            this.TSMIFile.Size = new System.Drawing.Size(37, 20);
            this.TSMIFile.Text = "&File";
            // 
            // TSMIAdd
            // 
            this.TSMIAdd.Name = "TSMIAdd";
            this.TSMIAdd.Size = new System.Drawing.Size(180, 22);
            this.TSMIAdd.Text = "Add files";
            this.TSMIAdd.Click += new System.EventHandler(this.TSMIAdd_Click);
            // 
            // TSMIQuit
            // 
            this.TSMIQuit.Name = "TSMIQuit";
            this.TSMIQuit.Size = new System.Drawing.Size(180, 22);
            this.TSMIQuit.Text = "Quit";
            this.TSMIQuit.Click += new System.EventHandler(this.TSMIQuit_Click);
            // 
            // LVFiles
            // 
            this.LVFiles.AllowDrop = true;
            this.LVFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.LVFiles.FullRowSelect = true;
            this.LVFiles.GridLines = true;
            this.LVFiles.Location = new System.Drawing.Point(0, 27);
            this.LVFiles.Name = "LVFiles";
            this.LVFiles.Size = new System.Drawing.Size(1118, 693);
            this.LVFiles.TabIndex = 17;
            this.LVFiles.UseCompatibleStateImageBehavior = false;
            this.LVFiles.View = System.Windows.Forms.View.Details;
            this.LVFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.LVFiles_DragDrop);
            this.LVFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.LVFiles_DragEnter);
            this.LVFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LVFiles_KeyDown);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Path";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ext.";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "New name";
            this.columnHeader3.Width = 350;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "New ext.";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Created time";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Accessed time";
            this.columnHeader8.Width = 115;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Modified time";
            this.columnHeader9.Width = 115;
            // 
            // BTRename
            // 
            this.BTRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTRename.Enabled = false;
            this.BTRename.Location = new System.Drawing.Point(1035, 736);
            this.BTRename.Name = "BTRename";
            this.BTRename.Size = new System.Drawing.Size(75, 46);
            this.BTRename.TabIndex = 18;
            this.BTRename.Text = "&Rename";
            this.BTRename.UseVisualStyleBackColor = true;
            this.BTRename.Click += new System.EventHandler(this.BTRename_Click);
            // 
            // BTClear
            // 
            this.BTClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTClear.Enabled = false;
            this.BTClear.Location = new System.Drawing.Point(1035, 788);
            this.BTClear.Name = "BTClear";
            this.BTClear.Size = new System.Drawing.Size(75, 46);
            this.BTClear.TabIndex = 19;
            this.BTClear.Text = "Clear";
            this.BTClear.UseVisualStyleBackColor = true;
            this.BTClear.Click += new System.EventHandler(this.BTClear_Click);
            // 
            // BW
            // 
            this.BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_DoWork);
            this.BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_RunWorkerCompleted);
            // 
            // Renamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 875);
            this.Controls.Add(this.BTClear);
            this.Controls.Add(this.BTRename);
            this.Controls.Add(this.LVFiles);
            this.Controls.Add(this.SSMessage);
            this.Controls.Add(this.MSMenu);
            this.Controls.Add(this.GBExt);
            this.Controls.Add(this.GBName);
            this.Controls.Add(this.GBAdd);
            this.Controls.Add(this.GBRemove);
            this.Controls.Add(this.GBReplace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MSMenu;
            this.MinimumSize = new System.Drawing.Size(1134, 913);
            this.Name = "Renamer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Renamer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBReplace.ResumeLayout(false);
            this.GBReplace.PerformLayout();
            this.GBRemove.ResumeLayout(false);
            this.GBRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemoveTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemoveFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemoveLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRemoveFirst)).EndInit();
            this.GBAdd.ResumeLayout(false);
            this.GBAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAddAt)).EndInit();
            this.GBName.ResumeLayout(false);
            this.GBName.PerformLayout();
            this.GBExt.ResumeLayout(false);
            this.GBExt.PerformLayout();
            this.SSMessage.ResumeLayout(false);
            this.SSMessage.PerformLayout();
            this.MSMenu.ResumeLayout(false);
            this.MSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBReplace;
        private System.Windows.Forms.CheckBox CBReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBReplaceWith;
        private System.Windows.Forms.TextBox TBReplaceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CBRemove;
        private System.Windows.Forms.NumericUpDown NUDRemoveTo;
        private System.Windows.Forms.NumericUpDown NUDRemoveFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUDRemoveLast;
        private System.Windows.Forms.NumericUpDown NUDRemoveFirst;
        private System.Windows.Forms.GroupBox GBAdd;
        private System.Windows.Forms.CheckBox CBAdd;
        private System.Windows.Forms.TextBox TBAddInsert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBAddSufix;
        private System.Windows.Forms.TextBox TBAddPrefix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GBName;
        private System.Windows.Forms.ComboBox CBNameAction;
        private System.Windows.Forms.TextBox TBNameRename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox CBName;
        private System.Windows.Forms.GroupBox GBExt;
        private System.Windows.Forms.ComboBox CBExtAction;
        private System.Windows.Forms.TextBox TBExtRename;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CBExt;
        private System.Windows.Forms.NumericUpDown NUDAddAt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.StatusStrip SSMessage;
        private System.Windows.Forms.ToolStripStatusLabel TSSLMessage;
        private System.Windows.Forms.MenuStrip MSMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMIFile;
        private System.Windows.Forms.ListView LVFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button BTRename;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripMenuItem TSMIQuit;
        private System.Windows.Forms.ToolStripMenuItem TSMIAdd;
        private System.Windows.Forms.Button BTClear;
        private System.ComponentModel.BackgroundWorker BW;
    }
}

