namespace Account_Registration
{
    partial class AccountRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            tbStudentNo = new TextBox();
            tbLastName = new TextBox();
            tbMiddleName = new TextBox();
            tbFirstName = new TextBox();
            tbAge = new TextBox();
            tbContactNo = new TextBox();
            tbAdress = new TextBox();
            cbProgram = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 47);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 47);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 130);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 130);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "FirstName:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 130);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 210);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(177, 210);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 6;
            label7.Text = "Contact No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 294);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 7;
            label8.Text = "Adress:";
            // 
            // button1
            // 
            button1.Location = new Point(158, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbStudentNo
            // 
            tbStudentNo.Location = new Point(26, 65);
            tbStudentNo.Name = "tbStudentNo";
            tbStudentNo.Size = new Size(100, 23);
            tbStudentNo.TabIndex = 9;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(26, 148);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(100, 23);
            tbLastName.TabIndex = 10;
            // 
            // tbMiddleName
            // 
            tbMiddleName.Location = new Point(315, 148);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(100, 23);
            tbMiddleName.TabIndex = 11;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(177, 148);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(100, 23);
            tbFirstName.TabIndex = 12;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(26, 228);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 23);
            tbAge.TabIndex = 13;
            // 
            // tbContactNo
            // 
            tbContactNo.Location = new Point(177, 225);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.Size = new Size(100, 23);
            tbContactNo.TabIndex = 14;
            // 
            // tbAdress
            // 
            tbAdress.Location = new Point(26, 312);
            tbAdress.Multiline = true;
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(251, 61);
            tbAdress.TabIndex = 15;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "Bachelor Of Science in Information Technology", "Bachelor Of Science in Aircraft Maintenance", "Bachelor Of Science in Hotel Management", "Bachelor Of Science in Vulcanizing" });
            cbProgram.Location = new Point(315, 65);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(121, 23);
            cbProgram.TabIndex = 16;
            // 
            // AccountRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(cbProgram);
            Controls.Add(tbAdress);
            Controls.Add(tbContactNo);
            Controls.Add(tbAge);
            Controls.Add(tbFirstName);
            Controls.Add(tbMiddleName);
            Controls.Add(tbLastName);
            Controls.Add(tbStudentNo);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccountRegistration";
            Text = "Account Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private TextBox tbStudentNo;
        private TextBox tbLastName;
        private TextBox tbMiddleName;
        private TextBox tbFirstName;
        private TextBox tbAge;
        private TextBox tbContactNo;
        private TextBox tbAdress;
        private ComboBox cbProgram;
    }
}