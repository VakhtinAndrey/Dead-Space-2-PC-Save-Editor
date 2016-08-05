namespace DeadSpace2SaveEditor
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblThanks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.llEmail = new System.Windows.Forms.LinkLabel();
            this.llGitHub = new System.Windows.Forms.LinkLabel();
            this.lblCopyright2 = new System.Windows.Forms.Label();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(244, 425);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAppName.Location = new System.Drawing.Point(32, 113);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(267, 22);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Dead Space 2 PC Save Editor";
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersion.Location = new System.Drawing.Point(143, 135);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(156, 23);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version: {ver}";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(12, 169);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(307, 2);
            this.lblLine.TabIndex = 3;
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.lblThanks.Location = new System.Drawing.Point(13, 183);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(304, 85);
            this.lblThanks.TabIndex = 4;
            this.lblThanks.Text = "         ~ Special Thanks ~\r\n\r\n • To Adam Spindler aka Experiment5X \r\n   for EA\'s" +
    " MC02 algorithm\r\n • To my lovely girlfriend";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 2);
            this.label3.TabIndex = 5;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCopyright.Location = new System.Drawing.Point(89, 303);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(152, 16);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "Vakhtin Andrey © 2016";
            // 
            // llEmail
            // 
            this.llEmail.AutoSize = true;
            this.llEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llEmail.Location = new System.Drawing.Point(85, 332);
            this.llEmail.Name = "llEmail";
            this.llEmail.Size = new System.Drawing.Size(160, 15);
            this.llEmail.TabIndex = 8;
            this.llEmail.TabStop = true;
            this.llEmail.Text = "smile.voronezh@gmail.com";
            this.llEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEmail_LinkClicked);
            // 
            // llGitHub
            // 
            this.llGitHub.AutoSize = true;
            this.llGitHub.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llGitHub.Location = new System.Drawing.Point(74, 356);
            this.llGitHub.Name = "llGitHub";
            this.llGitHub.Size = new System.Drawing.Size(183, 15);
            this.llGitHub.TabIndex = 9;
            this.llGitHub.TabStop = true;
            this.llGitHub.Text = "https://github.com/VakhtinAndrey";
            this.llGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGitHub_LinkClicked);
            // 
            // lblCopyright2
            // 
            this.lblCopyright2.AutoSize = true;
            this.lblCopyright2.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCopyright2.Location = new System.Drawing.Point(11, 395);
            this.lblCopyright2.Name = "lblCopyright2";
            this.lblCopyright2.Size = new System.Drawing.Size(308, 15);
            this.lblCopyright2.TabIndex = 10;
            this.lblCopyright2.Text = "All rights for Dead Space 2 belong to Electronic Arts Inc.";
            // 
            // pbBanner
            // 
            this.pbBanner.BackColor = System.Drawing.Color.Black;
            this.pbBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbBanner.Image = global::DeadSpace2SaveEditor.Properties.Resources.DS2Banner;
            this.pbBanner.Location = new System.Drawing.Point(12, 12);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(307, 83);
            this.pbBanner.TabIndex = 11;
            this.pbBanner.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(331, 465);
            this.ControlBox = false;
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.lblCopyright2);
            this.Controls.Add(this.llGitHub);
            this.Controls.Add(this.llEmail);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.LinkLabel llEmail;
        private System.Windows.Forms.LinkLabel llGitHub;
        private System.Windows.Forms.Label lblCopyright2;
        private System.Windows.Forms.PictureBox pbBanner;
    }
}