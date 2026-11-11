namespace kirjasto
{
    partial class khForm
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
            khUusiKirja = new Button();
            button2 = new Button();
            KhHaeKirja = new Button();
            listBox1 = new ListBox();
            KhValitse = new Button();
            label1 = new Label();
            KhUusiAsiakas = new Button();
            btnRaportit = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // khUusiKirja
            // 
            khUusiKirja.BackColor = Color.FloralWhite;
            khUusiKirja.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            khUusiKirja.Location = new Point(35, 236);
            khUusiKirja.Name = "khUusiKirja";
            khUusiKirja.Size = new Size(131, 42);
            khUusiKirja.TabIndex = 0;
            khUusiKirja.Text = "Lisää uusi kirja";
            khUusiKirja.UseVisualStyleBackColor = false;
            khUusiKirja.Click += khUusiKirja_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FloralWhite;
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(35, 297);
            button2.Name = "button2";
            button2.Size = new Size(127, 43);
            button2.TabIndex = 1;
            button2.Text = "Päivitä tietoja";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // KhHaeKirja
            // 
            KhHaeKirja.BackColor = Color.FloralWhite;
            KhHaeKirja.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KhHaeKirja.Location = new Point(646, 128);
            KhHaeKirja.Name = "KhHaeKirja";
            KhHaeKirja.Size = new Size(128, 41);
            KhHaeKirja.TabIndex = 2;
            KhHaeKirja.Text = "Hae kirjat";
            KhHaeKirja.UseVisualStyleBackColor = false;
            KhHaeKirja.Click += KhHaeKirja_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(188, 175);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(586, 284);
            listBox1.TabIndex = 3;
            // 
            // KhValitse
            // 
            KhValitse.BackColor = Color.OldLace;
            KhValitse.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KhValitse.Location = new Point(639, 465);
            KhValitse.Name = "KhValitse";
            KhValitse.Size = new Size(135, 40);
            KhValitse.TabIndex = 4;
            KhValitse.Text = "Valitse";
            KhValitse.UseVisualStyleBackColor = false;
            KhValitse.Click += KhValitse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 48);
            label1.Name = "label1";
            label1.Size = new Size(280, 29);
            label1.TabIndex = 5;
            label1.Text = "Kirjastonhoitajan työtila";
            // 
            // KhUusiAsiakas
            // 
            KhUusiAsiakas.BackColor = Color.FloralWhite;
            KhUusiAsiakas.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KhUusiAsiakas.Location = new Point(35, 175);
            KhUusiAsiakas.Name = "KhUusiAsiakas";
            KhUusiAsiakas.Size = new Size(108, 42);
            KhUusiAsiakas.TabIndex = 6;
            KhUusiAsiakas.Text = "Luo asiakas";
            KhUusiAsiakas.UseVisualStyleBackColor = false;
            KhUusiAsiakas.Click += KhUusiAsiakas_Click;
            // 
            // btnRaportit
            // 
            btnRaportit.BackColor = Color.FloralWhite;
            btnRaportit.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaportit.Location = new Point(35, 360);
            btnRaportit.Name = "btnRaportit";
            btnRaportit.Size = new Size(108, 32);
            btnRaportit.TabIndex = 7;
            btnRaportit.Text = "Raportit";
            btnRaportit.UseVisualStyleBackColor = false;
            btnRaportit.Click += btnRaportit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(199, 137);
            label2.Name = "label2";
            label2.Size = new Size(428, 22);
            label2.TabIndex = 8;
            label2.Text = "Tähän voit hakea kaikki kirjaston kirjat ja tarkistella niitä:";
            // 
            // khForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 576);
            Controls.Add(label2);
            Controls.Add(btnRaportit);
            Controls.Add(KhUusiAsiakas);
            Controls.Add(label1);
            Controls.Add(KhValitse);
            Controls.Add(listBox1);
            Controls.Add(KhHaeKirja);
            Controls.Add(button2);
            Controls.Add(khUusiKirja);
            Name = "khForm";
            Text = "khForm";
            Load += khForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button khUusiKirja;
        private Button button2;
        private Button KhHaeKirja;
        private ListBox listBox1;
        private Button KhValitse;
        private Label label1;
        private Button KhUusiAsiakas;
        private Button btnRaportit;
        private Label label2;
    }
}