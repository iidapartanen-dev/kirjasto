namespace kirjasto
{
    partial class Raportit
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
            dataGridView1 = new DataGridView();
            cmbRaportit = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FloralWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(329, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(505, 265);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbRaportit
            // 
            cmbRaportit.FormattingEnabled = true;
            cmbRaportit.Items.AddRange(new object[] { "Suosituimmat kirjat", "Ei koskaan lainattu", "Asiakkaat ja lainojen määrä", "Asiakkaat jotka eivät ole lainanneet", "Myöhässä olevat kirjat" });
            cmbRaportit.Location = new Point(31, 187);
            cmbRaportit.Name = "cmbRaportit";
            cmbRaportit.Size = new Size(220, 28);
            cmbRaportit.TabIndex = 1;
            cmbRaportit.SelectedIndexChanged += cmbRaportit_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(452, 27);
            label1.Name = "label1";
            label1.Size = new Size(265, 40);
            label1.TabIndex = 2;
            label1.Text = "Kirjaston raportit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 162);
            label2.Name = "label2";
            label2.Size = new Size(319, 22);
            label2.TabIndex = 3;
            label2.Text = "Valitse listalta raportti, jonka haluat hakea:";
            // 
            // Raportit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(889, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbRaportit);
            Controls.Add(dataGridView1);
            Name = "Raportit";
            Text = "Raportit";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbRaportit;
        private Label label1;
        private Label label2;
    }
}