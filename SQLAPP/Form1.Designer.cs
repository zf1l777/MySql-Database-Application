namespace SQLAPP
{
    partial class Form1
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
            System.Windows.Forms.Button ButtonIn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonSe = new System.Windows.Forms.Button();
            this.boxTitle = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labDirector = new System.Windows.Forms.Label();
            this.labRating = new System.Windows.Forms.Label();
            this.boxYear = new System.Windows.Forms.TextBox();
            this.boxDirector = new System.Windows.Forms.TextBox();
            this.boxRating = new System.Windows.Forms.TextBox();
            this.labHeading = new System.Windows.Forms.Label();
            this.ButtonCL = new System.Windows.Forms.Button();
            ButtonIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonIn
            // 
            ButtonIn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            ButtonIn.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonIn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            ButtonIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonIn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ButtonIn.Location = new System.Drawing.Point(367, 112);
            ButtonIn.Name = "ButtonIn";
            ButtonIn.Size = new System.Drawing.Size(118, 50);
            ButtonIn.TabIndex = 6;
            ButtonIn.Text = "Insert";
            ButtonIn.UseVisualStyleBackColor = false;
            ButtonIn.Click += new System.EventHandler(this.ButtonIn_Click);
            // 
            // ButtonSe
            // 
            this.ButtonSe.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonSe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSe.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSe.Location = new System.Drawing.Point(367, 57);
            this.ButtonSe.Name = "ButtonSe";
            this.ButtonSe.Size = new System.Drawing.Size(118, 50);
            this.ButtonSe.TabIndex = 5;
            this.ButtonSe.TabStop = false;
            this.ButtonSe.Text = "Search";
            this.ButtonSe.UseVisualStyleBackColor = false;
            this.ButtonSe.Click += new System.EventHandler(this.Button1_Click);
            // 
            // boxTitle
            // 
            this.boxTitle.AutoCompleteCustomSource.AddRange(new string[] {
            "Racolta"});
            this.boxTitle.BackColor = System.Drawing.SystemColors.Control;
            this.boxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTitle.Location = new System.Drawing.Point(99, 57);
            this.boxTitle.Multiline = true;
            this.boxTitle.Name = "boxTitle";
            this.boxTitle.Size = new System.Drawing.Size(250, 25);
            this.boxTitle.TabIndex = 1;
            this.boxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(4, 57);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(56, 25);
            this.labTitle.TabIndex = 8;
            this.labTitle.Text = "Title:";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labYear.Location = new System.Drawing.Point(3, 97);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(57, 25);
            this.labYear.TabIndex = 9;
            this.labYear.Text = "Year:";
            // 
            // labDirector
            // 
            this.labDirector.AutoSize = true;
            this.labDirector.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDirector.Location = new System.Drawing.Point(3, 137);
            this.labDirector.Name = "labDirector";
            this.labDirector.Size = new System.Drawing.Size(90, 25);
            this.labDirector.TabIndex = 10;
            this.labDirector.Text = "Director:";
            // 
            // labRating
            // 
            this.labRating.AutoSize = true;
            this.labRating.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRating.Location = new System.Drawing.Point(4, 177);
            this.labRating.Name = "labRating";
            this.labRating.Size = new System.Drawing.Size(76, 25);
            this.labRating.TabIndex = 11;
            this.labRating.Text = "Rating:";
            // 
            // boxYear
            // 
            this.boxYear.BackColor = System.Drawing.SystemColors.Control;
            this.boxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxYear.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxYear.Location = new System.Drawing.Point(99, 97);
            this.boxYear.Multiline = true;
            this.boxYear.Name = "boxYear";
            this.boxYear.Size = new System.Drawing.Size(250, 25);
            this.boxYear.TabIndex = 2;
            this.boxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxDirector
            // 
            this.boxDirector.BackColor = System.Drawing.SystemColors.Control;
            this.boxDirector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxDirector.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDirector.Location = new System.Drawing.Point(99, 137);
            this.boxDirector.Multiline = true;
            this.boxDirector.Name = "boxDirector";
            this.boxDirector.Size = new System.Drawing.Size(250, 25);
            this.boxDirector.TabIndex = 3;
            this.boxDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxRating
            // 
            this.boxRating.BackColor = System.Drawing.SystemColors.Control;
            this.boxRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxRating.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxRating.Location = new System.Drawing.Point(99, 177);
            this.boxRating.Multiline = true;
            this.boxRating.Name = "boxRating";
            this.boxRating.Size = new System.Drawing.Size(250, 25);
            this.boxRating.TabIndex = 4;
            this.boxRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labHeading
            // 
            this.labHeading.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labHeading.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeading.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labHeading.Location = new System.Drawing.Point(8, 9);
            this.labHeading.Name = "labHeading";
            this.labHeading.Size = new System.Drawing.Size(477, 38);
            this.labHeading.TabIndex = 0;
            this.labHeading.Text = "Search Movies";
            this.labHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonCL
            // 
            this.ButtonCL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonCL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCL.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCL.Location = new System.Drawing.Point(367, 168);
            this.ButtonCL.Name = "ButtonCL";
            this.ButtonCL.Size = new System.Drawing.Size(118, 34);
            this.ButtonCL.TabIndex = 7;
            this.ButtonCL.Text = "Clear all";
            this.ButtonCL.UseVisualStyleBackColor = false;
            this.ButtonCL.Click += new System.EventHandler(this.ButtonCL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(493, 209);
            this.Controls.Add(this.ButtonCL);
            this.Controls.Add(ButtonIn);
            this.Controls.Add(this.labHeading);
            this.Controls.Add(this.boxRating);
            this.Controls.Add(this.boxDirector);
            this.Controls.Add(this.boxYear);
            this.Controls.Add(this.labRating);
            this.Controls.Add(this.labDirector);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.boxTitle);
            this.Controls.Add(this.ButtonSe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSe;
        private System.Windows.Forms.TextBox boxTitle;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labDirector;
        private System.Windows.Forms.Label labRating;
        private System.Windows.Forms.TextBox boxYear;
        private System.Windows.Forms.TextBox boxDirector;
        private System.Windows.Forms.TextBox boxRating;
        private System.Windows.Forms.Label labHeading;
        private System.Windows.Forms.Button ButtonCL;
    }
}

