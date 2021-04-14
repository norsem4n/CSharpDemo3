namespace CKarnasProgram3
{
    partial class Program3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program3));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.grpShowHide = new System.Windows.Forms.GroupBox();
            this.ckBoxDeveloper = new System.Windows.Forms.CheckBox();
            this.ckBoxLogo = new System.Windows.Forms.CheckBox();
            this.ckBoxTagline = new System.Windows.Forms.CheckBox();
            this.ckBoxName = new System.Windows.Forms.CheckBox();
            this.grpPickColor = new System.Windows.Forms.GroupBox();
            this.rBtnPurple = new System.Windows.Forms.RadioButton();
            this.rBtnYellow = new System.Windows.Forms.RadioButton();
            this.rBtnGreen = new System.Windows.Forms.RadioButton();
            this.rBtnBlue = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpShowHide.SuspendLayout();
            this.grpPickColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(670, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(12, 394);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(124, 16);
            this.lblDeveloper.TabIndex = 1;
            this.lblDeveloper.Text = "Developed by CGK";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.ForeColor = System.Drawing.Color.Navy;
            this.lblBusinessName.Location = new System.Drawing.Point(37, 40);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(421, 41);
            this.lblBusinessName.TabIndex = 2;
            this.lblBusinessName.Text = "NYT Podcast The Daily";
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.Location = new System.Drawing.Point(464, 61);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(227, 20);
            this.lblTagline.TabIndex = 3;
            this.lblTagline.Text = "Streaming Every Weekday";
            // 
            // grpShowHide
            // 
            this.grpShowHide.Controls.Add(this.ckBoxDeveloper);
            this.grpShowHide.Controls.Add(this.ckBoxLogo);
            this.grpShowHide.Controls.Add(this.ckBoxTagline);
            this.grpShowHide.Controls.Add(this.ckBoxName);
            this.grpShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShowHide.Location = new System.Drawing.Point(574, 112);
            this.grpShowHide.Name = "grpShowHide";
            this.grpShowHide.Size = new System.Drawing.Size(191, 222);
            this.grpShowHide.TabIndex = 4;
            this.grpShowHide.TabStop = false;
            this.grpShowHide.Text = "Show/Hide";
            // 
            // ckBoxDeveloper
            // 
            this.ckBoxDeveloper.AutoSize = true;
            this.ckBoxDeveloper.Checked = true;
            this.ckBoxDeveloper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxDeveloper.Location = new System.Drawing.Point(28, 174);
            this.ckBoxDeveloper.Name = "ckBoxDeveloper";
            this.ckBoxDeveloper.Size = new System.Drawing.Size(116, 28);
            this.ckBoxDeveloper.TabIndex = 3;
            this.ckBoxDeveloper.Text = "&Developer";
            this.ckBoxDeveloper.UseVisualStyleBackColor = true;
            this.ckBoxDeveloper.CheckedChanged += new System.EventHandler(this.ckBoxDeveloper_CheckedChanged);
            // 
            // ckBoxLogo
            // 
            this.ckBoxLogo.AutoSize = true;
            this.ckBoxLogo.Checked = true;
            this.ckBoxLogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxLogo.Location = new System.Drawing.Point(28, 128);
            this.ckBoxLogo.Name = "ckBoxLogo";
            this.ckBoxLogo.Size = new System.Drawing.Size(72, 28);
            this.ckBoxLogo.TabIndex = 2;
            this.ckBoxLogo.Text = "&Logo";
            this.ckBoxLogo.UseVisualStyleBackColor = true;
            this.ckBoxLogo.CheckedChanged += new System.EventHandler(this.ckBoxLogo_CheckedChanged);
            // 
            // ckBoxTagline
            // 
            this.ckBoxTagline.AutoSize = true;
            this.ckBoxTagline.Checked = true;
            this.ckBoxTagline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxTagline.Location = new System.Drawing.Point(28, 84);
            this.ckBoxTagline.Name = "ckBoxTagline";
            this.ckBoxTagline.Size = new System.Drawing.Size(92, 28);
            this.ckBoxTagline.TabIndex = 1;
            this.ckBoxTagline.Text = "&Tagline";
            this.ckBoxTagline.UseVisualStyleBackColor = true;
            this.ckBoxTagline.CheckedChanged += new System.EventHandler(this.ckBoxTagline_CheckedChanged);
            // 
            // ckBoxName
            // 
            this.ckBoxName.AutoSize = true;
            this.ckBoxName.Checked = true;
            this.ckBoxName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxName.Location = new System.Drawing.Point(28, 40);
            this.ckBoxName.Name = "ckBoxName";
            this.ckBoxName.Size = new System.Drawing.Size(80, 28);
            this.ckBoxName.TabIndex = 0;
            this.ckBoxName.Text = "&Name";
            this.ckBoxName.UseVisualStyleBackColor = true;
            this.ckBoxName.CheckedChanged += new System.EventHandler(this.ckBoxName_CheckedChanged);
            // 
            // grpPickColor
            // 
            this.grpPickColor.Controls.Add(this.rBtnPurple);
            this.grpPickColor.Controls.Add(this.rBtnYellow);
            this.grpPickColor.Controls.Add(this.rBtnGreen);
            this.grpPickColor.Controls.Add(this.rBtnBlue);
            this.grpPickColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPickColor.Location = new System.Drawing.Point(44, 112);
            this.grpPickColor.Name = "grpPickColor";
            this.grpPickColor.Size = new System.Drawing.Size(191, 222);
            this.grpPickColor.TabIndex = 5;
            this.grpPickColor.TabStop = false;
            this.grpPickColor.Text = "Pick Color";
            // 
            // rBtnPurple
            // 
            this.rBtnPurple.AutoSize = true;
            this.rBtnPurple.Location = new System.Drawing.Point(18, 174);
            this.rBtnPurple.Name = "rBtnPurple";
            this.rBtnPurple.Size = new System.Drawing.Size(83, 28);
            this.rBtnPurple.TabIndex = 9;
            this.rBtnPurple.Text = "&Purple";
            this.rBtnPurple.UseVisualStyleBackColor = true;
            this.rBtnPurple.CheckedChanged += new System.EventHandler(this.rBtnPurple_CheckedChanged);
            // 
            // rBtnYellow
            // 
            this.rBtnYellow.AutoSize = true;
            this.rBtnYellow.Location = new System.Drawing.Point(18, 128);
            this.rBtnYellow.Name = "rBtnYellow";
            this.rBtnYellow.Size = new System.Drawing.Size(84, 28);
            this.rBtnYellow.TabIndex = 8;
            this.rBtnYellow.Text = "&Yellow";
            this.rBtnYellow.UseVisualStyleBackColor = true;
            this.rBtnYellow.CheckedChanged += new System.EventHandler(this.rBtnYellow_CheckedChanged);
            // 
            // rBtnGreen
            // 
            this.rBtnGreen.AutoSize = true;
            this.rBtnGreen.Location = new System.Drawing.Point(18, 84);
            this.rBtnGreen.Name = "rBtnGreen";
            this.rBtnGreen.Size = new System.Drawing.Size(81, 28);
            this.rBtnGreen.TabIndex = 7;
            this.rBtnGreen.Text = "&Green";
            this.rBtnGreen.UseVisualStyleBackColor = true;
            this.rBtnGreen.CheckedChanged += new System.EventHandler(this.rBtnGreen_CheckedChanged);
            // 
            // rBtnBlue
            // 
            this.rBtnBlue.AutoSize = true;
            this.rBtnBlue.Location = new System.Drawing.Point(18, 40);
            this.rBtnBlue.Name = "rBtnBlue";
            this.rBtnBlue.Size = new System.Drawing.Size(66, 28);
            this.rBtnBlue.TabIndex = 6;
            this.rBtnBlue.Text = "&Blue";
            this.rBtnBlue.UseVisualStyleBackColor = true;
            this.rBtnBlue.CheckedChanged += new System.EventHandler(this.rBtnBlue_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CKarnasProgram3.Properties.Resources.nyt1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 221);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "New York Times The Daily Podcast Logo");
            // 
            // Program3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpPickColor);
            this.Controls.Add(this.grpShowHide);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.btnExit);
            this.Name = "Program3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 2 - Program 3";
            this.grpShowHide.ResumeLayout(false);
            this.grpShowHide.PerformLayout();
            this.grpPickColor.ResumeLayout(false);
            this.grpPickColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.GroupBox grpShowHide;
        private System.Windows.Forms.CheckBox ckBoxDeveloper;
        private System.Windows.Forms.CheckBox ckBoxLogo;
        private System.Windows.Forms.CheckBox ckBoxTagline;
        private System.Windows.Forms.CheckBox ckBoxName;
        private System.Windows.Forms.GroupBox grpPickColor;
        private System.Windows.Forms.RadioButton rBtnPurple;
        private System.Windows.Forms.RadioButton rBtnYellow;
        private System.Windows.Forms.RadioButton rBtnGreen;
        private System.Windows.Forms.RadioButton rBtnBlue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

