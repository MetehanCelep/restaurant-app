namespace yazlab3
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            textBoxToplamSure = new TextBox();
            textBoxSaniye = new TextBox();
            buttonOnayla = new Button();
            textBoxMusteri = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 127);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Toplam Süre (Dakika) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 183);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 1;
            label2.Text = "Kaç Saniyede Bir ?";
            // 
            // textBoxToplamSure
            // 
            textBoxToplamSure.Location = new Point(327, 127);
            textBoxToplamSure.Name = "textBoxToplamSure";
            textBoxToplamSure.Size = new Size(125, 27);
            textBoxToplamSure.TabIndex = 2;
            // 
            // textBoxSaniye
            // 
            textBoxSaniye.Location = new Point(327, 183);
            textBoxSaniye.Name = "textBoxSaniye";
            textBoxSaniye.Size = new Size(125, 27);
            textBoxSaniye.TabIndex = 3;
            // 
            // buttonOnayla
            // 
            buttonOnayla.BackColor = Color.Lime;
            buttonOnayla.Location = new Point(530, 161);
            buttonOnayla.Name = "buttonOnayla";
            buttonOnayla.Size = new Size(134, 65);
            buttonOnayla.TabIndex = 4;
            buttonOnayla.Text = "Onayla";
            buttonOnayla.UseVisualStyleBackColor = false;
            buttonOnayla.Click += buttonOnayla_Click;
            // 
            // textBoxMusteri
            // 
            textBoxMusteri.Location = new Point(327, 243);
            textBoxMusteri.Name = "textBoxMusteri";
            textBoxMusteri.Size = new Size(125, 27);
            textBoxMusteri.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 243);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 5;
            label3.Text = "Kaç Müşteri Gelsin ?";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxMusteri);
            Controls.Add(label3);
            Controls.Add(buttonOnayla);
            Controls.Add(textBoxSaniye);
            Controls.Add(textBoxToplamSure);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Problem 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxToplamSure;
        private TextBox textBoxSaniye;
        private Button buttonOnayla;
        private TextBox textBoxMusteri;
        private Label label3;
    }
}