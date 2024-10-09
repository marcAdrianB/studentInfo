namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDstudent = new System.Windows.Forms.TextBox();
            this.namelast = new System.Windows.Forms.TextBox();
            this.namefirst = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDstudentList = new System.Windows.Forms.ListBox();
            this.namefirstList = new System.Windows.Forms.ListBox();
            this.namelastList = new System.Windows.Forms.ListBox();
            this.clearList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            // 
            // IDstudent
            // 
            this.IDstudent.Location = new System.Drawing.Point(16, 40);
            this.IDstudent.MaxLength = 8;
            this.IDstudent.Name = "IDstudent";
            this.IDstudent.Size = new System.Drawing.Size(135, 20);
            this.IDstudent.TabIndex = 3;
            // 
            // namelast
            // 
            this.namelast.Location = new System.Drawing.Point(160, 40);
            this.namelast.Name = "namelast";
            this.namelast.Size = new System.Drawing.Size(135, 20);
            this.namelast.TabIndex = 4;

            // 
            // namefirst
            // 
            this.namefirst.Location = new System.Drawing.Point(304, 40);
            this.namefirst.Name = "namefirst";
            this.namefirst.Size = new System.Drawing.Size(135, 20);
            this.namefirst.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(364, 66);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student ID List";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(157, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "First Name List";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(301, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Last Name List";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // IDstudentList
            // 
            this.IDstudentList.BackColor = System.Drawing.Color.LightBlue;
            this.IDstudentList.FormattingEnabled = true;
            this.IDstudentList.Location = new System.Drawing.Point(16, 124);
            this.IDstudentList.Name = "IDstudentList";
            this.IDstudentList.Size = new System.Drawing.Size(135, 108);
            this.IDstudentList.TabIndex = 10;
            // 
            // namefirstList
            // 
            this.namefirstList.BackColor = System.Drawing.Color.LightBlue;
            this.namefirstList.FormattingEnabled = true;
            this.namefirstList.Location = new System.Drawing.Point(160, 124);
            this.namefirstList.Name = "namefirstList";
            this.namefirstList.Size = new System.Drawing.Size(135, 108);
            this.namefirstList.TabIndex = 11;
            // 
            // namelastList
            // 
            this.namelastList.BackColor = System.Drawing.Color.LightBlue;
            this.namelastList.FormattingEnabled = true;
            this.namelastList.Location = new System.Drawing.Point(304, 124);
            this.namelastList.Name = "namelastList";
            this.namelastList.Size = new System.Drawing.Size(135, 108);
            this.namelastList.TabIndex = 12;
            // 
            // clearList
            // 
            this.clearList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearList.Location = new System.Drawing.Point(364, 242);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(75, 23);
            this.clearList.TabIndex = 13;
            this.clearList.Text = "Clear List";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 107);
            this.label7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(156, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 107);
            this.label8.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(300, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 107);
            this.label9.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(12, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 19);
            this.label10.TabIndex = 17;

            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(156, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(300, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 19);
            this.label12.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(361, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 22);
            this.label13.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(361, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 22);
            this.label14.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(16, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 23);
            this.label15.TabIndex = 22;
            this.label15.Text = "* = required";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(129, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 23);
            this.label16.TabIndex = 23;
            this.label16.Text = "Student Information App";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(277, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 22);
            this.label17.TabIndex = 25;
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentInfoApplication.Properties.Resources.orange_gradient_background_modern_clean_background_copy_space_blank_background_design_cover_power_point_banner_181589494;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.namelastList);
            this.Controls.Add(this.namefirstList);
            this.Controls.Add(this.IDstudentList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.namefirst);
            this.Controls.Add(this.namelast);
            this.Controls.Add(this.IDstudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStudentInfo";
            this.Text = "Student Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStudentInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDstudent;
        private System.Windows.Forms.TextBox namelast;
        private System.Windows.Forms.TextBox namefirst;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox IDstudentList;
        private System.Windows.Forms.ListBox namefirstList;
        private System.Windows.Forms.ListBox namelastList;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
    }
}

