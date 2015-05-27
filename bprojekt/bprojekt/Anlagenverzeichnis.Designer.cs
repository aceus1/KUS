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
            this.anschaffwertbox = new System.Windows.Forms.TextBox();
            this.Zugangbox = new System.Windows.Forms.TextBox();
            this.dauerbox = new System.Windows.Forms.TextBox();
            this.Prozentbox = new System.Windows.Forms.TextBox();
            this.AbgangBox = new System.Windows.Forms.TextBox();
            this.gegenstandbox = new System.Windows.Forms.TextBox();
            this.anschaffdatumbox = new System.Windows.Forms.TextBox();
            this.savebuttonanlage = new System.Windows.Forms.Button();
            this.deletebuttonanlage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteanlagenidbox = new System.Windows.Forms.TextBox();
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
            // anschaffwertbox
            // 
            this.anschaffwertbox.Location = new System.Drawing.Point(607, 234);
            this.anschaffwertbox.Name = "anschaffwertbox";
            this.anschaffwertbox.Size = new System.Drawing.Size(169, 22);
            this.anschaffwertbox.TabIndex = 1;
            this.anschaffwertbox.TextChanged += new System.EventHandler(this.anschaffwertbox_TextChanged);
            // 
            // Zugangbox
            // 
            this.Zugangbox.Location = new System.Drawing.Point(782, 234);
            this.Zugangbox.Name = "Zugangbox";
            this.Zugangbox.Size = new System.Drawing.Size(133, 22);
            this.Zugangbox.TabIndex = 2;
            this.Zugangbox.TextChanged += new System.EventHandler(this.Zugangbox_TextChanged);
            // 
            // dauerbox
            // 
            this.dauerbox.Location = new System.Drawing.Point(921, 234);
            this.dauerbox.Name = "dauerbox";
            this.dauerbox.Size = new System.Drawing.Size(133, 22);
            this.dauerbox.TabIndex = 3;
            this.dauerbox.TextChanged += new System.EventHandler(this.dauerbox_TextChanged);
            // 
            // Prozentbox
            // 
            this.Prozentbox.Location = new System.Drawing.Point(1060, 234);
            this.Prozentbox.Name = "Prozentbox";
            this.Prozentbox.Size = new System.Drawing.Size(133, 22);
            this.Prozentbox.TabIndex = 4;
            this.Prozentbox.TextChanged += new System.EventHandler(this.Prozentbox_TextChanged);
            // 
            // AbgangBox
            // 
            this.AbgangBox.Location = new System.Drawing.Point(1199, 234);
            this.AbgangBox.Name = "AbgangBox";
            this.AbgangBox.Size = new System.Drawing.Size(133, 22);
            this.AbgangBox.TabIndex = 5;
            this.AbgangBox.TextChanged += new System.EventHandler(this.AbangangBox_TextChanged);
            // 
            // gegenstandbox
            // 
            this.gegenstandbox.Location = new System.Drawing.Point(272, 234);
            this.gegenstandbox.Name = "gegenstandbox";
            this.gegenstandbox.Size = new System.Drawing.Size(128, 22);
            this.gegenstandbox.TabIndex = 7;
            this.gegenstandbox.TextChanged += new System.EventHandler(this.gegenstandbox_TextChanged);
            // 
            // anschaffdatumbox
            // 
            this.anschaffdatumbox.Location = new System.Drawing.Point(406, 234);
            this.anschaffdatumbox.Name = "anschaffdatumbox";
            this.anschaffdatumbox.Size = new System.Drawing.Size(195, 22);
            this.anschaffdatumbox.TabIndex = 8;
            this.anschaffdatumbox.TextChanged += new System.EventHandler(this.anschaffdatumbox_TextChanged);
            // 
            // savebuttonanlage
            // 
            this.savebuttonanlage.Location = new System.Drawing.Point(12, 234);
            this.savebuttonanlage.Name = "savebuttonanlage";
            this.savebuttonanlage.Size = new System.Drawing.Size(187, 67);
            this.savebuttonanlage.TabIndex = 10;
            this.savebuttonanlage.Text = "Speichern";
            this.savebuttonanlage.UseVisualStyleBackColor = true;
            this.savebuttonanlage.Click += new System.EventHandler(this.savebuttonanlage_Click);
            // 
            // deletebuttonanlage
            // 
            this.deletebuttonanlage.Location = new System.Drawing.Point(159, 394);
            this.deletebuttonanlage.Name = "deletebuttonanlage";
            this.deletebuttonanlage.Size = new System.Drawing.Size(78, 27);
            this.deletebuttonanlage.TabIndex = 11;
            this.deletebuttonanlage.Text = "Löschen";
            this.deletebuttonanlage.UseVisualStyleBackColor = true;
            this.deletebuttonanlage.Click += new System.EventHandler(this.deletebuttonanlage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "AnlagenverzeichnisID";
            // 
            // deleteanlagenidbox
            // 
            this.deleteanlagenidbox.Location = new System.Drawing.Point(12, 396);
            this.deleteanlagenidbox.Name = "deleteanlagenidbox";
            this.deleteanlagenidbox.Size = new System.Drawing.Size(141, 22);
            this.deleteanlagenidbox.TabIndex = 13;
            // 
            // Anlagenverzeichnis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 426);
            this.Controls.Add(this.deleteanlagenidbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletebuttonanlage);
            this.Controls.Add(this.savebuttonanlage);
            this.Controls.Add(this.anschaffdatumbox);
            this.Controls.Add(this.gegenstandbox);
            this.Controls.Add(this.AbgangBox);
            this.Controls.Add(this.Prozentbox);
            this.Controls.Add(this.dauerbox);
            this.Controls.Add(this.Zugangbox);
            this.Controls.Add(this.anschaffwertbox);
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
        private System.Windows.Forms.TextBox anschaffwertbox;
        private System.Windows.Forms.TextBox Zugangbox;
        private System.Windows.Forms.TextBox dauerbox;
        private System.Windows.Forms.TextBox Prozentbox;
        private System.Windows.Forms.TextBox gegenstandbox;
        private System.Windows.Forms.TextBox anschaffdatumbox;
        private System.Windows.Forms.Button savebuttonanlage;
        private System.Windows.Forms.Button deletebuttonanlage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteanlagenidbox;
        private System.Windows.Forms.TextBox AbgangBox;
    }
}