namespace SampleWinApp
{
    partial class WCFClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Data Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(893, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(918, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = " Contact No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(975, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1119, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 40);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1119, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(392, 40);
            this.textBox2.TabIndex = 5;
            // 
            // cmbAmount
            // 
            this.cmbAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Items.AddRange(new object[] {
            "500",
            "600",
            "700",
            "800"});
            this.cmbAmount.Location = new System.Drawing.Point(1119, 301);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(392, 42);
            this.cmbAmount.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(1207, 440);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(303, 85);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 34;
            this.lstNames.Location = new System.Drawing.Point(116, 169);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(286, 378);
            this.lstNames.TabIndex = 8;
            this.lstNames.SelectedIndexChanged += new System.EventHandler(this.LstNames_SelectedIndexChanged);
            // 
            // WCFClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 634);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbAmount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WCFClient";
            this.Text = "WCFClient";
            this.Load += new System.EventHandler(this.WCFClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbAmount;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lstNames;
    }
}