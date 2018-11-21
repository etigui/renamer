namespace Renamer {
    partial class Timestamps {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timestamps));
            this.r = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTOk = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            this.SuspendLayout();
            // 
            // r
            // 
            this.r.ContainerControl = this;
            // 
            // BTOk
            // 
            this.BTOk.Location = new System.Drawing.Point(61, 241);
            this.BTOk.Name = "BTOk";
            this.BTOk.Size = new System.Drawing.Size(75, 23);
            this.BTOk.TabIndex = 4;
            this.BTOk.Text = "OK";
            this.BTOk.UseVisualStyleBackColor = true;
            this.BTOk.Click += new System.EventHandler(this.BTOk_Click);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(142, 241);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(75, 23);
            this.BTCancel.TabIndex = 5;
            this.BTCancel.Text = "Cancel";
            this.BTCancel.UseVisualStyleBackColor = true;
            // 
            // Timestamps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 276);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timestamps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timestamps";
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider r;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.Button BTOk;
    }
}