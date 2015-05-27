namespace bprojekt
{
    partial class Buchungen
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.belegnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustSummeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eADatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buchungenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSDataSet1 = new bprojekt.DBSDataSet1();
            this.buchungenTableAdapter = new bprojekt.DBSDataSet1TableAdapters.BuchungenTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Wert = new System.Windows.Forms.TextBox();
            this.Ust_Summe = new System.Windows.Forms.TextBox();
            this.Re_Datum = new System.Windows.Forms.TextBox();
            this.EA_Datum = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Löschen = new System.Windows.Forms.TextBox();
            this.Löschenbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buchungenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.belegnummerDataGridViewTextBoxColumn,
            this.artDataGridViewTextBoxColumn,
            this.ustDataGridViewTextBoxColumn,
            this.wertDataGridViewTextBoxColumn,
            this.ustSummeDataGridViewTextBoxColumn,
            this.reDatumDataGridViewTextBoxColumn,
            this.eADatumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buchungenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // belegnummerDataGridViewTextBoxColumn
            // 
            this.belegnummerDataGridViewTextBoxColumn.DataPropertyName = "Belegnummer";
            this.belegnummerDataGridViewTextBoxColumn.HeaderText = "Belegnummer";
            this.belegnummerDataGridViewTextBoxColumn.Name = "belegnummerDataGridViewTextBoxColumn";
            // 
            // artDataGridViewTextBoxColumn
            // 
            this.artDataGridViewTextBoxColumn.DataPropertyName = "Art";
            this.artDataGridViewTextBoxColumn.HeaderText = "Art";
            this.artDataGridViewTextBoxColumn.Name = "artDataGridViewTextBoxColumn";
            // 
            // ustDataGridViewTextBoxColumn
            // 
            this.ustDataGridViewTextBoxColumn.DataPropertyName = "Ust";
            this.ustDataGridViewTextBoxColumn.HeaderText = "Ust";
            this.ustDataGridViewTextBoxColumn.Name = "ustDataGridViewTextBoxColumn";
            // 
            // wertDataGridViewTextBoxColumn
            // 
            this.wertDataGridViewTextBoxColumn.DataPropertyName = "Wert";
            this.wertDataGridViewTextBoxColumn.HeaderText = "Wert";
            this.wertDataGridViewTextBoxColumn.Name = "wertDataGridViewTextBoxColumn";
            // 
            // ustSummeDataGridViewTextBoxColumn
            // 
            this.ustSummeDataGridViewTextBoxColumn.DataPropertyName = "Ust-Summe";
            this.ustSummeDataGridViewTextBoxColumn.HeaderText = "Ust-Summe";
            this.ustSummeDataGridViewTextBoxColumn.Name = "ustSummeDataGridViewTextBoxColumn";
            // 
            // reDatumDataGridViewTextBoxColumn
            // 
            this.reDatumDataGridViewTextBoxColumn.DataPropertyName = "Re-Datum";
            this.reDatumDataGridViewTextBoxColumn.HeaderText = "Re-Datum";
            this.reDatumDataGridViewTextBoxColumn.Name = "reDatumDataGridViewTextBoxColumn";
            // 
            // eADatumDataGridViewTextBoxColumn
            // 
            this.eADatumDataGridViewTextBoxColumn.DataPropertyName = "EA-Datum";
            this.eADatumDataGridViewTextBoxColumn.HeaderText = "EA-Datum";
            this.eADatumDataGridViewTextBoxColumn.Name = "eADatumDataGridViewTextBoxColumn";
            // 
            // buchungenBindingSource
            // 
            this.buchungenBindingSource.DataMember = "Buchungen";
            this.buchungenBindingSource.DataSource = this.dBSDataSet1;
            // 
            // dBSDataSet1
            // 
            this.dBSDataSet1.DataSetName = "DBSDataSet1";
            this.dBSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buchungenTableAdapter
            // 
            this.buchungenTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Eing./Ausg.";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Wert
            // 
            this.Wert.Location = new System.Drawing.Point(344, 200);
            this.Wert.Name = "Wert";
            this.Wert.Size = new System.Drawing.Size(100, 20);
            this.Wert.TabIndex = 3;
            this.Wert.Text = "Wert";
            this.Wert.TextChanged += new System.EventHandler(this.Wert_TextChanged);
            // 
            // Ust_Summe
            // 
            this.Ust_Summe.Location = new System.Drawing.Point(445, 200);
            this.Ust_Summe.Name = "Ust_Summe";
            this.Ust_Summe.ReadOnly = true;
            this.Ust_Summe.Size = new System.Drawing.Size(100, 20);
            this.Ust_Summe.TabIndex = 4;
            this.Ust_Summe.Text = "USt Summe";
            this.Ust_Summe.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Re_Datum
            // 
            this.Re_Datum.Location = new System.Drawing.Point(546, 200);
            this.Re_Datum.Name = "Re_Datum";
            this.Re_Datum.Size = new System.Drawing.Size(100, 20);
            this.Re_Datum.TabIndex = 5;
            this.Re_Datum.Text = "Re-Datum";
            this.Re_Datum.TextChanged += new System.EventHandler(this.Re_Datum_TextChanged);
            // 
            // EA_Datum
            // 
            this.EA_Datum.Location = new System.Drawing.Point(647, 200);
            this.EA_Datum.Name = "EA_Datum";
            this.EA_Datum.Size = new System.Drawing.Size(100, 20);
            this.EA_Datum.TabIndex = 6;
            this.EA_Datum.Text = "EA-Datum";
            this.EA_Datum.TextChanged += new System.EventHandler(this.EA_Datum_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(238, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Ust";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Belegnummer zum Löschen";
            // 
            // Löschen
            // 
            this.Löschen.Location = new System.Drawing.Point(15, 259);
            this.Löschen.Name = "Löschen";
            this.Löschen.Size = new System.Drawing.Size(84, 20);
            this.Löschen.TabIndex = 10;
            // 
            // Löschenbutton
            // 
            this.Löschenbutton.Location = new System.Drawing.Point(105, 257);
            this.Löschenbutton.Name = "Löschenbutton";
            this.Löschenbutton.Size = new System.Drawing.Size(75, 23);
            this.Löschenbutton.TabIndex = 11;
            this.Löschenbutton.Text = "Löschen";
            this.Löschenbutton.UseVisualStyleBackColor = true;
            // 
            // Buchungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 291);
            this.Controls.Add(this.Löschenbutton);
            this.Controls.Add(this.Löschen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.EA_Datum);
            this.Controls.Add(this.Re_Datum);
            this.Controls.Add(this.Ust_Summe);
            this.Controls.Add(this.Wert);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Buchungen";
            this.Text = "Buchungen";
            this.Load += new System.EventHandler(this.Buchungen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buchungenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBSDataSet1 dBSDataSet1;
        private System.Windows.Forms.BindingSource buchungenBindingSource;
        private DBSDataSet1TableAdapters.BuchungenTableAdapter buchungenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn belegnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ustDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ustSummeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eADatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Wert;
        private System.Windows.Forms.TextBox Ust_Summe;
        private System.Windows.Forms.TextBox Re_Datum;
        private System.Windows.Forms.TextBox EA_Datum;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Löschen;
        private System.Windows.Forms.Button Löschenbutton;
    }
}