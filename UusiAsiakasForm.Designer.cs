namespace kirjasto
{
    partial class UusiAsiakasForm
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
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            Lisää = new Button();
            txtAsnum = new TextBox();
            label10 = new Label();
            txtSalasana = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(580, 24);
            label1.TabIndex = 0;
            label1.Text = "Napsauta laatikkoa hakeaksesi seuraavan vapaan asiakastunnuksen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 146);
            label2.Name = "label2";
            label2.Size = new Size(207, 24);
            label2.TabIndex = 2;
            label2.Text = "Lisää asiakkaan tiedot:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 189);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 3;
            label3.Text = "Etunimi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(55, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 242);
            label4.Name = "label4";
            label4.Size = new Size(73, 22);
            label4.TabIndex = 5;
            label4.Text = "Sukunimi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 295);
            label5.Name = "label5";
            label5.Size = new Size(83, 22);
            label5.TabIndex = 7;
            label5.Text = "Kotiosoite";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(55, 318);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 27);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 348);
            label6.Name = "label6";
            label6.Size = new Size(97, 22);
            label6.TabIndex = 9;
            label6.Text = "Postinumero";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(55, 371);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 27);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(291, 189);
            label7.Name = "label7";
            label7.Size = new Size(128, 22);
            label7.TabIndex = 11;
            label7.Text = "Postitoimipaikka";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(291, 212);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(140, 27);
            textBox6.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(291, 242);
            label8.Name = "label8";
            label8.Size = new Size(115, 22);
            label8.TabIndex = 13;
            label8.Text = "Puhelinnumero";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(291, 265);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 27);
            textBox7.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(291, 295);
            label9.Name = "label9";
            label9.Size = new Size(87, 22);
            label9.TabIndex = 15;
            label9.Text = "Sähköposti";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(291, 318);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(158, 27);
            textBox8.TabIndex = 16;
            // 
            // Lisää
            // 
            Lisää.BackColor = Color.FloralWhite;
            Lisää.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lisää.Location = new Point(204, 433);
            Lisää.Name = "Lisää";
            Lisää.Size = new Size(189, 45);
            Lisää.TabIndex = 17;
            Lisää.Text = "Lisää uusi asiakas";
            Lisää.UseVisualStyleBackColor = false;
            Lisää.Click += Lisää_Click;
            // 
            // txtAsnum
            // 
            txtAsnum.Location = new Point(54, 100);
            txtAsnum.Name = "txtAsnum";
            txtAsnum.Size = new Size(163, 27);
            txtAsnum.TabIndex = 18;
            txtAsnum.Click += txtAsnum_Click;
            txtAsnum.TextChanged += txtAsnum_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(54, 75);
            label10.Name = "label10";
            label10.Size = new Size(104, 22);
            label10.TabIndex = 19;
            label10.Text = "Asiakastunnus";
            // 
            // txtSalasana
            // 
            txtSalasana.Location = new Point(291, 371);
            txtSalasana.Name = "txtSalasana";
            txtSalasana.Size = new Size(152, 27);
            txtSalasana.TabIndex = 20;
            txtSalasana.TextChanged += textBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(291, 348);
            label11.Name = "label11";
            label11.Size = new Size(68, 22);
            label11.TabIndex = 21;
            label11.Text = "Salasana";
            // 
            // UusiAsiakasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(724, 551);
            Controls.Add(label11);
            Controls.Add(txtSalasana);
            Controls.Add(label10);
            Controls.Add(txtAsnum);
            Controls.Add(Lisää);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UusiAsiakasForm";
            Text = "UusiAsiakas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        //private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Button Lisää;
        private TextBox txtAsnum;
        private Label label10;
        private TextBox txtSalasana;
        private Label label11;
    }
}