namespace yazlab3
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
            masa1 = new Button();
            masa2 = new Button();
            masa3 = new Button();
            masa4 = new Button();
            masa5 = new Button();
            masa6 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            musterisayitextbox = new TextBox();
            bekleyenMusteriListbox = new ListBox();
            label2 = new Label();
            Garson1ListBox = new ListBox();
            Garson2ListBox = new ListBox();
            Garson3ListBox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Asci1ListBox = new ListBox();
            label6 = new Label();
            label7 = new Label();
            Asci2ListBox = new ListBox();
            label8 = new Label();
            KasaListBox = new ListBox();
            OnaylaButton = new Button();
            textBoxOncelikli = new TextBox();
            SuspendLayout();
            // 
            // masa1
            // 
            masa1.BackColor = Color.Lime;
            masa1.Location = new Point(27, 50);
            masa1.Name = "masa1";
            masa1.Size = new Size(139, 110);
            masa1.TabIndex = 0;
            masa1.Text = "masa1";
            masa1.UseVisualStyleBackColor = false;
            masa1.Click += masa1_Click;
            // 
            // masa2
            // 
            masa2.BackColor = Color.Lime;
            masa2.Location = new Point(184, 50);
            masa2.Name = "masa2";
            masa2.Size = new Size(139, 110);
            masa2.TabIndex = 1;
            masa2.Text = "masa2";
            masa2.UseVisualStyleBackColor = false;
            masa2.Click += masa2_Click;
            // 
            // masa3
            // 
            masa3.BackColor = Color.Lime;
            masa3.Location = new Point(347, 50);
            masa3.Name = "masa3";
            masa3.Size = new Size(139, 110);
            masa3.TabIndex = 2;
            masa3.Text = "masa3";
            masa3.UseVisualStyleBackColor = false;
            masa3.Click += masa3_Click;
            // 
            // masa4
            // 
            masa4.BackColor = Color.Lime;
            masa4.Location = new Point(27, 215);
            masa4.Name = "masa4";
            masa4.Size = new Size(139, 110);
            masa4.TabIndex = 3;
            masa4.Text = "masa4";
            masa4.UseVisualStyleBackColor = false;
            masa4.Click += masa4_Click;
            // 
            // masa5
            // 
            masa5.BackColor = Color.Lime;
            masa5.Location = new Point(184, 215);
            masa5.Name = "masa5";
            masa5.Size = new Size(139, 110);
            masa5.TabIndex = 4;
            masa5.Text = "masa5";
            masa5.UseVisualStyleBackColor = false;
            masa5.Click += masa5_Click;
            // 
            // masa6
            // 
            masa6.BackColor = Color.Lime;
            masa6.Location = new Point(347, 215);
            masa6.Name = "masa6";
            masa6.Size = new Size(139, 110);
            masa6.TabIndex = 5;
            masa6.Text = "masa6";
            masa6.UseVisualStyleBackColor = false;
            masa6.Click += masa6_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(611, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 250);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(619, 44);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 7;
            label1.Text = "Gelen Müşteriler";
            // 
            // musterisayitextbox
            // 
            musterisayitextbox.Location = new Point(416, 12);
            musterisayitextbox.Name = "musterisayitextbox";
            musterisayitextbox.PlaceholderText = "Müşteri Sayısı";
            musterisayitextbox.Size = new Size(184, 27);
            musterisayitextbox.TabIndex = 8;
            // 
            // bekleyenMusteriListbox
            // 
            bekleyenMusteriListbox.FormattingEnabled = true;
            bekleyenMusteriListbox.Location = new Point(908, 66);
            bekleyenMusteriListbox.Name = "bekleyenMusteriListbox";
            bekleyenMusteriListbox.Size = new Size(279, 244);
            bekleyenMusteriListbox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(908, 43);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 10;
            label2.Text = "Bekleyen Müşteriler";
            // 
            // Garson1ListBox
            // 
            Garson1ListBox.FormattingEnabled = true;
            Garson1ListBox.Location = new Point(18, 368);
            Garson1ListBox.Name = "Garson1ListBox";
            Garson1ListBox.Size = new Size(392, 144);
            Garson1ListBox.TabIndex = 11;
            Garson1ListBox.SelectedIndexChanged += Garson1ListBox_SelectedIndexChanged;
            // 
            // Garson2ListBox
            // 
            Garson2ListBox.FormattingEnabled = true;
            Garson2ListBox.Location = new Point(416, 368);
            Garson2ListBox.Name = "Garson2ListBox";
            Garson2ListBox.Size = new Size(394, 144);
            Garson2ListBox.TabIndex = 12;
            Garson2ListBox.SelectedIndexChanged += Garson2ListBox_SelectedIndexChanged;
            // 
            // Garson3ListBox
            // 
            Garson3ListBox.FormattingEnabled = true;
            Garson3ListBox.Location = new Point(816, 368);
            Garson3ListBox.Name = "Garson3ListBox";
            Garson3ListBox.Size = new Size(386, 144);
            Garson3ListBox.TabIndex = 13;
            Garson3ListBox.SelectedIndexChanged += Garson3ListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 345);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 14;
            label3.Text = "Garson 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 345);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 15;
            label4.Text = "Garson 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(816, 345);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 16;
            label5.Text = "Garson 3";
            // 
            // Asci1ListBox
            // 
            Asci1ListBox.FormattingEnabled = true;
            Asci1ListBox.Location = new Point(18, 558);
            Asci1ListBox.Name = "Asci1ListBox";
            Asci1ListBox.Size = new Size(392, 144);
            Asci1ListBox.TabIndex = 17;
            Asci1ListBox.SelectedIndexChanged += Asci1ListBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 535);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 18;
            label6.Text = "Aşçı 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 535);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 20;
            label7.Text = "Aşçı 2";
            // 
            // Asci2ListBox
            // 
            Asci2ListBox.FormattingEnabled = true;
            Asci2ListBox.Location = new Point(416, 558);
            Asci2ListBox.Name = "Asci2ListBox";
            Asci2ListBox.Size = new Size(392, 144);
            Asci2ListBox.TabIndex = 19;
            Asci2ListBox.SelectedIndexChanged += Asci2ListBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(816, 535);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 22;
            label8.Text = "Kasa";
            // 
            // KasaListBox
            // 
            KasaListBox.FormattingEnabled = true;
            KasaListBox.Location = new Point(816, 558);
            KasaListBox.Name = "KasaListBox";
            KasaListBox.Size = new Size(392, 144);
            KasaListBox.TabIndex = 21;
            KasaListBox.SelectedIndexChanged += KasaListBox_SelectedIndexChanged;
            // 
            // OnaylaButton
            // 
            OnaylaButton.Location = new Point(801, 11);
            OnaylaButton.Name = "OnaylaButton";
            OnaylaButton.Size = new Size(113, 29);
            OnaylaButton.TabIndex = 23;
            OnaylaButton.Text = "Onayla";
            OnaylaButton.UseVisualStyleBackColor = true;
            OnaylaButton.Click += OnaylaButton_Click;
            // 
            // textBoxOncelikli
            // 
            textBoxOncelikli.Location = new Point(611, 12);
            textBoxOncelikli.Name = "textBoxOncelikli";
            textBoxOncelikli.PlaceholderText = "Öncelikli";
            textBoxOncelikli.Size = new Size(184, 27);
            textBoxOncelikli.TabIndex = 24;
            textBoxOncelikli.TextChanged += textBoxOncelikli_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 714);
            Controls.Add(textBoxOncelikli);
            Controls.Add(OnaylaButton);
            Controls.Add(label8);
            Controls.Add(KasaListBox);
            Controls.Add(label7);
            Controls.Add(Asci2ListBox);
            Controls.Add(label6);
            Controls.Add(Asci1ListBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Garson3ListBox);
            Controls.Add(Garson2ListBox);
            Controls.Add(Garson1ListBox);
            Controls.Add(label2);
            Controls.Add(bekleyenMusteriListbox);
            Controls.Add(musterisayitextbox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(masa6);
            Controls.Add(masa5);
            Controls.Add(masa4);
            Controls.Add(masa3);
            Controls.Add(masa2);
            Controls.Add(masa1);
            Name = "Form1";
            Text = "Problem 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button masa1;
        private Button masa2;
        private Button masa3;
        private Button masa4;
        private Button masa5;
        private Button masa6;
        private Panel panel1;
        private Label label1;
        private TextBox musterisayitextbox;
        private ListBox bekleyenMusteriListbox;
        private Label label2;
        private ListBox Garson1ListBox;
        private ListBox Garson2ListBox;
        private ListBox Garson3ListBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox Asci1ListBox;
        private Label label6;
        private Label label7;
        private ListBox Asci2ListBox;
        private Label label8;
        private ListBox KasaListBox;
        private Button OnaylaButton;
        private TextBox textBoxOncelikli;
    }
}
