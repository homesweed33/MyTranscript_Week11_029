
namespace MyTranscript_Week11_029
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
            this.labelUniversityName = new System.Windows.Forms.Label();
            this.labelFacultyName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCourseCredit = new System.Windows.Forms.TextBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.dataGridViewY1S1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageYear1Sem1 = new System.Windows.Forms.TabPage();
            this.tabPageYear1Sem2 = new System.Windows.Forms.TabPage();
            this.dataGridViewY1S2 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageYear1Sem1.SuspendLayout();
            this.tabPageYear1Sem2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUniversityName
            // 
            this.labelUniversityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUniversityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelUniversityName.Location = new System.Drawing.Point(250, 19);
            this.labelUniversityName.Name = "labelUniversityName";
            this.labelUniversityName.Size = new System.Drawing.Size(289, 37);
            this.labelUniversityName.TabIndex = 0;
            this.labelUniversityName.Text = "My university name";
            this.labelUniversityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFacultyName
            // 
            this.labelFacultyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelFacultyName.Location = new System.Drawing.Point(250, 56);
            this.labelFacultyName.Name = "labelFacultyName";
            this.labelFacultyName.Size = new System.Drawing.Size(289, 37);
            this.labelFacultyName.TabIndex = 1;
            this.labelFacultyName.Text = "My faculty name";
            this.labelFacultyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonAddCourse);
            this.groupBox1.Controls.Add(this.textBoxGrade);
            this.groupBox1.Controls.Add(this.textBoxCourseCredit);
            this.groupBox1.Controls.Add(this.textBoxCourseName);
            this.groupBox1.Controls.Add(this.textBoxCourseID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Course Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Credit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Grade";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(124, 19);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(100, 23);
            this.textBoxCourseID.TabIndex = 4;
            this.textBoxCourseID.Text = "12345678";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(124, 44);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(197, 23);
            this.textBoxCourseName.TabIndex = 5;
            this.textBoxCourseName.Text = "Computer Laboratory";
            this.textBoxCourseName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCourseCredit
            // 
            this.textBoxCourseCredit.Location = new System.Drawing.Point(124, 70);
            this.textBoxCourseCredit.Name = "textBoxCourseCredit";
            this.textBoxCourseCredit.Size = new System.Drawing.Size(49, 23);
            this.textBoxCourseCredit.TabIndex = 6;
            this.textBoxCourseCredit.Text = "3";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(124, 97);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(49, 23);
            this.textBoxGrade.TabIndex = 7;
            this.textBoxGrade.Text = "B+";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(268, 100);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(53, 23);
            this.buttonAddCourse.TabIndex = 8;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.AddGrade);
            // 
            // dataGridViewY1S1
            // 
            this.dataGridViewY1S1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewY1S1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewY1S1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewY1S1.Name = "dataGridViewY1S1";
            this.dataGridViewY1S1.Size = new System.Drawing.Size(762, 227);
            this.dataGridViewY1S1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageYear1Sem1);
            this.tabControl1.Controls.Add(this.tabPageYear1Sem2);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 259);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageYear1Sem1
            // 
            this.tabPageYear1Sem1.Controls.Add(this.dataGridViewY1S1);
            this.tabPageYear1Sem1.Location = new System.Drawing.Point(4, 22);
            this.tabPageYear1Sem1.Name = "tabPageYear1Sem1";
            this.tabPageYear1Sem1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYear1Sem1.Size = new System.Drawing.Size(768, 233);
            this.tabPageYear1Sem1.TabIndex = 0;
            this.tabPageYear1Sem1.Text = "Year1 Sem1";
            this.tabPageYear1Sem1.UseVisualStyleBackColor = true;
            // 
            // tabPageYear1Sem2
            // 
            this.tabPageYear1Sem2.Controls.Add(this.dataGridViewY1S2);
            this.tabPageYear1Sem2.Location = new System.Drawing.Point(4, 22);
            this.tabPageYear1Sem2.Name = "tabPageYear1Sem2";
            this.tabPageYear1Sem2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYear1Sem2.Size = new System.Drawing.Size(768, 233);
            this.tabPageYear1Sem2.TabIndex = 1;
            this.tabPageYear1Sem2.Text = "Year1 Sem2";
            this.tabPageYear1Sem2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewY1S2
            // 
            this.dataGridViewY1S2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewY1S2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewY1S2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewY1S2.Name = "dataGridViewY1S2";
            this.dataGridViewY1S2.Size = new System.Drawing.Size(762, 227);
            this.dataGridViewY1S2.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(327, 100);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(55, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.SaveFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelFacultyName);
            this.Controls.Add(this.labelUniversityName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageYear1Sem1.ResumeLayout(false);
            this.tabPageYear1Sem2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY1S2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUniversityName;
        private System.Windows.Forms.Label labelFacultyName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCourseCredit;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.DataGridView dataGridViewY1S1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageYear1Sem1;
        private System.Windows.Forms.TabPage tabPageYear1Sem2;
        private System.Windows.Forms.DataGridView dataGridViewY1S2;
        private System.Windows.Forms.Button buttonSave;
    }
}

