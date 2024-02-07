namespace yazlab3
{
    partial class mainForm
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
            problem1 = new Button();
            problem2 = new Button();
            SuspendLayout();
            // 
            // problem1
            // 
            problem1.Location = new Point(191, 113);
            problem1.Name = "problem1";
            problem1.Size = new Size(269, 134);
            problem1.TabIndex = 0;
            problem1.Text = "Problem 1";
            problem1.UseVisualStyleBackColor = true;
            problem1.Click += problem1_Click;
            // 
            // problem2
            // 
            problem2.Location = new Point(594, 113);
            problem2.Name = "problem2";
            problem2.Size = new Size(269, 134);
            problem2.TabIndex = 1;
            problem2.Text = "Problem 2";
            problem2.UseVisualStyleBackColor = true;
            problem2.Click += problem2_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1074, 443);
            Controls.Add(problem2);
            Controls.Add(problem1);
            Name = "mainForm";
            Text = "Restoran Yönetim Sistemi";
            ResumeLayout(false);
        }

        #endregion

        private Button problem1;
        private Button problem2;
    }
}