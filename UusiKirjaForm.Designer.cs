namespace kirjasto
{
    partial class UusiKirjaForm
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
            isbn = new TextBox();
            label3 = new Label();
            kirja = new TextBox();
            label4 = new Label();
            sivut = new TextBox();
            label5 = new Label();
            vuosi = new TextBox();
            label6 = new Label();
            kieli = new TextBox();
            label7 = new Label();
            muoto = new TextBox();
            cmbLuokka = new ComboBox();
            btnHaeLuokat = new Button();
            btnLisääKirja = new Button();
            label8 = new Label();
            label9 = new Label();
            nide = new TextBox();
            label10 = new Label();
            cmbTekijä = new ComboBox();
            btnHaeTekijä = new Button();
            label11 = new Label();
            kpl = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 34);
            label1.Name = "label1";
            label1.Size = new Size(389, 37);
            label1.TabIndex = 0;
            label1.Text = "Lisää uusi kirja tietokantaan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 98);
            label2.Name = "label2";
            label2.Size = new Size(41, 22);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // isbn
            // 
            isbn.Location = new Point(77, 121);
            isbn.Name = "isbn";
            isbn.Size = new Size(157, 27);
            isbn.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 151);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 3;
            label3.Text = "Kirjan nimi";
            // 
            // kirja
            // 
            kirja.Location = new Point(77, 174);
            kirja.Name = "kirja";
            kirja.Size = new Size(205, 27);
            kirja.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 204);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 5;
            label4.Text = "Sivumäärä";
            // 
            // sivut
            // 
            sivut.Location = new Point(77, 227);
            sivut.Name = "sivut";
            sivut.Size = new Size(90, 27);
            sivut.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(77, 257);
            label5.Name = "label5";
            label5.Size = new Size(46, 22);
            label5.TabIndex = 7;
            label5.Text = "Vuosi";
            // 
            // vuosi
            // 
            vuosi.Location = new Point(77, 280);
            vuosi.Name = "vuosi";
            vuosi.Size = new Size(94, 27);
            vuosi.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(331, 98);
            label6.Name = "label6";
            label6.Size = new Size(42, 22);
            label6.TabIndex = 9;
            label6.Text = "Kieli";
            // 
            // kieli
            // 
            kieli.Location = new Point(331, 121);
            kieli.Name = "kieli";
            kieli.Size = new Size(150, 27);
            kieli.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(331, 151);
            label7.Name = "label7";
            label7.Size = new Size(53, 22);
            label7.TabIndex = 11;
            label7.Text = "Muoto";
            // 
            // muoto
            // 
            muoto.Location = new Point(331, 174);
            muoto.Name = "muoto";
            muoto.Size = new Size(163, 27);
            muoto.TabIndex = 12;
            // 
            // cmbLuokka
            // 
            cmbLuokka.FormattingEnabled = true;
            cmbLuokka.Location = new Point(331, 238);
            cmbLuokka.Name = "cmbLuokka";
            cmbLuokka.Size = new Size(244, 28);
            cmbLuokka.TabIndex = 13;
            // 
            // btnHaeLuokat
            // 
            btnHaeLuokat.BackColor = Color.FloralWhite;
            btnHaeLuokat.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHaeLuokat.Location = new Point(593, 238);
            btnHaeLuokat.Name = "btnHaeLuokat";
            btnHaeLuokat.Size = new Size(111, 37);
            btnHaeLuokat.TabIndex = 14;
            btnHaeLuokat.Text = "Hae Luokat";
            btnHaeLuokat.UseVisualStyleBackColor = false;
            btnHaeLuokat.Click += btnHaeLuokat_Click;
            // 
            // btnLisääKirja
            // 
            btnLisääKirja.BackColor = Color.FloralWhite;
            btnLisääKirja.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLisääKirja.Location = new Point(283, 410);
            btnLisääKirja.Name = "btnLisääKirja";
            btnLisääKirja.Size = new Size(205, 52);
            btnLisääKirja.TabIndex = 15;
            btnLisääKirja.Text = "Lisää kirja";
            btnLisääKirja.UseVisualStyleBackColor = false;
            btnLisääKirja.Click += btnLisääKirja_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(331, 215);
            label8.Name = "label8";
            label8.Size = new Size(157, 22);
            label8.TabIndex = 16;
            label8.Text = "Valitse kirjan luokka ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 430);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 17;
            label9.Text = "Nidetunnus";
            label9.Visible = false;
            // 
            // nide
            // 
            nide.Location = new Point(38, 453);
            nide.Name = "nide";
            nide.Size = new Size(166, 27);
            nide.TabIndex = 18;
            nide.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(331, 269);
            label10.Name = "label10";
            label10.Size = new Size(103, 22);
            label10.TabIndex = 19;
            label10.Text = "Valitse tekijä";
            // 
            // cmbTekijä
            // 
            cmbTekijä.FormattingEnabled = true;
            cmbTekijä.Location = new Point(331, 292);
            cmbTekijä.Name = "cmbTekijä";
            cmbTekijä.Size = new Size(216, 28);
            cmbTekijä.TabIndex = 20;
            // 
            // btnHaeTekijä
            // 
            btnHaeTekijä.BackColor = Color.FloralWhite;
            btnHaeTekijä.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHaeTekijä.Location = new Point(591, 281);
            btnHaeTekijä.Name = "btnHaeTekijä";
            btnHaeTekijä.Size = new Size(113, 38);
            btnHaeTekijä.TabIndex = 21;
            btnHaeTekijä.Text = "Hae tekijä";
            btnHaeTekijä.UseVisualStyleBackColor = false;
            btnHaeTekijä.Click += btnHaeTekijä_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(77, 310);
            label11.Name = "label11";
            label11.Size = new Size(85, 22);
            label11.TabIndex = 23;
            label11.Text = "Lukumäärä";
            // 
            // kpl
            // 
            kpl.Location = new Point(77, 333);
            kpl.Name = "kpl";
            kpl.Size = new Size(106, 27);
            kpl.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(399, 344);
            label12.Name = "label12";
            label12.Size = new Size(320, 44);
            label12.TabIndex = 25;
            label12.Text = "Mikäli luokkaa ja tekijää ei löydy listalta,\r\nkäy lisäämässä ne \"Päivitä tietoja\" valikosta";
            // 
            // UusiKirjaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(800, 528);
            Controls.Add(label12);
            Controls.Add(kpl);
            Controls.Add(label11);
            Controls.Add(btnHaeTekijä);
            Controls.Add(cmbTekijä);
            Controls.Add(label10);
            Controls.Add(nide);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnLisääKirja);
            Controls.Add(btnHaeLuokat);
            Controls.Add(cmbLuokka);
            Controls.Add(muoto);
            Controls.Add(label7);
            Controls.Add(kieli);
            Controls.Add(label6);
            Controls.Add(vuosi);
            Controls.Add(label5);
            Controls.Add(sivut);
            Controls.Add(label4);
            Controls.Add(kirja);
            Controls.Add(label3);
            Controls.Add(isbn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UusiKirjaForm";
            Text = "UusiKirjaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox isbn;
        private Label label3;
        private TextBox kirja;
        private Label label4;
        private TextBox sivut;
        private Label label5;
        private TextBox vuosi;
        private Label label6;
        private TextBox kieli;
        private Label label7;
        private TextBox muoto;
        private ComboBox cmbLuokka;
        private Button btnHaeLuokat;
        private Button btnLisääKirja;
        private Label label8;
        private Label label9;
        private TextBox nide;
        private Label label10;
        private ComboBox cmbTekijä;
        private Button btnHaeTekijä;
        private Label label11;
        private TextBox kpl;
        private Label label12;
    }
}