namespace MVP
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
            LbFirstNameError = new Label();
            label3 = new Label();
            LbLastNameError = new Label();
            TbFirstName = new TextBox();
            TbLastName = new TextBox();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Förnamn";
            // 
            // LbFirstNameError
            // 
            LbFirstNameError.AutoSize = true;
            LbFirstNameError.Location = new Point(33, 58);
            LbFirstNameError.Margin = new Padding(2, 0, 2, 0);
            LbFirstNameError.Name = "LbFirstNameError";
            LbFirstNameError.Size = new Size(0, 15);
            LbFirstNameError.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Efternamn";
            // 
            // LbLastNameError
            // 
            LbLastNameError.AutoSize = true;
            LbLastNameError.Location = new Point(33, 133);
            LbLastNameError.Margin = new Padding(2, 0, 2, 0);
            LbLastNameError.Name = "LbLastNameError";
            LbLastNameError.Size = new Size(0, 15);
            LbLastNameError.TabIndex = 3;
            // 
            // TbFirstName
            // 
            TbFirstName.Location = new Point(33, 33);
            TbFirstName.Margin = new Padding(2);
            TbFirstName.Name = "TbFirstName";
            TbFirstName.Size = new Size(391, 23);
            TbFirstName.TabIndex = 4;
            // 
            // TbLastName
            // 
            TbLastName.Location = new Point(33, 108);
            TbLastName.Margin = new Padding(2);
            TbLastName.Name = "TbLastName";
            TbLastName.Size = new Size(391, 23);
            TbLastName.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(152, 165);
            BtnSave.Margin = new Padding(2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(145, 37);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "SAVE";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 225);
            Controls.Add(BtnSave);
            Controls.Add(TbLastName);
            Controls.Add(TbFirstName);
            Controls.Add(LbLastNameError);
            Controls.Add(label3);
            Controls.Add(LbFirstNameError);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LbFirstNameError;
        private Label label3;
        private Label LbLastNameError;
        private TextBox TbFirstName;
        private TextBox TbLastName;
        private Button BtnSave;
    }
}