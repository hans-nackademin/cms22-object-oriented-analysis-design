namespace WinFormsApp
{
    partial class Form1
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
            CompanyName = new TextBox();
            CompanyName_Error = new Label();
            label3 = new Label();
            Email = new TextBox();
            Email_Error = new Label();
            Save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 0;
            label1.Text = "Company Name";
            // 
            // CompanyName
            // 
            CompanyName.Location = new Point(44, 57);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(703, 35);
            CompanyName.TabIndex = 1;
            // 
            // CompanyName_Error
            // 
            CompanyName_Error.AutoSize = true;
            CompanyName_Error.Location = new Point(44, 95);
            CompanyName_Error.Name = "CompanyName_Error";
            CompanyName_Error.Size = new Size(0, 30);
            CompanyName_Error.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 155);
            label3.Name = "label3";
            label3.Size = new Size(151, 30);
            label3.TabIndex = 3;
            label3.Text = "E-mail Address";
            // 
            // Email
            // 
            Email.Location = new Point(44, 188);
            Email.Name = "Email";
            Email.Size = new Size(703, 35);
            Email.TabIndex = 4;
            // 
            // Email_Error
            // 
            Email_Error.AutoSize = true;
            Email_Error.Location = new Point(44, 226);
            Email_Error.Name = "Email_Error";
            Email_Error.Size = new Size(0, 30);
            Email_Error.TabIndex = 5;
            // 
            // Save
            // 
            Save.Location = new Point(239, 280);
            Save.Name = "Save";
            Save.Size = new Size(293, 74);
            Save.TabIndex = 6;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 393);
            Controls.Add(Save);
            Controls.Add(Email_Error);
            Controls.Add(Email);
            Controls.Add(label3);
            Controls.Add(CompanyName_Error);
            Controls.Add(CompanyName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CompanyName;
        private Label CompanyName_Error;
        private Label label3;
        private TextBox Email;
        private Label Email_Error;
        private Button Save;
    }
}