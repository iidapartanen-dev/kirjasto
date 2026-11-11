namespace kirjasto
{
    partial class YhteystiedotForm
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnPaivita = new Button();
            txtEnimi = new TextBox();
            txtSnimi = new TextBox();
            txtKoso = new TextBox();
            txtPno = new TextBox();
            txtPtp = new TextBox();
            txtPuh = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 38);
            label1.Name = "label1";
            label1.Size = new Size(445, 54);
            label1.TabIndex = 0;
            label1.Text = "Täällä voit päivittää yhteystietosi ajantasalle\r\nJärjestelmä hakee tämänhetkiset yhteystietosi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 134);
            label2.Name = "label2";
            label2.Size = new Size(64, 22);
            label2.TabIndex = 1;
            label2.Text = "Etunimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 196);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 2;
            label3.Text = "Sukunimi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 263);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 3;
            label4.Text = "Kotiosoite";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 334);
            label5.Name = "label5";
            label5.Size = new Size(97, 22);
            label5.TabIndex = 4;
            label5.Text = "Postinumero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 411);
            label6.Name = "label6";
            label6.Size = new Size(128, 22);
            label6.TabIndex = 5;
            label6.Text = "Postitoimipaikka";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(379, 196);
            label7.Name = "label7";
            label7.Size = new Size(115, 22);
            label7.TabIndex = 6;
            label7.Text = "Puhelinnumero";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(379, 263);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 7;
            label8.Text = "Sähköposti";
            // 
            // btnPaivita
            // 
            btnPaivita.BackColor = Color.LemonChiffon;
            btnPaivita.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaivita.Location = new Point(431, 451);
            btnPaivita.Name = "btnPaivita";
            btnPaivita.Size = new Size(149, 44);
            btnPaivita.TabIndex = 8;
            btnPaivita.Text = "Päivitä";
            btnPaivita.UseVisualStyleBackColor = false;
            btnPaivita.Click += btnPaivita_Click;
            // 
            // txtEnimi
            // 
            txtEnimi.Location = new Point(64, 160);
            txtEnimi.Name = "txtEnimi";
            txtEnimi.Size = new Size(230, 27);
            txtEnimi.TabIndex = 9;
            // 
            // txtSnimi
            // 
            txtSnimi.Location = new Point(64, 221);
            txtSnimi.Name = "txtSnimi";
            txtSnimi.Size = new Size(230, 27);
            txtSnimi.TabIndex = 10;
            // 
            // txtKoso
            // 
            txtKoso.Location = new Point(64, 288);
            txtKoso.Name = "txtKoso";
            txtKoso.Size = new Size(230, 27);
            txtKoso.TabIndex = 11;
            // 
            // txtPno
            // 
            txtPno.Location = new Point(65, 359);
            txtPno.Name = "txtPno";
            txtPno.Size = new Size(229, 27);
            txtPno.TabIndex = 12;
            // 
            // txtPtp
            // 
            txtPtp.Location = new Point(65, 436);
            txtPtp.Name = "txtPtp";
            txtPtp.Size = new Size(229, 27);
            txtPtp.TabIndex = 13;
            // 
            // txtPuh
            // 
            txtPuh.Location = new Point(381, 221);
            txtPuh.Name = "txtPuh";
            txtPuh.Size = new Size(232, 27);
            txtPuh.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(379, 288);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 27);
            txtEmail.TabIndex = 15;
            // 
            // YhteystiedotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 565);
            Controls.Add(txtEmail);
            Controls.Add(txtPuh);
            Controls.Add(txtPtp);
            Controls.Add(txtPno);
            Controls.Add(txtKoso);
            Controls.Add(txtSnimi);
            Controls.Add(txtEnimi);
            Controls.Add(btnPaivita);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YhteystiedotForm";
            Text = "YhteystiedotForm";
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
        private Button btnPaivita;
        private TextBox txtEnimi;
        private TextBox txtSnimi;
        private TextBox txtKoso;
        private TextBox txtPno;
        private TextBox txtPtp;
        private TextBox txtPuh;
        private TextBox txtEmail;
    }
}