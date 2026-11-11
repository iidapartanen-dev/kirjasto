namespace kirjasto
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
            label2 = new Label();
            AsKirjaudu = new Button();
            KhKirjaudu = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            LuoYhteys = new Button();
            katkaise = new Button();
            txtTunnus = new TextBox();
            txtSalasana = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnKirjaudu = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 32);
            label1.Name = "label1";
            label1.Size = new Size(332, 40);
            label1.TabIndex = 0;
            label1.Text = "Tervetuloa kirjastoon!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(298, 378);
            label2.Name = "label2";
            label2.Size = new Size(162, 27);
            label2.TabIndex = 1;
            label2.Text = "Kirjaudu sisään:";
            // 
            // AsKirjaudu
            // 
            AsKirjaudu.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AsKirjaudu.Location = new Point(12, 586);
            AsKirjaudu.Name = "AsKirjaudu";
            AsKirjaudu.Size = new Size(105, 42);
            AsKirjaudu.TabIndex = 2;
            AsKirjaudu.Text = "Asiakas";
            AsKirjaudu.UseVisualStyleBackColor = true;
            AsKirjaudu.Visible = false;
            AsKirjaudu.Click += button1_Click;
            // 
            // KhKirjaudu
            // 
            KhKirjaudu.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KhKirjaudu.Location = new Point(137, 586);
            KhKirjaudu.Name = "KhKirjaudu";
            KhKirjaudu.Size = new Size(148, 42);
            KhKirjaudu.TabIndex = 3;
            KhKirjaudu.Text = "Kirjastonhoitaja";
            KhKirjaudu.UseVisualStyleBackColor = true;
            KhKirjaudu.Visible = false;
            KhKirjaudu.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 144);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 4;
            label3.Text = "Palvelin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "localhost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(189, 207);
            label4.Name = "label4";
            label4.Size = new Size(131, 22);
            label4.TabIndex = 6;
            label4.Text = "Tietokannan nimi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 27);
            textBox2.TabIndex = 7;
            textBox2.Text = "kirjasto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(456, 144);
            label5.Name = "label5";
            label5.Size = new Size(113, 22);
            label5.TabIndex = 8;
            label5.Text = "Käyttäjätunnus";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(415, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 27);
            textBox3.TabIndex = 9;
            textBox3.Text = "root";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(495, 207);
            label6.Name = "label6";
            label6.Size = new Size(68, 22);
            label6.TabIndex = 10;
            label6.Text = "Salasana";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(415, 230);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(147, 27);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // LuoYhteys
            // 
            LuoYhteys.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LuoYhteys.Location = new Point(243, 283);
            LuoYhteys.Name = "LuoYhteys";
            LuoYhteys.Size = new Size(129, 43);
            LuoYhteys.TabIndex = 12;
            LuoYhteys.Text = "Luo yhteys";
            LuoYhteys.UseVisualStyleBackColor = true;
            LuoYhteys.Click += LuoYhteys_Click;
            // 
            // katkaise
            // 
            katkaise.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            katkaise.Location = new Point(395, 283);
            katkaise.Name = "katkaise";
            katkaise.Size = new Size(146, 43);
            katkaise.TabIndex = 13;
            katkaise.Text = "Katkaise yhteys";
            katkaise.UseVisualStyleBackColor = true;
            katkaise.Click += katkaise_Click;
            // 
            // txtTunnus
            // 
            txtTunnus.Location = new Point(189, 444);
            txtTunnus.Name = "txtTunnus";
            txtTunnus.Size = new Size(165, 27);
            txtTunnus.TabIndex = 14;
            // 
            // txtSalasana
            // 
            txtSalasana.Location = new Point(421, 444);
            txtSalasana.Name = "txtSalasana";
            txtSalasana.PasswordChar = '*';
            txtSalasana.Size = new Size(141, 27);
            txtSalasana.TabIndex = 15;
            txtSalasana.TextChanged += txtSalasana_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(189, 421);
            label7.Name = "label7";
            label7.Size = new Size(113, 22);
            label7.TabIndex = 16;
            label7.Text = "Käyttäjätunnus";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(494, 419);
            label8.Name = "label8";
            label8.Size = new Size(68, 22);
            label8.TabIndex = 17;
            label8.Text = "Salasana";
            // 
            // btnKirjaudu
            // 
            btnKirjaudu.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKirjaudu.Location = new Point(317, 491);
            btnKirjaudu.Name = "btnKirjaudu";
            btnKirjaudu.Size = new Size(143, 37);
            btnKirjaudu.TabIndex = 18;
            btnKirjaudu.Text = "Kirjaudu";
            btnKirjaudu.UseVisualStyleBackColor = true;
            btnKirjaudu.Click += btnKirjaudu_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(98, 94);
            label9.Name = "label9";
            label9.Size = new Size(600, 20);
            label9.TabIndex = 19;
            label9.Text = "Luo ensin yhteys tietokantaan ja sen jälkeen kirjaudu käyttäjätunnuksella ja salasanalla";
            label9.Click += label9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 650);
            Controls.Add(label9);
            Controls.Add(btnKirjaudu);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtSalasana);
            Controls.Add(txtTunnus);
            Controls.Add(katkaise);
            Controls.Add(LuoYhteys);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(KhKirjaudu);
            Controls.Add(AsKirjaudu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button AsKirjaudu;
        private Button KhKirjaudu;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Button LuoYhteys;
        private Button katkaise;
        private TextBox txtTunnus;
        private TextBox txtSalasana;
        private Label label7;
        private Label label8;
        private Button btnKirjaudu;
        private Label label9;
    }
}
