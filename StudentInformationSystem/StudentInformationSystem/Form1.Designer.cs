namespace StudentInformationSystem
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBox = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.python = new System.Windows.Forms.CheckBox();
            this.VSN = new System.Windows.Forms.CheckBox();
            this.java = new System.Windows.Forms.CheckBox();
            this.php = new System.Windows.Forms.CheckBox();
            this.cs = new System.Windows.Forms.CheckBox();
            this.cpp = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.yearLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.birthDay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information System";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBox);
            this.panel1.Controls.Add(this.Upload);
            this.panel1.Controls.Add(this.img);
            this.panel1.Controls.Add(this.python);
            this.panel1.Controls.Add(this.VSN);
            this.panel1.Controls.Add(this.java);
            this.panel1.Controls.Add(this.php);
            this.panel1.Controls.Add(this.cs);
            this.panel1.Controls.Add(this.cpp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.yearLevel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rbfemale);
            this.panel1.Controls.Add(this.rbmale);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.birthDay);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStudentNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 392);
            this.panel1.TabIndex = 1;
            // 
            // saveBox
            // 
            this.saveBox.Location = new System.Drawing.Point(767, 306);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(190, 35);
            this.saveBox.TabIndex = 25;
            this.saveBox.Text = "SAVE";
            this.saveBox.UseVisualStyleBackColor = true;
            this.saveBox.Click += new System.EventHandler(this.saveBox_Click);
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(767, 255);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(190, 35);
            this.Upload.TabIndex = 24;
            this.Upload.Text = "UPLOAD";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(731, 3);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(266, 235);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 23;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // python
            // 
            this.python.AutoSize = true;
            this.python.Location = new System.Drawing.Point(574, 273);
            this.python.Name = "python";
            this.python.Size = new System.Drawing.Size(71, 17);
            this.python.TabIndex = 22;
            this.python.Text = "PYTHON";
            this.python.UseVisualStyleBackColor = true;
            // 
            // VSN
            // 
            this.VSN.AutoSize = true;
            this.VSN.Location = new System.Drawing.Point(574, 217);
            this.VSN.Name = "VSN";
            this.VSN.Size = new System.Drawing.Size(65, 17);
            this.VSN.TabIndex = 21;
            this.VSN.Text = "VS.NET";
            this.VSN.UseVisualStyleBackColor = true;
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.Location = new System.Drawing.Point(574, 159);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(52, 17);
            this.java.TabIndex = 20;
            this.java.Text = "JAVA";
            this.java.UseVisualStyleBackColor = true;
            // 
            // php
            // 
            this.php.AutoSize = true;
            this.php.Location = new System.Drawing.Point(478, 273);
            this.php.Name = "php";
            this.php.Size = new System.Drawing.Size(48, 17);
            this.php.TabIndex = 19;
            this.php.Text = "PHP";
            this.php.UseVisualStyleBackColor = true;
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.Location = new System.Drawing.Point(478, 217);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(40, 17);
            this.cs.TabIndex = 18;
            this.cs.Text = "C#";
            this.cs.UseVisualStyleBackColor = true;
            // 
            // cpp
            // 
            this.cpp.AutoSize = true;
            this.cpp.Location = new System.Drawing.Point(478, 159);
            this.cpp.Name = "cpp";
            this.cpp.Size = new System.Drawing.Size(45, 17);
            this.cpp.TabIndex = 17;
            this.cpp.Text = "C++";
            this.cpp.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Skills";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Year Level";
            // 
            // yearLevel
            // 
            this.yearLevel.FormattingEnabled = true;
            this.yearLevel.Items.AddRange(new object[] {
            "BSIT - 1",
            "BSIT - 2",
            "BSIT - 3",
            "BSIT - 4",
            "BSIT - 5"});
            this.yearLevel.Location = new System.Drawing.Point(478, 45);
            this.yearLevel.Name = "yearLevel";
            this.yearLevel.Size = new System.Drawing.Size(178, 21);
            this.yearLevel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sex";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(278, 274);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(59, 17);
            this.rbfemale.TabIndex = 11;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(188, 274);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(48, 17);
            this.rbmale.TabIndex = 10;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(188, 218);
            this.Age.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(149, 20);
            this.Age.TabIndex = 9;
            this.Age.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // birthDay
            // 
            this.birthDay.Location = new System.Drawing.Point(171, 321);
            this.birthDay.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.birthDay.MinDate = new System.DateTime(1985, 12, 31, 0, 0, 0, 0);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(15, 20);
            this.birthDay.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Age";
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(190, 160);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(147, 20);
            this.lName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(188, 104);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(149, 20);
            this.fName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(188, 46);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(149, 20);
            this.txtStudentNumber.TabIndex = 1;
            this.txtStudentNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Number";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 509);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(1017, 273);
            this.dgvStudents.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 794);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker birthDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.CheckBox php;
        private System.Windows.Forms.CheckBox cs;
        private System.Windows.Forms.CheckBox cpp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox yearLevel;
        private System.Windows.Forms.CheckBox python;
        private System.Windows.Forms.CheckBox VSN;
        private System.Windows.Forms.CheckBox java;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button saveBox;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}

