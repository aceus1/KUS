namespace bprojekt
{
    partial class Anlagenverzeichnis
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
            this.anlagenverzeichnisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gegenstandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anschaffungsdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anschaffungswertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zugangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prozentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abgangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anlagenverzeichnisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSDataSet1 = new bprojekt.DBSDataSet1();
            this.anlagenverzeichnisTableAdapter = new bprojekt.DBSDataSet1TableAdapters.AnlagenverzeichnisTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anlagenverzeichnisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anlagenverzeichnisIDDataGridViewTextBoxColumn,
            this.gegenstandDataGridViewTextBoxColumn,
            this.anschaffungsdatumDataGridViewTextBoxColumn,
            this.anschaffungswertDataGridViewTextBoxColumn,
            this.zugangDataGridViewTextBoxColumn,
            this.dauerDataGridViewTextBoxColumn,
            this.prozentDataGridViewTextBoxColumn,
            this.abgangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.anlagenverzeichnisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1318, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // anlagenverzeichnisIDDataGridViewTextBoxColumn
            // 
            this.anlagenverzeichnisIDDataGridViewTextBoxColumn.DataPropertyName = "AnlagenverzeichnisID";
            this.anlagenverzeichnisIDDataGridViewTextBoxColumn.HeaderText = "AnlagenverzeichnisID";
            this.anlagenverzeichnisIDDataGridViewTextBoxColumn.Name = "anlagenverzeichnisIDDataGridViewTextBoxColumn";
            this.anlagenverzeichnisIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // gegenstandDataGridViewTextBoxColumn
            // 
            this.gegenstandDataGridViewTextBoxColumn.DataPropertyName = "Gegenstand";
            this.gegenstandDataGridViewTextBoxColumn.HeaderText = "Gegenstand";
            this.gegenstandDataGridViewTextBoxColumn.Name = "gegenstandDataGridViewTextBoxColumn";
            // 
            // anschaffungsdatumDataGridViewTextBoxColumn
            // 
            this.anschaffungsdatumDataGridViewTextBoxColumn.DataPropertyName = "Anschaffungsdatum";
            this.anschaffungsdatumDataGridViewTextBoxColumn.HeaderText = "Anschaffungsdatum";
            this.anschaffungsdatumDataGridViewTextBoxColumn.Name = "anschaffungsdatumDataGridViewTextBoxColumn";
            this.anschaffungsdatumDataGridViewTextBoxColumn.Width = 150;
            // 
            // anschaffungswertDataGridViewTextBoxColumn
            // 
            this.anschaffungswertDataGridViewTextBoxColumn.DataPropertyName = "Anschaffungswert";
            this.anschaffungswertDataGridViewTextBoxColumn.HeaderText = "Anschaffungswert";
            this.anschaffungswertDataGridViewTextBoxColumn.Name = "anschaffungswertDataGridViewTextBoxColumn";
            this.anschaffungswertDataGridViewTextBoxColumn.Width = 135;
            // 
            // zugangDataGridViewTextBoxColumn
            // 
            this.zugangDataGridViewTextBoxColumn.DataPropertyName = "Zugang";
            this.zugangDataGridViewTextBoxColumn.HeaderText = "Zugang";
            this.zugangDataGridViewTextBoxColumn.Name = "zugangDataGridViewTextBoxColumn";
            // 
            // dauerDataGridViewTextBoxColumn
            // 
            this.dauerDataGridViewTextBoxColumn.DataPropertyName = "Dauer";
            this.dauerDataGridViewTextBoxColumn.HeaderText = "Dauer";
            this.dauerDataGridViewTextBoxColumn.Name = "dauerDataGridViewTextBoxColumn";
            // 
            // prozentDataGridViewTextBoxColumn
            // 
            this.prozentDataGridViewTextBoxColumn.DataPropertyName = "Prozent";
            this.prozentDataGridViewTextBoxColumn.HeaderText = "Prozent";
            this.prozentDataGridViewTextBoxColumn.Name = "prozentDataGridViewTextBoxColumn";
            // 
            // abgangDataGridViewTextBoxColumn
            // 
            this.abgangDataGridViewTextBoxColumn.DataPropertyName = "Abgang";
            this.abgangDataGridViewTextBoxColumn.HeaderText = "Abgang";
            this.abgangDataGridViewTextBoxColumn.Name = "abgangDataGridViewTextBoxColumn";
            // 
            // anlagenverzeichnisBindingSource
            // 
            this.anlagenverzeichnisBindingSource.DataMember = "Anlagenverzeichnis";
            this.anlagenverzeichnisBindingSource.DataSource = this.dBSDataSet1;
            // 
            // dBSDataSet1
            // 
            this.dBSDataSet1.DataSetName = "DBSDataSet1";
            this.dBSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anlagenverzeichnisTableAdapter
            // 
            this.anlagenverzeichnisTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(805, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(911, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1017, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1123, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1229, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 5;
            // 
            // Anlagenverzeichnis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 426);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Anlagenverzeichnis";
            this.Text = "Anlagenverzeichnis";
            this.Load += new System.EventHandler(this.Anlagenverzeichnis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anlagenverzeichnisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBSDataSet1 dBSDataSet1;
        private System.Windows.Forms.BindingSource anlagenverzeichnisBindingSource;
        private DBSDataSet1TableAdapters.AnlagenverzeichnisTableAdapter anlagenverzeichnisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn anlagenverzeichnisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gegenstandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anschaffungsdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anschaffungswertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zugangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prozentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abgangDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}