namespace PasswordGenerator
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(313, 307);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Generate password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 1;
            label1.Text = "Password generator";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 360);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Lowercase", "Uppercase", "Digits", "Special Characters" });
            checkedListBox1.Location = new Point(292, 169);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 116);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 127);
            label2.Name = "label2";
            label2.Size = new Size(226, 25);
            label2.TabIndex = 4;
            label2.Text = "Please Select the characters";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 45);
            label3.Name = "label3";
            label3.Size = new Size(228, 25);
            label3.TabIndex = 6;
            label3.Text = "Enter Number of characters";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Hello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
    }
}
