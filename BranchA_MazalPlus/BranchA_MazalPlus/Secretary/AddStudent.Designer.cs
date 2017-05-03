﻿namespace BranchA_MazalPlus.Secretary
{
    partial class AddStudent
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
            this.Add = new System.Windows.Forms.Button();
            this.CourseID = new System.Windows.Forms.ComboBox();
            this.CourseSerial = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.Semester = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(168, 110);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(79, 20);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CourseID
            // 
            this.CourseID.FormattingEnabled = true;
            this.CourseID.Items.AddRange(new object[] {
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "400",
            "401",
            "402",
            "403",
            "404"});
            this.CourseID.Location = new System.Drawing.Point(14, 27);
            this.CourseID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(188, 24);
            this.CourseID.TabIndex = 1;
            // 
            // CourseSerial
            // 
            this.CourseSerial.FormattingEnabled = true;
            this.CourseSerial.Items.AddRange(new object[] {
            "1001"});
            this.CourseSerial.Location = new System.Drawing.Point(212, 27);
            this.CourseSerial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CourseSerial.Name = "CourseSerial";
            this.CourseSerial.Size = new System.Drawing.Size(188, 24);
            this.CourseSerial.TabIndex = 2;
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            "a101",
            "a102",
            "f101",
            "f102",
            "f103",
            "f104",
            "s101",
            "s102",
            "s103",
            "s104"});
            this.Class.Location = new System.Drawing.Point(14, 70);
            this.Class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(188, 24);
            this.Class.TabIndex = 3;
            // 
            // Semester
            // 
            this.Semester.FormattingEnabled = true;
            this.Semester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Semester.Location = new System.Drawing.Point(212, 70);
            this.Semester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(188, 24);
            this.Semester.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course_ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course_Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Semester";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 146);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.CourseSerial);
            this.Controls.Add(this.CourseID);
            this.Controls.Add(this.Add);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox CourseID;
        private System.Windows.Forms.ComboBox CourseSerial;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.ComboBox Semester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}