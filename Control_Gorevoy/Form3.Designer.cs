namespace Control_Gorevoy
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yacht_YardDataSet1 = new Control_Gorevoy.Yacht_YardDataSet1();
            this.boatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boatTableAdapter = new Control_Gorevoy.Yacht_YardDataSet1TableAdapters.BoatTableAdapter();
            this.boatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfRowersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yacht_YardDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Окно лодок";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boatIDDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.boatTypeDataGridViewTextBoxColumn,
            this.numberOfRowersDataGridViewTextBoxColumn,
            this.mastDataGridViewCheckBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.woodDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 316);
            this.dataGridView1.TabIndex = 4;
            // 
            // yacht_YardDataSet1
            // 
            this.yacht_YardDataSet1.DataSetName = "Yacht_YardDataSet1";
            this.yacht_YardDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boatBindingSource
            // 
            this.boatBindingSource.DataMember = "Boat";
            this.boatBindingSource.DataSource = this.yacht_YardDataSet1;
            // 
            // boatTableAdapter
            // 
            this.boatTableAdapter.ClearBeforeFill = true;
            // 
            // boatIDDataGridViewTextBoxColumn
            // 
            this.boatIDDataGridViewTextBoxColumn.DataPropertyName = "boat_ID";
            this.boatIDDataGridViewTextBoxColumn.HeaderText = "boat_ID";
            this.boatIDDataGridViewTextBoxColumn.Name = "boatIDDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // boatTypeDataGridViewTextBoxColumn
            // 
            this.boatTypeDataGridViewTextBoxColumn.DataPropertyName = "BoatType";
            this.boatTypeDataGridViewTextBoxColumn.HeaderText = "BoatType";
            this.boatTypeDataGridViewTextBoxColumn.Name = "boatTypeDataGridViewTextBoxColumn";
            // 
            // numberOfRowersDataGridViewTextBoxColumn
            // 
            this.numberOfRowersDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRowers";
            this.numberOfRowersDataGridViewTextBoxColumn.HeaderText = "NumberOfRowers";
            this.numberOfRowersDataGridViewTextBoxColumn.Name = "numberOfRowersDataGridViewTextBoxColumn";
            // 
            // mastDataGridViewCheckBoxColumn
            // 
            this.mastDataGridViewCheckBoxColumn.DataPropertyName = "Mast";
            this.mastDataGridViewCheckBoxColumn.HeaderText = "Mast";
            this.mastDataGridViewCheckBoxColumn.Name = "mastDataGridViewCheckBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            // 
            // woodDataGridViewTextBoxColumn
            // 
            this.woodDataGridViewTextBoxColumn.DataPropertyName = "Wood";
            this.woodDataGridViewTextBoxColumn.HeaderText = "Wood";
            this.woodDataGridViewTextBoxColumn.Name = "woodDataGridViewTextBoxColumn";
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            this.basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.HeaderText = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Меню лодок";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yacht_YardDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Yacht_YardDataSet1 yacht_YardDataSet1;
        private System.Windows.Forms.BindingSource boatBindingSource;
        private Yacht_YardDataSet1TableAdapters.BoatTableAdapter boatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRowersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mastDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn woodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
    }
}