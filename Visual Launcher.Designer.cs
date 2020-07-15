namespace VSCLauncher_GUI
{
    partial class Visual_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visual_Launcher));
            this.ProjectTextBox = new System.Windows.Forms.RichTextBox();
            this.ProjectBtn = new System.Windows.Forms.Button();
            this.ModeBox = new System.Windows.Forms.ComboBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CurrentFolder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.DetectUrls = false;
            this.ProjectTextBox.Location = new System.Drawing.Point(292, 12);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.Size = new System.Drawing.Size(239, 37);
            this.ProjectTextBox.TabIndex = 0;
            this.ProjectTextBox.Text = "Project Name";
            // 
            // ProjectBtn
            // 
            this.ProjectBtn.Location = new System.Drawing.Point(292, 64);
            this.ProjectBtn.Name = "ProjectBtn";
            this.ProjectBtn.Size = new System.Drawing.Size(239, 41);
            this.ProjectBtn.TabIndex = 1;
            this.ProjectBtn.Text = "Select Project Folder";
            this.ProjectBtn.UseVisualStyleBackColor = true;
            this.ProjectBtn.Click += new System.EventHandler(this.ProjectBtn_Click);
            // 
            // ModeBox
            // 
            this.ModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeBox.FormattingEnabled = true;
            this.ModeBox.Items.AddRange(new object[] {
            "NodeJS",
            "C#",
            "C++",
            "Python"});
            this.ModeBox.Location = new System.Drawing.Point(292, 122);
            this.ModeBox.Name = "ModeBox";
            this.ModeBox.Size = new System.Drawing.Size(239, 28);
            this.ModeBox.TabIndex = 2;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(292, 173);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(239, 41);
            this.CreateBtn.TabIndex = 3;
            this.CreateBtn.Text = "Create Project";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CurrentFolder
            // 
            this.CurrentFolder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CurrentFolder.ForeColor = System.Drawing.SystemColors.Menu;
            this.CurrentFolder.Location = new System.Drawing.Point(46, 233);
            this.CurrentFolder.Multiline = true;
            this.CurrentFolder.Name = "CurrentFolder";
            this.CurrentFolder.ReadOnly = true;
            this.CurrentFolder.Size = new System.Drawing.Size(485, 26);
            this.CurrentFolder.TabIndex = 5;
            // 
            // Visual_Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(578, 271);
            this.Controls.Add(this.CurrentFolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ModeBox);
            this.Controls.Add(this.ProjectBtn);
            this.Controls.Add(this.ProjectTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Visual_Launcher";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ProjectTextBox;
        private System.Windows.Forms.Button ProjectBtn;
        private System.Windows.Forms.ComboBox ModeBox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CurrentFolder;
    }
}

