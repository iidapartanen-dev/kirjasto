namespace kirjasto
{
    partial class asiakasForm
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
            button1 = new Button();
            button2 = new Button();
            AsHae = new Button();
            btnLainaa = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            valitse = new DataGridViewCheckBoxColumn();
            nide = new DataGridViewTextBoxColumn();
            nimi = new DataGridViewTextBoxColumn();
            kieli = new DataGridViewTextBoxColumn();
            luokka = new DataGridViewTextBoxColumn();
            txtHae = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(46, 453);
            button1.Name = "button1";
            button1.Size = new Size(170, 60);
            button1.TabIndex = 0;
            button1.Text = "Päivitä yhteystiedot";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(46, 352);
            button2.Name = "button2";
            button2.Size = new Size(151, 49);
            button2.TabIndex = 1;
            button2.Text = "Omat lainaukset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AsHae
            // 
            AsHae.BackColor = Color.LemonChiffon;
            AsHae.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AsHae.Location = new Point(930, 181);
            AsHae.Name = "AsHae";
            AsHae.Size = new Size(124, 47);
            AsHae.TabIndex = 2;
            AsHae.Text = "Hae kirjat";
            AsHae.UseVisualStyleBackColor = false;
            AsHae.Click += AsHae_Click;
            // 
            // btnLainaa
            // 
            btnLainaa.BackColor = Color.LemonChiffon;
            btnLainaa.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLainaa.Location = new Point(893, 600);
            btnLainaa.Name = "btnLainaa";
            btnLainaa.Size = new Size(161, 49);
            btnLainaa.TabIndex = 4;
            btnLainaa.Text = "Lainaa valitut";
            btnLainaa.UseVisualStyleBackColor = false;
            btnLainaa.Click += btnLainaa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(504, 145);
            label1.Name = "label1";
            label1.Size = new Size(575, 25);
            label1.TabIndex = 5;
            label1.Text = "Kirjoita hakuun haluamasi kirja tai hae kaikki kirjaston vapaat kirjat:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { valitse, nide, nimi, kieli, luokka });
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(279, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(775, 334);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // valitse
            // 
            valitse.HeaderText = "Valitse";
            valitse.Name = "valitse";
            valitse.Width = 70;
            // 
            // nide
            // 
            nide.HeaderText = "Nide";
            nide.Name = "nide";
            nide.Width = 150;
            // 
            // nimi
            // 
            nimi.HeaderText = "Nimi";
            nimi.Name = "nimi";
            nimi.Width = 250;
            // 
            // kieli
            // 
            kieli.HeaderText = "Kieli";
            kieli.Name = "kieli";
            // 
            // luokka
            // 
            luokka.HeaderText = "Luokka";
            luokka.Name = "luokka";
            // 
            // txtHae
            // 
            txtHae.Location = new Point(715, 191);
            txtHae.Name = "txtHae";
            txtHae.Size = new Size(156, 27);
            txtHae.TabIndex = 7;
            txtHae.TextChanged += txtHae_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 18);
            label2.Name = "label2";
            label2.Size = new Size(480, 65);
            label2.TabIndex = 8;
            label2.Text = "Tervetuloa kirjastoon!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 317);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 9;
            label3.Text = "Tarkista omat lainaukset:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 420);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 10;
            label4.Text = "Päivitä yhteystiedot:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 148);
            label5.Name = "label5";
            label5.Size = new Size(262, 42);
            label5.TabIndex = 11;
            label5.Text = "Mikäli tarvitset apua,\r\nkirjastonhoitajat auttavat mielellään!";
            // 
            // asiakasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1152, 686);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHae);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnLainaa);
            Controls.Add(AsHae);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "asiakasForm";
            Text = "asiakasForm";
            Load += asiakasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button AsHae;
        private Button btnLainaa;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtHae;
        private DataGridViewCheckBoxColumn valitse;
        private DataGridViewTextBoxColumn nide;
        private DataGridViewTextBoxColumn nimi;
        private DataGridViewTextBoxColumn kieli;
        private DataGridViewTextBoxColumn luokka;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}