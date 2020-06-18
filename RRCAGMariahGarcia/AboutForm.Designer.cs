namespace RRCAGMariahGarcia
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblAboutSystem = new System.Windows.Forms.Label();
            this.lblAboutVersion = new System.Windows.Forms.Label();
            this.lblAboutCopyright = new System.Windows.Forms.Label();
            this.lblAboutAuthor = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.vsbAboutDescription = new System.Windows.Forms.VScrollBar();
            this.btnAboutOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAboutSystem
            // 
            this.lblAboutSystem.AutoSize = true;
            this.lblAboutSystem.Enabled = false;
            this.lblAboutSystem.Location = new System.Drawing.Point(208, 12);
            this.lblAboutSystem.Name = "lblAboutSystem";
            this.lblAboutSystem.Size = new System.Drawing.Size(162, 13);
            this.lblAboutSystem.TabIndex = 0;
            this.lblAboutSystem.Text = "Automotive Management System";
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.AutoSize = true;
            this.lblAboutVersion.Enabled = false;
            this.lblAboutVersion.Location = new System.Drawing.Point(208, 43);
            this.lblAboutVersion.Name = "lblAboutVersion";
            this.lblAboutVersion.Size = new System.Drawing.Size(78, 13);
            this.lblAboutVersion.TabIndex = 1;
            this.lblAboutVersion.Text = "Version 1.0.0.0";
            // 
            // lblAboutCopyright
            // 
            this.lblAboutCopyright.AutoSize = true;
            this.lblAboutCopyright.Enabled = false;
            this.lblAboutCopyright.Location = new System.Drawing.Point(208, 77);
            this.lblAboutCopyright.Name = "lblAboutCopyright";
            this.lblAboutCopyright.Size = new System.Drawing.Size(90, 13);
            this.lblAboutCopyright.TabIndex = 2;
            this.lblAboutCopyright.Text = "Copyright © 2017";
            // 
            // lblAboutAuthor
            // 
            this.lblAboutAuthor.AutoSize = true;
            this.lblAboutAuthor.Enabled = false;
            this.lblAboutAuthor.Location = new System.Drawing.Point(208, 117);
            this.lblAboutAuthor.Name = "lblAboutAuthor";
            this.lblAboutAuthor.Size = new System.Drawing.Size(73, 13);
            this.lblAboutAuthor.TabIndex = 3;
            this.lblAboutAuthor.Text = "Mariah Garcia";
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.BackgroundImage")));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLogo.Enabled = false;
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(173, 343);
            this.imgLogo.TabIndex = 6;
            this.imgLogo.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(211, 147);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 169);
            this.txtDescription.TabIndex = 0;
            // 
            // vsbAboutDescription
            // 
            this.vsbAboutDescription.Location = new System.Drawing.Point(489, 148);
            this.vsbAboutDescription.Name = "vsbAboutDescription";
            this.vsbAboutDescription.Size = new System.Drawing.Size(18, 168);
            this.vsbAboutDescription.TabIndex = 8;
            // 
            // btnAboutOk
            // 
            this.btnAboutOk.Location = new System.Drawing.Point(427, 330);
            this.btnAboutOk.Name = "btnAboutOk";
            this.btnAboutOk.Size = new System.Drawing.Size(80, 25);
            this.btnAboutOk.TabIndex = 1;
            this.btnAboutOk.Text = "&OK";
            this.btnAboutOk.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 379);
            this.Controls.Add(this.btnAboutOk);
            this.Controls.Add(this.vsbAboutDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblAboutAuthor);
            this.Controls.Add(this.lblAboutCopyright);
            this.Controls.Add(this.lblAboutVersion);
            this.Controls.Add(this.lblAboutSystem);
            this.Name = "AboutForm";
            this.Text = "About RRC Automotive Form Group";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutSystem;
        private System.Windows.Forms.Label lblAboutVersion;
        private System.Windows.Forms.Label lblAboutCopyright;
        private System.Windows.Forms.Label lblAboutAuthor;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.VScrollBar vsbAboutDescription;
        private System.Windows.Forms.Button btnAboutOk;
    }
}