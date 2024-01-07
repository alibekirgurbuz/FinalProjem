namespace SiparisSistemi
{
    partial class Odeme
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 41);
            label1.Name = "label1";
            label1.Size = new Size(222, 28);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 198);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 1;
            label2.Text = "Kart Üzerindeki İsim: \r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 241);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Kart Numarası: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 323);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 5;
            label4.Text = "Kart Tipi: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 396);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 6;
            label5.Text = "Toplam Tutar: ";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(186, 319);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Visa";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(266, 319);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 24);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "MasterCard";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 396);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "labelSon";
            // 
            // button1
            // 
            button1.Location = new Point(266, 460);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 10;
            button1.Text = "Öde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(123, 122);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(123, 160);
            label8.Name = "label8";
            label8.Size = new Size(0, 22);
            label8.TabIndex = 12;
            // 
            // Odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 589);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Odeme";
            Text = "Odeme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
    }
}