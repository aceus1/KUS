namespace bprojekt
{
    partial class Fahrtbuch
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
            this.savebutton = new System.Windows.Forms.Button();
            this.endkmtb = new System.Windows.Forms.TextBox();
            this.ankmtb = new System.Windows.Forms.TextBox();
            this.Zielorttb = new System.Windows.Forms.TextBox();
            this.Abfahrtsorttb = new System.Windows.Forms.TextBox();
            this.Datumtb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fahrtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtsortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zielortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anfangskmstandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endkmstandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbsDataSet11 = new bprojekt.DBSDataSet1();
            this.fahrtenbuchTableAdapter = new bprojekt.DBSDataSet1TableAdapters.FahrtenbuchTableAdapter();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(16, 207);
            this.savebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(152, 44);
            this.savebutton.TabIndex = 1;
            this.savebutton.Text = "Speichern";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // endkmtb
            // 
            this.endkmtb.Location = new System.Drawing.Point(755, 207);
            this.endkmtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endkmtb.Name = "endkmtb";
            this.endkmtb.Size = new System.Drawing.Size(132, 22);
            this.endkmtb.TabIndex = 2;
            this.endkmtb.Text = "Endkmstand";
            this.endkmtb.TextChanged += new System.EventHandler(this.endkmtb_TextChanged);
            // 
            // ankmtb
            // 
            this.ankmtb.Location = new System.Drawing.Point(613, 207);
            this.ankmtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ankmtb.Name = "ankmtb";
            this.ankmtb.Size = new System.Drawing.Size(132, 22);
            this.ankmtb.TabIndex = 3;
            this.ankmtb.Text = "Anfangskmstand";
            this.ankmtb.TextChanged += new System.EventHandler(this.ankmtb_TextChanged);
            // 
            // Zielorttb
            // 
            this.Zielorttb.Location = new System.Drawing.Point(472, 207);
            this.Zielorttb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zielorttb.Name = "Zielorttb";
            this.Zielorttb.Size = new System.Drawing.Size(132, 22);
            this.Zielorttb.TabIndex = 4;
            this.Zielorttb.Text = "Zielort";
            this.Zielorttb.TextChanged += new System.EventHandler(this.Zielorttb_TextChanged);
            // 
            // Abfahrtsorttb
            // 
            this.Abfahrtsorttb.Location = new System.Drawing.Point(331, 207);
            this.Abfahrtsorttb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Abfahrtsorttb.Name = "Abfahrtsorttb";
            this.Abfahrtsorttb.Size = new System.Drawing.Size(132, 22);
            this.Abfahrtsorttb.TabIndex = 5;
            this.Abfahrtsorttb.Text = "Abfahrtsort";
            this.Abfahrtsorttb.TextChanged += new System.EventHandler(this.Abfahrtsorttb_TextChanged);
            // 
            // Datumtb
            // 
            this.Datumtb.Location = new System.Drawing.Point(189, 207);
            this.Datumtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Datumtb.Name = "Datumtb";
            this.Datumtb.Size = new System.Drawing.Size(132, 22);
            this.Datumtb.TabIndex = 6;
            this.Datumtb.Text = "Datum";
            this.Datumtb.TextChanged += new System.EventHandler(this.Datumtb_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fahrtIDDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.abfahrtsortDataGridViewTextBoxColumn,
            this.zielortDataGridViewTextBoxColumn,
            this.anfangskmstandDataGridViewTextBoxColumn,
            this.endkmstandDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(872, 185);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fahrtIDDataGridViewTextBoxColumn
            // 
            this.fahrtIDDataGridViewTextBoxColumn.DataPropertyName = "FahrtID";
            this.fahrtIDDataGridViewTextBoxColumn.HeaderText = "FahrtID";
            this.fahrtIDDataGridViewTextBoxColumn.Name = "fahrtIDDataGridViewTextBoxColumn";
            this.fahrtIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abfahrtsortDataGridViewTextBoxColumn
            // 
            this.abfahrtsortDataGridViewTextBoxColumn.DataPropertyName = "Abfahrtsort";
            this.abfahrtsortDataGridViewTextBoxColumn.HeaderText = "Abfahrtsort";
            this.abfahrtsortDataGridViewTextBoxColumn.Name = "abfahrtsortDataGridViewTextBoxColumn";
            this.abfahrtsortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zielortDataGridViewTextBoxColumn
            // 
            this.zielortDataGridViewTextBoxColumn.DataPropertyName = "Zielort";
            this.zielortDataGridViewTextBoxColumn.HeaderText = "Zielort";
            this.zielortDataGridViewTextBoxColumn.Name = "zielortDataGridViewTextBoxColumn";
            this.zielortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anfangskmstandDataGridViewTextBoxColumn
            // 
            this.anfangskmstandDataGridViewTextBoxColumn.DataPropertyName = "Anfangskmstand";
            this.anfangskmstandDataGridViewTextBoxColumn.HeaderText = "Anfangskmstand";
            this.anfangskmstandDataGridViewTextBoxColumn.Name = "anfangskmstandDataGridViewTextBoxColumn";
            this.anfangskmstandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endkmstandDataGridViewTextBoxColumn
            // 
            this.endkmstandDataGridViewTextBoxColumn.DataPropertyName = "Endkmstand";
            this.endkmstandDataGridViewTextBoxColumn.HeaderText = "Endkmstand";
            this.endkmstandDataGridViewTextBoxColumn.Name = "endkmstandDataGridViewTextBoxColumn";
            this.endkmstandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Fahrtenbuch";
            this.bindingSource1.DataSource = this.dbsDataSet11;
            // 
            // dbsDataSet11
            // 
            this.dbsDataSet11.DataSetName = "DBSDataSet1";
            this.dbsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fahrtenbuchTableAdapter
            // 
            this.fahrtenbuchTableAdapter.ClearBeforeFill = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // DeleteID
            // 
            this.DeleteID.Location = new System.Drawing.Point(13, 313);
            this.DeleteID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(100, 22);
            this.DeleteID.TabIndex = 9;
            this.DeleteID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID zum Löschen";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fahrtbuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Datumtb);
            this.Controls.Add(this.Abfahrtsorttb);
            this.Controls.Add(this.Zielorttb);
            this.Controls.Add(this.ankmtb);
            this.Controls.Add(this.endkmtb);
            this.Controls.Add(this.savebutton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fahrtbuch";
            this.Text = "Fahrtbuch";
            this.Load += new System.EventHandler(this.Fahrtbuch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox endkmtb;
        private System.Windows.Forms.TextBox ankmtb;
        private System.Windows.Forms.TextBox Zielorttb;
        private System.Windows.Forms.TextBox Abfahrtsorttb;
        private System.Windows.Forms.TextBox Datumtb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBSDataSet1 dbsDataSet11;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DBSDataSet1TableAdapters.FahrtenbuchTableAdapter fahrtenbuchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fahrtIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtsortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zielortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anfangskmstandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endkmstandDataGridViewTextBoxColumn;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}