namespace SampleWinApp
{
    partial class MainContainer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtNewSalary = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1733, 759);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lstNames);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1725, 730);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(581, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 481);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details of the Employee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 89);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(278, 239);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(385, 40);
            this.txtSalary.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(278, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 40);
            this.txtName.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(278, 92);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(385, 40);
            this.txtID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "Emp Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Emp Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Emp ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "List of Employees";
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 34;
            this.lstNames.Location = new System.Drawing.Point(45, 177);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(446, 480);
            this.lstNames.TabIndex = 1;
            this.lstNames.SelectedIndexChanged += new System.EventHandler(this.LstNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Users with Us";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1725, 730);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1725, 730);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About Us";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddNew);
            this.groupBox2.Controls.Add(this.txtNewSalary);
            this.groupBox2.Controls.Add(this.txtNewName);
            this.groupBox2.Controls.Add(this.txtNewID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(470, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 481);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add the Details of New Employee";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(266, 341);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(286, 89);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Save Changes";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.myAddingEvent);
            // 
            // txtNewSalary
            // 
            this.txtNewSalary.Location = new System.Drawing.Point(278, 239);
            this.txtNewSalary.Name = "txtNewSalary";
            this.txtNewSalary.Size = new System.Drawing.Size(385, 40);
            this.txtNewSalary.TabIndex = 5;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(278, 167);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(385, 40);
            this.txtNewName.TabIndex = 4;
            // 
            // txtNewID
            // 
            this.txtNewID.Location = new System.Drawing.Point(278, 92);
            this.txtNewID.Name = "txtNewID";
            this.txtNewID.Size = new System.Drawing.Size(385, 40);
            this.txtNewID.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Emp Salary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "Emp Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "Emp ID:";
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 766);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainContainer";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainContainer_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtNewSalary;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

