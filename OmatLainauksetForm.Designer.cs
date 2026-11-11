namespace kirjasto
{
    partial class OmatLainauksetForm
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
            btnHaeLainat = new Button();
            dataGridView1 = new DataGridView();
            valitse = new DataGridViewCheckBoxColumn();
            nide = new DataGridViewTextBoxColumn();
            nimi = new DataGridViewTextBoxColumn();
            palpvm = new DataGridViewTextBoxColumn();
            btnPalauta = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnHaeLainat
            // 
            btnHaeLainat.BackColor = Color.LemonChiffon;
            btnHaeLainat.Location = new Point(635, 176);
            btnHaeLainat.Name = "btnHaeLainat";
            btnHaeLainat.Size = new Size(169, 50);
            btnHaeLainat.TabIndex = 0;
            btnHaeLainat.Text = "Hae lainaukset";
            btnHaeLainat.UseVisualStyleBackColor = false;
            btnHaeLainat.Click += btnHaeLainat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { valitse, nide, nimi, palpvm });
            dataGridView1.Location = new Point(120, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(684, 231);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // valitse
            // 
            valitse.HeaderText = "Valitse";
            valitse.Name = "valitse";
            valitse.Width = 80;
            // 
            // nide
            // 
            nide.HeaderText = "Nide";
            nide.Name = "nide";
            nide.Width = 170;
            // 
            // nimi
            // 
            nimi.HeaderText = "Nimi";
            nimi.Name = "nimi";
            nimi.Width = 270;
            // 
            // palpvm
            // 
            palpvm.HeaderText = "Palautuspäivä";
            palpvm.Name = "palpvm";
            palpvm.Width = 120;
            // 
            // btnPalauta
            // 
            btnPalauta.BackColor = Color.LemonChiffon;
            btnPalauta.Location = new Point(592, 505);
            btnPalauta.Name = "btnPalauta";
            btnPalauta.Size = new Size(212, 42);
            btnPalauta.TabIndex = 2;
            btnPalauta.Text = "Palauta valitut";
            btnPalauta.UseVisualStyleBackColor = false;
            btnPalauta.Click += btnPalauta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 30);
            label1.Name = "label1";
            label1.Size = new Size(251, 40);
            label1.TabIndex = 3;
            label1.Text = "Omat lainaukset";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 89);
            label2.Name = "label2";
            label2.Size = new Size(358, 66);
            label2.TabIndex = 4;
            label2.Text = "Hae listalle tällä hetkellä sinulla olevat lainaukset\r\nPalauta valitsemalla kirja listasta ja napsauta\r\n\"Palauta valitut\"";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // OmatLainauksetForm
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(940, 623);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPalauta);
            Controls.Add(dataGridView1);
            Controls.Add(btnHaeLainat);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "OmatLainauksetForm";
            Text = "OmatLainauksetForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHaeLainat;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn valitse;
        private DataGridViewTextBoxColumn nide;
        private DataGridViewTextBoxColumn nimi;
        private DataGridViewTextBoxColumn palpvm;
        private Button btnPalauta;
        private Label label1;
        private Label label2;
    }
}