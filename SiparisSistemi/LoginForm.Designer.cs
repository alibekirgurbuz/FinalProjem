namespace SiparisSistemi
{
    partial class LoginForm
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtLoginEposta = new TextBox();
            txtLoginSifre = new TextBox();
            button1 = new Button();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            Loginbox = new GroupBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            signinbox = new GroupBox();
            buttontemizle = new Button();
            label6 = new Label();
            Loginbox.SuspendLayout();
            signinbox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 52);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 92);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Eposta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 137);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Şifre";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(192, 45);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(192, 85);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtLoginEposta
            // 
            txtLoginEposta.Location = new Point(124, 85);
            txtLoginEposta.Name = "txtLoginEposta";
            txtLoginEposta.Size = new Size(125, 27);
            txtLoginEposta.TabIndex = 7;
            // 
            // txtLoginSifre
            // 
            txtLoginSifre.Location = new Point(124, 130);
            txtLoginSifre.Name = "txtLoginSifre";
            txtLoginSifre.Size = new Size(125, 27);
            txtLoginSifre.TabIndex = 8;
            txtLoginSifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(249, 234);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(192, 127);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(125, 27);
            txtEposta.TabIndex = 11;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(192, 177);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 12;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 130);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 13;
            label7.Text = "Eposta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 177);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 14;
            label8.Text = "Şifre";
            // 
            // button2
            // 
            button2.Location = new Point(223, 234);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Kayıt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Loginbox
            // 
            Loginbox.Controls.Add(label5);
            Loginbox.Controls.Add(comboBox1);
            Loginbox.Controls.Add(txtLoginEposta);
            Loginbox.Controls.Add(label3);
            Loginbox.Controls.Add(txtLoginSifre);
            Loginbox.Controls.Add(label4);
            Loginbox.Controls.Add(button1);
            Loginbox.Location = new Point(47, 63);
            Loginbox.Name = "Loginbox";
            Loginbox.Size = new Size(352, 287);
            Loginbox.TabIndex = 16;
            Loginbox.TabStop = false;
            Loginbox.Text = "Giriş Yap";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 60);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 11;
            label5.Text = "Yetki";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Çalışan", "Müşteri" });
            comboBox1.Location = new Point(124, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // signinbox
            // 
            signinbox.Controls.Add(buttontemizle);
            signinbox.Controls.Add(txtAd);
            signinbox.Controls.Add(txtSoyad);
            signinbox.Controls.Add(button2);
            signinbox.Controls.Add(txtEposta);
            signinbox.Controls.Add(label8);
            signinbox.Controls.Add(txtSifre);
            signinbox.Controls.Add(label7);
            signinbox.Controls.Add(label1);
            signinbox.Controls.Add(label2);
            signinbox.Location = new Point(453, 63);
            signinbox.Name = "signinbox";
            signinbox.Size = new Size(349, 287);
            signinbox.TabIndex = 17;
            signinbox.TabStop = false;
            signinbox.Text = "Kayıt Ol";
            // 
            // buttontemizle
            // 
            buttontemizle.Location = new Point(85, 234);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(94, 29);
            buttontemizle.TabIndex = 16;
            buttontemizle.Text = "Temizle";
            buttontemizle.UseVisualStyleBackColor = true;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(296, 19);
            label6.Name = "label6";
            label6.Size = new Size(274, 24);
            label6.TabIndex = 18;
            label6.Text = "Burger Sipariş Sistemi";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 375);
            Controls.Add(label6);
            Controls.Add(signinbox);
            Controls.Add(Loginbox);
            Name = "LoginForm";
            Text = "Form1";
            Loginbox.ResumeLayout(false);
            Loginbox.PerformLayout();
            signinbox.ResumeLayout(false);
            signinbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtLoginEposta;
        private TextBox txtLoginSifre;
        private Button button1;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private Label label7;
        private Label label8;
        private Button button2;
        private GroupBox Loginbox;
        private GroupBox signinbox;
        private Button buttontemizle;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
    }
}
