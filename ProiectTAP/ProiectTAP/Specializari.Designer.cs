
namespace ProiectTAP
{
    partial class Specializari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Specializari));
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denumireSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrAniStudiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaAnualaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProiectTAP.DataSet1();
            this.specializariTableAdapter = new ProiectTAP.DataSet1TableAdapters.SpecializariTableAdapter();
            this.btnSelectie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizare
            // 
            this.btnActualizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizare.Location = new System.Drawing.Point(87, 47);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(109, 26);
            this.btnActualizare.TabIndex = 2;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(202, 47);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(109, 26);
            this.btnSalvare.TabIndex = 3;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenuntare.Location = new System.Drawing.Point(317, 47);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(109, 26);
            this.btnRenuntare.TabIndex = 4;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireSpecializareDataGridViewTextBoxColumn,
            this.nrAniStudiuDataGridViewTextBoxColumn,
            this.taxaAnualaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specializariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 204);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // denumireSpecializareDataGridViewTextBoxColumn
            // 
            this.denumireSpecializareDataGridViewTextBoxColumn.DataPropertyName = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.HeaderText = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.Name = "denumireSpecializareDataGridViewTextBoxColumn";
            // 
            // nrAniStudiuDataGridViewTextBoxColumn
            // 
            this.nrAniStudiuDataGridViewTextBoxColumn.DataPropertyName = "NrAniStudiu";
            this.nrAniStudiuDataGridViewTextBoxColumn.HeaderText = "NrAniStudiu";
            this.nrAniStudiuDataGridViewTextBoxColumn.Name = "nrAniStudiuDataGridViewTextBoxColumn";
            // 
            // taxaAnualaDataGridViewTextBoxColumn
            // 
            this.taxaAnualaDataGridViewTextBoxColumn.DataPropertyName = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn.HeaderText = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn.Name = "taxaAnualaDataGridViewTextBoxColumn";
            // 
            // specializariBindingSource
            // 
            this.specializariBindingSource.DataMember = "Specializari";
            this.specializariBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // btnSelectie
            // 
            this.btnSelectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectie.Location = new System.Drawing.Point(202, 307);
            this.btnSelectie.Name = "btnSelectie";
            this.btnSelectie.Size = new System.Drawing.Size(109, 26);
            this.btnSelectie.TabIndex = 6;
            this.btnSelectie.Text = "Selectie";
            this.btnSelectie.UseVisualStyleBackColor = true;
            this.btnSelectie.Click += new System.EventHandler(this.btnSelectie_Click);
            // 
            // Specializari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectTAP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(538, 340);
            this.Controls.Add(this.btnSelectie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Specializari";
            this.Text = "Specializari";
            this.Load += new System.EventHandler(this.Specializari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource specializariBindingSource;
        private DataSet1TableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrAniStudiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaAnualaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSelectie;
    }
}