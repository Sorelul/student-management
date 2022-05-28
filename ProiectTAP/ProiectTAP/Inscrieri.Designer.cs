
namespace ProiectTAP
{
    partial class Inscrieri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscrieri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAdaugareInregistrare = new System.Windows.Forms.Button();
            this.btnModificareInregistrare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.txtIdInscriere = new System.Windows.Forms.TextBox();
            this.inscrieri1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProiectTAP.DataSet1();
            this.idInscriereDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecializareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInscrieriiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anStudiuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaInitialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaAnualaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRamasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrieriContinut1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idInscriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireSpecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInscrieriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anStudiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrAniStudiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaAnualaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTaxaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrieri1TableAdapter = new ProiectTAP.DataSet1TableAdapters.Inscrieri1TableAdapter();
            this.inscrieriContinut1TableAdapter = new ProiectTAP.DataSet1TableAdapters.InscrieriContinut1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieri1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriContinut1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInscriereDataGridViewTextBoxColumn,
            this.idSpecializareDataGridViewTextBoxColumn,
            this.denumireSpecializareDataGridViewTextBoxColumn,
            this.dataInscrieriiDataGridViewTextBoxColumn,
            this.anStudiuDataGridViewTextBoxColumn,
            this.nrAniStudiuDataGridViewTextBoxColumn,
            this.taxaAnualaDataGridViewTextBoxColumn,
            this.totalTaxaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inscrieri1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(658, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInscriereDataGridViewTextBoxColumn1,
            this.idSpecializareDataGridViewTextBoxColumn1,
            this.idStudentDataGridViewTextBoxColumn,
            this.nrcDataGridViewTextBoxColumn,
            this.numeStudentDataGridViewTextBoxColumn,
            this.dataInscrieriiDataGridViewTextBoxColumn1,
            this.cNPDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.anStudiuDataGridViewTextBoxColumn1,
            this.taxaInitialaDataGridViewTextBoxColumn,
            this.taxaAnualaDataGridViewTextBoxColumn1,
            this.totalRamasDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inscrieriContinut1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(844, 156);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnAdaugareInregistrare
            // 
            this.btnAdaugareInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareInregistrare.Location = new System.Drawing.Point(718, 96);
            this.btnAdaugareInregistrare.Name = "btnAdaugareInregistrare";
            this.btnAdaugareInregistrare.Size = new System.Drawing.Size(105, 55);
            this.btnAdaugareInregistrare.TabIndex = 2;
            this.btnAdaugareInregistrare.Text = "Adaugare Inregistrare";
            this.btnAdaugareInregistrare.UseVisualStyleBackColor = true;
            this.btnAdaugareInregistrare.Click += new System.EventHandler(this.btnAdaugareInregistrare_Click);
            // 
            // btnModificareInregistrare
            // 
            this.btnModificareInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificareInregistrare.Location = new System.Drawing.Point(718, 157);
            this.btnModificareInregistrare.Name = "btnModificareInregistrare";
            this.btnModificareInregistrare.Size = new System.Drawing.Size(105, 53);
            this.btnModificareInregistrare.TabIndex = 3;
            this.btnModificareInregistrare.Text = "Modificare Inregistrare";
            this.btnModificareInregistrare.UseVisualStyleBackColor = true;
            this.btnModificareInregistrare.Click += new System.EventHandler(this.btnModificareInregistrare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(718, 216);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(105, 50);
            this.btnStergere.TabIndex = 4;
            this.btnStergere.Text = "Sterge Inregistrare";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // txtIdInscriere
            // 
            this.txtIdInscriere.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscrieri1BindingSource, "IdInscriere", true));
            this.txtIdInscriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInscriere.Location = new System.Drawing.Point(718, 31);
            this.txtIdInscriere.Name = "txtIdInscriere";
            this.txtIdInscriere.Size = new System.Drawing.Size(105, 29);
            this.txtIdInscriere.TabIndex = 5;
            // 
            // inscrieri1BindingSource
            // 
            this.inscrieri1BindingSource.DataMember = "Inscrieri1";
            this.inscrieri1BindingSource.DataSource = this.dataSet1;
            this.inscrieri1BindingSource.PositionChanged += new System.EventHandler(this.inscrieriBindingSource_PositionChanged_1);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idInscriereDataGridViewTextBoxColumn1
            // 
            this.idInscriereDataGridViewTextBoxColumn1.DataPropertyName = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn1.HeaderText = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn1.Name = "idInscriereDataGridViewTextBoxColumn1";
            this.idInscriereDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idInscriereDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idSpecializareDataGridViewTextBoxColumn1
            // 
            this.idSpecializareDataGridViewTextBoxColumn1.DataPropertyName = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn1.HeaderText = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn1.Name = "idSpecializareDataGridViewTextBoxColumn1";
            this.idSpecializareDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idSpecializareDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            this.idStudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStudentDataGridViewTextBoxColumn.Visible = false;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeStudentDataGridViewTextBoxColumn
            // 
            this.numeStudentDataGridViewTextBoxColumn.DataPropertyName = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.HeaderText = "NumeStudent";
            this.numeStudentDataGridViewTextBoxColumn.Name = "numeStudentDataGridViewTextBoxColumn";
            this.numeStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInscrieriiDataGridViewTextBoxColumn1
            // 
            this.dataInscrieriiDataGridViewTextBoxColumn1.DataPropertyName = "DataInscrierii";
            this.dataInscrieriiDataGridViewTextBoxColumn1.HeaderText = "DataInscrierii";
            this.dataInscrieriiDataGridViewTextBoxColumn1.Name = "dataInscrieriiDataGridViewTextBoxColumn1";
            this.dataInscrieriiDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataInscrieriiDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            this.nrTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anStudiuDataGridViewTextBoxColumn1
            // 
            this.anStudiuDataGridViewTextBoxColumn1.DataPropertyName = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn1.HeaderText = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn1.Name = "anStudiuDataGridViewTextBoxColumn1";
            this.anStudiuDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // taxaInitialaDataGridViewTextBoxColumn
            // 
            this.taxaInitialaDataGridViewTextBoxColumn.DataPropertyName = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.HeaderText = "TaxaInitiala";
            this.taxaInitialaDataGridViewTextBoxColumn.Name = "taxaInitialaDataGridViewTextBoxColumn";
            this.taxaInitialaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxaAnualaDataGridViewTextBoxColumn1
            // 
            this.taxaAnualaDataGridViewTextBoxColumn1.DataPropertyName = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn1.HeaderText = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn1.Name = "taxaAnualaDataGridViewTextBoxColumn1";
            this.taxaAnualaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalRamasDataGridViewTextBoxColumn
            // 
            this.totalRamasDataGridViewTextBoxColumn.DataPropertyName = "Total Ramas";
            this.totalRamasDataGridViewTextBoxColumn.HeaderText = "Total Ramas";
            this.totalRamasDataGridViewTextBoxColumn.Name = "totalRamasDataGridViewTextBoxColumn";
            this.totalRamasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscrieriContinut1BindingSource
            // 
            this.inscrieriContinut1BindingSource.DataMember = "InscrieriContinut1";
            this.inscrieriContinut1BindingSource.DataSource = this.dataSet1;
            // 
            // idInscriereDataGridViewTextBoxColumn
            // 
            this.idInscriereDataGridViewTextBoxColumn.DataPropertyName = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn.HeaderText = "IdInscriere";
            this.idInscriereDataGridViewTextBoxColumn.Name = "idInscriereDataGridViewTextBoxColumn";
            this.idInscriereDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInscriereDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSpecializareDataGridViewTextBoxColumn
            // 
            this.idSpecializareDataGridViewTextBoxColumn.DataPropertyName = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.HeaderText = "IdSpecializare";
            this.idSpecializareDataGridViewTextBoxColumn.Name = "idSpecializareDataGridViewTextBoxColumn";
            this.idSpecializareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSpecializareDataGridViewTextBoxColumn.Visible = false;
            // 
            // denumireSpecializareDataGridViewTextBoxColumn
            // 
            this.denumireSpecializareDataGridViewTextBoxColumn.DataPropertyName = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.HeaderText = "DenumireSpecializare";
            this.denumireSpecializareDataGridViewTextBoxColumn.Name = "denumireSpecializareDataGridViewTextBoxColumn";
            this.denumireSpecializareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInscrieriiDataGridViewTextBoxColumn
            // 
            this.dataInscrieriiDataGridViewTextBoxColumn.DataPropertyName = "DataInscrierii";
            this.dataInscrieriiDataGridViewTextBoxColumn.HeaderText = "DataInscrierii";
            this.dataInscrieriiDataGridViewTextBoxColumn.Name = "dataInscrieriiDataGridViewTextBoxColumn";
            this.dataInscrieriiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anStudiuDataGridViewTextBoxColumn
            // 
            this.anStudiuDataGridViewTextBoxColumn.DataPropertyName = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn.HeaderText = "AnStudiu";
            this.anStudiuDataGridViewTextBoxColumn.Name = "anStudiuDataGridViewTextBoxColumn";
            this.anStudiuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrAniStudiuDataGridViewTextBoxColumn
            // 
            this.nrAniStudiuDataGridViewTextBoxColumn.DataPropertyName = "NrAniStudiu";
            this.nrAniStudiuDataGridViewTextBoxColumn.HeaderText = "NrAniStudiu";
            this.nrAniStudiuDataGridViewTextBoxColumn.Name = "nrAniStudiuDataGridViewTextBoxColumn";
            this.nrAniStudiuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxaAnualaDataGridViewTextBoxColumn
            // 
            this.taxaAnualaDataGridViewTextBoxColumn.DataPropertyName = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn.HeaderText = "TaxaAnuala";
            this.taxaAnualaDataGridViewTextBoxColumn.Name = "taxaAnualaDataGridViewTextBoxColumn";
            this.taxaAnualaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalTaxaDataGridViewTextBoxColumn
            // 
            this.totalTaxaDataGridViewTextBoxColumn.DataPropertyName = "Total Taxa";
            this.totalTaxaDataGridViewTextBoxColumn.HeaderText = "Total Taxa";
            this.totalTaxaDataGridViewTextBoxColumn.Name = "totalTaxaDataGridViewTextBoxColumn";
            this.totalTaxaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscrieri1TableAdapter
            // 
            this.inscrieri1TableAdapter.ClearBeforeFill = true;
            // 
            // inscrieriContinut1TableAdapter
            // 
            this.inscrieriContinut1TableAdapter.ClearBeforeFill = true;
            // 
            // Inscrieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectTAP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(868, 460);
            this.Controls.Add(this.txtIdInscriere);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificareInregistrare);
            this.Controls.Add(this.btnAdaugareInregistrare);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inscrieri";
            this.Text = "Inscrieri";
            this.Load += new System.EventHandler(this.Inscrieri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieri1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriContinut1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAdaugareInregistrare;
        private System.Windows.Forms.Button btnModificareInregistrare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.TextBox txtIdInscriere;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource inscrieri1BindingSource;
        private DataSet1TableAdapters.Inscrieri1TableAdapter inscrieri1TableAdapter;
        private System.Windows.Forms.BindingSource inscrieriContinut1BindingSource;
        private DataSet1TableAdapters.InscrieriContinut1TableAdapter inscrieriContinut1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireSpecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInscrieriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anStudiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrAniStudiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaAnualaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTaxaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscriereDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecializareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInscrieriiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anStudiuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaInitialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaAnualaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRamasDataGridViewTextBoxColumn;
    }
}